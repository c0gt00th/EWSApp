using Data_Access.Models.Create_Models;
using Data_Access.Models.View_Models.Email;
using Microsoft.Exchange.WebServices.Data;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Data_Access.Models.View_Models.Calendar;

namespace Data_Access
{
    public class EWSInstance
    {
        public List<string> _pendingAttachments { get; set; }
        public ExchangeService _service { get; set; }

        //Mail Objects

        public List<string> CurrentItems { get; set; }
        public MailMessage CurrentMessage { get; set; }

        //Calendar Objects
        public List<ExistingCalendarEvent> CurrentEvents { get; set; }

        public EWSInstance(string email, string password)
        {
            CurrentItems = new List<string>();
            CurrentEvents = new List<ExistingCalendarEvent>();

            _service = new ExchangeService(ExchangeVersion.Exchange2013_SP1)
            {
                Credentials = new WebCredentials(email, password),
                EnableScpLookup = false,
                Url = new Uri("https://outlook.office365.com/EWS/Exchange.asmx")
            };
        }

        #region Mail-Related Methods

        #region Loading Methods

        public void LoadMessagesFromGivenFolder(string folder)
        {
            CurrentItems.Clear();
            var view = new FolderView(100)
            {
                PropertySet = new PropertySet(BasePropertySet.IdOnly)
                    {
                        FolderSchema.DisplayName
                    },
                Traversal = FolderTraversal.Deep
            };

            var findFolderResults = _service.FindFolders(WellKnownFolderName.Root, view);
            //find specific folder
            var targetFolder = findFolderResults.Where(x => x.DisplayName == folder);
            if (targetFolder.Count() > 0)
            {
                foreach (Folder f in targetFolder)
                {
                    var itemView = new ItemView(30);
                    var targetItems = f.FindItems(itemView);
                    if (targetItems.Count() > 0)
                    {
                        foreach (var item in targetItems)
                        {
                            CurrentItems.Add(item.Id.ToString());
                        }
                    }

                    else
                    {
                        CurrentItems.Add("No Messages Found.");
                    }
                }
            }

            else
            {
                CurrentItems.Add("Folder does not exist.");
            }
        }

        public void LoadMessageById(string id)
        {
            _pendingAttachments = new List<string>();
            var ps = new PropertySet(BasePropertySet.FirstClassProperties, ItemSchema.Attachments);
            ps.RequestedBodyType = BodyType.Text;
            CurrentMessage = new MailMessage(EmailMessage.Bind(_service, new ItemId(id),ps));
        }

        #endregion

        #region Message Actions

        public void SendEmail(Dictionary<string, string> details)
        {
            var newMessage = new NewEmail(details["Sender"], details["CC"], details["BCC"], details["Subject"], details["Body"], _pendingAttachments);

            newMessage.SendNewMail(_service);
        }

        public void DeleteEmail(string id)
        {
            var msg = EmailMessage.Bind(_service, id);
            msg.Delete(DeleteMode.MoveToDeletedItems);
        }

        public void SaveAttachment(string filename, string path)
        {
            var attachment = CurrentMessage.NativeMessage.Attachments.Where(x => x.Name == filename).FirstOrDefault() as FileAttachment;
            using (var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                attachment.Load(stream);
                stream.Close();
            }
        }

        public void AddAttachment(string filename)
        {
            _pendingAttachments.Add(filename);
        }

        public void RemoveAttachment(string filename)
        {
            _pendingAttachments = _pendingAttachments.Where(x => x != filename).ToList();
        }

        #endregion

        #endregion

        #region Calendar-Related Methods

        public void LoadCalendarEventsWithinRange(DateTime start, DateTime end)
        {
            CurrentEvents = new List<ExistingCalendarEvent>();

            var calendar = CalendarFolder.Bind(_service, WellKnownFolderName.Calendar, new PropertySet());
            var cView = new CalendarView(start, end, 200);
            cView.PropertySet = new PropertySet(BasePropertySet.FirstClassProperties);
            var appointments = calendar.FindAppointments(cView);

            foreach (var appointment in appointments)
            {
                appointment.Load();
                CurrentEvents.Add(new ExistingCalendarEvent(appointment));
            }
        }

        #endregion
    }
}
