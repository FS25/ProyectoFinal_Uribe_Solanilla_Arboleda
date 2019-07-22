Public Class HighestScore
    Private Sub BtnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Hide()
        SeleccionQuices.Show()
    End Sub

    Private Sub Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Database.closeConnection()
        Application.Exit()
    End Sub

    Private Sub HighestScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargamos los puntajes mas altos'
        Try
            Dim command = Database.getCommand()
            Dim dataReader As Odbc.OdbcDataReader

            command.CommandText = "SELECT TOP (10) username,
	                                    puntaje,
	                                    nombre
                                    FROM [BB_Games].[dbo].[quiz_usuario]
                                    JOIN quiz ON quiz.id = quiz_usuario.id_quiz
                                    ORDER BY puntaje DESC"
            dataReader = command.ExecuteReader

            While dataReader.Read
                Dim index = dgvScores.Rows.Add()
                Dim row = dgvScores.Rows(index)
                row.Cells("Nombre").Value = dataReader("username")
                row.Cells("puntos").Value = dataReader("puntaje")
                row.Cells("Tema").Value = dataReader("nombre")
            End While
        Catch ex As Exception
            MsgBox("Ha ocurrido un error obteniendo la información. " & ex.ToString())
        End Try
    End Sub
End Class