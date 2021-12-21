using RazorDemo.Models;
using System.Text.Json;


namespace RazorDemo.Services;

public class TrekService
{
     public List<TrekStructure> Treks { get; }
    
    // (a) The Web host Environment 
    public IWebHostEnvironment WebHostEnvironment { get; }
    public TrekService(IWebHostEnvironment webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    // (b) Fetch the Json file from the Root directory
    private string JsonFileName
    {
        get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
    }

    public IEnumerable<TrekStructure> GetProducts()
    {
        using (var jsonFileReader = File.OpenText(JsonFileName))
        {
            return JsonSerializer.Deserialize<TrekStructure[]>(jsonFileReader.ReadToEnd());
        }
    }


}