Partial Class BB_GamesDataSet
    Partial Public Class preguntaDataTable
        Private Sub preguntaDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.descripcionColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
