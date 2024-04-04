Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class VoirTournee
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder

    Private Sub charger()
        DataGridView1.DataSource = Nothing
        Dim query As String = "SELECT TOURNID, TOURNDATE, TOURNDEPART, TOURNARRIVEE, CAMIMMAT FROM TOURNEE;"

        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader

        Dim boutonColumn As New DataGridViewButtonColumn()
        boutonColumn.Text = "Commandes"
        boutonColumn.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(boutonColumn)

        AddHandler DataGridView1.CellContentClick, AddressOf DataGridView1_CellContentClick

        Dim dataTable As New DataTable()

        dataTable.Load(myReader)

        myReader.Close()

        DataGridView1.DataSource = dataTable
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim tourId As String = DataGridView1.Rows(e.RowIndex).Cells("TOURNID").Value.ToString()
        VoirCommandes.Show()
        VoirCommandes.charger($"SELECT COMID, COMDATE, COMDEVISE, COMCHARG, COMLIVR, CLINOM, EXPNOM, TOURNID FROM COMMANDE INNER JOIN CLIENT ON COMMANDE.CLIID = CLIENT.CLIID INNER JOIN EXPEDITEUR ON COMMANDE.EXPID = EXPEDITEUR.EXPID WHERE TOURNID = {tourId};")
    End Sub




    Private Sub VoirTournee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        charger()
    End Sub


    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Yellow
    End Sub
End Class