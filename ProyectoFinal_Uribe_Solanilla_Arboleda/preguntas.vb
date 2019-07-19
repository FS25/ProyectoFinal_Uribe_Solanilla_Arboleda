Public Class Preguntas
    Private quiz As QuizGame
    Private questions(-1) As Question
    Private questionIndex As Integer = -1

    Public Sub SetQuiz(ByRef quiz As QuizGame)
        Me.quiz = quiz
        LoadQuiz(quiz.GetId()) 'Cargamos los datos del quiz'

        questionIndex += 1
        SetQuestion(questions(questionIndex)) 'Mostramos la primera pregunta'
    End Sub

    Private Sub LoadQuiz(ByVal id As Integer)
        Try
            Dim command = Database.getCommand()
            Dim dataReader As Odbc.OdbcDataReader
            Dim queryTxt = "SELECT [id] " +
                           "    ,[id_quiz] " +
                           "    ,[descripcion] " +
                           "    ,[puntos] " +
                           "    ,[activo] " +
                           "FROM [BB_Games].[dbo].[pregunta] " +
                           "WHERE id_quiz = " + id.ToString()

            command.CommandText = queryTxt
            dataReader = command.ExecuteReader

            'Leemos las preguntas'
            While dataReader.Read
                Try
                    Dim question As Question = New Question(Integer.Parse(dataReader("id")), dataReader("descripcion"))

                    ReDim Preserve Me.questions(Me.questions.Length)
                    Me.questions(Me.questions.Length - 1) = question
                Catch ex As Exception
                    MsgBox("Error cargando pregunta")
                End Try
            End While

            'Obtenemos las respuestas de cada pregunta'
            For Each question As Question In questions
                question.SetAnswers(LoadAnswers(question.GetId()))
            Next
        Catch ex As Exception
            MsgBox("Error cargando las preguntas del quiz. " & ex.ToString())
        End Try
    End Sub

    Private Function LoadAnswers(ByVal id_question As Integer) As Answer()
        Dim answers(-1) As Answer

        Try
            Dim command = Database.getCommand()
            Dim dataReader As Odbc.OdbcDataReader
            Dim queryTxt = "SELECT [id] " +
                           "    ,[id_pregunta] " +
                           "    ,[descripcion] " +
                           "    ,[correcta] " +
                           "FROM [BB_Games].[dbo].[respuesta] " +
                           "WHERE id_pregunta = " + id_question.ToString()

            command.CommandText = queryTxt
            dataReader = command.ExecuteReader

            'Leemos las respuestas de cada pregunta'
            While dataReader.Read
                Try
                    Dim answer As Answer = New Answer(Integer.Parse(dataReader("id")), dataReader("descripcion"), Boolean.Parse(dataReader("correcta")))

                    ReDim Preserve answers(answers.Length)
                    answers(answers.Length - 1) = answer
                Catch ex As Exception
                    MsgBox("Error cargando respuesta")
                End Try
            End While
            Return answers
        Catch ex As Exception
            MsgBox("Error cargando las respuestas de la pregunta. " & ex.ToString())
            Return answers
        End Try
    End Function

    Private Sub SetQuestion(ByRef question As Question)
        'Mostramos la pregunta en los formularios'

        lblPreguntaNum.Text = "Pregunta N° " + (questionIndex + 1).ToString()
        lblQuest.Text = question.GetDescription()

        If question.GetAnswers().Length = 3 Then
            Dim answers As Answer() = question.GetAnswers()
            rdBtnOption1.Text = answers(0).GetDescription()
            rdBtnOption2.Text = answers(1).GetDescription()
            rdBtnOption3.Text = answers(2).GetDescription()
        Else
            MsgBox("Error cargando la pregunta")
        End If
    End Sub


    Private Sub BtnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim actualQuestion = questions(questionIndex)

        'Seleccionar respuestas'
        If rdBtnOption1.Checked Then
            actualQuestion.SetAnswer(actualQuestion.GetAnswers(0).GetId())
        ElseIf rdBtnOption2.Checked Then
            actualQuestion.SetAnswer(actualQuestion.GetAnswers(1).GetId())
        Else
            actualQuestion.SetAnswer(actualQuestion.GetAnswers(2).GetId())
        End If

        If questionIndex + 1 < questions.Length Then
            'Carga siguiente pregunta'
            questionIndex += 1
            SetQuestion(questions(questionIndex))
        Else
            'Gaurdamos el registro de las preguntas'
            Dim cmd = Database.getCommand()
            Dim dataReader As Odbc.OdbcDataReader
            Dim points As Integer

            For Each question As Question In questions
                cmd.CommandText = "INSERT INTO [BB_Games].[dbo].[respuesta_usuario] VALUES('" & question.GetId().ToString() & "', '" & question.GetSelectedAnswer().ToString() & "', '" & UserSession.getUsername() & "')"
                cmd.ExecuteNonQuery()
            Next

            'Obtenemos el puntaje'
            cmd.CommandText = "SELECT SUM(puntos) puntos 
                                FROM [BB_Games].[dbo].[respuesta_usuario] 
                                JOIN pregunta ON pregunta.id = respuesta_usuario.id_pregunta 
                                JOIN respuesta ON respuesta.id = respuesta_usuario.id_respuesta 
                                WHERE pregunta.id_quiz = " & quiz.GetId().ToString() & " AND respuesta.correcta = 1"
            dataReader = cmd.ExecuteReader
            dataReader.Read()

            points = Integer.Parse(dataReader("puntos").ToString())
            dataReader.Close()

            'Guardamos el quiz'
            cmd.CommandText = "INSERT INTO [BB_Games].[dbo].[quiz_usuario] VALUES('" & quiz.GetId().ToString() & "', '" & UserSession.getUsername() & "', '" & points.ToString() & "', CURRENT_TIMESTAMP)"
            cmd.ExecuteNonQuery()

            'Cargamos la vista de puntajes'
            Puntaje.Show()
            Puntaje.SetScore(points)

            'Cerramos esta vista'
            Me.questionIndex = -1
            Me.Close()
        End If
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs)
        questionIndex = questionIndex - 1
        SetQuestion(questions(questionIndex))
    End Sub
End Class