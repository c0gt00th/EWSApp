using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;

namespace Data_Access.Models.View_Models.Calendar
{
    public class Calendar
    {
        private CalendarView _currentView;
        private CalendarFolder _calendarFolder;

        public List<ExistingCalendarEvent> Events { get; set; }

        public Calendar(ExchangeService instance, DateTime start, DateTime end)
        {
            _currentView = new CalendarView(start, end);
            _calendarFolder = CalendarFolder.Bind(instance, WellKnownFolderName.Calendar);

            Events = new List<ExistingCalendarEvent>();

            var events = _calendarFolder.FindAppointments(_currentView);
            var meetings = new List<Appointment>();
            var appointments = new List<Appointment>();

            var propertySet = new PropertySet(BasePropertySet.FirstClassProperties);
            propertySet.RequestedBodyType = BodyType.Text;

            foreach (var item in events)
            {
                item.Load(propertySet);
                Events.Add(new ExistingCalendarEvent(item));
            }
        }
    }

    public enum CalendarEventType
    {
        Appointment,
        Meeting
    }
}
