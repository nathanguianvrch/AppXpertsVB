Public Class CreerCamion
    Dim myConnection As New Odbc.OdbcConnection
    Dim myCommand As New Odbc.OdbcCommand
    Dim myReader As Odbc.OdbcDataReader
    Dim myAdapter As Odbc.OdbcDataAdapter
    Dim myBuilder As Odbc.OdbcCommandBuilder
    Private Sub CreerCamion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub CreerCommandes_creer_Click(sender As Object, e As EventArgs) Handles CreerCommandes_creer.Click
        Dim query As String = "INSERT INTO CAMION (CAMIMMAT, CAMNOM, CHAUFFID, TCID) VALUES ('" + IMMAT_input.Text + "', '" + NOM_input.Text + "', '" + CHAUFFID_input.Text + "', '" + TCID_input.Text + "');"
        myCommand.Connection = Connexion.GetMyConnection()
        myCommand.CommandText = query
        Try
            myCommand.ExecuteNonQuery()
            MessageBox.Show("Le camion a été créé !")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Un problème est survenu : " + ex.Message)
        End Try
    End Sub
End Class