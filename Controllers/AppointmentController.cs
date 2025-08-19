using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SelKirimDokumSite.Models;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace SelKirimDokumSite.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IConfiguration _config;
        public AppointmentController(IConfiguration config) => _config = config;

        [HttpPost]
        public IActionResult Create(AppointmentRequest req)
        {
            if(!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Formu kontrol edin. Zorunlu alanlar eksik.";
                return Redirect(Request.Headers["Referer"].ToString());
            }

            var dir = Path.Combine(Directory.GetCurrentDirectory(), "App_Data");
            Directory.CreateDirectory(dir);
            var stamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var path = Path.Combine(dir, $"appointment_{stamp}.txt");

            string? savedFile = null;
            var file = Request.Form.Files.FirstOrDefault();
            if (file != null && file.Length > 0)
            {
                var uploads = Path.Combine(dir, "uploads");
                Directory.CreateDirectory(uploads);
                var safeName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(uploads, $"{stamp}_{safeName}");
                using (var fs = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fs);
                }
                savedFile = filePath;
            }

            // Save to text for backup
            System.IO.File.WriteAllText(path, $@"Ad: {req.Name}
Telefon: {req.Phone}
E-Posta: {req.Email}
İl/İlçe: {req.City} / {req.District}
Adres: {req.Address}
Hizmet: {req.Service}
İstenen Tarih: {req.DesiredDate}
Bütçe: {req.Budget}
Alan (m²): {req.ProjectArea}
Kat Adedi: {req.Floors}
Açıklama: {req.Message}
Ek Dosya: {savedFile}
Tarih: {DateTime.Now}");

            // Send Email
            try
            {
                var smtpHost = _config["Smtp:Host"] ?? "smtp.gmail.com";
                var smtpPort = int.TryParse(_config["Smtp:Port"], out var p) ? p : 587;
                var enableSsl = bool.TryParse(_config["Smtp:EnableSsl"], out var ssl) ? ssl : true;
                var from = _config["Smtp:From"] ?? "no-reply@example.com";
                var to = _config["Smtp:To"] ?? from;
                var user = _config["Smtp:User"] ?? "";
                var pass = _config["Smtp:Password"] ?? "";

                var body = new StringBuilder()
                    .AppendLine("<h2>Yeni Keşif/İletişim Talebi</h2>")
                    .AppendLine("<table style='border-collapse:collapse'>")
                    .AppendLine($"<tr><td><b>Ad Soyad</b></td><td>{WebUtility.HtmlEncode(req.Name)}</td></tr>")
                    .AppendLine($"<tr><td><b>Telefon</b></td><td><a href='tel:{WebUtility.HtmlEncode(req.Phone)}'>{WebUtility.HtmlEncode(req.Phone)}</a></td></tr>")
                    .AppendLine($"<tr><td><b>E-Posta</b></td><td>{WebUtility.HtmlEncode(req.Email ?? "")}</td></tr>")
                    .AppendLine($"<tr><td><b>İl / İlçe</b></td><td>{WebUtility.HtmlEncode(req.City ?? "")} / {WebUtility.HtmlEncode(req.District ?? "")}</td></tr>")
                    .AppendLine($"<tr><td><b>Adres</b></td><td>{WebUtility.HtmlEncode(req.Address)}</td></tr>")
                    .AppendLine($"<tr><td><b>Hizmet</b></td><td>{WebUtility.HtmlEncode(req.Service)}</td></tr>")
                    .AppendLine($"<tr><td><b>İstenen Tarih</b></td><td>{WebUtility.HtmlEncode(req.DesiredDate ?? "")}</td></tr>")
                    .AppendLine($"<tr><td><b>Bütçe</b></td><td>{WebUtility.HtmlEncode(req.Budget ?? "")}</td></tr>")
                    .AppendLine($"<tr><td><b>Alan (m²)</b></td><td>{WebUtility.HtmlEncode(req.ProjectArea ?? "")}</td></tr>")
                    .AppendLine($"<tr><td><b>Kat Adedi</b></td><td>{WebUtility.HtmlEncode(req.Floors ?? "")}</td></tr>")
                    .AppendLine($"<tr><td><b>Mesaj</b></td><td>{WebUtility.HtmlEncode(req.Message ?? "")}</td></tr>")
                    .AppendLine($"<tr><td><b>Ek Dosya</b></td><td>{(savedFile != null ? "Kaydedildi" : "Yok")}</td></tr>")
                    .AppendLine($"<tr><td><b>Tarih</b></td><td>{DateTime.Now}</td></tr>")
                    .AppendLine("</table>")
                    .ToString();

                using var msg = new MailMessage();
                msg.From = new MailAddress(from, "Sel Kırım Döküm");
                msg.To.Add(new MailAddress(to));
                msg.Subject = "Yeni Keşif Talebi";
                msg.Body = body;
                msg.IsBodyHtml = true;

                // FIXED: attach uploaded file using OpenReadStream -> MemoryStream
                if (file != null && file.Length > 0)
                {
                    var mem = new MemoryStream();
                    using (var s = file.OpenReadStream())
                    {
                        s.CopyTo(mem);
                    }
                    mem.Position = 0;
                    msg.Attachments.Add(new Attachment(mem, file.FileName, file.ContentType ?? "application/octet-stream"));
                }

                using var client = new SmtpClient(smtpHost, smtpPort);
                client.EnableSsl = enableSsl;
                client.Credentials = new NetworkCredential(user, pass);
                client.Send(msg);
            }
            catch (Exception ex)
            {
                var log = Path.Combine(Directory.GetCurrentDirectory(), "App_Data", "mail_errors.log");
                System.IO.File.AppendAllText(log, $"[{DateTime.Now}] {ex}\\n");
                TempData["ErrorMessage"] = "Talebiniz alındı ancak e-posta gönderiminde hata oluştu. Size geri dönüş yapacağız.";
                return Redirect(Request.Headers["Referer"].ToString());
            }

            TempData["SuccessMessage"] = "Talebiniz alındı. Ekip en kısa sürede sizinle iletişime geçecek.";
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}