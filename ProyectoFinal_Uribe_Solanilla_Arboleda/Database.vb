Module Database
    Private conn As Odbc.OdbcConnection
    Private cmd As Odbc.OdbcCommand

    Public Function createConnection() As Boolean
        Try
            conn = New Odbc.OdbcConnection("DSN=BBG")
            conn.Open()
            cmd = New Odbc.OdbcCommand()
            cmd.Connection = conn
            Return True
        Catch ex As Odbc.OdbcException
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function getCommand() As Odbc.OdbcCommand
        Return cmd
    End Function

    Public Sub closeConnection()
        Try
            conn.Close()
        Catch ex As Odbc.OdbcException
            Console.WriteLine(ex.Message)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module
