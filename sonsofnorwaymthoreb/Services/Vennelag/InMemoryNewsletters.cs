using System;
using System.Collections.Generic;
using System.Linq;
using sonsofnorwaymthoreb.Models.Vennelag;

namespace sonsofnorwaymthoreb.Services.Vennelag
{
    public class InMemoryNewsletters : INewsletterData
    {
        public List<Newsletter> _newsletters;

        public InMemoryNewsletters()
        {
            _newsletters = new List<Newsletter> {
                new Newsletter {
                    Id = 0,
                    Title = "Vennelag November 2017",
                    Date = "October 31, 2017",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/Vennelag201711-12newsletter.compressed.pdf"
                },
                new Newsletter {
                    Id = 1,
                    Title = "Vennelag September 2017",
                    Date = "September 5, 2017",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/VennelagNewsletterSeptember2017.compressed.pdf"
                },
                new Newsletter {
                    Id = 2,
                    Title = "Vennelag July - August 2017",
                    Date = "June 28, 2017",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/VennelagNewsletterJUly-August2017.pdf"
                },
                new Newsletter {
                    Id = 3,
                    Title = "Vennelag May - June 2017",
                    Date = "April 27, 2017",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/2017MayJune.compressed.pdf"
                },
                new Newsletter {
                    Id = 4,
                    Title = "Vennelag March - April 2017",
                    Date = "March 6, 2017",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/VennelagMarch-April2017.compressed.pdf"
                },
                new Newsletter {
                    Id = 5,
                    Title = "Vennelag January - February 2017",
                    Date = "January 3, 2017",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/VennelagNewsletterJanuary2017.compressed.pdf"
                },
                new Newsletter {
                    Id = 6,
                    Title = "Vennelag November - December 2016",
                    Date = "October 31, 2016",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/vennelag2016novdecnewsletter.compressed1.pdf"
                },
                new Newsletter {
                    Id = 7,
                    Title = "Vennelag September 2016",
                    Date = "August 29, 2016",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/Vennelagsepoct2016newsletteronline.compressed.pdf"
                },
                new Newsletter {
                    Id = 8,
                    Title = "Vennelag July - August 2016",
                    Date = "July 8, 2016",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/201607-08newsletter.compressed.pdf"
                },
                new Newsletter {
                    Id = 9,
                    Title = "Vennelag 513 May - June 2016",
                    Date = "May 6, 2016",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/2016%2005-06%20newsletter.compressed.pdf"
                },
                new Newsletter {
                    Id = 10,
                    Title = "Vennelag 513 March - April 2016",
                    Date = "March 1, 2016",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/vennelag2016%2003-04%20newsletter.compressed.pdf"
                },
                new Newsletter {
                    Id = 11,
                    Title = "Vennelag 513 January - February 2016",
                    Date = "January 5, 2016",
                    Url = "http://sonsofnorway5.com/library/lodge_newsletters/2016%20Jan%20Feb%20newsletter%20online%20version.compressed.pdf"
                }
            };
        }

        public IEnumerable<Newsletter> GetAll()
        {
            return _newsletters.OrderBy(n => n.Id);
        }

        public Newsletter Get(int id)
        {
            return _newsletters.FirstOrDefault(n => n.Id == id);
        }

        public Newsletter Add(Newsletter newsletter)
        {
            newsletter.Id = _newsletters.Max(n => n.Id) + 1;
            _newsletters.Add(newsletter);

            return newsletter;
        }

        public Newsletter Update(Newsletter newsletter)
        {
            throw new NotImplementedException();
        }
    }
}