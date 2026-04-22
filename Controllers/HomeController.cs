using Microsoft.AspNetCore.Mvc; //kullanırken de using kullanmak 

namespace dotnet_basics.Controllers; // tanımlarken namespace gerekiyor

 //ASP.NET Core'da bir sayfayı veya bir grup işlemi yöneten sınıfların sonuna geleneksel olarak Controller kelimesi eklenir.HomeController, Controller sınıfından miras alıyor.Controller sınıfı içinde hazır gelen (sayfayı ekrana basma, veri gönderme vb.) tüm yetenekler artık HomeController içinde de kullanılabilir hale gelir.Controller (Ana Sınıf) Bu, Microsoft'un hazırladığı hazır bir kütüphanedir.
public class HomeController : Controller
{
    //localhost:3000/home buradaki home bizim yazdığımız controller olan HomeControllera karşılık gelir.
    //localhost:3000/home/Index
    public ActionResult Index()
    {
        int sayi1=10;
        int sayi2=20;

        //int urun_fiyat = 5000
        
        sayi1=30;//sayi1 güncellenmis kabul eder.

        int toplam = sayi1+sayi2;//50
        ViewData["Toplam"] = toplam;//MVC'de, denetleyiciden görünüme veri aktarmak istediğimizde ViewData'yı kullanırız. Bu, verileri dahili olarak depolayan bir sözlük türüdür.
        return View();
    }
    
    //localhost:3000/home/about buradaki about ise actiona karşılık geliyor.Ve action methodları büyük harfle başlar
    public ActionResult About() //About methodu parametre almaz
    {
        return View();
    }

    //localhost:3000/home/contact
    public ActionResult Contact()
    {
        return View();
    }
}

