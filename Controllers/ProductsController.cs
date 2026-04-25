using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller
{
    List<Product> urunler =
        [
            new Product{Id=1,urunBaslik = "Iphone 15", urunFiyat =47249, urunResim="i1.png", urunAciklama = "iPhone 15’in ekranı yuvarlatılmış köşelere sahiptir. Telefonun kıvrımlı, zarif tasarımını takip eden bu köşeler standart bir dikdörtgenin sınırları içinde yer alır. Standart bir dikdörtgen olarak ölçüldüğünde ekran diyagonal olarak 6.12 inçtir (görüntülenebilen gerçek alan daha azdır",urunSatistami=true,IsHome=true},

            new Product{Id=2,urunBaslik = "Iphone 16", urunFiyat =57999, urunResim="i2.png", urunAciklama = "iPhone 16’nın ekranı yuvarlatılmış köşelere sahiptir. Telefonun kıvrımlı, zarif tasarımını takip eden bu köşeler standart bir dikdörtgenin sınırları içinde yer alır. Standart bir dikdörtgen olarak ölçüldüğünde ekran diyagonal olarak 6.12 inçtir (görüntülenebilen gerçek alan daha azdır",urunSatistami=true,IsHome=true},

            new Product{Id=3,urunBaslik = "Iphone 17", urunFiyat =73999, urunResim="i3.png", urunAciklama = "iPhone 17’nın ekranı yuvarlatılmış köşelere sahiptir. Telefonun kıvrımlı, zarif tasarımını takip eden bu köşeler standart bir dikdörtgenin sınırları içinde yer alır. Standart bir dikdörtgen olarak ölçüldüğünde ekran diyagonal olarak 6.12 inçtir (görüntülenebilen gerçek alan daha azdır",urunSatistami=true,IsHome=true},
            new Product{Id=4,urunBaslik = "Iphone 18", urunFiyat =90999, urunResim="i4.png", urunAciklama = "iPhone 18’in ekranı yuvarlatılmış köşelere sahiptir. Telefonun kıvrımlı, zarif tasarımını takip eden bu köşeler standart bir dikdörtgenin sınırları içinde yer alır. Standart bir dikdörtgen olarak ölçüldüğünde ekran diyagonal olarak 6.12 inçtir (görüntülenebilen gerçek alan daha azdır",urunSatistami=false,IsHome=false}

        ];
    public ActionResult Index()
    {
        List<Product> products = urunler.Where(p=>p.IsHome).ToList();
        return View(products);
    }

    public ActionResult List()
    {
        
        return View(urunler);
    }

    public ActionResult Details(int id)
    {
        Product? product = urunler.Where(p => p.Id == id).FirstOrDefault();

        return View(product);
    }
}
