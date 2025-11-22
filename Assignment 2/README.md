# IKU-CARS ASP.NET MVC 5 Projesi

## Proje Açıklaması
Bu proje, İstanbul Kültür Üniversitesi için geliştirilmiş bir araç kiralama web uygulamasıdır. ASP.NET MVC 5 ve Entity Framework Code First yaklaşımı kullanılarak geliştirilmiştir.

## Teknolojiler
- ASP.NET MVC 5.2.9
- .NET Framework 4.7.2
- Entity Framework 6.4.4
- Bootstrap 5.2.3
- jQuery 3.7.0
- SQL Server LocalDB

## Özellikler
- ✅ Responsive web tasarımı
- ✅ Araç listesi görüntüleme
- ✅ Araç detay sayfaları
- ✅ Admin paneli ile CRUD işlemleri
- ✅ Veritabanı entegrasyonu
- ✅ Örnek veri ile otomatik doldurma

## Kurulum ve Çalıştırma

### 1. Gereksinimler
- Visual Studio 2019 veya üzeri
- .NET Framework 4.7.2
- SQL Server LocalDB

### 2. Projeyi Çalıştırma
1. Visual Studio'da `IKU-CARS.sln` dosyasını açın
2. Package Manager Console'u açın (Tools → NuGet Package Manager → Package Manager Console)
3. Aşağıdaki komutları sırayla çalıştırın:
   ```
   Enable-Migrations
   Add-Migration InitialCreate
   Update-Database
   ```
4. Projeyi derleyin: Build → Rebuild Solution (Ctrl+Shift+B)
5. F5 tuşuna basarak projeyi çalıştırın

### 3. Veritabanı
- LocalDB kullanılmaktadır
- İlk çalıştırmada otomatik olarak 16 örnek araç verisi eklenir
- Connection String: `Web.config` dosyasında tanımlıdır

## Proje Yapısı

### Models
- `Car.cs`: Araç model sınıfı
- `IKUCarDB.cs`: Entity Framework DbContext
- `SampleData.cs`: Örnek veri sınıfı

### Controllers
- `HomeController.cs`: Ana sayfa ve kullanıcı arayüzü
- `CarsController.cs`: Admin paneli CRUD işlemleri

### Views
- `Home/Index.cshtml`: Ana sayfa
- `Home/Car_List.cshtml`: Araç listesi
- `Home/Car_Info.cshtml`: Araç detay sayfası
- `Cars/`: Admin paneli sayfaları (Index, Create, Edit, Delete, Details)

### Assets
- `Content/`: CSS dosyaları ve Bootstrap stilleri
- `Scripts/`: JavaScript dosyaları ve kütüphaneler
- `Images/`: Araç resimleri ve site görselleri
- `bin/`: Derlenmiş assembly dosyaları
- `obj/`: Geçici derleme dosyaları

## Sayfalar

### Kullanıcı Arayüzü
- **Ana Sayfa** (`/`): Banner, filo tanıtımı ve rezervasyon formu
- **Araç Listesi** (`/Home/Car_List`): Tüm araçların listesi
- **Araç Detayı** (`/Home/Car_Info/{id}`): Seçilen aracın detay bilgileri

### Admin Paneli
- **Araç Yönetimi** (`/Cars`): Araç listesi ve yönetim
- **Araç Ekleme** (`/Cars/Create`): Yeni araç ekleme formu
- **Araç Düzenleme** (`/Cars/Edit/{id}`): Araç bilgilerini düzenleme
- **Araç Silme** (`/Cars/Delete/{id}`): Araç silme onayı

## Örnek Veriler
Proje 16 farklı araç ile gelir:
- **Audi**: R8, Sedan, Van, A3
- **BMW**: Van, X5, i7, i8
- **Hyundai**: Elantra, Sport, Tucson, Van, Bayon, i10, i20, Kona

## Dosya Yapısı

### Konfigürasyon Dosyaları
- `Web.config`: Ana konfigürasyon dosyası
- `Web.Debug.config`: Debug ortamı ayarları
- `Web.Release.config`: Release ortamı ayarları
- `Global.asax`: Uygulama başlangıç dosyası
- `packages.config`: NuGet paket referansları
- `IKU-CARS.csproj`: Visual Studio proje dosyası

### Klasör Yapısı
- `App_Data/`: Uygulama verileri
- `App_Start/`: Başlangıç konfigürasyonları
- `Properties/`: Proje özellikleri
- `favicon.ico`: Site ikonu

## Geliştirici Notları
- Tüm araç resimleri `~/Images/` klasöründe bulunmaktadır
- Responsive tasarım Bootstrap 5 ile sağlanmıştır
- Entity Framework Code First Migration kullanılmıştır
- Hata yönetimi ve null kontrolleri eklenmiştir
- Footer'daki karakter kodlama sorunu düzeltilmiştir

## Lisans
Bu proje eğitim amaçlı geliştirilmiştir.
