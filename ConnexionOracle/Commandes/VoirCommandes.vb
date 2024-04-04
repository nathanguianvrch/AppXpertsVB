Imports System.Data.Common

Public Class VoirCommandes
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

        Dim boutonColumn As New DataGridViewButtonColumn()
        boutonColumn.Text = "Palettes"
        boutonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(boutonColumn)

        AddHandler DataGridView1.CellContentClick, AddressOf DataGridView1_CellContentClick

        Dim dataTable As New DataTable()

        dataTable.Load(myReader)

        myReader.Close()

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim COMID As String = DataGridView1.Rows(e.RowIndex).Cells("COMID").Value.ToString()
        VoirPalettes.Show()
        VoirPalettes.charger("SELECT PALID, PALTYPE, COMID FROM PALETTE WHERE COMID = " + COMID + ";")
    End Sub
End Class