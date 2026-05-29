# ASP.NET Core MVC Basics

Başlangıç seviyesindeki geliştiriciler için hazırlanmış, **ASP.NET Core MVC** mimarisinin temellerini ve basit **CRUD (Create, Read, Update, Delete)** işlemlerini örnekleyen bir öğrenme projesidir.

##  Özellikler

- ASP.NET Core MVC mimarisinin temel kullanımı
- Controller, Model ve View yapılarının uygulanması
- Basit CRUD işlemleri
- Razor View motoru ile dinamik sayfa oluşturma
- Static dosya (CSS / JS) yönetimi
- HTTPS yönlendirme ve temel middleware yapılandırması

##  Kullanılan Teknolojiler

- **.NET 9.0**
- **ASP.NET Core MVC**
- **C#**
- **Razor (cshtml)**
- **HTML / CSS / JavaScript**

## Proje Yapısı

```
aspnet-core-mvc-basics/
├── Controllers/        # MVC controller sınıfları
├── Models/             # Veri modelleri
├── Views/              # Razor view dosyaları (.cshtml)
├── Properties/         # launchSettings.json
├── wwwroot/            # Statik dosyalar (css, js, lib)
├── Program.cs          # Uygulama giriş noktası ve yapılandırma
├── appsettings.json    # Genel konfigürasyon
└── dotnet-basics.csproj
```

##  Kurulum

### Gereksinimler

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)


### Adımlar

```bash
# 1. Depoyu klonlayın
git clone https://github.com/a1eynayildiz/aspnet-core-mvc-basics.git

# 2. Proje klasörüne girin
cd aspnet-core-mvc-basics

# 3. Bağımlılıkları yükleyin
dotnet restore

# 4. Projeyi çalıştırın
dotnet run
```

Uygulama varsayılan olarak `https://localhost:5001` veya `http://localhost:5000` adresinde çalışacaktır.

##  Öğrenme Hedefleri

Bu proje aşağıdaki konuları pratik etmek için tasarlanmıştır:

- MVC tasarım deseninin anlaşılması
- Routing yapılandırması
- Form gönderimleri ve model binding
- Razor syntax kullanımı
- Controller–View veri aktarımı (ViewBag, ViewData, Model)


