using Microsoft.AspNetCore.Mvc;
using dotnet_basics.Models;
using dotnet_basics.Models.ViewModels;


namespace dotnet_basics.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            List<Course> courses = new List<Course>
            {
                new Course { Title="Javascript", Image="1.jpg", IsHome=true, IsActive=true },
                new Course { Title="React", Image="2.jpg", IsHome=true, IsActive=true },
                new Course { Title="Angular", Image="3.jpg", IsHome=false, IsActive=true },
                new Course { Title="Node.js", Image="4.jpg", IsHome=true, IsActive=true }
            };

            
            List<Product> products = new List<Product>
            {
                new Product { urunBaslik="Iphone 15", urunResim="i1.png", urunSatistami=true },
                new Product { urunBaslik="Iphone 16", urunResim="i2.png", urunSatistami=true },
                new Product { urunBaslik="Iphone 17", urunResim="i3.png", urunSatistami=false }
            };

            
            var model = new HomePageViewModel
            {
                Courses = courses.Where(x => x.IsHome).ToList(),
                Products = products.Where(x => x.urunSatistami).ToList()
            };

            return View(model);
        }
    }
}