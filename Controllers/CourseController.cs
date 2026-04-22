using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class CourseController : Controller
{
    //localhost:3000/course 
    public ActionResult Index()
    {
        return View();
    }


    //localhost:3000/course/list
    public ActionResult List()
    {
        string kursAdi1 = "Javascript Kursu ";
        string kursAdi2 = "React Kursu";

        string kursAciklama1 = "JavaScript Kurs Açıklaması";
        string kursAciklama2 = "React Kurs Açıklaması";

        string[] kursResimleri = ["1.jpg","2.jpg"];


        string[] kursAdlari = ["Javascript Kursu","React Kursu"];
        string[] kursAciklamalari = ["JavaScript Kurs Açıklaması","React Kurs Açıklaması"] ;

        ViewData["kursAdi1"] = kursAdlari[0];//javascript
        ViewData["kursAdi2"] = kursAdlari[1];//react

        ViewData["kursAciklama1"] = kursAciklamalari[0];//javascript
        ViewData["kursAciklama2"] = kursAciklamalari[1];//react

        ViewData["kursResim1"] = kursResimleri[0];//javascript
        ViewData["kursResim2"] = kursResimleri[1];//react

        return View();
    }

    //localhost:3000/course/details
    public ActionResult Details()
    {
        Course kurs1 = new Course();
        kurs1.Title ="Django kursu";
        kurs1.Image = "1.jpg";
        
        return View();
       
    }
}
