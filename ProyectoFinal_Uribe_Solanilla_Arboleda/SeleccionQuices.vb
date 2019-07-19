Public Class SeleccionQuices

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Database.closeConnection()
        Application.Exit()
    End Sub

    Private Sub SeleccionQuices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadQuices()
    End Sub

    Private Sub DgvQuices_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvQuices.CellClick
        'Jugar quiz al presionar el boton de Jugar'
        If e.ColumnIndex = 4 Then
            Hide()
            Preguntas.SetQuiz(New QuizGame(Integer.Parse(dgvQuices.Rows(e.RowIndex).Cells("qId").Value)))
            Preguntas.Show()
        End If
    End Sub

    Private Sub Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Database.closeConnection()
        Application.Exit()
    End Sub

    Public Sub LoadQuices()
        dgvQuices.Rows.Clear()

        'Obtenemos los nuevos quices'
        Try
            Dim command = Database.getCommand()
            Dim dataReader As Odbc.OdbcDataReader
            Dim queryTxt = "SELECT DISTINCT qz.id,
	                            qz.nombre quiz,
	                            us.username max_nombre,
	                            qz_us.puntaje max_puntaje
                            FROM quiz qz  
                            LEFT JOIN (
	                            SELECT TOP (1) id_quiz, username, MAX(puntaje) puntaje FROM quiz_usuario WHERE id_quiz = 3 GROUP BY username, id_quiz ORDER BY puntaje DESC
                            ) qz_us ON qz_us.id_quiz = qz.id
                            LEFT JOIN usuario us ON us.username = qz_us.username
                            GROUP BY qz.id, qz.nombre, us.username, qz_us.puntaje"

            command.CommandText = queryTxt
            dataReader = command.ExecuteReader

            While dataReader.Read
                Dim index = dgvQuices.Rows.Add()
                Dim row = dgvQuices.Rows(index)
                row.Cells("qId").Value = dataReader("id")
                row.Cells("quiz").Value = dataReader("quiz")
                row.Cells("userName").Value = dataReader("max_nombre")
                row.Cells("score").Value = dataReader("max_puntaje")
                row.Cells("action").Value = "Jugar"
            End While
        Catch ex As Exception
            MsgBox("Ha ocurrido un error cargando los quices. " & ex.ToString())
        End Try
    End Sub

    Private Sub BtnHighScore_Click(sender As Object, e As EventArgs) Handles btnHighScore.Click
        HighestScore.Show()
        Me.Hide()
    End Sub
End Class