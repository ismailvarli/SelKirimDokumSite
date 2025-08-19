# SMTP E-posta Ayarı

1) `appsettings.json` içindeki `Smtp` bölümünde şunları güncelle:
- `From`, `To`, `User`: `selkirimdokum@gmail.com`
- `Password`: Gmail **uygulama şifresi** (16 haneli).

2) Gmail için önerilen değerler:
- Host: smtp.gmail.com
- Port: 587
- EnableSsl: true

3) Çalıştırmadan önce publish/dev ortamında dosyanın okunduğundan emin ol (varsayılan olarak ASP.NET Core bunu otomatik okur).

> Not: Uygulama şifresi yoksa gönderim başarısız olur ve `App_Data/mail_errors.log` dosyasına hata yazılır.