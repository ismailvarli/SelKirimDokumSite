using Microsoft.AspNetCore.Mvc;

namespace SelKirimDokumSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Contact() => View();
    }
}