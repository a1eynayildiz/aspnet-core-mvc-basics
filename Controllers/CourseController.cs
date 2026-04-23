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
    
    //localhost:3000/course/details
    public ActionResult Details()
    {
        Course kurs1 = new Course();
        kurs1.Title ="Django kursu";
        kurs1.Image = "1.jpg";
        
        return View(kurs1);
       
    }

    public ActionResult List()
    {
        Course kurs1 = new Course();
        kurs1.Title = "Javascript Kursu ";
        kurs1.Image ="1.jpg";

        Course kurs2 = new Course();
        kurs2.Title = "React Kursu ";
        kurs2.Image ="2.jpg";

        Course kurs3 = new Course();
        kurs3.Title = "Angular Kursu ";
        kurs3.Image ="3.jpg";


        //Course[] kurslar = [kurs1,kurs2,kurs3];
        List<Course> kurslar = new List<Course>
        {
            kurs1,kurs2,kurs3
        };

       
        return View(kurslar);
    }


    
}
