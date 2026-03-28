namespace ConsoleApp1123.week8_part_2_clafish.Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }
    
    public override void Open()
    {
        IsOpen = true;
    }

    public override void Close()
    {
        IsOpen = false;
    }

    public void Dispose()
    {
        Close();
    }
}