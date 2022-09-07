namespace csharp_concepts.types;

public class ReferenceTypes
{
    string _characterSequence = "ABC";
    string[] _singleDimArray = { "x1", "x2", "x3" };
    string[,] _twoDimArray = { { "x1,y1", "x1,y2" }, { "x2,y1", "x2,y2" } };

    interface IDemoInterface
    {
        void DemoMethod();
        int DemoFunction(int x);
    }

    class DemoClass : IDemoInterface
    {
        public void DemoMethod()
        {
            Console.WriteLine("Do something!");
        }

        public int DemoFunction(int x)
        {
            return x * x;
        }
    }
}