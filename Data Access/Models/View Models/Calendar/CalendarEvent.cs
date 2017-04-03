using Microsoft.Exchange.WebServices.Data;
using System;

namespace Data_Access.Models.View_Models.Calendar
{
    public class ExistingCalendarEvent
    {
        private DateTime _start;
        private DateTime _end;

        public string Subject { get; set; }
        public string Body { get; set; }
        public string When { get; set; }
        public string Where { get; set; }
        public bool IsAllDay { get; set; }
        public CalendarEventType Type { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }

        public ExistingCalendarEvent(Appointment appointment)
        {
            _start = appointment.Start;
            _end = appointment.End;

            Subject = appointment.Subject;
            Body = appointment.Body;
            Where = appointment.Location;
            IsAllDay = appointment.IsAllDayEvent;

            if (IsAllDay)
            {
                When = $"{_start.Date} - All Day Event";
            }

            else
            {
                When = $"{_start.Date}: {_start.TimeOfDay} - {_end.TimeOfDay}";
            }

            if (appointment.OptionalAttendees.Count > 0 || appointment.RequiredAttendees.Count > 1)
            {
                Type = CalendarEventType.Meeting;
                var formattedRequired = string.Join(",\n\t", appointment.RequiredAttendees);
                RequiredAttendees = string.IsNullOrEmpty(formattedRequired) ? "None" : formattedRequired;
                var formattedOptional = string.Join(",\n\t", appointment.OptionalAttendees);
                OptionalAttendees = string.IsNullOrEmpty(formattedOptional) ? "None" : formattedOptional;
            }

            else
            {
                Type = CalendarEventType.Appointment;
            }
        }
    }
}
