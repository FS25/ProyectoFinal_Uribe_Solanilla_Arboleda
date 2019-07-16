Public Class SeleccionQuices

    Private quices(-1) As Quices

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Preguntas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'carga preguntas quiz dos
        Preguntas.Show()
        Preguntas.SetQuiz(New QuizGame(3))
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'carga preguntas quiz tres
        Hide()
        Preguntas.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Hide()
        HighestScore.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Database.closeConnection()
        Application.Exit()
    End Sub

    Private Sub SeleccionQuices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvQuices.Rows.Clear()

        Dim command = Database.getCommand()
        Dim dataReader As Odbc.OdbcDataReader
        Dim queryTxt = "SELECT DISTINCT qz.id, " +
                    "   qz.nombre quiz, " +
                    "   MAX(qz_us.username) max_usuario, " +
                    "   MAX(us.nombre) max_nombre, " +
                    "   MAX(qz_us.puntaje) max_puntaje " +
                    "FROM quiz qz " +
                    "LEFT JOIN quiz_usuario qz_us ON qz_us.id_quiz = qz.id " +
                    "LEFT JOIN usuario us ON us.username = qz_us.username " +
                    "GROUP BY qz.id, qz.nombre"

        command.CommandText = queryTxt
        dataReader = command.ExecuteReader

        While dataReader.Read
            Dim index = dgvQuices.Rows.Add()
            Dim row = dgvQuices.Rows(index)
            row.Cells("quiz").Value = dataReader("quiz")
            row.Cells("userName").Value = dataReader("max_nombre")
            row.Cells("score").Value = dataReader("max_puntaje")
            row.Cells("action").Value = "Jugar"
        End While
    End Sub
End Class