Imports System.Runtime.InteropServices
Imports System.Windows

Public Class Connexion

    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Dim connString As String
    Dim donnee As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As String = User.Text
        Dim password As String = TextBox2.Text

        'login = "admin"
        'password = "admin"

        Dim query As String = "SELECT login, typeuser FROM USERS WHERE login = '" + login + "' AND password = '" + password + "';"

        myCommand.Connection = myConnection
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader


        Dim username = ""
        Dim typeuser

        While myReader.Read
            username = myReader.GetString(0)
            typeuser = myReader.GetString(1)
        End While
        If username = "" Then
            MessageBox.Show("Utilisateur introuvable mot de passe incorrect")
        End If

        myReader.Close()
        If typeuser = 4 Then
            Admin.Show()
            Admin.TextUser.Text = "Connecté en tant que : " + username
            Me.Hide()
        End If
        If typeuser = 1 Then
            Exploitant.Show()
            Exploitant.TextUser.Text = "Connecté en tant que : " + username
            Me.Hide()
        End If
        If typeuser = 2 Then
            Chauffeur.Show()
            Chauffeur.TextUser.Text = "Connecté en tant que : " + username
            Me.Hide()
        End If
        If typeuser = 3 Then
            Quais.Show()
            Quais.TextUser.Text = "Connecté en tant que : " + username
            Me.Hide()
        End If
    End Sub

    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connString = "DSN=CNXORA03;Uid=SCOTT;Pwd=Iroise29;"

        myConnection.ConnectionString = connString

        Try
            myConnection.Open()
        Catch ex As Odbc.OdbcException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function GetMyConnection() As Odbc.OdbcConnection
        Return myConnection
    End Function

    Private Sub User_TextChanged(sender As Object, e As EventArgs) Handles User.TextChanged

    End Sub
End Class