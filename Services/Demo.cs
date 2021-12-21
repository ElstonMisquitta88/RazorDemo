using Newtonsoft.Json;
namespace RazorDemo.Services;
    public class Root
    {
        public string activity { get; set; }
        public string type { get; set; }
        public int participants { get; set; }
        public string link { get; set; }
        public string key { get; set; }
   
    }

public class DemoService
{
    public string FetchName()
    {
        return "Hello World. From Another Service";
    }

    public async Task<Root> GetRandomActivity()
    {
        var client = new HttpClient();
        var response = await client.GetAsync("http://www.boredapi.com/api/activity");
        var content = await response.Content.ReadAsStringAsync();
        Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(content);
        return myDeserializedClass; 
    }
}