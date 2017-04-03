using Microsoft.Exchange.WebServices.Data;
using System.Collections.Generic;

namespace Data_Access.Models.View_Models.Email
{
    public class Inbox
    {
        private Mailbox _mailbox;
        private Folder _inbox;

        public List<MailMessage> Messages { get; set; }

        public Inbox(ExchangeService instance, string address)
        {
            _mailbox = new Mailbox(address);
            _inbox = Folder.Bind(instance, new FolderId(WellKnownFolderName.Inbox, _mailbox));

            Messages = new List<MailMessage>();

            if (_inbox != null)
            {
                var view = new ItemView(100);
                var findItemsCollection = _inbox.FindItems(view);
                var propertySet = new PropertySet(BasePropertySet.FirstClassProperties, ItemSchema.Attachments);

                foreach (var item in findItemsCollection)
                {
                    // https://blogs.msdn.microsoft.com/brijs/2010/02/12/how-to-retrieve-email-address-from-the-from-and-to-field-of-mail-item-using-ews-managed-api/
                    var message = EmailMessage.Bind(instance, item.Id, propertySet);
                    item.Load(propertySet);
                    Messages.Add(new MailMessage(message));
                }
            }
        }
    }
}
