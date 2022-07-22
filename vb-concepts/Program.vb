Imports System

Module Program
    Sub Main(args As String())
        Dim person As Person = New Person()
        Console.WriteLine(person.tell("Hello World!"))
    End Sub
End Module


Public Class Person
    Private id As Integer
    Protected gender As Char
    Public name As String

    Public Sub New()
        id = 1
        gender = "M"
        name = "Mario"
    End Sub

    Public Function tell()
        Return $"Hello my name is {name}"
    End Function

    Public Function tell(ByVal message As String)
        Return $"{tell()}: {message}"
    End Function
End Class