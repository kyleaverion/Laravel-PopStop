' SignUpForm.vb
Friend Class MySqlConnection
    Private connectionString As String

    Public Sub New(connectionString As String)
        Me.connectionString = connectionString
    End Sub

    Friend Sub Open()
        Throw New NotImplementedException()
    End Sub

    Friend Sub Close()
        Throw New NotImplementedException()
    End Sub
End Class
