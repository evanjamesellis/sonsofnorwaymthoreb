using System;
using System.Collections.Generic;
using System.Linq;
using sonsofnorwaymthoreb.Models.Vennelag;

namespace sonsofnorwaymthoreb.Services
{
    public class InMemoryProgramsAndActivities : IProgramsAndActivitiesData
    {
        public List<ProgramOrActivity> _programsAndActivities;

        public InMemoryProgramsAndActivities()
        {
            _programsAndActivities = new List<ProgramOrActivity> {
                new ProgramOrActivity {
                    Id = 0,
                    Name = "Monthly Meeting",
                    Description = "We begin with a short business session to bring members up to date.",
                    Url = null
                },
                new ProgramOrActivity {
                    Id = 1,
                    Name = "Cultural Skills and Sports Medal Programs",
                    Description = "Learn wood carving techniques, resemal designs, Hardanger patterns, folk dancing and how to prepare traditional Norwegian foods are just a few of the 14 cultural skills available. Sports medals can be earned by active participation in walking, biking, swimming, skiing or general fitness.",
                    Url = null
                },
                new ProgramOrActivity {
                    Id = 2,
                    Name = "Kaffee Stue",
                    Description = "A traditional Norwegian foods luncheon is served on the third Saturday in July, in conjunction with Mount Horeb's Annual Art Fair. The public is invited to sample foods such as lefse, sotsuppe, smørbrod, rømmegrøt and Norsk pastries.",
                    Url = null
                },
                new ProgramOrActivity {
                    Id =3,
                    Name = "Høst Frokost",
                    Description = "Norwegian fall breakfast is held at the Mount Horeb Community Center and is open to the public. The event, held in conjunction with the Mount Horeb Fall Festival on the first Saturday in October, gives the opportunity to experience a traditional Norwegian breakfast. The menu can consist of such items as Norwegian pancakes, heart waffles with lingonberries, æbleskiver, soft or hard boiled eggs, rullepølse, lefse, breads, herring, smoked salmon, cold meats (ham, dried beef, salami), fruit salad, Norwegian pastries and plenty of coffee.",
                    Url = null
                },
                new ProgramOrActivity {
                    Id = 4,
                    Name = "Baking Workshop",
                    Description = "The first Saturday of November lodge members volunteer to demonstrate and allow registered students hands-on experience in maing selected traditional foods.",
                    Url = null
                },
                new ProgramOrActivity {
                    Id = 5,
                    Name = "Jultrefest",
                    Description = "A 'Christmas Tree Party' is held on the first Saturday in December. A potluck meal for the entire family with many Norwegian foods begins at about 6:00 PM followed by entertainment, dacing around the tree, and watch for a visit by Santa!",
                    Url = null
                },
                new ProgramOrActivity {
                    Id = 6,
                    Name = "Lefse Sale",
                    Description = "Lodge members gather to make lefse using a real potato recipe. Sales to other lodge members and the public is usually in December in time for holiday events.",
                    Url = null
                },
                new ProgramOrActivity {
                    Id = 7,
                    Name = "Youth Heritage Camp Funding",
                    Description = "Vennelag Lodge will provide tuition assistance to youth (ages 9-15) to attend the two-week summer camp conducted by Sons of Norway District Five.",
                    Url = "http://www.massemoro.org/"
                }
            };
        }

        public IEnumerable<ProgramOrActivity> GetAll() {
            return _programsAndActivities.OrderBy(p => p.Id);
        }

        public ProgramOrActivity Get(int id) {
            return _programsAndActivities.FirstOrDefault(p => p.Id == id);
        }

        public ProgramOrActivity Add(ProgramOrActivity programOrActivity) {
            programOrActivity.Id = _programsAndActivities.Max(p => p.Id) + 1;
            _programsAndActivities.Add(programOrActivity);

            return programOrActivity;
        }

        public ProgramOrActivity Update(ProgramOrActivity programOrActivity) {
            throw new NotImplementedException();
        }
    }
}