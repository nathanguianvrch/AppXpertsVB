Imports System.Data.Common

Public Class ModifCamion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Private Sub ModifCamion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IMMAT_input.Text = VoirCamion.DataGridView1.SelectedRows(0).Cells("CAMIMMAT").Value.ToString()

        NOM_input.Text = VoirCamion.DataGridView1.SelectedRows(0).Cells("CAMNOM").Value.ToString()

        CHAUFFID_input.Text = VoirCamion.DataGridView1.SelectedRows(0).Cells("CHAUFFNOM").Value.ToString()

        TCID_input.Text = VoirCamion.DataGridView1.SelectedRows(0).Cells("TCLibelle").Value.ToString()

        Dim query As String = "SELECT TCID, TCLibelle FROM TYPECAMION;"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        myReader = myCommand.ExecuteReader()
        Dim dataTable As New DataTable()

        dataTable.Load(myReader)
        myReader.Close()
        TCID_input.DataSource = dataTable
        TCID_input.ValueMember = "TCID"
        TCID_input.DisplayMember = "TCLibelle"

        Dim query2 As String = "SELECT DISTINCT CHAUFFID, CHAUFFNOM FROM CHAUFFEUR;"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query2
        myReader = myCommand.ExecuteReader()
        Dim dataTable2 As New DataTable()

        dataTable2.Load(myReader)
        myReader.Close()
        CHAUFFID_input.DataSource = dataTable2
        CHAUFFID_input.ValueMember = "CHAUFFID"
        CHAUFFID_input.DisplayMember = "CHAUFFNOM"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String = $"UPDATE CAMION SET CAMNOM = '{NOM_input.Text}', TCID = {TCID_input.SelectedValue.ToString}, CHAUFFID = {CHAUFFID_input.SelectedValue.ToString} WHERE CAMIMMAT = '{IMMAT_input.Text}';"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query

        Try
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Le camion a été modifié !")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu : " + ex.Message)
        End Try
        VoirCamion.charger("SELECT CAMIMMAT, CAMNOM, CHAUFFEUR.CHAUFFNOM, TYPECAMION.TCLIBELLE, CAMION.CHAUFFID, CAMION.TCID FROM CAMION INNER JOIN CHAUFFEUR ON CAMION.CHAUFFID = CHAUFFEUR.CHAUFFID INNER JOIN TYPECAMION ON CAMION.TCID = TYPECAMION.TCID;")
    End Sub
End Class