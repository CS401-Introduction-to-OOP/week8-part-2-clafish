namespace ConsoleApp1123.week8_part_2_clafish.Week8;

public struct Point
{
    public int X { get; set; }

    public int Y { get; set; }
    
    public void Print()
    {
        Console.WriteLine($"X - {X}, Y - {Y}");
    }
}