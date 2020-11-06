﻿Public Class IModifyReservation

    Dim mainForm As MainForm
    Dim data As DataTable
    Dim defaultDays As Integer
    Dim defaultHours As Integer
    Dim defaultReturn As Date
    Dim loaded As Boolean = False

    Sub New(main As MainForm, items As DataTable)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        data = items
    End Sub


    Private Sub IModifyReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDefaults()
    End Sub

    Private Function setDefaults()
        For Each it As DataRow In data.Rows
            'setting defaults
            defaultDays = CInt(it.Item(5)) / 24
            defaultHours = CInt(it.Item(5)) Mod 24
            defaultReturn = it.Item(6)
            'Inserting values into textBoxes
            ReservID.Text = it.Item(0)
            RenterName.Text = it.Item(1)
            Authorisation.Text = it.Item(3)
            ReservDate.Value = it.Item(4)
            NumericDays.Value = defaultDays
            NumericHours.Value = defaultHours
            ReturnDate.Value = defaultReturn
            Comments.Text = it.Item(7)
            If defaultReturn < Date.Now Then
                ReturnDate.MinDate = defaultReturn
            Else
                ReturnDate.MinDate = Date.Now
            End If
        Next
        Dim equipmentList As DataTable = EntityReservations.getInstance().getReservationEquipments(CInt(ReservID.Text))
        Equipments.DataSource = equipmentList
        If ReturnDate.Value < Date.Now Then
            MessageBox.Show("Cette réservation est en retard.")
        End If
        ReservDate.Format = DateTimePickerFormat.Custom
        ReservDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        ReturnDate.Format = DateTimePickerFormat.Custom
        ReturnDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        loaded = True
    End Function

    Private Sub Duration_ValueChanged(sender As Object, e As EventArgs) Handles NumericDays.ValueChanged, NumericHours.ValueChanged
        If NumericHours.Value = 24 Then
            NumericDays.Increment = 1
            NumericHours.Value = 0
        End If
        If loaded AndAlso Not CheckBox1.Checked Then
            ReturnDate.Value = ReservDate.Value.AddHours(NumericHours.Value + (NumericDays.Value * 24))
            If Not ControllerDates.getInstance().isValidReturnDate(ReturnDate.Value) Then
                SaveButton.Enabled = False
                MessageBox.Show($"La date ou l'heure de retour est invalide{Environment.NewLine}Puisque le Cégep sera fermé.{Environment.NewLine}Veuillez en sélectionner un nouvelle.")
            ElseIf ReturnDate.Value < Date.Now Then
                SaveButton.Enabled = False
            Else
                SaveButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            NumericDays.Enabled = False
            NumericHours.Enabled = False
            ReturnDate.Enabled = True
        Else
            NumericDays.Enabled = True
            NumericHours.Enabled = True
            ReturnDate.Enabled = False
        End If
    End Sub

    Private Sub ReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles ReturnDate.ValueChanged
        If loaded AndAlso CheckBox1.Checked Then
            Dim hourDiff As Integer = DateDiff(DateInterval.Hour, ReservDate.Value, ReturnDate.Value)
            NumericDays.Value = hourDiff / 24
            NumericHours.Value = hourDiff Mod 24
            If Not ControllerDates.getInstance().isValidReturnDate(ReturnDate.Value) Then
                SaveButton.Enabled = False
                MessageBox.Show($"La date ou l'heure de retour est invalide{Environment.NewLine}Puisque le Cégep sera fermé.{Environment.NewLine}Veuillez en sélectionner un nouvelle.")
            ElseIf ReturnDate.Value < Date.Now Then
                SaveButton.Enabled = False
                MessageBox.Show($"Cette date est passée.{Environment.NewLine}Veuillez en sélectionner une nouvelle.")
            Else
                SaveButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim duree As String = DateDiff(DateInterval.Hour, ReservDate.Value, ReturnDate.Value).ToString()
        ModelReservation.getInstance().updateReservReturnDate(ReservID.Text, duree, ReturnDate.Value, Trim(Comments.Text))
        mainForm.InterfacePanel.Controls.Clear()
        Dim reserv As New IReservation(mainForm)
        reserv.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(reserv)
        reserv.BringToFront()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            setDefaults()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

End Class
