using Microsoft.AspNetCore.Mvc;
using sonsofnorwaymthoreb.Services;
using sonsofnorwaymthoreb.Services.Vennelag;
using sonsofnorwaymthoreb.ViewModels.Vennelag;

namespace sonsofnorwaymthoreb.Controllers
{
    public class VennelagController : Controller
    {
        private IProgramsAndActivitiesData _programsAndActivitiesData;
        private ILutefiskDinnersData _lutefiskDinnersData;
        private INewsletterData _newsletterData;

        public VennelagController(
            IProgramsAndActivitiesData programsAndActivitiesData,
            ILutefiskDinnersData lutefiskDinnersData,
            INewsletterData newsletterData)
        {
            _programsAndActivitiesData = programsAndActivitiesData;
            _lutefiskDinnersData = lutefiskDinnersData;
            _newsletterData = newsletterData;
        }

        public IActionResult Index()
        {
            var model = new VennelagViewModel();

            model.ProgramsAndActivities = _programsAndActivitiesData.GetAll();
            model.LutefiskDinners = _lutefiskDinnersData.GetAll();
            model.Newsletters = _newsletterData.GetAll();

            return View(model);
        }
    }
}
