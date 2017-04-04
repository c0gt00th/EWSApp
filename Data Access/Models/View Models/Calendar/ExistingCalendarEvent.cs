using Microsoft.Exchange.WebServices.Data;
using System;

namespace Data_Access.Models.View_Models.Calendar
{
    public class ExistingCalendarEvent
    {
        public string Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Where { get; set; }
        public bool IsAllDay { get; set; }
        public CalendarEventType Type { get; set; }
        public string RequiredAttendees { get; set; }
        public string OptionalAttendees { get; set; }

        public ExistingCalendarEvent(Appointment appointment)
        {
            Id = appointment.Id.ToString();
            Subject = appointment.Subject;
            Body = appointment.Body;
            Start = appointment.Start;
            End = appointment.End;
            Where = appointment.Location;
            IsAllDay = appointment.IsAllDayEvent;

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
