using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;

namespace Data_Access.Models.View_Models.Email
{
    public class MailMessage
    {
        public EmailMessage NativeMessage { get; set; }

        public string Id { get; set; }
        public DateTime When { get; set; }
        public string Sender { get; set; }
        public string Recipients { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public bool HasAttachments { get; set; }
        public List<string> Attachments { get; set; }


        public MailMessage(EmailMessage message)
        {
            NativeMessage = message;

            Id = message.Id.ToString();
            When = message.DateTimeSent;
            Sender = message.Sender.Address;
            
            var recipientAddresses = new List<string>();
            foreach (var recipient in message.ToRecipients)
            {
                recipientAddresses.Add(recipient.Address);
            }
            Recipients = String.Join("; ", recipientAddresses.ToArray());

            var ccAddresses = new List<string>();
            foreach (var recipient in message.CcRecipients)
            {
                ccAddresses.Add(recipient.Address);
            }
            CC = String.Join("; ", ccAddresses.ToArray());

            var bccAddresses = new List<string>();
            foreach (var recipient in message.BccRecipients)
            {
                bccAddresses.Add(recipient.Address);
            }
            BCC = String.Join("; ", bccAddresses.ToArray());

            Subject = message.Subject;
            BodyText = message.Body.Text;

            HasAttachments = message.HasAttachments;
            Attachments = new List<string>();
            foreach(var attachment in message.Attachments)
            {
                Attachments.Add(attachment.Name);
            }
        }
    }
}
