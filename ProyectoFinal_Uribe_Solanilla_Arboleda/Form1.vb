'Curso: Herramientas de Programación Aplicada 3'
'Grupo: 1IL132'
'Fecha: 18 de Julio de 2019'

'Estudiantes:'
'Luis Arboleda 8-932-2422'
'Fabio Solanilla 8-954-2298'
'Daniel Uribe 20-14-3774

'Version de Visual Basic: .NET Framework 4.5'
'Proyecto Final'
'Descripción: Programa de quices interactivos para empresa de Juegos'


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
        If Not Database.createConnection() Then
            MsgBox("Ha ocurrido un error conectandose a la base de datos. Por favor, contacte al soporte técnico al 209-8888.")
            Application.Exit()
        End If
    End Sub

    Private Sub Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Database.closeConnection()
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("hemos enviado su contraseña a su correo")
    End Sub

    Private Sub PboView_Click(sender As Object, e As EventArgs) Handles pboView.Click
        If txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
        Else txtPassword.PasswordChar = ""
            txtPassword.PasswordChar = "*"
        End If
    End Sub
End Class
