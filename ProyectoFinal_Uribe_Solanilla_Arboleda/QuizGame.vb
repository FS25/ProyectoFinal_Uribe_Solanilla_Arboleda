Public Class QuizGame
    Private id As Integer

    Public Sub New(ByVal id As Integer)
        Me.id = id
    End Sub

    Public Function GetId() As Integer
        Return id
    End Function
End Class

Public Class Question
    Private id As Integer
    Private description As String
    Private answers() As Answer

    Public Sub New(ByVal id As Integer, ByVal desc As String)
        Me.id = id
        Me.description = desc
    End Sub

    Public Sub SetAnswers(ByRef answers() As Answer)
        ReDim Me.answers(answers.Length - 1)
        Me.answers = answers
    End Sub

    Public Function GetId() As Integer
        Return Me.id
    End Function
End Class

Public Class Answer
    Private id As Integer
    Private description As String
    Private correct As Boolean

    Public Sub New(ByVal id As Integer, ByVal desc As String, ByVal correct As Boolean)
        Me.id = id
        Me.description = desc
        Me.correct = correct
    End Sub
End Class
