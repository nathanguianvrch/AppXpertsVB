Public Class Admin
    Private Sub Quais_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Connexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VoirTournee.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CreerTournee.Show()
    End Sub

    Private Sub VoirCommandes_btn_Click(sender As Object, e As EventArgs) Handles VoirCommandes_btn.Click
        VoirCommandes.Show()
        VoirCommandes.charger("SELECT COMID, COMDATE, COMDEVISE, COMCHARG, COMLIVR, CLINOM, EXPNOM, TOURNID FROM COMMANDE INNER JOIN CLIENT ON COMMANDE.CLIID = CLIENT.CLIID INNER JOIN EXPEDITEUR ON COMMANDE.EXPID = EXPEDITEUR.EXPID;")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CreerCommandes.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CreerPalettes.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        VoirCommandes.Show()
        VoirCommandes.charger("SELECT PALID, PALTYPE, COMID FROM PALETTE;")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CreerCamion.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        VoirCamion.Show()
        VoirCamion.charger("SELECT CAMIMMAT, CAMNOM, CHAUFFEUR.CHAUFFNOM, TYPECAMION.TCLIBELLE, CAMION.CHAUFFID, CAMION.TCID FROM CAMION INNER JOIN CHAUFFEUR ON CAMION.CHAUFFID = CHAUFFEUR.CHAUFFID INNER JOIN TYPECAMION ON CAMION.TCID = TYPECAMION.TCID;")
    End Sub
End Class