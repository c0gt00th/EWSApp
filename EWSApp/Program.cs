using Data_Access;
using Data_Access.Models.Create_Models;
using Data_Access.Models.View_Models.Calendar;
using Data_Access.Models.View_Models.Email;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace DevMessagingApp
{
    class Program
    {
        #region Helpful Links

        // https://msdn.microsoft.com/en-us/library/office/microsoft.exchange.webservices.data(v=exchg.80).aspx

        #endregion
        #region Credentials

        private static string _username;
        private static string _password;

        #endregion
        #region String Constants

        private static string _logInBanner = "==========================================\n\n\tPlease Log In to Continue\n\n==========================================\n";
        private static string _mainMenuBanner = "==========================================\n\n\tMain Menu\n\n==========================================\n";
        private static string _EWSMenuBanner = "==========================================\n\n\tExchange Web Service Menu\n\n==========================================\n";
        private static string _RESTMenuBanner = "==========================================\n\n\tREST API Menu\n==========================================\n";
        private static string _viewItemMenuBanner = "==========================================\n\n\tVIEW Item Menu\n\n==========================================\n";
        private static string _createItemMenuBanner = "==========================================\n\n\tCREATE Item Menu\n\n==========================================\n";
        private static string _newEmailBanner = "==========================================\n\n\tNew Email Message\n\n==========================================\n";
        private static string _newCalendarEventBanner = "==========================================\n\n\tNew Calendar Event\n\n==========================================\n";
        private static string _newAppointmentBanner = "==========================================\n\n\tCreate New Appointment\n\n==========================================\n";
        private static string _newMeetingBanner = "==========================================\n\n\tCreate New Meeting\n\n==========================================\n";
        private static string _appointmentsBanner = "==========================================\n\n\tAppointments\n\n==========================================\n";
        private static string _meetingBanner = "==========================================\n\n\tMeetings\n\n==========================================\n";
        private static string _horizontalRule = "----------------------------------------";

        #endregion

        static void Main(string[] args)
        {
            MainMenu();
        }

        #region General Helper Methods

        private static void MainMenu()
        {
            var createMenuItems = new List<string>()
            {
                "\t- Exchange Web Service/EWS (1)",
                "- REST API (2)",
                "- Exit Application (0)"
            };
            var menuString = string.Join("\n\t", createMenuItems);

            while (true)
            {
                GenerateMenu(_mainMenuBanner, menuString);
                var response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        EWSMenu();
                        continue;
                    case "2":
                        RESTMenu();
                        continue;
                    case "0":
                        Console.WriteLine("Exiting application..");
                        Thread.Sleep(1500);
                        return;
                    default:
                        Console.WriteLine("Invalid operation.  Please try again.");
                        continue;
                }
            }
        }

        private static void ReadStop()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void EWSMenu()
        {
            var instance = AuthenticateAndStartService();
            var createMenuItems = new List<string>()
            {
                "\t- View Items (1)",
                "- Create Items (2)",
                "- Main Menu (0)"
            };
            var menuString = string.Join("\n\t", createMenuItems);

            while (true)
            {
                GenerateMenu(_EWSMenuBanner, menuString);
                var response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        ViewMenu(instance);
                        continue;
                    case "2":
                        CreateMenu(instance);
                        continue;
                    case "0":
                        Console.WriteLine("Exiting application..");
                        Thread.Sleep(1500);
                        return;
                    default:
                        Console.WriteLine("Invalid operation.  Please try again.");
                        continue;
                }
            }
        }

        private async static void RESTMenu()
        {
            var ra = new RESTAccessor();            

            foreach (var email in await ra.RetrieveInbox())
            {
                Console.WriteLine(email);
            }
            ReadStop();
        }

        private static void GenerateMenu(string banner, string menuString)
        {
            Console.Clear();
            Console.WriteLine(banner);
            Console.WriteLine("Please make a selection: ");
            Console.WriteLine($"{menuString}\n");
            Console.Write("Selection: ");
        }

        #endregion

        #region EWS Methods

        #region Service Setup Methods

        private static EWSInstance AuthenticateAndStartService()
        {
            while (true)
            {
                Console.WriteLine(_logInBanner);
                try
                {
                    EnterCredentials();
                    return new EWSInstance(_username, _password);
                }

                catch
                {
                    Console.WriteLine("Establishment of the Exchange service failed.  Please try again..");
                    ReadStop();
                    continue;
                }
            }
        }

        private static void EnterCredentials()
        {
            Console.Write("Please enter your email address: ");
            _username = Console.ReadLine();
            Console.Write("Please enter your password: ");
            // http://stackoverflow.com/questions/3404421/password-masking-console-application
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    _password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _password.Length > 0)
                    {
                        _password = _password.Substring(0, (_password.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.Write("\n\nRetrieving data..");
        }

        #endregion

        #region View Operations

        private static void ViewMenu(EWSInstance instance)
        {
            var viewMenuItems = new List<string>()
            {
                "\t- Inbox (1)",
                "- Calendar (2)",
                "- Main Menu (0)"
            };
            var menuString = string.Join("\n\t", viewMenuItems);

            while (true)
            {
                GenerateMenu(_viewItemMenuBanner, menuString);
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ReadMail(instance);
                        return;
                    case "2":
                        ReadCalendarEvents(instance);
                        return;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("ERROR: Invalid Operation");
                        continue;
                }
            }
        }

        #region Mailbox View Methods

        private static void ReadMail(EWSInstance instance)
        {
            var inbox = new Inbox(instance.Service, _username);
            foreach (var msg in inbox.Messages)
            {
                OutputMessage(msg);
            }
        }

        private static void OutputMessage(MailMessage msg)
        {
            var localBody = msg.BodyText;

            Console.WriteLine($"{_horizontalRule}");
            Console.WriteLine($"From: {msg.Sender}");
            Console.WriteLine($"Subject: {msg.Subject}\n");
            Console.WriteLine($"Body: {Truncate(ref localBody, 100)}");
            Console.WriteLine($"{_horizontalRule}\n");
        }

        public static string Truncate(ref string str, int maxLength)
        {
            return str.Substring(0, Math.Min(str.Length, maxLength));
        }

        #endregion

        #region Calendar View Methods

        private static void ReadCalendarEvents(EWSInstance instance)
        {
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            while (true)
            {
                if (GetDateRange(ref startDate, ref endDate))
                {
                    break;
                }
            }

            var calendar = new Calendar(instance.Service, startDate, endDate);

            Console.WriteLine(_appointmentsBanner);
            var appointmentCollection = calendar.Events.Where(x => x.Type == CalendarEventType.Appointment);
            if (appointmentCollection.Count() == 0)
            {
                Console.WriteLine($"{_horizontalRule}");
                Console.WriteLine("\n\tNo Appointments Scheduled\n");
                Console.WriteLine($"{_horizontalRule}\n");
            }

            else
            {
                foreach (var item in calendar.Events.Where(x => x.Type == CalendarEventType.Appointment))
                {
                    OutputAppointment(item);
                }
            }
            

            Console.WriteLine(_meetingBanner);
            var meetingCollection = calendar.Events.Where(x => x.Type == CalendarEventType.Meeting);
            if (meetingCollection.Count() == 0)
            {
                Console.WriteLine($"{_horizontalRule}");
                Console.WriteLine("\n\tNo Meetings Scheduled\n");
                Console.WriteLine($"{_horizontalRule}\n");
            }

            else
            {
                foreach (var item in meetingCollection)
                {
                    OutputMeeting(item);
                }
            }
        }

        private static bool GetDateRange(ref DateTime startDate, ref DateTime endDate)
        {
            Console.Write("Please enter start date (DD/MM/YYYY): ");
            var startSuccess = DateTime.TryParse(Console.ReadLine(), out startDate);
            Console.Write("Please enter end date (DD/MM/YYYY): ");
            var endSuccess = DateTime.TryParse(Console.ReadLine(), out endDate);

            if (!startSuccess || !endSuccess)
            {
                Console.WriteLine("\nInvalid dates provided, please try again..");
                Console.Clear();
                return false;
            }

            if (endDate.Year - startDate.Year > 1)
            {
                Console.WriteLine("\nPlease put in a range less than one year.");
                Console.Clear();
                return false;
            }

            return true;
        }

        private static void OutputAppointment(ExistingCalendarEvent appointment)
        {
            Console.WriteLine($"{_horizontalRule}");
            Console.WriteLine($"Event: {appointment.Subject}");
            Console.WriteLine($"When: {appointment.When}");
            Console.WriteLine($"Where: {appointment.Where}\n");
            Console.WriteLine($"{appointment.Body}");
            Console.WriteLine($"{_horizontalRule}\n");
        }

        private static void OutputMeeting(ExistingCalendarEvent meeting)
        {
            Console.WriteLine($"{_horizontalRule}");
            Console.WriteLine($"Event: {meeting.Subject}");
            Console.WriteLine($"When: {meeting.When}");
            Console.WriteLine($"Where: {meeting.Where}\n");
            Console.WriteLine($"{meeting.Body}");
            Console.WriteLine($"Required Attendees: \n\t{meeting.RequiredAttendees}");
            Console.WriteLine($"Optional Attendees: \n\t{meeting.OptionalAttendees}");
            Console.WriteLine($"{_horizontalRule}\n");
        }

        #endregion

        #endregion

        #region Create Operations

        private static void CreateMenu(EWSInstance instance)
        {
            var createMenuItems = new List<string>()
            {
                "\t- New Mail Message (1)",
                "- New Calendar Event (2)",
                "- Main Menu (0)"
            };
            var menuString = string.Join("\n\t", createMenuItems);

            while (true)
            {
                GenerateMenu(_createItemMenuBanner, menuString);
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        WriteEmail(instance);
                        return;
                    case "2":
                        CreateCalendarEvent();
                        return;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("ERROR: Invalid Operation");
                        continue;
                }
            }
        }

        private static void WriteEmail(EWSInstance instance)
        {
            Console.Clear();
            Console.WriteLine(_newEmailBanner);
            Console.Write("Recipient: ");
            var recipients = Console.ReadLine();
            Console.Write("Subject: ");
            var subject = Console.ReadLine();
            Console.Write("Body: ");
            var body = Console.ReadLine();

            var newMail = new NewEmail(recipients, string.Empty, string.Empty, subject, body);

            var response = newMail.SendNewMail(instance.Service) ? "\nEmail sent successfully.\n" : "\nEmail send failed.  Please try again.\n";
            Console.WriteLine(response);
        }

        #region Calendar Event Creation Methods

        private static void CreateCalendarEvent()
        {
            NewCalendarEvent calendarEvent;

            var createCalendarEventMenuItems = new List<string>()
            {
                "\t- New Appointment (1)",
                "- New Meeting (2)",
                "- Main Menu (0)"
            };
            var menuString = string.Join("\n\t", createCalendarEventMenuItems);

            while (true)
            {
                GenerateMenu(_newCalendarEventBanner, menuString);
                var selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        calendarEvent = new NewCalendarEvent(NewCalendarEventType.Appointment);
                        return;
                    case "2":
                        calendarEvent = new NewCalendarEvent(NewCalendarEventType.Meeting);
                        return;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid entry.  Try again.");
                        continue;
                }
            }
        }

        private static void CreateNewAppointment(NewCalendarEvent newCalendarEvent)
        {
            Console.Clear();
            Console.WriteLine(_newAppointmentBanner);

            Console.Write("Event: ");
            var subject = Console.ReadLine();
            Console.Write("Description: ");
            var body = Console.ReadLine();
            Console.Write("Location: ");
            var where = Console.ReadLine();

            newCalendarEvent.SetSimpleData(subject, body, where);

        }

        private static void GetDateSpecification(ref NewCalendarEvent newCalendarEvent)
        {
            while (true)
            {
                Console.Write("Date: ");
                var input = Console.ReadLine();
                var success = DateTime.TryParse(input, out var inputDate);
                if (success)
                {
                    while (true)
                    {
                        Console.Write("Is this an all day event? (Y/N): ");
                        var response = Console.ReadLine();
                        switch (response)
                        {
                            case "Y":
                                newCalendarEvent.SetAllDayDate(inputDate);
                                return;
                            case "N":
                                return;
                            default:
                                continue;
                        }
                    }
                }

                continue;
            }
        }

        private static void CreateNewMeeting()
        {

        }

        #endregion

        #endregion

        #endregion
    }
}
