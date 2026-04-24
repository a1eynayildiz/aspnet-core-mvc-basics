// namespace dotnet_basics.Models;

// public class Course
// {
//     public string Title { get; set; } // normal oluşturduğumuz değişkenlere benziyor sadece biraz daha yetenekli.Sınıf içinde oluşturduğumuz değişkenlere property diyoruz.
//     //HATIRLATMA!!!get → değeri okumayı sağlaR. set → değeri değiştirmeyi sağlar
//     //kullanım
//     //Yas = 25;      // set çalışır
//     //Console.WriteLine(Yas);  // get çalışır
//     public string Image {get; set;}

// }
namespace dotnet_basics.Models;

public class Course
{
    public int Id { get; set; }
    public string? Title { get; set; } = null!;
    public string? Image { get; set; }
    public bool IsActive {get; set;}
    public bool IsHome {get;set;}


}