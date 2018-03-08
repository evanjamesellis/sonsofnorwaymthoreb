using System;
using System.Collections.Generic;
using System.Linq;
using sonsofnorwaymthoreb.Models.Calendar;

namespace sonsofnorwaymthoreb.Services.Calendar
{
    public class InMemoryCalendarEvents : ICalendarData
    {
        public List<CalendarEvent> _calendarEvents;

        public InMemoryCalendarEvents()
        {
            _calendarEvents = new List<CalendarEvent> {
				new CalendarEvent() {
					Id = 0,
                    Title = null,
					Date = "Sunday, January 21, 2018",
					Description = "At 12 Noon we begin with a movie 'The King's Choice'. Approximately 2 PM a business meeting and installation of 2018-2019 officers will be held. Mt. Horeb Community Center.",
					Url = null
				},
                new CalendarEvent() {
                    Id = 1,
                    Title = "Jultrefest (Norwegian-themed Christmas Party) Mt. Horeb Community Center",
                    Date = "Saturday, December 2, 2017",
                    Description = "A social time starts at 5:30 PM with appetizers and punch. A potluck meal to begin about 6:00 PM. Reservations may be made with Tiffany Schwoerer.",
                    Url = null
                },
                new CalendarEvent() {
                    Id = 2,
                    Title = "Høst Frokost (Fall Breakfast) Mt. Horeb Community Center",
                    Date = "Saturday, October 7, 2017",
                    Description = "Old Style fall breakfast, featuring tradional breakfast fare, Norwegian specialties and more! Serving from 7:30 AM - 11 AM. 107 N. Grove Street, Mt. Horeb, WI",
                    Url = null
                },
                new CalendarEvent() {
                    Id = 3,
                    Title = "Brats in the Lot Fundraiser and Bake Sale. Serving 10 AM - 1 PM.",
                    Date = "Saturday, August 19, 2017",
                    Description = "Millers Supermarket, 1845 Springdale Street, Mt. Horeb, WI. Grab a quick lunch and a Norwegian treat for the road! Monies further community projects and scholarships.",
                    Url = null
                },
                new CalendarEvent() {
                    Id = 4,
                    Title = "Summer Kaffe Stue-Coffee-Lunch Room, Bake Sale and Art Fair. Mt. Horeb Community Center",
                    Date = "Saturday, July 15, 2017",
                    Description = "Coffee and sweets available at 9 AM, Serving Norsk sandwiches and delicacies from 10:30 AM - 2 PM. Join specialized vendors in the downtown area for a great art fair with unique and useful items, 9 AM - 4 PM.",
                    Url = null
                },
                new CalendarEvent {
                    Id = 5,
                    Title = "Donald Park, Pop's Knoll. Located on State Highway 92 south of Mount Horeb.",
                    Date = "Thursday, June 22, 2017",
                    Description = "For the first time ever, Vennelag will be holding a lodge meeting in June. We will be meeting at Donald Park, Pop’s Knoll, at Delma’s Shelter, on Thursday evening, June 22nd. A rain date for the event is June 29th. We will be celebrating Midsommer. Plans are for music, possible dancing, a picnic meal, walks of the park, and viewing of the night skies, if the weather is cooperative. Mark your calendar for another fun family event!",
                    Url = null
                },
                new CalendarEvent {
                    Id = 6,
                    Title = "Mount Horeb Community Center - 6:30 PM",
                    Date = "Thursday, May 25, 2017",
                    Description = "A Potluck Dinner and Grand Syttende Mai Celebration it will be on May 25th, as Emeritus Professor of Folklore and Scandinavian Studies, James P. Leary presents, 'The Evolution of the Folk Music Tradition', as practiced in the early 20th Century in Wisconsin homes of Norwegian Americans. Jim is the co-founder of the Center for the Study of Upper Midwestern Cultures, at UW-Madison. Carolyn Johnson will present membership awards. We will begin the meeting with one of our outstanding potluck meals. In the Norwegian tradition of Syttende Mai, please wear a bunad or other festive wear. Please extend a hearty velkommen to someone you know!",
                    Url = null
                },
                new CalendarEvent {
                    Id = 7,
                    Title = "Mount Horeb Community Center - 6:30 PM",
                    Date = "Thursday, April 20, 2017",
                    Description = "April, a time to think about summer camp! Eric Dregni will be making a return engagement to our Lodge meeting on April 20th. His presentation this year is entitled, 'You’re Sending Me Where?' A synopsis can be found at the link below.",
                    Url = "https://www.upress.umn.edu/book-division/books/youare-sending-me-where"
                },
                new CalendarEvent {
                    Id = 8,
                    Title = null,
                    Date = "Sunday, March 19, 2017",
                    Description = "Family Lodge Meeting at Mount Horeb Community Center, March 19, 2017 - 2:00 PM. Our presenter for March will be Ingunn Linnerud, Mt. Horeb’s exchange student from Roa, Hadeland, Norway. She will compare schooling in her hometown to that of Mt.Horeb. Following Ingunn’s presentation, everyone is invited to play several rounds of 'Ingenting', a dice game very similar to BUNCO. Prizes will be awarded to the individual(s) with the lowest score and the highest score. One lucky prize will also be awarded. The purpose of the game is to provide lodge members and visitors an opportunity to get to know the many new people who have joined our midst over the course of the last year. This game is also perfect for our youth-please bring your youngsters to this event!",
                    Url = null
                },
                new CalendarEvent {
                    Id = 9,
                    Title = null,
                    Date = "Sunday, February 19, 2017",
                    Description = "Lodge Meeting at Mount Horeb Community Center, Sunday, February 19, 2017 - 2:00 PM. Local author Matt Geiger will share details from his book, 'The Geiger Counter'. A light meal will follow the program.",
                    Url = null
                }
            };
        }

        public IEnumerable<CalendarEvent> GetAll()
        {
            return _calendarEvents.OrderBy(c => c.Id);
        }

        public CalendarEvent Get(int id)
        {
            return _calendarEvents.FirstOrDefault(c => c.Id == id);
        }

        public CalendarEvent Add(CalendarEvent calendarEvent)
        {
            calendarEvent.Id = _calendarEvents.Max(c => c.Id) + 1;
            _calendarEvents.Add(calendarEvent);

            return calendarEvent;
        }

        public CalendarEvent Update(CalendarEvent CalendarEvent)
        {
            throw new NotImplementedException();
        }
    }
}
