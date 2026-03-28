using ConsoleApp1123.week8_part_2_clafish.Week8;

class Program
{
    public static void Main()
    {
        var container = new DataContainer<DataItem>();
        
        for (int i = 0; i < 10000; i++)
        {
            var item = new DataItem
            {
                Id = $"item-{i}",
                Payload = new byte[1024]
            };
            
            container.AddItem(item);
        }
        Console.WriteLine($"Total size before GC: {container.GetTotalSize()} bytes");
        // calling garbage collector and nothing changed because we are storing references
        GC.Collect();
        Console.WriteLine("GC.Collect() was called.");
        Console.WriteLine($"Total size after GC: {container.GetTotalSize()} bytes");
    }
}