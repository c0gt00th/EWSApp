using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;

namespace Data_Access.Models.Create_Models
{
    public class NewEmail
    {
        private string _recipients;
        private string _ccRecipients;
        private string _bccRecipients;
        private string _subject;
        private string _body;
        private List<string> _attachments;

        public NewEmail(string recipients, string cc, string bcc, string subject, string body, List<string> attachments)
        {
            _recipients = recipients;
            _ccRecipients = cc;
            _bccRecipients = bcc;
            _subject = subject;
            _body = body;
            _attachments = attachments;
        }

        public bool SendNewMail(ExchangeService instance)
        {
            try
            {
                var msg = new EmailMessage(instance)
                {
                    Subject = _subject,
                    Body = _body
                };

                if (_recipients.Contains("; "))
                {
                    msg.ToRecipients.AddRange(_recipients.Split(new[] { "; " }, StringSplitOptions.None));
                }

                else
                {
                    msg.ToRecipients.Add(_recipients);
                }

                if (_ccRecipients != string.Empty)
                {
                    msg.CcRecipients.AddRange(_ccRecipients.Split(new[] { "; " }, StringSplitOptions.None));
                }
                
                if (_bccRecipients != string.Empty)
                {
                    msg.BccRecipients.AddRange(_bccRecipients.Split(new[] { "; " }, StringSplitOptions.None));
                }

                foreach (var attachment in _attachments)
                {
                    msg.Attachments.AddFileAttachment(attachment);
                }
                
                msg.Send();

                return true;
            }

            catch
            {
                return false;
            }
        }
    }
}
