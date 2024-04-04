Imports System.Data.Common

Public Class CreerCommandes
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Private Sub CreerCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT CLIID, CLINOM FROM CLIENT;"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            CLIID_input.Items.Add(myReader("CLINOM").ToString())
        End While
        myReader.Close()

        Dim query2 As String = "SELECT EXPID, EXPNOM FROM EXPEDITEUR;"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            EXPID_input.Items.Add(myReader("EXPNOM").ToString())
        End While
        myReader.Close()

        Dim query3 As String = "SELECT TOURNID FROM TOURNEE;"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query3
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            TOURNID_input.Items.Add(myReader("TOURNID").ToString())
        End While
        myReader.Close()
    End Sub

    Private Sub CreerCommandes_creer_Click(sender As Object, e As EventArgs) Handles CreerCommandes_creer.Click
        Dim query As String = "INSERT INTO COMMANDE (COMDEVISE, COMCHARG, COMLIVR, CLIID, EXPID, TOURNID) VALUES ('" + COMDEVISE_input.Text + "', '" + COMCHARG_input.Text + "', '" + COMLIVR_input.Text + "', " + CLIID_input.Text + ", " + EXPID_input.Text + ", " + TOURNID_input.Text + ");"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        Try
            myCommand.ExecuteNonQuery()
            MessageBox.Show("La commande a été créée !")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu : " + ex.Message)
        End Try
    End Sub
End Class