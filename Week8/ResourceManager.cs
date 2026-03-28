namespace ConsoleApp1123.week8_part_2_clafish.Week8;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();
    
    public void Add(T resource)
    {
        _resources.Add(resource);
    }
    public void OpenAll()
    {
        foreach (var resource in _resources)
        {
            resource.Open();
        }
    }

    public void CloseAll()
    {
        foreach (var resource in _resources)
        {
            resource.Close();
        }
    }
}