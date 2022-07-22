Public Class Expressions
    Sub arithmeticExpressions()
        Dim a As Integer = 1
        Dim b As Integer = 2

        Console.WriteLine($"Plus:{a + b}")
        Console.WriteLine($"Minus:{a - b}")
        Console.WriteLine($"Multiplication:{a * b}")
        Console.WriteLine($"Division:{a / b}")
        Console.WriteLine($"Remainder (Modulo):{-5.2 Mod 2.0}")
    End Sub

    Sub logicalExpressions()
        Dim a As Boolean = True
        Dim b As Boolean = False

        Console.WriteLine($"Negation:{Not a}")
        Console.WriteLine($"AND:{a And b}")
        Console.WriteLine($"OR:{a Or b}")
        Console.WriteLine($"XOR:{a Xor b}")
    End Sub

    Sub orderExpressions()
        Dim a As Integer = 1
        Dim b As Integer = 2

        Console.WriteLine($"Less Than:{a < b}")
        Console.WriteLine($"Less Than or Equal:{a <= b}")
        Console.WriteLine($"Greater Than:{a > b}")
        Console.WriteLine($"Greater Than or Equal:{a >= b}")
    End Sub

    Sub equalityExpressions()
        Dim valueType1 As Integer = 1
        Dim valueType2 As Integer = 2

        Console.WriteLine($"Equal:{valueType1 = valueType2}")
        Console.WriteLine($"Not Equal:{valueType1 <> valueType2}")

        Dim referenceType1 As Expressions = New Expressions()
        Dim referenceType2 As Expressions = New Expressions()

        Console.WriteLine($"Equal:{referenceType1 Is referenceType2}")
        Console.WriteLine($"Not Equal:{referenceType1 IsNot referenceType2}")
    End Sub

    Sub ternaryOperator()
        Dim condition As Boolean = True
        Dim result As String = If(condition, "True value", "False value")
    End Sub
End Class
