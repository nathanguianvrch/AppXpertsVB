Public Class Chauffeur
    Private Sub Chauffeur_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Connexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VoirTournee.Show()
    End Sub

    Private Sub CreerTournee_button_Click(sender As Object, e As EventArgs)
        CreerTournee.Show()
    End Sub
End Class