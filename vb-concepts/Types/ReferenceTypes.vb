Public Class ReferenceTypes

    Dim characterSequence As String = "ABC"
    Dim singleDimArray() As String = {"x1", "x2", "x3"}
    Dim twoDimArray(,) As String = {{"x1,y1", "x1,y2"}, {"x2,y1", "x2,y2"}}

End Class

Public Interface DemoInterface
    Sub demoMethod()
    Function demoFunction(ByVal x As Integer) As Integer
End Interface

Public Class DemoClass
    Implements DemoInterface

    Public Sub demoMethod() Implements DemoInterface.demoMethod
        Console.WriteLine("Do something!")
    End Sub

    Public Function demoFunction(x As Integer) As Integer Implements DemoInterface.demoFunction
        Return x * x
    End Function
End Class