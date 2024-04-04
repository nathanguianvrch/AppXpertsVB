Imports System.Data.Common

Public Class VoirCamion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Public Sub charger(Query As String)
        DataGridView1.DataSource = Nothing
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = Query
        myReader = myCommand.ExecuteReader

        Dim dataTable As New DataTable()

        dataTable.Load(myReader)

        myReader.Close()

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query As String = $"DELETE FROM CAMION WHERE CAMIMMAT = '{DataGridView1.SelectedRows(0).Cells("CAMIMMAT").Value}'"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        Try
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Le camion a été supprimé !")
            charger("SELECT * FROM CAMION;")
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu : " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModifCamion.Show()
    End Sub

End Class