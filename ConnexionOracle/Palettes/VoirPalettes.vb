Public Class VoirPalettes
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
End Class