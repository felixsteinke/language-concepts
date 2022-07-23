Public Class ExceptionHandling

    Sub handleException()
        Try
            Throw New Exception("Handled Exception")
        Catch ex As Exception
            Console.WriteLine($"Got {ex.GetType}: {ex.Message}")
        Finally
            Console.WriteLine("Always gets executed!")
        End Try
    End Sub

    Sub handleExceptionWithGoto()
        On Error GoTo ErrorHandler
        Throw New Exception("Handled Exception")
        Exit Sub
ErrorHandler:
        Console.WriteLine($"Handled an exception.")
        Resume Next
    End Sub

    Sub throwException()
        Throw New Exception("Unhandled Exception")
    End Sub
End Class
