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
        SeleccionQuices.Show()
    End Sub
End Class