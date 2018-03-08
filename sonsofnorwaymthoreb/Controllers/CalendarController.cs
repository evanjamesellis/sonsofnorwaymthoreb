using Microsoft.AspNetCore.Mvc;
using sonsofnorwaymthoreb.Services.Calendar;
using sonsofnorwaymthoreb.ViewModels.Calendar;

namespace sonsofnorwaymthoreb.Controllers
{
    public class CalendarController : Controller
    {
        private ICalendarData _calendarData;

        public CalendarController(
            ICalendarData calendarData)
        {
            _calendarData = calendarData;
        }

        public IActionResult Index() {
            var model = new CalendarViewModel();

            model.CalendarEvents = _calendarData.GetAll();

            return View(model);
        }
    }
}
