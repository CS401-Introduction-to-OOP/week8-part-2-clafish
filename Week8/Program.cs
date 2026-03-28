using ConsoleApp1123.week8_part_2_clafish.Week8;

class Program
{
    public static void Main()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 10;
        
        // struct is creating a ValueType, so when we copy, we create an independent object
        p1.Print();
        p2.Print();
        
        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;

        // class is creating a ReferenceType, so when we copy, we just copy pointer to memory
        r2.Y = 42;
        r1.Print();
        r2.Print();

// Boxing demo
        BoxingTester.Test();
    }
}