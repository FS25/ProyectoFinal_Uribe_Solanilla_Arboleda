Public Class SeleccionQuices

    Private quices(-1) As QuizGame

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

        'Obtenemos los nuevos quices'
        Try
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
                ReDim quices(quices.Length)
                quices(quices.Length - 1) = New QuizGame(Integer.Parse(dataReader("id")))

                Dim index = dgvQuices.Rows.Add()
                Dim row = dgvQuices.Rows(index)
                row.Cells("quiz").Value = dataReader("quiz")
                row.Cells("userName").Value = dataReader("max_nombre")
                row.Cells("score").Value = dataReader("max_puntaje")
                row.Cells("action").Value = "Jugar"
            End While
        Catch ex As Exception
            MsgBox("Ha ocurrido un error cargando los quices. " & ex.ToString())
        End Try
    End Sub

    Private Sub DgvQuices_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuices.CellClick
        'Jugar quiz'
        If e.ColumnIndex = 3 Then
            Hide()
            Preguntas.SetQuiz(New QuizGame(3))
            Preguntas.Show()
        End If
    End Sub

    Private Sub DgvQuices_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Database.closeConnection()
        Application.Exit()
    End Sub

End Class