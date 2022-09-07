namespace csharp_concepts.expressions;

public class Expressions
{
    public void ArithmeticExpressions()
    {
        var a = 1;
        var b = 2;

        Console.WriteLine($"Increment: {a++}");
        Console.WriteLine($"Decrement: {a--}");
        Console.WriteLine($"Plus:{a + b}");
        Console.WriteLine($"Minus:{a - b}");
        Console.WriteLine($"Multiplication:{a * b}");
        Console.WriteLine($"Division:{a / b}");
        Console.WriteLine($"Remainder (Modulo):{-5.2 % 2.0}");
    }

    public void LogicalExpressions()
    {
        var a = true;
        var b = false;

        Console.WriteLine($"Negation:{!a}");
        Console.WriteLine($"AND:{a && b}");
        Console.WriteLine($"OR:{a || b}");
        Console.WriteLine($"XOR:{a ^ b}");
    }

    public void OrderExpressions()
    {
        var a = 1;
        var b = 2;

        Console.WriteLine($"Less Than:{a < b}");
        Console.WriteLine($"Less Than or Equal:{a <= b}");
        Console.WriteLine($"Greater Than:{a > b}");
        Console.WriteLine($"Greater Than or Equal:{a >= b}");
    }

    public void EqualityExpressions()
    {
        var valueType1 = 1;
        var valueType2 = 1;

        Console.WriteLine($"Equal:{valueType1 == valueType2}");
        Console.WriteLine($"Not Equal:{valueType1 != valueType2}");

        var referenceType1 = new Expressions();
        var referenceType2 = new Expressions();

        Console.WriteLine($"Equal memory reference: {referenceType1 == referenceType2}");
    }

    public void TernaryOperator()
    {
        var condition = true;
        var result = condition ? "True value" : "False value";
    }
}