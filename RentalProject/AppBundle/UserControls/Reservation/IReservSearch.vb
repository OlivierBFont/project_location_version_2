Public Class IReservSearch

    Dim reservs As IReservation
    Dim mainForm As MainForm

    Sub New(main As MainForm, reserv As IReservation)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        reservs = reserv
        ''' Ces lignes font les premieres restrictions pour l'utilisateur.
        ''' cette gestion est appliqué plus bas.
        DetailsButton.Enabled = False
        SearchButton.Enabled = False
        ByReservName.Checked = True
    End Sub

    Private Sub IReservSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData(EntityReservations.getInstance().getReserv(), True)
    End Sub

    ''' <summary>
    ''' Cette fonction permet de charger les donnés qui seront affiché à l'utilisateur.
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="type"></param>
    ''' <returns></returns>
    Public Function loadData(data As DataTable, type As Boolean)
        ListView1.Items.Clear()
        Dim reservTable As DataTable = data
        ''' Cette vérification empêche l'utilisateur d'utiliser cette interface
        ''' s'il n'y a pas d'emprunt à afficher. Ou si la recherche effectué ne
        ''' retourne aucun résultat, on affiche la totalité des emprunts.
        If Not reservTable.Rows.Count > 0 Then
            If type Then
                MessageBox.Show("Aucune réservation dans la base de donnée.")
                Me.SendToBack()
            Else
                ReservFirstName.Text = ""
                ReservLastName.Text = ""
                AuthorisationName.Text = ""
                MessageBox.Show($"Aucune réservations correspondant à vos critères{Environment.NewLine}dans la base de donnée.")
                loadData(EntityReservations.getInstance().getReserv(), True)
            End If
        Else
            For Each it As DataRow In reservTable.Rows
                If Not IsNothing(it) Then
                    ListView1.Items.Add(New ListViewItem({it.Item(0), it.Item(1), it.Item(2)}))
                End If
            Next
        End If
    End Function

    ''' <summary>
    ''' Ce Sub agit lors d'une modification à la ligne sélectionné et
    ''' permet d'afficher les détails de l'article choisi.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If Not IsNothing(ListView1.FocusedItem) AndAlso ListView1.FocusedItem.Index >= 0 Then
            DetailsButton.Enabled = True
        Else
            DetailsButton.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Ce sub agit lorsqu'un nouveau boutton radio est choisi
    ''' et déactive les autres champs text.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles ByReservName.CheckedChanged, ByAuthorisationName.CheckedChanged
        ReservFirstName.Text = ""
        ReservLastName.Text = ""
        AuthorisationName.Text = ""
        If ByReservName.Checked Then
            ReservFirstName.Enabled = True
            ReservLastName.Enabled = True
            AuthorisationName.Enabled = False
        ElseIf ByAuthorisationName.Checked Then
            ReservFirstName.Enabled = False
            ReservLastName.Enabled = False
            AuthorisationName.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Ce sub agit lorsque les champs text sont modifié pour
    ''' débloquer le boutton recherche si les champs contiennent des données.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SearchBoxes_TextChanged(sender As Object, e As EventArgs) Handles ReservFirstName.TextChanged, ReservLastName.TextChanged, AuthorisationName.TextChanged
        ReservFirstName.Text = Trim(ReservFirstName.Text)
        ReservLastName.Text = Trim(ReservLastName.Text)
        AuthorisationName.Text = Trim(AuthorisationName.Text)
        If (ReservFirstName.Text.Length > 0 Or ReservLastName.Text.Length > 0) Or AuthorisationName.Text.Length > 0 Then
            SearchButton.Enabled = True
        Else
            SearchButton.Enabled = False
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchItems()
    End Sub

    Private Sub PressedEnter(sender As Object, e As KeyEventArgs) Handles ReservFirstName.KeyUp, ReservLastName.KeyUp, AuthorisationName.KeyUp
        If e.KeyCode = Keys.Enter Then
            SearchItems()
        End If
    End Sub

    ''' <summary>
    ''' Cette fonction effectue la recherche lorsque le bouton
    ''' recherche est appuyé selon les paramètres de chercherches entrés.
    ''' </summary>
    ''' <returns></returns>
    Private Function SearchItems()
        Dim firstName = Trim(ReservFirstName.Text)
        Dim lastName = Trim(ReservLastName.Text)
        Dim authorisor = Trim(AuthorisationName.Text)
        Dim data As DataTable
        If (firstName.Length > 0 Or lastName.Length > 0) Then
            If (firstName.Length > 0 And lastName.Length > 0) Then
                data = EntityReservations.getInstance().getReservByReservFirstAndLastName(firstName, lastName)
            ElseIf (Not (firstName.Length > 0) And lastName.Length > 0) Then
                data = EntityReservations.getInstance().getReservByReservLastName(lastName)
            ElseIf (firstName.Length > 0 And Not (lastName.Length > 0)) Then
                data = EntityReservations.getInstance().getReservByReservFirstName(firstName)
            End If
            loadData(data, False)
        ElseIf AuthorisationName.Text.Length > 0 Then
            data = EntityReservations.getInstance().getReservByReservName(authorisor)
            loadData(data, False)
        End If
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    ''' <summary>
    ''' Affiche l'interface d'informations détaillées de l'article sélectionné.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click, ListView1.DoubleClick
        If Not IsNothing(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text) Then
            Dim detail As New IReservationDetails(mainForm, CInt(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text))
            detail.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(detail)
            detail.BringToFront()
        End If
    End Sub
End Class
