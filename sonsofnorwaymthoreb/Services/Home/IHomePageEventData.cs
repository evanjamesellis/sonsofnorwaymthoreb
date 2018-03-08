using sonsofnorwaymthoreb.Models.Home;

namespace sonsofnorwaymthoreb.Services.Home
{
    public interface IHomePageEventData
    {
        HomePageEvent Get();
        HomePageEvent Update(HomePageEvent homePageEvent);
    }
}