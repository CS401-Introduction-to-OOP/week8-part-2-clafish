namespace ConsoleApp1123.week8_part_2_clafish.Week8;

public class DataContainer<T> where T : DataItem
{
    private readonly List<T> _items = new();
    public void AddItem(T item)
    {
        _items.Add(item);
    }
    
    public long GetTotalSize()
    {
        long sum = 0;
        foreach (var item in _items)
        {
            sum += item.GetSize();
        }

        return sum;
    }
}