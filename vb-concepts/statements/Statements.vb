Public Class Statements

    Sub iterationStatementFor()
        Dim list() As String = {"Friday", "Saturday", "Sunday"}

        For index = 0 To 9 Step 2
            If index = 4 Then
                Console.WriteLine("Skip the 4!")
                Continue For
            End If
            Console.WriteLine($"Loop on index: {index}")
        Next

        For Each day As String In list
            Console.WriteLine($"Loop on collection: {day}")
        Next
    End Sub

    Sub iterationStatementWhile()
        Dim conditionFalse As Boolean = False
        Dim conditionTrue As Boolean = True

        Do While conditionFalse
            Console.WriteLine("Loop until condition is false!")
        Loop

        Do Until conditionTrue
            Console.WriteLine("Loop until condition is true!")
        Loop

        Do
            Console.WriteLine("Loop at least once!")
        Loop While conditionFalse
    End Sub

    Sub selectStatementIf()
        Dim day As String = "Monday"

        If day.Contains("e") Then
            Console.WriteLine("Branch 1")
        ElseIf day.Contains("a") Then
            Console.WriteLine("Branch 2")
        Else
            Console.WriteLine("Default Branch")
            Exit Sub
        End If
        Console.WriteLine("Selected a predicted branch.")
    End Sub

    Sub selectStatementSwitch()
        Dim day As DayOfWeek = DayOfWeek.Monday

        Select Case day
            Case Is = DayOfWeek.Friday
                Console.WriteLine("Great!")
            Case DayOfWeek.Saturday, DayOfWeek.Sunday
                Console.WriteLine("Even better!")
            Case Else
                Console.WriteLine("Could be better...")
        End Select
    End Sub
End Class
