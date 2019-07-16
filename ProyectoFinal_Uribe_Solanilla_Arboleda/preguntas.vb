Imports System.Data.SqlClient

Public Class Preguntas
    Public pivot As Integer
    Public ArrayPreguntas(9) As String
    Public ArrayRespuestas(2) As String
    Public ans(9) As String


    Private Sub Preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BB_GamesDataSet.respuesta' table. You can move, or remove it, as needed.
        Dim mover As Integer
        Dim conn As Odbc.OdbcConnection
        conn = New Odbc.OdbcConnection("DSN=BBG")

        conn.Open()
        MsgBox(conn.State.ToString)

        Dim command As New Odbc.OdbcCommand()
        command.Connection = conn


        command.CommandText = "SELECT *  FROM respuesta where id_pregunta= " + Convert.ToString(pivot + 1)

        Dim datReader As Odbc.OdbcDataReader
        datReader = command.ExecuteReader

        While datReader.Read
            ArrayRespuestas(mover) = datReader("descripcion")
            mover = mover + 1
        End While


        conn.Close()

        lblPreguntaNum.Text = "Pregunta # " + Convert.ToString(pivot + 1)
        lblQuest.Text = ArrayPreguntas(pivot)
        RadioButton1.Text = ArrayRespuestas(0)
        RadioButton2.Text = ArrayRespuestas(1)
        RadioButton3.Text = ArrayRespuestas(2)

    End Sub

    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click

        If pivot < 9 Then
            If RadioButton1.Checked = True Then
                ans(pivot) = RadioButton1.Text
            ElseIf RadioButton2.Checked = True Then
                ans(pivot) = RadioButton2.Text
            ElseIf RadioButton3.Checked = True Then
                ans(pivot) = RadioButton3.Text

            End If
            pivot = pivot + 1
            Preguntas_Load(sender, e)

        Else
            Hide()
            Puntaje.Show()

        End If


    End Sub


End Class