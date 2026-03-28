using ConsoleApp1123.week8_part_2_clafish.Week8;

class Program
{
    public static void Main()
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        var manager = new ResourceManager<Resource>();
        manager.Add(file);
        manager.Add(network);
        
        manager.OpenAll();
        
        using(var res = new FileResource("mainfile.txt"))
        {
            res.Open();
        }
        
        manager.CloseAll();
    }
    
}