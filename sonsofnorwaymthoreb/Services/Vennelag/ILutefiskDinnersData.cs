using System.Collections.Generic;
using sonsofnorwaymthoreb.Models.Vennelag;

namespace sonsofnorwaymthoreb.Services
{
    public interface ILutefiskDinnersData
    {
        IEnumerable<LutefiskDinner> GetAll();
        LutefiskDinner Get(int id);
        LutefiskDinner Add(LutefiskDinner lutefiskDinner);
        LutefiskDinner Update(LutefiskDinner lutefiskDinner);
    }
}