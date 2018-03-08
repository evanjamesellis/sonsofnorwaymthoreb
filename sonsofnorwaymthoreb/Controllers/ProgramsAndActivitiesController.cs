using Microsoft.AspNetCore.Mvc;

namespace sonsofnorwaymthoreb.Controllers
{
    public class ProgramsAndActivitiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
