using sonsofnorwaymthoreb.Models.Home;

namespace sonsofnorwaymthoreb.Services.Home
{
    public class InMemoryHomePageEvent : IHomePageEventData
    {
        public HomePageEvent _homePageEvent;

        public InMemoryHomePageEvent() {
            _homePageEvent = new HomePageEvent
            {
                Title = "Member Meeting",
                Date = "February 18, 2018 at 2 PM",
                Description =
                    "Our upcoming meeting will be held on Sunday afternoon, February 18, 2018, beginning at 2 PM." +
                    " I encourage all of you to join in the fun by participating in the chili cook-off and/or the cookie contest." +
                    " It is brought to you by District 5 Sports and Recreation Director, Michaela Decker." +
                    " Her lodge has participated in this fun activity for many years." +
                    " Little ones can help with preparing the hamburger or other stew meat, grating cheese, or by cutting vegetables (with supervision, of course)." +
                    " Adding garnishes is an easy thing for them to do. A taste taster will sample the entries and a “winner” will walk home with our traveling trophy." +
                    " Baking cookies with youngsters is a lot of fun, too, and many children enjoy the decorating process!" +
                    " Pamela Barnes will judge the cookie entries, determining who will walk home with the “tastiest cookie honor”." +
                    " There are no separate categories for the cookies, simply choose your favorite and bring it in to the meeting." +
                    " Some cookies will be saved for our luncheon that day, and extra cookies will be sent on to the American Birkebeiner in Hayward, WI, where they will be enjoyed by young and old alike." +
                    " Due to a concern over allergies, I ask that the cookies be free of nutmeats." +
                    " Pictures will be taken of both contest winners, and they will be submitted to the District 5 webmaster for posting. Lykke til!" +
                    " Please bring the recipes for the chili and the cookies written on recipe cards." +
                    " The winning recipes will be published in an upcoming edition of the Vennelag News." +
                    " While the judging is taking place, Cultural Director Tiffany Schwoerer and Social Director Allen Watrud have prepared the Viking Olympics for all to enjoy." +
                    " These activities will provide quality time for our members to interact with one another and to build strong lodge relationships." +
                    " Youngsters are encouraged to attend this meeting." +
                    " Usually, they can teach us a thing or two! I look forward to seeing your family on February 18th."
            };
        }

        public HomePageEvent Get()
        {
            return _homePageEvent;
        }

        public HomePageEvent Update(HomePageEvent homePageEvent)
        {
            _homePageEvent = homePageEvent;

            return _homePageEvent;
        }
    }
}