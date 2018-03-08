using Microsoft.AspNetCore.Mvc;

namespace sonsofnorwaymthoreb.Controllers
{
    public class ScholarshipController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
