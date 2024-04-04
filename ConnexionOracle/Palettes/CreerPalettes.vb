Imports System.Data.Common

Public Class CreerPalettes
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Private Sub CreerPalettes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT COMID FROM COMMANDE;"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            COMID_input.Items.Add(myReader("COMID").ToString())
        End While
        myReader.Close()
    End Sub

    Private Sub CreerTournee_creer_Click(sender As Object, e As EventArgs) Handles CreerTournee_creer.Click
        Dim query As String = "INSERT INTO PALETTE (PALTYPE, COMID) VALUES ('" + PALTYPE_input.Text + "', " + COMID_input.Text + ");"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        Try
            myCommand.ExecuteNonQuery()
            MessageBox.Show("La palette a été créée !")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu : " + ex.Message)
        End Try
    End Sub
End Class