using System.Collections.Generic;
using sonsofnorwaymthoreb.Models.Vennelag;

namespace sonsofnorwaymthoreb.Services
{
    public interface IProgramsAndActivitiesData
    {
        IEnumerable<ProgramOrActivity> GetAll();
        ProgramOrActivity Get(int id);
        ProgramOrActivity Add(ProgramOrActivity programOrActivity);
        ProgramOrActivity Update(ProgramOrActivity programOrActivity);
    }
}