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
        

        //Course[] kurslar = [kurs1,kurs2,kurs3];

        List<Course> kurslar = new List<Course>
        {
            new Course { Title = "Javascript Kursu ",Image = "1.jpg"},
            new Course {Title = "Python Kursu ",Image = "2.jpg"},
            new Course {Title = "Angular Kursu ", Image = "3.jpg"},
            new Course {Title = "Node.js Kursu", Image= "4.jpg"}

        };
       
        return View(kurslar);
    }


    
}
