using dotnet_basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_basics.Controllers;

public class CourseController : Controller
{
    List<Course> kurslar = new List<Course> {
        new Course { Title = "Javascript Kursu",Image = "1.jpg", IsActive = true,IsHome=true },
        new Course { Title = "React Kursu", Image = "2.jpg", IsActive = true,IsHome=true },
        new Course { Title = "Angular Kursu",Image = "3.jpg", IsActive = true,IsHome=true},
        new Course { Title = "Node.js Kursu",Image = "4.jpg", IsActive = true,IsHome=true },
        new Course { Title = "React Kursu", Image = "2.jpg", IsActive = true,IsHome=false },
        new Course { Title = "Angular Kursu",Image = "3.jpg", IsActive = true,IsHome=false},
        new Course { Title = "Node.js Kursu",Image = "4.jpg", IsActive = true,IsHome=true },
        
    };

    public ActionResult Index()
    {
        return View(kurslar);
    }

    public ActionResult Details()
    {
        Course kurs1 = new Course();
        kurs1.Title = "Django Kursu";
        kurs1.Image = "1.jpg";
        kurs1.IsActive = true;

        return View(kurs1);
    }

    public ActionResult List()
    {
        return View(kurslar);
    }


}
