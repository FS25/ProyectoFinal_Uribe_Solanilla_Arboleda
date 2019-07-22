Public Class Puntaje
    Private Sub BtnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        'Mostramos siguiente pantalla'
        Hide()
        sugerencias.Show()
    End Sub

    Private Sub Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Database.closeConnection()
        Application.Exit()
    End Sub

    Public Sub SetScore(ByVal score As Integer)
        lblScore.Text = score.ToString()
    End Sub
End Class