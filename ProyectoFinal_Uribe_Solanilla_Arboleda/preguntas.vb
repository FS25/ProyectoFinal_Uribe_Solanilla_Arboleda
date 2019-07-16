Imports System.Data.SqlClient

Public Class Preguntas
    Private quiz As QuizGame
    Private questions(-1) As Question

    Public Sub SetQuiz(ByRef quiz As QuizGame)
        Me.quiz = quiz
        LoadQuiz(quiz.GetId())
    End Sub

    Private Sub LoadQuiz(ByVal id As Integer)
        Dim command = Database.getCommand()
        Dim dataReader As Odbc.OdbcDataReader
        Dim queryTxt = "SELECT [id] " +
                       "    ,[id_quiz] " +
                       "    ,[descripcion] " +
                       "    ,[puntos] " +
                       "    ,[activo] " +
                       "FROM [BB_Games].[dbo].[pregunta] " +
                       "WHERE id_quiz = " + id

        command.CommandText = queryTxt
        dataReader = command.ExecuteReader

        While dataReader.Read
            Try
                Dim question As Question = New Question(Integer.Parse(dataReader("id")), dataReader("descripcion"))

                ReDim Preserve Me.questions(Me.questions.Length)
                Me.questions(Me.questions.Length - 1) = question
            Catch ex As Exception
                MsgBox("Error cargando pregunta")
            End Try
        End While

        For Each question As Question In questions
            question.SetAnswers(LoadAnswers(question.GetId()))
        Next

        MsgBox(questions(0).GetId())
    End Sub

    Private Function LoadAnswers(ByVal id_question As Integer) As Answer()
        Dim answers(-1) As Answer
        Dim command = Database.getCommand()
        Dim dataReader As Odbc.OdbcDataReader
        Dim queryTxt = "SELECT [id] " +
                       "    ,[id_pregunta] " +
                       "    ,[descripcion] " +
                       "    ,[correcta] " +
                       "FROM [BB_Games].[dbo].[respuesta] " +
                       "WHERE id_pregunta = " + id_question

        command.CommandText = queryTxt
        dataReader = command.ExecuteReader

        While dataReader.Read
            Try
                Dim answer As Answer = New Answer(Integer.Parse(dataReader("id")), dataReader("descripcion"), Boolean.Parse(dataReader("correcta")))

                ReDim Preserve answers(answers.Length)
                answers(answers.Length - 1) = answer
            Catch ex As Exception
                MsgBox("Error cargando respuesta")
            End Try
        End While
    End Function

    Private Sub Preguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.quiz = New QuizGame(3)
        Me.SetQuiz(Me.quiz)
        MsgBox(quiz.GetId())
    End Sub
End Class