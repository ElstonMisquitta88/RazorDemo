using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDemo.Models;
using RazorDemo.Services;

namespace RazorDemo.Pages
{
    public class TrekModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public TrekService _ProductService;
        public DemoService _DemoService;
        public IMyDependency _Dependency;

        public IEnumerable<TrekStructure> AllTrekList { get; private set; }
        public string Hellostring {get;set;}
        public Task<Root> RActivity {get;set;}

        public string DMessage {get;set;}


        // Requesting the Product Service - You can also request other services
        public TrekModel(ILogger<IndexModel> logger,TrekService productService,DemoService demoservc,IMyDependency Dependency)  
        {
            _logger = logger;
            _ProductService = productService;
            _DemoService=demoservc;
            _Dependency=Dependency;
        }

        public void OnGet()
        {
            AllTrekList=_ProductService.GetProducts();
            Hellostring=_DemoService.FetchName ();
            RActivity=_DemoService.GetRandomActivity();
            DMessage=_Dependency.WriteMessage (" : Elston Misquitta  ");
        }

        

    }

}
