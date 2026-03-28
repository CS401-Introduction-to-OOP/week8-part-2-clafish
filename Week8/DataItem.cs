namespace ConsoleApp1123.week8_part_2_clafish.Week8;

public class DataItem
{
    public string Id { get; set; } = string.Empty;
    public byte[] Payload { get; set; } = Array.Empty<byte>();
    
    public long GetSize()
    {
        return Payload.Length;
    }
}