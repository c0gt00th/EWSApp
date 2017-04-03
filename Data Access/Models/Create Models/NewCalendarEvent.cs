using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Models.Create_Models
{
    public class NewCalendarEvent
    {
        private NewCalendarEventType _type;
        private string _subject;
        private string _body;
        private DateTime _start;
        private DateTime _end;
        private string _where;
        private string _requiredAttendees;
        private string _optionalAttendees;
        private bool _isAllDayEvent;

        public NewCalendarEvent(NewCalendarEventType type)
        {
            _type = type;
        }

        public void SetSimpleData(string subject, string body, string where)
        {
            _subject = subject;
            _body = body;
            _where = where;
        }

        public void SetAllDayDate(DateTime date)
        {
            _start = date.Date;
            _isAllDayEvent = true;
        }
    }

    public enum NewCalendarEventType
    {
        Appointment,
        Meeting
    }
}
