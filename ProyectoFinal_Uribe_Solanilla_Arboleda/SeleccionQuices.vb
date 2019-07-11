Public Class SeleccionQuices

    Private quices(-1) As Quices

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mover As Integer
        Dim conn As Odbc.OdbcConnection
        conn = New Odbc.OdbcConnection("DSN=BBG")

        conn.Open()
        MsgBox(conn.State.ToString)

        Dim command As New Odbc.OdbcCommand()
        command.Connection = conn


        command.CommandText = "select descripcion, id_quiz from pregunta where id_quiz = 3"

        Dim datReader As Odbc.OdbcDataReader
        datReader = command.ExecuteReader

        While datReader.Read
            Preguntas.ArrayPreguntas(mover) = datReader("descripcion")
            mover = mover + 1
        End While


        conn.Close()

        Hide()
        Preguntas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'carga preguntas quiz dos
        Hide()
        Preguntas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

Class Quiz
    Private name As String
    Private id As Integer

    Public Sub Quiz(ByVal id As Integer, ByVal name As String)
        Me.id = id
        Me.name = name
    End Sub
End Class