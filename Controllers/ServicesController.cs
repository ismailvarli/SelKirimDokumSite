using Microsoft.AspNetCore.Mvc;

namespace SelKirimDokumSite.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult BinaYikimi() => View();
        public IActionResult FabrikaSokum() => View();
        public IActionResult Krim() => View(); // Beton/duvar/şap kırım
        public IActionResult HafriyatMoloz() => View();
        public IActionResult BetonKesmeDelme() => View();
        public IActionResult AsbestSokumu() => View();
        public IActionResult ellekirim() => View();
        public IActionResult mutfakkirim() => View();
        public IActionResult fayanskirim() => View();
        public IActionResult hiltikirim() => View();
        public IActionResult kompresorlukirim() => View();
    }
}