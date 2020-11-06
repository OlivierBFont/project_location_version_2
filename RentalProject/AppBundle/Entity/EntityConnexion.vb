Imports MySql.Data.MySqlClient

Public Class EntityConnexion
    ReadOnly connection As New MySqlConnection(Connexion.getInstance().connectionString)
    Shared instance As EntityConnexion = Nothing

    Public Shared Function getInstance() As EntityConnexion
        If IsNothing(instance) Then
            instance = New EntityConnexion()
        End If
        Return instance
    End Function

    Public Function getUser() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from utilisateur"
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
        command.CommandText = $"Select count(*) from utilisateur where matricule = {matricule} and password = {password}"
        connection.Open()

        Try
            Dim result = command.ExecuteScalar()
            If (result = 1) Then
                verif = True
            Else
                verif = False
            End If

            connection.Close()
            Return verif
        Catch ex As Exception
            connection.Close()
        End Try






    End Function

End Class
