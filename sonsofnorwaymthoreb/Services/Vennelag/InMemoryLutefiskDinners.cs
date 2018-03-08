using System;
using System.Collections.Generic;
using System.Linq;
using sonsofnorwaymthoreb.Models.Vennelag;

namespace sonsofnorwaymthoreb.Services
{
    public class InMemoryLutefiskDinners : ILutefiskDinnersData
    {
        public List<LutefiskDinner> _lutefiskDinners;

        public InMemoryLutefiskDinners() {
            _lutefiskDinners = new List<LutefiskDinner>
            {
                new LutefiskDinner {
                    Id = 0,
                    Date = "Saturday, October 21 2017",
                    Description = "Vermont Lutheran Church, 9886 Vermont Church Road, Black Earth, WI (Ph. 608-767-3312 or vermont_church@tds.net). Serving 11:00 AM - 6:20 PM. Reservations needed at $18 a plate."
                },
                new LutefiskDinner {
                    Id = 1,
                    Date = "Saturday, October 21 2017",
                    Description = "Northland Lutheran Church, N9880 State Rd. 49, Iola, WI (Ph. 715-445-2956). 100th annual lutefisk supper, bake, and craft sale. Adults $14, ages 6-12 $4, and ages 5 and under free."
                },
                new LutefiskDinner {
                    Id = 2,
                    Date = "Saturday, October 28 2017",
                    Description = "Orfordville Lutheran Church, 210 N. Main Street, Orfordville, WI (Ph. 608-879-2575 or office@orfordvillelutheranchurch.org). Pricing and serving times not available."
                },
                new LutefiskDinner {
                    Id = 3,
                    Date = "Saturday, October 28 2017",
                    Description = "Five Points Lutheran Church, 25744 Five Points Drive, Blue River, WI (Ph. 608-536-3877 or fivepointslutheranchurch@gmail.com). Serving at 11:00 AM, 2:00 PM, 3:00 PM, and 6:00 PM. Adults $15, children ages 7-12 $6, and ages 6 and under free."
                },
                new LutefiskDinner {
                    Id = 4,
                    Date = "Saturday, November 4 2017",
                    Description = "Barneveld Lutheran Church, 505 Swiss Lane, Barneveld, WI (Ph. 608-924-8621). Adults $18, childres 12 and under $7. Serving from 11:00 AM to 4:00 PM. Walk-ins welcome after 2:00 PM. Save $1.00 when you prepay your tickets!"
                },
                new LutefiskDinner {
                    Id = 5,
                    Date = "Saturday, November 4 2017",
                    Description = "Bonnet Prairie Lutheran Church, N3694 Old F Road, Rio, WI (Ph. 920-992-3200)."
                },
                new LutefiskDinner {
                    Id = 6,
                    Date = "Saturday, November 11 2017",
                    Description = "Christ Lutheran Church, 220 S. Main St., DeForest, WI (Ph. 608-846-4718 or office@christlutherandeforest.org). Adults $18, ages 4-12 $9, ages 3 and under free. Serving 11:00 AM - 5:00 PM. Reservations or walk-ins."
                },
                new LutefiskDinner {
                    Id = 7,
                    Date = "Saturday, December 2 2017",
                    Description = "Christ Lutheran Church, 700 County Road B, Stoughton, WI (Ph. 608-873-9353)."
                }
            };
        }

        public IEnumerable<LutefiskDinner> GetAll()
        {
            return _lutefiskDinners.OrderBy(l => l.Id);
        }

        public LutefiskDinner Get(int id)
        {
            return _lutefiskDinners.FirstOrDefault(l => l.Id == id);
        }

        public LutefiskDinner Add(LutefiskDinner lutefiskDinner)
        {
            lutefiskDinner.Id = _lutefiskDinners.Max(l => l.Id) + 1;
            _lutefiskDinners.Add(lutefiskDinner);

            return lutefiskDinner;
        }

        public LutefiskDinner Update(LutefiskDinner lutefiskDinner)
        {
            throw new NotImplementedException();
        }
    }
}