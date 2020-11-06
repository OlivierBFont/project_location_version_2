Imports MySql.Data.MySqlClient


Public Class EntityReservations

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityReservations = Nothing

    Public Shared Function getInstance() As EntityReservations
        If IsNothing(instance) Then
            instance = New EntityReservations()
        End If
        Return instance
    End Function

    Public Function getReservation() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct E.ID, initcap(concat(P.nom, ', ', P.prenom)) as Réservé_par, initcap(E.autorisation) as autorisation from reservation E inner join personne P on E.noPersonne = P.noPersonne order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("Reservation")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getReservationEquipments(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E2.nom from reservation E inner join equipement E2 on E2.noEquipement = E.noEquipement where ID = {id}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("reserve")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function Empruntnextid() As Integer
        Dim command As New MySqlCommand
        Dim ID As Integer
        command.Connection = connection
        command.CommandText = "select max(distinct id) from reservation"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim reservTable As New DataTable("reserv")
        reservTable.Load(reader)
        connection.Close()
        If reservTable.Rows.Count = 1 And String.IsNullOrEmpty(reservTable.Rows(0).Item(0).ToString()) Then
            Return 1
        Else
            Return reservTable.Rows(0).Item(0) + 1
        End If
    End Function

    Public Function getReserv() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct E.ID, initcap(concat(P.nom, ', ', P.prenom)) as Réservé_par, initcap(E.autorisation) as autorisation from reservation E inner join personne P on E.noPersonne = P.noPersonne order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("reserv")
        table.Load(reader)
        connection.Close()
        Return table
    End Function


    Public Function getReservDatesbyID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation), E.DateEmprunt, E.duree, E.dateRetour, E.commentaires from reservation E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where E.ID = {id} order by E.ID"
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("reserv")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

    Public Function getReservDetailed(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select E.ID, initcap(P.prenom), initcap(P.nom), initcap(P.statut), P.email, initcap(E.autorisation), E.DateEmprunt, E.dateRetour from reservation E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne inner join categorie C2 on E2.noCategorie = C2.noCategorie where E.ID = {id} order by E.ID"
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("reserv")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

    Public Function getReservByID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select * from reservation where ID = {id} order by ID"
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("reserv")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

    Public Function getReservByReservFirstAndLastName(firstName As String, lastName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from reservation E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.prenom) like upper('{firstName}%') and upper(P.nom) like upper('{lastName}%') order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("reserv")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getReservByReservLastName(lastName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from reservation E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.nom) like upper('{lastName}%') order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("reserv")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getReservByReservFirstName(firstName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from reservation E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.prenom) like upper('{firstName}%') order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("Reserv")
        table.Load(reader)
        connection.Close()
        Return table
    End Function


    Public Function getReservByReservName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from reservation E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(E.autorisation) like upper('{name}%') order by E.ID"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("Reserv")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class