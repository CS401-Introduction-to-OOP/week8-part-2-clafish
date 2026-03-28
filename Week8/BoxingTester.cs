namespace ConsoleApp1123.week8_part_2_clafish.Week8;

public static class BoxingTester
{
    public static void Test()
    {
        // creating a variable a
        int a = 10;

        // Box the value type into an object reference (added an instance of object to heap)
        object obj = a;

        // Unbox a reference into an object with checking type (copied reference from heap and adding to stack)
        int b = (int)obj;

        // printing a and b
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}