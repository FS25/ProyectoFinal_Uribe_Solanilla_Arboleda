Public Class sugerencias
    Private Sub BtnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click

        'Guardamos recomendación'
        Try
            Dim cmd = Database.getCommand()

            cmd.CommandText = "INSERT INTO tema VALUES('" & UserSession.getUsername() & "', '" & txtTema.Text & "')"
            cmd.ExecuteNonQuery()

            MsgBox("¡Gracias por tu recomendación, " & UserSession.getName() & "!")
        Catch ex As Exception
            MsgBox("Error guardando recomendación. " & ex.ToString())
        End Try

        Hide()
        SeleccionQuices.LoadQuices()
        SeleccionQuices.Show()
    End Sub

    Private Sub Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Database.closeConnection()
        Application.Exit()
    End Sub
End Class