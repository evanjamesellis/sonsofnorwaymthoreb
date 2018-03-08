using System.Collections.Generic;
using sonsofnorwaymthoreb.Models.Calendar;

namespace sonsofnorwaymthoreb.ViewModels.Calendar
{
    public class CalendarViewModel
    {
        public IEnumerable<CalendarEvent> CalendarEvents { get; set; }
    }
}
