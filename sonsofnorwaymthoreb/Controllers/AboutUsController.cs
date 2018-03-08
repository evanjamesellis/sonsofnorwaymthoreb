using Microsoft.AspNetCore.Mvc;

namespace sonsofnorwaymthoreb.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
