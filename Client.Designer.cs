namespace AwesomeEmail
{
    partial class Client
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
            this.EmailTab = new System.Windows.Forms.TabControl();
            this.Inbox = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.attachmentPanel = new System.Windows.Forms.Panel();
            this.listAttachments = new System.Windows.Forms.TreeView();
            this.labelAttachments = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.useSslCheckBox = new System.Windows.Forms.CheckBox();
            this.listMessages = new System.Windows.Forms.TreeView();
            this.totalMessagesTextBox = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SendMail = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Send = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.MailMessage = new System.Windows.Forms.RichTextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Bcc = new System.Windows.Forms.TextBox();
            this.Cc = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.connectAndRetrieveButton = new System.Windows.Forms.Button();
            this.EmailTab.SuspendLayout();
            this.Inbox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.attachmentPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SendMail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmailTab
            // 
            this.EmailTab.Controls.Add(this.Inbox);
            this.EmailTab.Controls.Add(this.SendMail);
            this.EmailTab.Location = new System.Drawing.Point(12, 12);
            this.EmailTab.Name = "EmailTab";
            this.EmailTab.SelectedIndex = 0;
            this.EmailTab.Size = new System.Drawing.Size(1059, 656);
            this.EmailTab.TabIndex = 5;
            // 
            // Inbox
            // 
            this.Inbox.Controls.Add(this.groupBox3);
            this.Inbox.Controls.Add(this.groupBox2);
            this.Inbox.Location = new System.Drawing.Point(4, 22);
            this.Inbox.Name = "Inbox";
            this.Inbox.Padding = new System.Windows.Forms.Padding(3);
            this.Inbox.Size = new System.Drawing.Size(1051, 630);
            this.Inbox.TabIndex = 0;
            this.Inbox.Text = "Inbox";
            this.Inbox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.attachmentPanel);
            this.groupBox3.Controls.Add(this.messageTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Silver;
            this.groupBox3.Location = new System.Drawing.Point(523, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(522, 604);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected Message";
            // 
            // attachmentPanel
            // 
            this.attachmentPanel.Controls.Add(this.listAttachments);
            this.attachmentPanel.Controls.Add(this.labelAttachments);
            this.attachmentPanel.Location = new System.Drawing.Point(9, 435);
            this.attachmentPanel.Name = "attachmentPanel";
            this.attachmentPanel.Size = new System.Drawing.Size(507, 160);
            this.attachmentPanel.TabIndex = 11;
            this.attachmentPanel.Visible = false;
            // 
            // listAttachments
            // 
            this.listAttachments.Location = new System.Drawing.Point(8, 24);
            this.listAttachments.Name = "listAttachments";
            this.listAttachments.ShowLines = false;
            this.listAttachments.ShowRootLines = false;
            this.listAttachments.Size = new System.Drawing.Size(496, 117);
            this.listAttachments.TabIndex = 10;
            // 
            // labelAttachments
            // 
            this.labelAttachments.Location = new System.Drawing.Point(12, 8);
            this.labelAttachments.Name = "labelAttachments";
            this.labelAttachments.Size = new System.Drawing.Size(136, 16);
            this.labelAttachments.TabIndex = 3;
            this.labelAttachments.Text = "Attachments";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Location = new System.Drawing.Point(9, 21);
            this.messageTextBox.MaxLength = 999999999;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageTextBox.Size = new System.Drawing.Size(507, 408);
            this.messageTextBox.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.connectAndRetrieveButton);
            this.groupBox2.Controls.Add(this.useSslCheckBox);
            this.groupBox2.Controls.Add(this.listMessages);
            this.groupBox2.Controls.Add(this.totalMessagesTextBox);
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Silver;
            this.groupBox2.Location = new System.Drawing.Point(27, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 601);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inbox";
            // 
            // useSslCheckBox
            // 
            this.useSslCheckBox.AutoSize = true;
            this.useSslCheckBox.Checked = true;
            this.useSslCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useSslCheckBox.Location = new System.Drawing.Point(6, 556);
            this.useSslCheckBox.Name = "useSslCheckBox";
            this.useSslCheckBox.Size = new System.Drawing.Size(87, 20);
            this.useSslCheckBox.TabIndex = 14;
            this.useSslCheckBox.Text = "Use SSL";
            this.useSslCheckBox.UseVisualStyleBackColor = true;
            // 
            // listMessages
            // 
            this.listMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMessages.Location = new System.Drawing.Point(0, 21);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(490, 507);
            this.listMessages.TabIndex = 13;
            this.listMessages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.listMessages_AfterSelect);
            // 
            // totalMessagesTextBox
            // 
            this.totalMessagesTextBox.Location = new System.Drawing.Point(0, 579);
            this.totalMessagesTextBox.Name = "totalMessagesTextBox";
            this.totalMessagesTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalMessagesTextBox.TabIndex = 12;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(6, 534);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(478, 12);
            this.progressBar.TabIndex = 11;
            // 
            // SendMail
            // 
            this.SendMail.Controls.Add(this.groupBox1);
            this.SendMail.Location = new System.Drawing.Point(4, 22);
            this.SendMail.Name = "SendMail";
            this.SendMail.Padding = new System.Windows.Forms.Padding(3);
            this.SendMail.Size = new System.Drawing.Size(1051, 630);
            this.SendMail.TabIndex = 1;
            this.SendMail.Text = "Send Mail";
            this.SendMail.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Send);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.MailMessage);
            this.groupBox1.Controls.Add(this.Subject);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Bcc);
            this.groupBox1.Controls.Add(this.Cc);
            this.groupBox1.Controls.Add(this.To);
            this.groupBox1.Controls.Add(this.From);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(18, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 594);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Mail Message";
            // 
            // Send
            // 
            this.Send.ForeColor = System.Drawing.Color.Black;
            this.Send.Location = new System.Drawing.Point(793, 485);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 16;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(9, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Message :";
            // 
            // MailMessage
            // 
            this.MailMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailMessage.Location = new System.Drawing.Point(89, 120);
            this.MailMessage.Name = "MailMessage";
            this.MailMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.MailMessage.Size = new System.Drawing.Size(779, 359);
            this.MailMessage.TabIndex = 14;
            this.MailMessage.Text = "";
            // 
            // Subject
            // 
            this.Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.Location = new System.Drawing.Point(87, 78);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(206, 21);
            this.Subject.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(9, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Subject :";
            // 
            // Bcc
            // 
            this.Bcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcc.Location = new System.Drawing.Point(368, 51);
            this.Bcc.Name = "Bcc";
            this.Bcc.Size = new System.Drawing.Size(206, 21);
            this.Bcc.TabIndex = 7;
            // 
            // Cc
            // 
            this.Cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cc.Location = new System.Drawing.Point(87, 51);
            this.Cc.Name = "Cc";
            this.Cc.Size = new System.Drawing.Size(206, 21);
            this.Cc.TabIndex = 6;
            // 
            // To
            // 
            this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To.Location = new System.Drawing.Point(368, 24);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(206, 21);
            this.To.TabIndex = 5;
            // 
            // From
            // 
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.Location = new System.Drawing.Point(87, 24);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(206, 21);
            this.From.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(309, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Bcc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(16, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cc :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(309, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "To :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(16, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "From :";
            // 
            // connectAndRetrieveButton
            // 
            this.connectAndRetrieveButton.Location = new System.Drawing.Point(403, 557);
            this.connectAndRetrieveButton.Name = "connectAndRetrieveButton";
            this.connectAndRetrieveButton.Size = new System.Drawing.Size(82, 39);
            this.connectAndRetrieveButton.TabIndex = 15;
            this.connectAndRetrieveButton.Text = "Get Mail";
            this.connectAndRetrieveButton.Click += new System.EventHandler(this.connectAndRetrieveButton_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 680);
            this.Controls.Add(this.EmailTab);
            this.Name = "Client";
            this.Text = "Awesome Email";
            this.EmailTab.ResumeLayout(false);
            this.Inbox.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.attachmentPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SendMail.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EmailTab;
        private System.Windows.Forms.TabPage Inbox;
        private System.Windows.Forms.TabPage SendMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox MailMessage;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Bcc;
        private System.Windows.Forms.TextBox Cc;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox From;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox totalMessagesTextBox;
        private System.Windows.Forms.CheckBox useSslCheckBox;
        private System.Windows.Forms.TreeView listMessages;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel attachmentPanel;
        private System.Windows.Forms.TreeView listAttachments;
        private System.Windows.Forms.Label labelAttachments;
        private System.Windows.Forms.Button connectAndRetrieveButton;



    }
}