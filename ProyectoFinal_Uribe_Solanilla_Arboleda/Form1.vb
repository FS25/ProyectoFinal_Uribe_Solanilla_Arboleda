Public Class Quices

    Private conn As Odbc.OdbcConnection

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim command = Database.getCommand()
        Dim dataReader As Odbc.OdbcDataReader

        command.CommandText = "SELECT * FROM usuario WHERE username='" + txtNombreUsuario.Text + "'"
        dataReader = command.ExecuteReader

        If dataReader.HasRows Then
            dataReader.Read()

            Dim username As String = dataReader("username")
            Dim password As String = dataReader("password")
            Dim name As String = dataReader("nombre")

            If password = txtPassword.Text Then
                UserSession.setUser(username, name)
                dataReader.Close()

                MsgBox("¡Bienvenido, " & name & "!")

                Hide()
                SeleccionQuices.Show()
            Else
                dataReader.Close()
                MsgBox("Contraseña incorrecta")
            End If
        Else
            dataReader.Close()
            MsgBox("Usuario no encontrado")
        End If


    End Sub

    Private Sub Quices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.createConnection()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("hemos enviado su contraseña a su correo")
    End Sub
End Class
