using System.Collections.Generic;
using sonsofnorwaymthoreb.Models.Calendar;

namespace sonsofnorwaymthoreb.Services.Calendar
{
    public interface ICalendarData
    {
        IEnumerable<CalendarEvent> GetAll();
        CalendarEvent Get(int id);
        CalendarEvent Add(CalendarEvent calendarEvent);
        CalendarEvent Update(CalendarEvent calendarEvent);
    }
}
