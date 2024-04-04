Imports System.Data.Common
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Diagnostics.Eventing

Public Class CreerTournee
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles TOURNDATE_input.ValueChanged
        MessageBox.Show(TOURNDATE_input.Value.Date)
    End Sub

    Private Sub CreerTournee_creer_Click(sender As Object, e As EventArgs) Handles CreerTournee_creer.Click
        Dim query As String = "INSERT INTO TOURNEE (TOURNDEPART, TOURNARRIVEE, CAMIMMAT) VALUES ('" + TOURNDEPART_input.Text + "', '" + TOURNARRIVEE_input.Text + "', " + CAMIMMAT_input.Text + ");"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        Try
            myCommand.ExecuteNonQuery()
            MessageBox.Show("La tournée a été créée !")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu : " + ex.Message)
        End Try
    End Sub

    Private Sub CreerTournee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT CAMIMMAT FROM CAMION;"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            CAMIMMAT_input.Items.Add(myReader("CAMIMMAT").ToString())
        End While
        myReader.Close()
    End Sub
End Class