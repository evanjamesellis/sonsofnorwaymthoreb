using Microsoft.AspNetCore.Mvc;

namespace sonsofnorwaymthoreb.Controllers
{
    public class AppExceptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
