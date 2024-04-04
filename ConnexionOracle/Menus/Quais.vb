Public Class Quais
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VoirTournee.Show()
    End Sub
    Private Sub Quais_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Connexion.Close()
    End Sub

    Private Sub VoirCommandes_btn_Click(sender As Object, e As EventArgs) Handles VoirCommandes_btn.Click
        VoirCommandes.Show()
        VoirCommandes.charger("SELECT COMID, COMDATE, COMDEVISE, COMCHARG, COMLIVR, CLIID, EXPID, TOURNID FROM COMMANDE;")
    End Sub
End Class