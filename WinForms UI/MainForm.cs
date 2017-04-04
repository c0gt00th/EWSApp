using Data_Access;
using Data_Access.Models.View_Models.Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_UI
{
    public partial class MainForm : Form
    {
        private EWSInstance api;

        public MainForm()
        {
            InitializeComponent();
            ActiveControl = UsernameTextbox;
        }

        #region Sign On Controls

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginButton.Text == "Login")
                {
                    AuthenticateAndLoadEnvironments();
                }

                else if (LoginButton.Text == "Logout")
                {
                    //Nullify the API instance;
                    api = null;

                    //Login control management
                    UsernameTextbox.ReadOnly = false;
                    PasswordTextbox.ReadOnly = false;
                    UsernameTextbox.Text = string.Empty;
                    PasswordTextbox.Text = string.Empty;
                    LoginButton.Text = "Login";

                    DisposeMailEnvironment();
                }
            }

            catch
            {
                ErrorLabel.Text = "Login Failed";
            }
        }

        private void AuthenticateAndLoadEnvironments()
        {
            //Temporary button changes
            LoginButton.Text = "Please wait..";
            LoginButton.Enabled = false;

            //Login Process
            Cursor.Current = Cursors.WaitCursor;
            api = new EWSInstance(UsernameTextbox.Text, PasswordTextbox.Text);
            Cursor.Current = Cursors.Default;

            //Fixing temporary changes
            LoginButton.Enabled = true;
            LoginButton.Text = "Logout";

            //Display login information
            UsernameTextbox.ReadOnly = true;
            PasswordTextbox.ReadOnly = true;

            //Error label management
            ErrorLabel.Text = string.Empty;

            LoadMailEnvironment();
            LoadCalendarEnvironment();
        }

        private void PasswordTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AuthenticateAndLoadEnvironments();
            }
        }

        #endregion

        #region Mail-Related Methods

        #region Helper Methods
        private void LoadMessagesFromGivenFolder(string folder)
        {
            FolderViewListbox.Items.Clear();
            if (api != null)
            {
                api.LoadMessagesFromGivenFolder(folder);

                foreach (var message in api.CurrentItems)
                {
                    if (api.CurrentItems[0] == "No Messages Found." || api.CurrentItems[0] == "Folder does not exist.")
                    {
                        FolderViewListbox.Items.Add($"{message}");
                        break;
                    }

                    FolderViewListbox.Items.Add($"Message ID: {message}");
                }

                if (FolderViewListbox.Items.Count > 0)
                {
                    FolderViewListbox.SelectedIndex = 0;
                }
            }
        }

        private void LoadMessageContentById(string id)
        {
            try
            {
                api.LoadMessageById(id);

                //Loading data into controls
                var msg = api.CurrentMessage;

                MessageSenderTextbox.ReadOnly = false;
                MessageSenderTextbox.Text = msg.Sender;
                MessageSenderTextbox.ReadOnly = true;

                MessageWhenTextbox.ReadOnly = false;
                MessageWhenTextbox.Text = msg.When.ToString();
                MessageWhenTextbox.ReadOnly = true;

                MessageRecipientsTextbox.ReadOnly = false;
                MessageRecipientsTextbox.Text = msg.Recipients;
                MessageRecipientsTextbox.ReadOnly = true;

                MessageCCTextbox.ReadOnly = false;
                MessageCCTextbox.Text = msg.CC;
                MessageCCTextbox.ReadOnly = true;

                MessageBCCTextbox.ReadOnly = false;
                MessageBCCTextbox.Text = msg.BCC;
                MessageBCCTextbox.ReadOnly = true;

                MessageSubjectTextbox.ReadOnly = false;
                MessageSubjectTextbox.Text = msg.Subject;
                MessageSubjectTextbox.ReadOnly = true;

                MessageBodyTextbox.ReadOnly = false;
                MessageBodyTextbox.Text = msg.BodyText;
                MessageBodyTextbox.ReadOnly = true;

                //Control management
                NewButton.Enabled = true;
                ReplyButton.Enabled = true;
                ForwardButton.Enabled = true;
                SendButton.Enabled = false;
                DeleteButton.Enabled = true;
                SendButton.Enabled = false;

                //Attachment management
                AttachFileMenuItem.Enabled = false;
                if (msg.Attachments.Count > 0)
                {
                    AttachmentsListbox.Enabled = true;
                    AttachmentsListbox.BackColor = Color.White;
                    AttachmentsListbox.Items.Clear();
                    AttachmentsListbox.Items.AddRange(msg.Attachments.ToArray());
                    SaveAttachmentMenuItem.Enabled = true;
                }
            }

            catch
            {

            }

        }

        private void LoadMailEnvironment()
        {
            //Activate relevant controls
            MailFolderGoButton.Enabled = true;
            FolderNameTextbox.ReadOnly = false;
            FolderNameTextbox.Text = "Inbox";
            FolderViewListbox.Enabled = true;
            LoadMessagesFromGivenFolder(FolderNameTextbox.Text);

            //Message control management
            NewButton.Enabled = true;

            ActiveControl = FolderViewListbox;
        }

        private void DisposeMailEnvironment()
        {
            //Folder control management
            FolderNameTextbox.ReadOnly = true;
            FolderNameTextbox.Text = string.Empty;
            FolderViewListbox.Items.Clear();
            FolderViewListbox.Enabled = false;
            MailFolderGoButton.Enabled = false;

            //Message control management
            MessageWhenTextbox.Text = string.Empty;
            MessageRecipientsTextbox.Text = string.Empty;
            MessageSenderTextbox.Text = string.Empty;
            MessageCCTextbox.Text = string.Empty;
            MessageBCCTextbox.Text = string.Empty;
            MessageSubjectTextbox.Text = string.Empty;
            MessageBodyTextbox.Text = string.Empty;
            NewButton.Enabled = false;
            ReplyButton.Enabled = false;
            ForwardButton.Enabled = false;
            DeleteButton.Enabled = false;
            SendButton.Enabled = false;
            AttachFileMenuItem.Enabled = false;
            SaveAttachmentMenuItem.Enabled = false;

            //Attachment management
            AttachmentsListbox.Items.Clear();
            AttachmentsListbox.BackColor = SystemColors.Control;
            AttachmentsListbox.Enabled = false;
        }

        private void NewPressOrReset()
        {
            //Button management
            ReplyButton.Enabled = false;
            ForwardButton.Enabled = false;
            DeleteButton.Enabled = false;
            SendButton.Enabled = true;

            //Text field management
            MessageWhenTextbox.Text = string.Empty;
            MessageSenderTextbox.Text = UsernameTextbox.Text;
            MessageSenderTextbox.ReadOnly = true;
            MessageRecipientsTextbox.ReadOnly = false;
            MessageRecipientsTextbox.Text = string.Empty;
            MessageCCTextbox.ReadOnly = false;
            MessageCCTextbox.Text = string.Empty;
            MessageBCCTextbox.ReadOnly = false;
            MessageBCCTextbox.Text = string.Empty;
            MessageSubjectTextbox.ReadOnly = false;
            MessageSubjectTextbox.Text = string.Empty;
            MessageBodyTextbox.ReadOnly = false;
            MessageBodyTextbox.Text = string.Empty;

            if (AttachmentsListbox.Items.Count > 0)
            {
                AttachmentsListbox.Items.Clear();
            }
        }

        #endregion

        #region Folder Controls

        private void FolderViewListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = FolderViewListbox.SelectedItem.ToString();
            if (selectedItem.ToString() != "No Messages Found." || selectedItem.ToString() != "Folder does not exist.")
            {
                var id = api.CurrentItems[FolderViewListbox.SelectedIndex];
                LoadMessageContentById(id);
            }

            MessageSenderTextbox.ReadOnly = true;
            MessageRecipientsTextbox.ReadOnly = true;
            MessageCCTextbox.ReadOnly = true;
            MessageBCCTextbox.ReadOnly = true;
            MessageSubjectTextbox.ReadOnly = true;
            MessageBodyTextbox.ReadOnly = true;
        }

        private void MailFolderGoButton_Click(object sender, EventArgs e)
        {
            FolderViewListbox.Items.Clear();
            LoadMessagesFromGivenFolder(FolderNameTextbox.Text);
        }

        private void CopyMessageIDMenuItem_Click(object sender, EventArgs e)
        {
            if (api != null)
            {
                Clipboard.SetText(api.CurrentMessage.Id);
            }
        }

        #endregion

        #region Message Controls

        private void NewButton_Click(object sender, EventArgs e)
        {
            AttachFileMenuItem.Enabled = true;
            SaveAttachmentMenuItem.Enabled = false;
            NewPressOrReset();
        }

        private void ReplyButton_Click(object sender, EventArgs e)
        {
            var oldSender = MessageSenderTextbox.Text;
            var oldRecipients = MessageRecipientsTextbox.Text.Split(new[] { "; " }, StringSplitOptions.None).Where(x => x != UsernameTextbox.Text);
            var separator = "============================================";
            var oldBody = MessageBodyTextbox.Text;

            MessageSenderTextbox.Text = UsernameTextbox.Text;
            MessageSenderTextbox.ReadOnly = true;
            MessageRecipientsTextbox.ReadOnly = false;
            MessageRecipientsTextbox.Text = oldSender;
            MessageCCTextbox.ReadOnly = false;
            MessageCCTextbox.Text = String.Join("; ", oldRecipients);
            MessageBCCTextbox.ReadOnly = false;
            MessageSubjectTextbox.ReadOnly = false;
            AttachmentsListbox.Enabled = true;
            AttachFileMenuItem.Enabled = true;
            SaveAttachmentMenuItem.Enabled = true;
            RemoveAttachmentMenuItem.Enabled = true;
            MessageBodyTextbox.ReadOnly = false;
            MessageBodyTextbox.Text = $"{Environment.NewLine}{Environment.NewLine}{separator}{Environment.NewLine}{Environment.NewLine}{oldBody}";

            DeleteButton.Enabled = false;
            SendButton.Enabled = true;
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            var oldSender = MessageSenderTextbox.Text;
            var oldCC = MessageCCTextbox.Text;
            var separator = "============================================";
            var oldBody = MessageBodyTextbox.Text;

            MessageSenderTextbox.Text = UsernameTextbox.Text;
            MessageSenderTextbox.ReadOnly = true;
            MessageRecipientsTextbox.ReadOnly = false;
            MessageRecipientsTextbox.Text = string.Empty;
            MessageCCTextbox.ReadOnly = false;
            MessageCCTextbox.Text = $"{oldSender}; {oldCC}";
            MessageBCCTextbox.ReadOnly = false;
            MessageSubjectTextbox.ReadOnly = false;
            AttachmentsListbox.Enabled = true;
            AttachFileMenuItem.Enabled = true;
            SaveAttachmentMenuItem.Enabled = true;
            RemoveAttachmentMenuItem.Enabled = true;
            MessageBodyTextbox.ReadOnly = false;
            MessageBodyTextbox.Text = $"{Environment.NewLine}{Environment.NewLine}{separator}{Environment.NewLine}{Environment.NewLine}{oldBody}";

            DeleteButton.Enabled = false;
            SendButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Temporary changes while sending
                DeleteButton.Text = " - ";
                DeleteButton.Enabled = false;

                Cursor.Current = Cursors.WaitCursor;
                api.DeleteEmail(api.CurrentMessage.Id);
                Cursor.Current = Cursors.Default;

                //Temporary changes while sending
                DeleteButton.Enabled = true;
                DeleteButton.Text = "Delete";

                AttachFileMenuItem.Enabled = false;
                SaveAttachmentMenuItem.Enabled = false;

                NewPressOrReset();
                LoadMessagesFromGivenFolder(FolderNameTextbox.Text);
            }

            catch
            {

            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Temporary changes while sending
                SendButton.Text = "...";
                SendButton.Enabled = false;

                var emailDetails = new Dictionary<string, string>()
                {
                    {"Sender", MessageSenderTextbox.Text },
                    {"CC", MessageCCTextbox.Text },
                    {"BCC", MessageBCCTextbox.Text },
                    {"Subject", MessageSubjectTextbox.Text },
                    {"Body", MessageBodyTextbox.Text }
                };

                Cursor.Current = Cursors.WaitCursor;
                api.SendEmail(emailDetails);
                MessageBox.Show("Message Successfully Sent");
                Cursor.Current = Cursors.Default;

                //Reverting temporary changes
                SendButton.Text = "Send";
                SendButton.Enabled = true;

                AttachFileMenuItem.Enabled = false;
                SaveAttachmentMenuItem.Enabled = false;

                //Message control reset
                NewPressOrReset();

                LoadMessagesFromGivenFolder(FolderNameTextbox.Text);
            }

            catch
            {

            }
        }

        #endregion

        #region Attachment Handling

        private void SaveAttachmentMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAttachmentSFD.FileName = AttachmentsListbox.SelectedItem.ToString();
                if (SaveAttachmentSFD.ShowDialog() == DialogResult.OK)
                {
                    var fullPath = Path.GetFullPath(SaveAttachmentSFD.FileName);
                    api.SaveAttachment(AttachmentsListbox.SelectedItem.ToString(), fullPath);
                }
            }

            catch
            {
                MessageBox.Show("File Save Failed.");
            }
        }

        private void AttachFileMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenAttachmentOFD.ShowDialog() == DialogResult.OK)
                {
                    var fullPath = Path.GetFullPath(OpenAttachmentOFD.FileName);
                    api.AddAttachment(fullPath);

                    AttachmentsListbox.Items.Clear();
                    AttachmentsListbox.Items.AddRange(api._pendingAttachments.ToArray());
                }

                RemoveAttachmentMenuItem.Enabled = true;
            }

            catch
            {
                MessageBox.Show("File Save Failed.");
            }
        }

        private void RemoveAttachmentMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttachmentsListbox.SelectedItem != null)
                {
                    api.RemoveAttachment(AttachmentsListbox.SelectedItem.ToString());
                    AttachmentsListbox.Items.Remove(AttachmentsListbox.SelectedItem);
                }
            }

            catch
            {

            }
        }

        #endregion

        #endregion

        #region Calendar-Related Methods

        private void LoadCalendarEnvironment()
        {
            MainCalendarControl.Enabled = true;
            ScheduleTreeView.Enabled = true;
            UseStandardTimeCheckbox.Enabled = true;

            var initialDate = DateTime.Now.Date;

            MainCalendarControl.SetDate(initialDate);
        }

        private void MainCalendarControl_DateChanged(object sender, DateRangeEventArgs e)
        {
            var start = MainCalendarControl.SelectionRange.Start;
            var end = MainCalendarControl.SelectionRange.End;
            api.LoadCalendarEventsWithinRange(start, end);

            ScheduleTreeView.Nodes.Clear();

            if (start != end)
            {
                var iterativeDate = start.Date;
                while (iterativeDate.Date != end.AddDays(1).Date)
                {
                    PopulateScheduleForDate(iterativeDate);
                    iterativeDate = iterativeDate.AddDays(1);
                }
                return;
            }

            PopulateScheduleForDate(start.Date);
        }

        private void PopulateScheduleForDate(DateTime start)
        {
            var orderedList = api.CurrentEvents.Where(y => y.Start.Date == start.Date).OrderBy(x => x.Start).ToList();
            var dateNode = new TreeNode(start.Date.ToString());

            foreach(var calendarEvent in orderedList)
            {
                var eventNode = new TreeNode($"{calendarEvent.Type} @ {calendarEvent.Start.TimeOfDay}");

                eventNode.Nodes.Add($"Subject: {calendarEvent.Subject}");
                eventNode.Nodes.Add($"Where: {calendarEvent.Where}");

                if (calendarEvent.Type == CalendarEventType.Meeting)
                {
                    eventNode.Nodes.Add($"Required Attendees: {calendarEvent.RequiredAttendees}");
                    eventNode.Nodes.Add($"Optional Attendees: {calendarEvent.OptionalAttendees}");
                }

                dateNode.Nodes.Add(eventNode);
            }

            ScheduleTreeView.Nodes.Add(dateNode);
        }

        #endregion

        #region People-Related Methods



        #endregion


    }
}
