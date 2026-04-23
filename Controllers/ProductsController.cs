using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class ProductsController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    public ActionResult List()
    {
        List<Product> urunler = new List<Product>
        {
            new Product{urunBaslik = "Iphone 15", urunFiyat =47249, urunResim="i1.png", urunAciklama = "iPhone 15’in ekranı yuvarlatılmış köşelere sahiptir. Telefonun kıvrımlı, zarif tasarımını takip eden bu köşeler standart bir dikdörtgenin sınırları içinde yer alır. Standart bir dikdörtgen olarak ölçüldüğünde ekran diyagonal olarak 6.12 inçtir (görüntülenebilen gerçek alan daha azdır",urunSatistami=true},

            new Product{urunBaslik = "Iphone 16", urunFiyat =57999, urunResim="i2.png", urunAciklama = "iPhone 16’nın ekranı yuvarlatılmış köşelere sahiptir. Telefonun kıvrımlı, zarif tasarımını takip eden bu köşeler standart bir dikdörtgenin sınırları içinde yer alır. Standart bir dikdörtgen olarak ölçüldüğünde ekran diyagonal olarak 6.12 inçtir (görüntülenebilen gerçek alan daha azdır",urunSatistami=true},

            new Product{urunBaslik = "Iphone 17", urunFiyat =73999, urunResim="i3.png", urunAciklama = "iPhone 17’nın ekranı yuvarlatılmış köşelere sahiptir. Telefonun kıvrımlı, zarif tasarımını takip eden bu köşeler standart bir dikdörtgenin sınırları içinde yer alır. Standart bir dikdörtgen olarak ölçüldüğünde ekran diyagonal olarak 6.12 inçtir (görüntülenebilen gerçek alan daha azdır",urunSatistami=false}

        };
        return View(urunler);
    }

    public ActionResult Details()
    {
        Product urun1 = new Product();

        urun1.urunBaslik = "Samsung S24 Ultra";
        urun1.urunAciklama = "Samsung Galaxy S24 Ultra 512 GB 12 GB Ram (Samsung Türkiye Garantili) Siyah";
        urun1.urunFiyat = 70000;
        urun1.urunResim = "samsung-s24.jpg";
        urun1.urunSatistami = false;

        return View(urun1);
    }
}
