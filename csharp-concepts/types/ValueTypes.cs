namespace csharp_concepts.types;

public class ValueTypes
{
    bool booleanVariable = true;

    short shortIntegral = short.MaxValue;
    int integral = int.MaxValue;
    long longIntegral = long.MaxValue;

    float shortDecimal = float.MaxValue;
    double normalDecimal = double.MaxValue;
    decimal longDecimal = Decimal.MaxValue;

    char singleCharacter = 'A';

    char? nullableType = null;
    
    enum Days {
        FRIDAY, SATURDAY, SUNDAY
    }
    
    struct Point
    {
        public double X { get; }
        public double Y { get; }
    
        public Point(double x, double y) => (X, Y) = (x, y);
    }
}