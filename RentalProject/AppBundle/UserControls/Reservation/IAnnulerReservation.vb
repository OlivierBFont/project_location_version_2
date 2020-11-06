Imports System.Text.RegularExpressions

Public Class IAnnulerReservation

    Dim mainForm As MainForm
    Dim reserv As IReservation
    Dim id As Integer

    Sub New(main As MainForm, r As IReservation, number As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        reserv = r
        id = number
    End Sub

    ''' <summary>
    ''' Ce Sub applique les données récupérées dans les champs textes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub IAnnulerReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim item As DataTable = EntityReservations.getInstance().getReservDetailed(id)
        For Each it As DataRow In item.Rows
            ReservID.Text = it.Item(0)
            RenterFirstName.Text = it.Item(1)
            RenterLastName.Text = it.Item(2)
            RenterStatus.Text = it.Item(3)
            Email.Text = it.Item(4)
            Authorisation.Text = it.Item(5)
            ReservDate.Value = it.Item(6)
        Next
        ReservDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        DGVEquipments.DataSource = EntityEquipment.getInstance.getEquipmentRented(ReservID.Text)
    End Sub


    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub FullReturnButton_Click(sender As Object, e As EventArgs) Handles FullReturnButton.Click
        Dim comment As String = ""
        Dim reception As String = ""
        Dim printed As Boolean = False
        If MessageBox.Show("Êtes-vous sûr de vouloir effectuer cette annulation?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If MessageBox.Show("Voulez vous ajouter un commentaire à ce retour?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                comment = InputBox("Note:", "Commentaires")
                comment = Regex.Replace(comment, "'", "''")
                comment = Regex.Replace(comment, "[^A-Za-z0-9' ]", String.Empty)
            End If
            While reception = ""
                reception = InputBox("Votre Nom:", "La personne qui reçoit ce retour")
                reception = Trim(reception)
                reception = Regex.Replace(reception, "[^A-Za-z- ]", String.Empty)
                If reception = "" Then
                    MessageBox.Show("Vous devez entrer un nom de réception.")
                End If
            End While
            For Each it As DataGridViewRow In DGVEquipments.Rows
                Dim personNumber As DataRow = EntityReservations.getInstance().getReservByID(CInt(ReservID.Text)).Rows(0)
                ModelReservation.getInstance().deleteReserv(ReservID.Text, it.Cells(0).Value)
                printed = True
            Next
            reserv.loadData(EntityReservations.getInstance().getReserv())
            reserv.DetailsButton.Enabled = False
            reserv.ReturnButton.Enabled = False
            mainForm.InterfacePanel.Controls.Clear()
            Dim reservs As New IReservation(mainForm)
            reservs.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(reservs)
            reservs.BringToFront()
        Else
            DGVEquipments.Select()
        End If
    End Sub
End Class
