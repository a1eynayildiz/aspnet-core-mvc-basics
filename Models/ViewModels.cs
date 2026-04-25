using dotnet_basics.Models;

namespace dotnet_basics.Models.ViewModels;

public class HomePageViewModel
{
    public List<Course> Courses { get; set; } = new();
    public List<Product> Products { get; set; } = new();
}