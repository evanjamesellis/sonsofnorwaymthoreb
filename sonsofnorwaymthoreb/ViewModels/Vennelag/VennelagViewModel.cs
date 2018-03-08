using System.Collections.Generic;
using sonsofnorwaymthoreb.Models.Vennelag;

namespace sonsofnorwaymthoreb.ViewModels.Vennelag
{
    public class VennelagViewModel
    {
        public IEnumerable<LutefiskDinner> LutefiskDinners { get; set; }
        public IEnumerable<ProgramOrActivity> ProgramsAndActivities { get; set; }
        public IEnumerable<Newsletter> Newsletters { get; set; }
    }
}