Module UserSession
    Private username As String
    Private nombre As String

    Public Sub setUser(ByVal user As String, ByVal name As String)
        username = user
        nombre = name
    End Sub

    Public Function getUsername() As String
        Return username
    End Function

    Public Function getName() As String
        Return nombre
    End Function
End Module
