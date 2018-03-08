using System.Collections.Generic;
using sonsofnorwaymthoreb.Models.Vennelag;

namespace sonsofnorwaymthoreb.Services.Vennelag
{
    public interface INewsletterData
    {
        IEnumerable<Newsletter> GetAll();
        Newsletter Get(int id);
        Newsletter Add(Newsletter newsletter);
        Newsletter Update(Newsletter newsletter);
    }
}