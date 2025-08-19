# SelKirimDokumSite (ASP.NET Core MVC)

Bu proje, **Sel Kırım Döküm** için oluşturulmuş modern ve hızlı bir web sitesi iskeletidir.

## Özellikler
- Anasayfa: Hero, KPI, Hizmet Kartları, SSS ve Ücretsiz Keşif Formu
- Hizmet Sayfaları: Bina Yıkımı, Fabrika & Endüstriyel Söküm, Kırım, Hafriyat & Moloz Atımı, Beton Kesme/Delme, Çatı & Asbest Sökümü
- Blog: Basit liste ve yazı görünümü
- SEO: Meta açıklamalar, Schema.org (`LocalBusiness` ve `Service`), semantik başlıklar
- UX: Mobil "Hemen Ara" butonu, akordeon SSS, temiz grid yapısı

## Kurulum
1. .NET 8 SDK kurulu olmalı.
2. Proje klasöründe:
   ```bash
   dotnet restore
   dotnet run
   ```
3. Tarayıcıda `https://localhost:5001` veya `http://localhost:5000`.

## Notlar
- Porto temasına **bağımlı değildir**; telifsiz, hafif bir arayüz kullanır.
- E-posta gönderimi örneklendirilmemiştir; istekler `App_Data/` içine düz metin olarak yazılır.
- Tel/eposta/adres bilgilerini `Views/Shared/_Layout.cshtml` içinden güncelleyebilirsiniz.