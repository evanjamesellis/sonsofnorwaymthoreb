using Microsoft.AspNetCore.Mvc;
using sonsofnorwaymthoreb.Services.Home;
using sonsofnorwaymthoreb.ViewModels.Home;

namespace sonsofnorwaymthoreb.Controllers
{
    public class HomeController : Controller
    {
        private IHomePageEventData _homePageEventData;

        public HomeController(IHomePageEventData homePageEventData)
        {
            _homePageEventData = homePageEventData;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();

            model.HomePageEvent = _homePageEventData.Get();

            return View(model);
        }
    }
}
