using System.Drawing;

namespace WinForms_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ContentTabControl = new System.Windows.Forms.TabControl();
            this.DelegatePermTab = new System.Windows.Forms.TabPage();
            this.DelegateTLP = new System.Windows.Forms.TableLayoutPanel();
            this.DelegateTabControl = new System.Windows.Forms.TabControl();
            this.EmailTab = new System.Windows.Forms.TabPage();
            this.MailTLP = new System.Windows.Forms.TableLayoutPanel();
            this.FolderViewTLP = new System.Windows.Forms.TableLayoutPanel();
            this.MailFolderGoButton = new System.Windows.Forms.Button();
            this.FolderViewListbox = new System.Windows.Forms.ListBox();
            this.FolderViewListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyMessageIDMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderNameTextboxLabel = new System.Windows.Forms.Label();
            this.FolderNameTextbox = new System.Windows.Forms.TextBox();
            this.MessageTLP = new System.Windows.Forms.TableLayoutPanel();
            this.MessageSenderTextbox = new System.Windows.Forms.TextBox();
            this.MessageRecipientsTextbox = new System.Windows.Forms.TextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.MessageSubjectTextbox = new System.Windows.Forms.TextBox();
            this.ReplyButton = new System.Windows.Forms.Button();
            this.MessageBCCTextbox = new System.Windows.Forms.TextBox();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.MessageCCTextbox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageSubjectLabel = new System.Windows.Forms.Label();
            this.MessageWhenTextbox = new System.Windows.Forms.TextBox();
            this.MessageWhenLabel = new System.Windows.Forms.Label();
            this.MessageBCCLabel = new System.Windows.Forms.Label();
            this.MessageFromLabel = new System.Windows.Forms.Label();
            this.MessageCCLabel = new System.Windows.Forms.Label();
            this.MessageToLabel = new System.Windows.Forms.Label();
            this.MessageBodyTextbox = new System.Windows.Forms.TextBox();
            this.AttachedLabel = new System.Windows.Forms.Label();
            this.AttachmentsListbox = new System.Windows.Forms.ListBox();
            this.AttachmentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AttachFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAttachmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveAttachmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalendarTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MainCalendarControl = new System.Windows.Forms.MonthCalendar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ScheduleTreeView = new System.Windows.Forms.TreeView();
            this.UseStandardTimeCheckbox = new System.Windows.Forms.CheckBox();
            this.PeopleTab = new System.Windows.Forms.TabPage();
            this.CredentialsTLP = new System.Windows.Forms.TableLayoutPanel();
            this.UsernameTextboxLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextboxLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AdminPermTab = new System.Windows.Forms.TabPage();
            this.SaveAttachmentSFD = new System.Windows.Forms.SaveFileDialog();
            this.OpenAttachmentOFD = new System.Windows.Forms.OpenFileDialog();
            this.ContentTabControl.SuspendLayout();
            this.DelegatePermTab.SuspendLayout();
            this.DelegateTLP.SuspendLayout();
            this.DelegateTabControl.SuspendLayout();
            this.EmailTab.SuspendLayout();
            this.MailTLP.SuspendLayout();
            this.FolderViewTLP.SuspendLayout();
            this.FolderViewListContextMenu.SuspendLayout();
            this.MessageTLP.SuspendLayout();
            this.AttachmentContextMenu.SuspendLayout();
            this.CalendarTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.CredentialsTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentTabControl
            // 
            this.ContentTabControl.Controls.Add(this.DelegatePermTab);
            this.ContentTabControl.Controls.Add(this.AdminPermTab);
            this.ContentTabControl.Location = new System.Drawing.Point(0, 0);
            this.ContentTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.ContentTabControl.Name = "ContentTabControl";
            this.ContentTabControl.Padding = new System.Drawing.Point(0, 0);
            this.ContentTabControl.SelectedIndex = 0;
            this.ContentTabControl.Size = new System.Drawing.Size(823, 709);
            this.ContentTabControl.TabIndex = 0;
            this.ContentTabControl.TabStop = false;
            // 
            // DelegatePermTab
            // 
            this.DelegatePermTab.BackColor = System.Drawing.SystemColors.Control;
            this.DelegatePermTab.Controls.Add(this.DelegateTLP);
            this.DelegatePermTab.Location = new System.Drawing.Point(4, 21);
            this.DelegatePermTab.Margin = new System.Windows.Forms.Padding(0);
            this.DelegatePermTab.Name = "DelegatePermTab";
            this.DelegatePermTab.Size = new System.Drawing.Size(815, 684);
            this.DelegatePermTab.TabIndex = 0;
            this.DelegatePermTab.Text = "Delegate Permissions";
            // 
            // DelegateTLP
            // 
            this.DelegateTLP.ColumnCount = 1;
            this.DelegateTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DelegateTLP.Controls.Add(this.DelegateTabControl, 0, 1);
            this.DelegateTLP.Controls.Add(this.CredentialsTLP, 0, 0);
            this.DelegateTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelegateTLP.Location = new System.Drawing.Point(0, 0);
            this.DelegateTLP.Margin = new System.Windows.Forms.Padding(0);
            this.DelegateTLP.Name = "DelegateTLP";
            this.DelegateTLP.RowCount = 2;
            this.DelegateTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DelegateTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DelegateTLP.Size = new System.Drawing.Size(815, 684);
            this.DelegateTLP.TabIndex = 1;
            // 
            // DelegateTabControl
            // 
            this.DelegateTabControl.Controls.Add(this.EmailTab);
            this.DelegateTabControl.Controls.Add(this.CalendarTab);
            this.DelegateTabControl.Controls.Add(this.PeopleTab);
            this.DelegateTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelegateTabControl.Location = new System.Drawing.Point(0, 100);
            this.DelegateTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.DelegateTabControl.Name = "DelegateTabControl";
            this.DelegateTabControl.Padding = new System.Drawing.Point(0, 0);
            this.DelegateTabControl.SelectedIndex = 0;
            this.DelegateTabControl.Size = new System.Drawing.Size(815, 584);
            this.DelegateTabControl.TabIndex = 6;
            this.DelegateTabControl.TabStop = false;
            // 
            // EmailTab
            // 
            this.EmailTab.BackColor = System.Drawing.SystemColors.Control;
            this.EmailTab.Controls.Add(this.MailTLP);
            this.EmailTab.Location = new System.Drawing.Point(4, 21);
            this.EmailTab.Margin = new System.Windows.Forms.Padding(0);
            this.EmailTab.Name = "EmailTab";
            this.EmailTab.Size = new System.Drawing.Size(807, 559);
            this.EmailTab.TabIndex = 0;
            this.EmailTab.Text = "Mail";
            // 
            // MailTLP
            // 
            this.MailTLP.ColumnCount = 2;
            this.MailTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 405F));
            this.MailTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 405F));
            this.MailTLP.Controls.Add(this.FolderViewTLP, 0, 0);
            this.MailTLP.Controls.Add(this.MessageTLP, 1, 0);
            this.MailTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailTLP.Location = new System.Drawing.Point(0, 0);
            this.MailTLP.Margin = new System.Windows.Forms.Padding(0);
            this.MailTLP.Name = "MailTLP";
            this.MailTLP.RowCount = 1;
            this.MailTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MailTLP.Size = new System.Drawing.Size(807, 559);
            this.MailTLP.TabIndex = 0;
            // 
            // FolderViewTLP
            // 
            this.FolderViewTLP.ColumnCount = 3;
            this.FolderViewTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FolderViewTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FolderViewTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FolderViewTLP.Controls.Add(this.MailFolderGoButton, 2, 1);
            this.FolderViewTLP.Controls.Add(this.FolderViewListbox, 0, 3);
            this.FolderViewTLP.Controls.Add(this.FolderNameTextboxLabel, 0, 1);
            this.FolderViewTLP.Controls.Add(this.FolderNameTextbox, 1, 1);
            this.FolderViewTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderViewTLP.Location = new System.Drawing.Point(0, 0);
            this.FolderViewTLP.Margin = new System.Windows.Forms.Padding(0);
            this.FolderViewTLP.Name = "FolderViewTLP";
            this.FolderViewTLP.RowCount = 4;
            this.FolderViewTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FolderViewTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FolderViewTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.FolderViewTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FolderViewTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FolderViewTLP.Size = new System.Drawing.Size(405, 559);
            this.FolderViewTLP.TabIndex = 0;
            // 
            // MailFolderGoButton
            // 
            this.MailFolderGoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MailFolderGoButton.Enabled = false;
            this.MailFolderGoButton.Location = new System.Drawing.Point(335, 20);
            this.MailFolderGoButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MailFolderGoButton.Name = "MailFolderGoButton";
            this.MailFolderGoButton.Size = new System.Drawing.Size(65, 30);
            this.MailFolderGoButton.TabIndex = 28;
            this.MailFolderGoButton.TabStop = false;
            this.MailFolderGoButton.Text = "Go";
            this.MailFolderGoButton.UseVisualStyleBackColor = true;
            this.MailFolderGoButton.Click += new System.EventHandler(this.MailFolderGoButton_Click);
            // 
            // FolderViewListbox
            // 
            this.FolderViewTLP.SetColumnSpan(this.FolderViewListbox, 3);
            this.FolderViewListbox.ContextMenuStrip = this.FolderViewListContextMenu;
            this.FolderViewListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderViewListbox.Enabled = false;
            this.FolderViewListbox.FormattingEnabled = true;
            this.FolderViewListbox.ItemHeight = 12;
            this.FolderViewListbox.Location = new System.Drawing.Point(5, 60);
            this.FolderViewListbox.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FolderViewListbox.Name = "FolderViewListbox";
            this.FolderViewListbox.Size = new System.Drawing.Size(395, 499);
            this.FolderViewListbox.TabIndex = 3;
            this.FolderViewListbox.SelectedIndexChanged += new System.EventHandler(this.FolderViewListbox_SelectedIndexChanged);
            // 
            // FolderViewListContextMenu
            // 
            this.FolderViewListContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.FolderViewListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyMessageIDMenuItem});
            this.FolderViewListContextMenu.Name = "FolderViewListContextMenu";
            this.FolderViewListContextMenu.Size = new System.Drawing.Size(265, 26);
            // 
            // CopyMessageIDMenuItem
            // 
            this.CopyMessageIDMenuItem.Name = "CopyMessageIDMenuItem";
            this.CopyMessageIDMenuItem.Size = new System.Drawing.Size(264, 22);
            this.CopyMessageIDMenuItem.Text = "Copy Selected Message ID.. (Ctrl+C)";
            this.CopyMessageIDMenuItem.Click += new System.EventHandler(this.CopyMessageIDMenuItem_Click);
            // 
            // FolderNameTextboxLabel
            // 
            this.FolderNameTextboxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderNameTextboxLabel.AutoSize = true;
            this.FolderNameTextboxLabel.Location = new System.Drawing.Point(5, 28);
            this.FolderNameTextboxLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FolderNameTextboxLabel.Name = "FolderNameTextboxLabel";
            this.FolderNameTextboxLabel.Size = new System.Drawing.Size(43, 13);
            this.FolderNameTextboxLabel.TabIndex = 1;
            this.FolderNameTextboxLabel.Text = "Folder:";
            // 
            // FolderNameTextbox
            // 
            this.FolderNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FolderNameTextbox.Location = new System.Drawing.Point(53, 24);
            this.FolderNameTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.FolderNameTextbox.Name = "FolderNameTextbox";
            this.FolderNameTextbox.ReadOnly = true;
            this.FolderNameTextbox.Size = new System.Drawing.Size(277, 21);
            this.FolderNameTextbox.TabIndex = 3;
            // 
            // MessageTLP
            // 
            this.MessageTLP.ColumnCount = 7;
            this.MessageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.MessageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MessageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MessageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MessageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MessageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MessageTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.MessageTLP.Controls.Add(this.MessageSenderTextbox, 2, 5);
            this.MessageTLP.Controls.Add(this.MessageRecipientsTextbox, 2, 7);
            this.MessageTLP.Controls.Add(this.NewButton, 1, 1);
            this.MessageTLP.Controls.Add(this.MessageSubjectTextbox, 2, 13);
            this.MessageTLP.Controls.Add(this.ReplyButton, 2, 1);
            this.MessageTLP.Controls.Add(this.MessageBCCTextbox, 2, 11);
            this.MessageTLP.Controls.Add(this.ForwardButton, 3, 1);
            this.MessageTLP.Controls.Add(this.MessageCCTextbox, 2, 9);
            this.MessageTLP.Controls.Add(this.DeleteButton, 4, 1);
            this.MessageTLP.Controls.Add(this.SendButton, 5, 1);
            this.MessageTLP.Controls.Add(this.MessageSubjectLabel, 1, 13);
            this.MessageTLP.Controls.Add(this.MessageWhenTextbox, 2, 3);
            this.MessageTLP.Controls.Add(this.MessageWhenLabel, 1, 3);
            this.MessageTLP.Controls.Add(this.MessageBCCLabel, 1, 11);
            this.MessageTLP.Controls.Add(this.MessageFromLabel, 1, 5);
            this.MessageTLP.Controls.Add(this.MessageCCLabel, 1, 9);
            this.MessageTLP.Controls.Add(this.MessageToLabel, 1, 7);
            this.MessageTLP.Controls.Add(this.MessageBodyTextbox, 1, 17);
            this.MessageTLP.Controls.Add(this.AttachedLabel, 1, 15);
            this.MessageTLP.Controls.Add(this.AttachmentsListbox, 2, 15);
            this.MessageTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageTLP.Location = new System.Drawing.Point(405, 0);
            this.MessageTLP.Margin = new System.Windows.Forms.Padding(0);
            this.MessageTLP.Name = "MessageTLP";
            this.MessageTLP.RowCount = 18;
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MessageTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MessageTLP.Size = new System.Drawing.Size(405, 559);
            this.MessageTLP.TabIndex = 1;
            // 
            // MessageSenderTextbox
            // 
            this.MessageSenderTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTLP.SetColumnSpan(this.MessageSenderTextbox, 4);
            this.MessageSenderTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageSenderTextbox.Location = new System.Drawing.Point(84, 83);
            this.MessageSenderTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageSenderTextbox.Name = "MessageSenderTextbox";
            this.MessageSenderTextbox.ReadOnly = true;
            this.MessageSenderTextbox.Size = new System.Drawing.Size(316, 21);
            this.MessageSenderTextbox.TabIndex = 18;
            // 
            // MessageRecipientsTextbox
            // 
            this.MessageRecipientsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTLP.SetColumnSpan(this.MessageRecipientsTextbox, 4);
            this.MessageRecipientsTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageRecipientsTextbox.Location = new System.Drawing.Point(84, 106);
            this.MessageRecipientsTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageRecipientsTextbox.Name = "MessageRecipientsTextbox";
            this.MessageRecipientsTextbox.ReadOnly = true;
            this.MessageRecipientsTextbox.Size = new System.Drawing.Size(316, 21);
            this.MessageRecipientsTextbox.TabIndex = 36;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewButton.Enabled = false;
            this.NewButton.Location = new System.Drawing.Point(7, 20);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 30);
            this.NewButton.TabIndex = 25;
            this.NewButton.TabStop = false;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // MessageSubjectTextbox
            // 
            this.MessageSubjectTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTLP.SetColumnSpan(this.MessageSubjectTextbox, 4);
            this.MessageSubjectTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageSubjectTextbox.Location = new System.Drawing.Point(84, 175);
            this.MessageSubjectTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageSubjectTextbox.Name = "MessageSubjectTextbox";
            this.MessageSubjectTextbox.ReadOnly = true;
            this.MessageSubjectTextbox.Size = new System.Drawing.Size(316, 21);
            this.MessageSubjectTextbox.TabIndex = 22;
            // 
            // ReplyButton
            // 
            this.ReplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplyButton.Enabled = false;
            this.ReplyButton.Location = new System.Drawing.Point(86, 20);
            this.ReplyButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReplyButton.Name = "ReplyButton";
            this.ReplyButton.Size = new System.Drawing.Size(75, 30);
            this.ReplyButton.TabIndex = 23;
            this.ReplyButton.TabStop = false;
            this.ReplyButton.Text = "Reply";
            this.ReplyButton.UseVisualStyleBackColor = true;
            this.ReplyButton.Click += new System.EventHandler(this.ReplyButton_Click);
            // 
            // MessageBCCTextbox
            // 
            this.MessageBCCTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTLP.SetColumnSpan(this.MessageBCCTextbox, 4);
            this.MessageBCCTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBCCTextbox.Location = new System.Drawing.Point(84, 152);
            this.MessageBCCTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageBCCTextbox.Name = "MessageBCCTextbox";
            this.MessageBCCTextbox.ReadOnly = true;
            this.MessageBCCTextbox.Size = new System.Drawing.Size(316, 21);
            this.MessageBCCTextbox.TabIndex = 21;
            // 
            // ForwardButton
            // 
            this.ForwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ForwardButton.Enabled = false;
            this.ForwardButton.Location = new System.Drawing.Point(165, 20);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(75, 30);
            this.ForwardButton.TabIndex = 24;
            this.ForwardButton.TabStop = false;
            this.ForwardButton.Text = "Forward";
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // MessageCCTextbox
            // 
            this.MessageCCTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTLP.SetColumnSpan(this.MessageCCTextbox, 4);
            this.MessageCCTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageCCTextbox.Location = new System.Drawing.Point(84, 129);
            this.MessageCCTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageCCTextbox.Name = "MessageCCTextbox";
            this.MessageCCTextbox.ReadOnly = true;
            this.MessageCCTextbox.Size = new System.Drawing.Size(316, 21);
            this.MessageCCTextbox.TabIndex = 19;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(244, 20);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 30);
            this.DeleteButton.TabIndex = 30;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Enabled = false;
            this.SendButton.Location = new System.Drawing.Point(323, 20);
            this.SendButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 30);
            this.SendButton.TabIndex = 27;
            this.SendButton.TabStop = false;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageSubjectLabel
            // 
            this.MessageSubjectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageSubjectLabel.AutoSize = true;
            this.MessageSubjectLabel.Location = new System.Drawing.Point(5, 180);
            this.MessageSubjectLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MessageSubjectLabel.Name = "MessageSubjectLabel";
            this.MessageSubjectLabel.Size = new System.Drawing.Size(79, 13);
            this.MessageSubjectLabel.TabIndex = 15;
            this.MessageSubjectLabel.Text = "Subject:";
            // 
            // MessageWhenTextbox
            // 
            this.MessageWhenTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTLP.SetColumnSpan(this.MessageWhenTextbox, 4);
            this.MessageWhenTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageWhenTextbox.Location = new System.Drawing.Point(84, 60);
            this.MessageWhenTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageWhenTextbox.Name = "MessageWhenTextbox";
            this.MessageWhenTextbox.ReadOnly = true;
            this.MessageWhenTextbox.Size = new System.Drawing.Size(316, 21);
            this.MessageWhenTextbox.TabIndex = 32;
            // 
            // MessageWhenLabel
            // 
            this.MessageWhenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageWhenLabel.AutoSize = true;
            this.MessageWhenLabel.Location = new System.Drawing.Point(5, 65);
            this.MessageWhenLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MessageWhenLabel.Name = "MessageWhenLabel";
            this.MessageWhenLabel.Size = new System.Drawing.Size(79, 13);
            this.MessageWhenLabel.TabIndex = 12;
            this.MessageWhenLabel.Text = "When: ";
            // 
            // MessageBCCLabel
            // 
            this.MessageBCCLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageBCCLabel.AutoSize = true;
            this.MessageBCCLabel.Location = new System.Drawing.Point(5, 157);
            this.MessageBCCLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MessageBCCLabel.Name = "MessageBCCLabel";
            this.MessageBCCLabel.Size = new System.Drawing.Size(79, 13);
            this.MessageBCCLabel.TabIndex = 9;
            this.MessageBCCLabel.Text = "BCC:";
            // 
            // MessageFromLabel
            // 
            this.MessageFromLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageFromLabel.AutoSize = true;
            this.MessageFromLabel.Location = new System.Drawing.Point(5, 88);
            this.MessageFromLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MessageFromLabel.Name = "MessageFromLabel";
            this.MessageFromLabel.Size = new System.Drawing.Size(79, 13);
            this.MessageFromLabel.TabIndex = 4;
            this.MessageFromLabel.Text = "From: ";
            // 
            // MessageCCLabel
            // 
            this.MessageCCLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageCCLabel.AutoSize = true;
            this.MessageCCLabel.Location = new System.Drawing.Point(5, 134);
            this.MessageCCLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MessageCCLabel.Name = "MessageCCLabel";
            this.MessageCCLabel.Size = new System.Drawing.Size(79, 13);
            this.MessageCCLabel.TabIndex = 8;
            this.MessageCCLabel.Text = "CC:";
            // 
            // MessageToLabel
            // 
            this.MessageToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageToLabel.AutoSize = true;
            this.MessageToLabel.Location = new System.Drawing.Point(5, 111);
            this.MessageToLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.MessageToLabel.Name = "MessageToLabel";
            this.MessageToLabel.Size = new System.Drawing.Size(79, 13);
            this.MessageToLabel.TabIndex = 6;
            this.MessageToLabel.Text = "To: ";
            // 
            // MessageBodyTextbox
            // 
            this.MessageBodyTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTLP.SetColumnSpan(this.MessageBodyTextbox, 5);
            this.MessageBodyTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageBodyTextbox.Location = new System.Drawing.Point(5, 234);
            this.MessageBodyTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.MessageBodyTextbox.MaximumSize = new System.Drawing.Size(395, 348);
            this.MessageBodyTextbox.Multiline = true;
            this.MessageBodyTextbox.Name = "MessageBodyTextbox";
            this.MessageBodyTextbox.ReadOnly = true;
            this.MessageBodyTextbox.Size = new System.Drawing.Size(395, 325);
            this.MessageBodyTextbox.TabIndex = 14;
            // 
            // AttachedLabel
            // 
            this.AttachedLabel.AutoSize = true;
            this.AttachedLabel.Location = new System.Drawing.Point(5, 201);
            this.AttachedLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.AttachedLabel.Name = "AttachedLabel";
            this.AttachedLabel.Size = new System.Drawing.Size(56, 13);
            this.AttachedLabel.TabIndex = 33;
            this.AttachedLabel.Text = "Attached:";
            // 
            // AttachmentsListbox
            // 
            this.AttachmentsListbox.BackColor = System.Drawing.SystemColors.Control;
            this.AttachmentsListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageTLP.SetColumnSpan(this.AttachmentsListbox, 4);
            this.AttachmentsListbox.ContextMenuStrip = this.AttachmentContextMenu;
            this.AttachmentsListbox.Enabled = false;
            this.AttachmentsListbox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachmentsListbox.FormattingEnabled = true;
            this.AttachmentsListbox.ItemHeight = 12;
            this.AttachmentsListbox.Location = new System.Drawing.Point(84, 198);
            this.AttachmentsListbox.Margin = new System.Windows.Forms.Padding(0);
            this.AttachmentsListbox.Name = "AttachmentsListbox";
            this.AttachmentsListbox.Size = new System.Drawing.Size(316, 26);
            this.AttachmentsListbox.TabIndex = 34;
            // 
            // AttachmentContextMenu
            // 
            this.AttachmentContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AttachmentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AttachFileMenuItem,
            this.SaveAttachmentMenuItem,
            this.RemoveAttachmentMenuItem});
            this.AttachmentContextMenu.Name = "AttachmentContextMenu";
            this.AttachmentContextMenu.Size = new System.Drawing.Size(237, 70);
            // 
            // AttachFileMenuItem
            // 
            this.AttachFileMenuItem.Enabled = false;
            this.AttachFileMenuItem.Name = "AttachFileMenuItem";
            this.AttachFileMenuItem.Size = new System.Drawing.Size(236, 22);
            this.AttachFileMenuItem.Text = "Attach File..";
            this.AttachFileMenuItem.Click += new System.EventHandler(this.AttachFileMenuItem_Click);
            // 
            // SaveAttachmentMenuItem
            // 
            this.SaveAttachmentMenuItem.Enabled = false;
            this.SaveAttachmentMenuItem.Name = "SaveAttachmentMenuItem";
            this.SaveAttachmentMenuItem.Size = new System.Drawing.Size(236, 22);
            this.SaveAttachmentMenuItem.Text = "Save Attachment As..";
            this.SaveAttachmentMenuItem.Click += new System.EventHandler(this.SaveAttachmentMenuItem_Click);
            // 
            // RemoveAttachmentMenuItem
            // 
            this.RemoveAttachmentMenuItem.Enabled = false;
            this.RemoveAttachmentMenuItem.Name = "RemoveAttachmentMenuItem";
            this.RemoveAttachmentMenuItem.Size = new System.Drawing.Size(236, 22);
            this.RemoveAttachmentMenuItem.Text = "Remove Selected Attachment..";
            this.RemoveAttachmentMenuItem.Click += new System.EventHandler(this.RemoveAttachmentMenuItem_Click);
            // 
            // CalendarTab
            // 
            this.CalendarTab.BackColor = System.Drawing.SystemColors.Control;
            this.CalendarTab.Controls.Add(this.tableLayoutPanel1);
            this.CalendarTab.Location = new System.Drawing.Point(4, 21);
            this.CalendarTab.Margin = new System.Windows.Forms.Padding(0);
            this.CalendarTab.Name = "CalendarTab";
            this.CalendarTab.Size = new System.Drawing.Size(807, 559);
            this.CalendarTab.TabIndex = 1;
            this.CalendarTab.Text = "Calendar";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 559);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.MainCalendarControl, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(270, 559);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // MainCalendarControl
            // 
            this.MainCalendarControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainCalendarControl.Enabled = false;
            this.MainCalendarControl.Location = new System.Drawing.Point(21, 0);
            this.MainCalendarControl.Margin = new System.Windows.Forms.Padding(0);
            this.MainCalendarControl.Name = "MainCalendarControl";
            this.MainCalendarControl.TabIndex = 0;
            this.MainCalendarControl.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MainCalendarControl_DateChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.ScheduleTreeView, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.UseStandardTimeCheckbox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(273, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(531, 553);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // ScheduleTreeView
            // 
            this.ScheduleTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleTreeView.Enabled = false;
            this.ScheduleTreeView.Location = new System.Drawing.Point(0, 37);
            this.ScheduleTreeView.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ScheduleTreeView.Name = "ScheduleTreeView";
            this.ScheduleTreeView.Size = new System.Drawing.Size(526, 511);
            this.ScheduleTreeView.TabIndex = 1;
            // 
            // UseStandardTimeCheckbox
            // 
            this.UseStandardTimeCheckbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UseStandardTimeCheckbox.AutoSize = true;
            this.UseStandardTimeCheckbox.Enabled = false;
            this.UseStandardTimeCheckbox.Location = new System.Drawing.Point(15, 10);
            this.UseStandardTimeCheckbox.Margin = new System.Windows.Forms.Padding(15, 10, 3, 10);
            this.UseStandardTimeCheckbox.Name = "UseStandardTimeCheckbox";
            this.UseStandardTimeCheckbox.Size = new System.Drawing.Size(104, 17);
            this.UseStandardTimeCheckbox.TabIndex = 2;
            this.UseStandardTimeCheckbox.Text = "Standard Time?";
            this.UseStandardTimeCheckbox.UseVisualStyleBackColor = true;
            // 
            // PeopleTab
            // 
            this.PeopleTab.BackColor = System.Drawing.SystemColors.Control;
            this.PeopleTab.Location = new System.Drawing.Point(4, 21);
            this.PeopleTab.Margin = new System.Windows.Forms.Padding(0);
            this.PeopleTab.Name = "PeopleTab";
            this.PeopleTab.Size = new System.Drawing.Size(807, 554);
            this.PeopleTab.TabIndex = 2;
            this.PeopleTab.Text = "People";
            // 
            // CredentialsTLP
            // 
            this.CredentialsTLP.ColumnCount = 5;
            this.CredentialsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.CredentialsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CredentialsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CredentialsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.CredentialsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CredentialsTLP.Controls.Add(this.UsernameTextboxLabel, 0, 1);
            this.CredentialsTLP.Controls.Add(this.PasswordTextbox, 1, 2);
            this.CredentialsTLP.Controls.Add(this.UsernameTextbox, 1, 1);
            this.CredentialsTLP.Controls.Add(this.LoginButton, 3, 1);
            this.CredentialsTLP.Controls.Add(this.PasswordTextboxLabel, 0, 2);
            this.CredentialsTLP.Controls.Add(this.ErrorLabel, 2, 3);
            this.CredentialsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CredentialsTLP.Location = new System.Drawing.Point(0, 0);
            this.CredentialsTLP.Margin = new System.Windows.Forms.Padding(0);
            this.CredentialsTLP.Name = "CredentialsTLP";
            this.CredentialsTLP.RowCount = 4;
            this.CredentialsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CredentialsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CredentialsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CredentialsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CredentialsTLP.Size = new System.Drawing.Size(815, 100);
            this.CredentialsTLP.TabIndex = 7;
            // 
            // UsernameTextboxLabel
            // 
            this.UsernameTextboxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTextboxLabel.AutoSize = true;
            this.UsernameTextboxLabel.Location = new System.Drawing.Point(5, 26);
            this.UsernameTextboxLabel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.UsernameTextboxLabel.Name = "UsernameTextboxLabel";
            this.UsernameTextboxLabel.Size = new System.Drawing.Size(80, 13);
            this.UsernameTextboxLabel.TabIndex = 0;
            this.UsernameTextboxLabel.Text = "Username:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CredentialsTLP.SetColumnSpan(this.PasswordTextbox, 2);
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.Location = new System.Drawing.Point(85, 45);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(200, 23);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextbox_KeyDown);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CredentialsTLP.SetColumnSpan(this.UsernameTextbox, 2);
            this.UsernameTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.HideSelection = false;
            this.UsernameTextbox.Location = new System.Drawing.Point(85, 20);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(200, 23);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginButton.Location = new System.Drawing.Point(295, 26);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LoginButton.Name = "LoginButton";
            this.CredentialsTLP.SetRowSpan(this.LoginButton, 2);
            this.LoginButton.Size = new System.Drawing.Size(100, 35);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.TabStop = false;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextboxLabel
            // 
            this.PasswordTextboxLabel.AutoSize = true;
            this.PasswordTextboxLabel.Location = new System.Drawing.Point(5, 49);
            this.PasswordTextboxLabel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.PasswordTextboxLabel.Name = "PasswordTextboxLabel";
            this.PasswordTextboxLabel.Size = new System.Drawing.Size(59, 13);
            this.PasswordTextboxLabel.TabIndex = 10;
            this.PasswordTextboxLabel.Text = "Password:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(195, 77);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(80, 13);
            this.ErrorLabel.TabIndex = 9;
            // 
            // AdminPermTab
            // 
            this.AdminPermTab.Location = new System.Drawing.Point(4, 21);
            this.AdminPermTab.Margin = new System.Windows.Forms.Padding(0);
            this.AdminPermTab.Name = "AdminPermTab";
            this.AdminPermTab.Size = new System.Drawing.Size(815, 684);
            this.AdminPermTab.TabIndex = 1;
            this.AdminPermTab.Text = "Admin Permissions";
            this.AdminPermTab.UseVisualStyleBackColor = true;
            // 
            // SaveAttachmentSFD
            // 
            this.SaveAttachmentSFD.SupportMultiDottedExtensions = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 709);
            this.Controls.Add(this.ContentTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainForm";
            this.Text = "Developer Messaging Support App";
            this.ContentTabControl.ResumeLayout(false);
            this.DelegatePermTab.ResumeLayout(false);
            this.DelegateTLP.ResumeLayout(false);
            this.DelegateTabControl.ResumeLayout(false);
            this.EmailTab.ResumeLayout(false);
            this.MailTLP.ResumeLayout(false);
            this.FolderViewTLP.ResumeLayout(false);
            this.FolderViewTLP.PerformLayout();
            this.FolderViewListContextMenu.ResumeLayout(false);
            this.MessageTLP.ResumeLayout(false);
            this.MessageTLP.PerformLayout();
            this.AttachmentContextMenu.ResumeLayout(false);
            this.CalendarTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.CredentialsTLP.ResumeLayout(false);
            this.CredentialsTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ContentTabControl;
        private System.Windows.Forms.TabPage DelegatePermTab;
        private System.Windows.Forms.TabPage AdminPermTab;
        private System.Windows.Forms.Label UsernameTextboxLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TabControl DelegateTabControl;
        private System.Windows.Forms.TabPage EmailTab;
        private System.Windows.Forms.TabPage CalendarTab;
        private System.Windows.Forms.TabPage PeopleTab;
        private System.Windows.Forms.TextBox FolderNameTextbox;
        private System.Windows.Forms.Label FolderNameTextboxLabel;
        private System.Windows.Forms.ListBox FolderViewListbox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button ReplyButton;
        private System.Windows.Forms.TextBox MessageSubjectTextbox;
        private System.Windows.Forms.TextBox MessageBCCTextbox;
        private System.Windows.Forms.TextBox MessageCCTextbox;
        private System.Windows.Forms.Label MessageSubjectLabel;
        private System.Windows.Forms.TextBox MessageBodyTextbox;
        private System.Windows.Forms.Label MessageWhenLabel;
        private System.Windows.Forms.Label MessageBCCLabel;
        private System.Windows.Forms.Label MessageCCLabel;
        private System.Windows.Forms.Label MessageToLabel;
        private System.Windows.Forms.Label MessageFromLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button MailFolderGoButton;
        private System.Windows.Forms.ContextMenuStrip FolderViewListContextMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyMessageIDMenuItem;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TableLayoutPanel DelegateTLP;
        private System.Windows.Forms.TableLayoutPanel CredentialsTLP;
        private System.Windows.Forms.Label PasswordTextboxLabel;
        private System.Windows.Forms.TableLayoutPanel MailTLP;
        private System.Windows.Forms.TableLayoutPanel FolderViewTLP;
        private System.Windows.Forms.TableLayoutPanel MessageTLP;
        private System.Windows.Forms.TextBox MessageWhenTextbox;
        private System.Windows.Forms.SaveFileDialog SaveAttachmentSFD;
        private System.Windows.Forms.Label AttachedLabel;
        private System.Windows.Forms.ListBox AttachmentsListbox;
        private System.Windows.Forms.ContextMenuStrip AttachmentContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveAttachmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AttachFileMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenAttachmentOFD;
        private System.Windows.Forms.TextBox MessageSenderTextbox;
        private System.Windows.Forms.TextBox MessageRecipientsTextbox;
        private System.Windows.Forms.ToolStripMenuItem RemoveAttachmentMenuItem;
        private System.Windows.Forms.TreeView ScheduleTreeView;
        private System.Windows.Forms.MonthCalendar MainCalendarControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox UseStandardTimeCheckbox;
    }
}

