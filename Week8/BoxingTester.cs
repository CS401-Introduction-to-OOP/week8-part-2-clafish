namespace ConsoleApp1123.week8_part_2_clafish.Week8;

public static class BoxingTester
{
    public static void Test()
    {
        // creating a variable a
        int a = 10;

        // boxing a
        object obj = a;

        // unboxing into b
        int b = (int)obj;

        // printing a and b
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}