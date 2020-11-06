Public Class IReservationDetails

    Dim mainForm As MainForm

    Dim id As Integer

    Sub New(main As MainForm, number As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        id = number
    End Sub


    Private Sub IReservationDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item As DataTable = EntityReservations.getInstance().getReservDetailed(id)
        For Each it As DataRow In item.Rows
            ReservID.Text = it.Item(0)
            RenterFirstName.Text = it.Item(1)
            RenterLastName.Text = it.Item(2)
            RenterStatus.Text = it.Item(3)
            Email.Text = it.Item(4)
            Authorisation.Text = it.Item(5)
            ReservDate.Value = it.Item(6)
            ReturnDate.Value = it.Item(7)
        Next
        ReservDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        ReturnDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"

        DGVEquipments.DataSource = EntityEquipment.getInstance.getEquipmentRented(ReservID.Text)

    End Sub


    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub


    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim data As DataTable = EntityReservations.getInstance().getReservDatesbyID(ReservID.Text)
        Dim modifyReserv As New IModifyReservation(mainForm, data)
        modifyReserv.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(modifyReserv)
        modifyReserv.BringToFront()
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Dim returnDetail As New IAnnulerReservation(mainForm, New IReservation(mainForm), CInt(ReservID.Text))
        returnDetail.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(returnDetail)
        returnDetail.BringToFront()
    End Sub

End Class
