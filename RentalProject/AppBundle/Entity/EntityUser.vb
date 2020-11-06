Imports MySql.Data.MySqlClient

Public Class EntityUser
    ReadOnly connection As New MySqlConnection(Connexion.getInstance().connectionString)
    Shared instance As EntityUser = Nothing

    Public Shared Function getInstance() As EntityUser
        If IsNothing(instance) Then
            instance = New EntityUser()
        End If
        Return instance
    End Function

    Public Function getUsers() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select matricule, statut from utilisateur"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("utilisateur")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function verifUser(matricule As Integer, password As String) As Boolean

        Dim verif = False
        Dim bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(password)
        Dim hashOfBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(bytes)
        Dim strHash As String = Convert.ToBase64String(hashOfBytes)

        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select count(*) from utilisateur where matricule = {matricule} and password LIKE '{password}'"
        connection.Open()

        Dim result = command.ExecuteScalar()

        If (result = 1) Then
            verif = True
        Else
            verif = False
        End If

        connection.Close()
        Return verif
    End Function

End Class
