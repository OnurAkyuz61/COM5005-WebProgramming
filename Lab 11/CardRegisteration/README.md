# Card Registration MVC5 Application

Bu proje, ASP.NET MVC5 kullanarak kredi kartı başvuru formu uygulamasıdır.

## Proje Yapısı

- **Models/Card.cs**: Form validasyonu için kullanılan model sınıfı
- **Controllers/HomeController.cs**: Ana controller (Offer, Form GET/POST actionları)
- **Views/Home/Offer.cshtml**: Ana sayfa (kredi kartı teklifi)
- **Views/Home/Form.cshtml**: Başvuru formu sayfası
- **Views/Home/Result.cshtml**: Sonuç sayfası

## Özellikler

- Form validasyonu (Data Annotations ile)
- HTML Helpers kullanımı (@Html.TextBoxFor, @Html.RadioButton, @Html.DropDownListFor)
- Model binding ve ModelState.IsValid kontrolü
- ViewBag ile veri aktarımı

## Kurulum

1. Visual Studio'da projeyi açın
2. NuGet Package Manager ile gerekli paketleri yükleyin:
   - Microsoft.AspNet.Mvc (v5.2.7)
   - System.ComponentModel.DataAnnotations
3. Projeyi çalıştırın

## Kullanım

1. Ana sayfa: `/Home/Offer` - "Would you like to have a credit card?" sorusu
2. Form sayfası: "Application Form" linkine tıklayarak `/Home/Form` sayfasına gidin
3. Formu doldurun ve Submit butonuna tıklayın
4. Validasyon başarılıysa Result sayfası görüntülenir

## Validasyon Kuralları

- **Name**: Zorunlu alan
- **SurName**: Zorunlu alan
- **Email**: Zorunlu alan + geçerli email formatı
- **Phone**: Zorunlu alan
- **Gender**: Zorunlu seçim (Male/Female)
- **Choice**: Zorunlu seçim (Yes/No)

