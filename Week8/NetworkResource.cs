namespace ConsoleApp1123.week8_part_2_clafish.Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        Console.WriteLine($"{Name} network is opened");
        IsOpen = true;
    }
    public override void Close()
    {
        
        IsOpen = false;
    }
    public void Dispose()
    {
        Console.WriteLine($"{Name} network was disposed successfully");
        Close();
    }
}