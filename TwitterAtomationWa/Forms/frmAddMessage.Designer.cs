namespace TwitterAtomationWa
{
    partial class frmAddMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "en")]
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
            this.gboxMessage = new System.Windows.Forms.GroupBox();
            this.lblLoadMessagefromFile = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoRandomSelect = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nUNumber = new System.Windows.Forms.NumericUpDown();
            this.lblSelectFile = new System.Windows.Forms.LinkLabel();
            this.lblSelectUsers = new System.Windows.Forms.LinkLabel();
            this.rdoThisUsers = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.llSelectUsers = new System.Windows.Forms.LinkLabel();
            this.rdoAccountForUser = new System.Windows.Forms.RadioButton();
            this.txtUsers = new System.Windows.Forms.TextBox();
            this.rdoallAccount = new System.Windows.Forms.RadioButton();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSendNow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SsWaiting = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.gboxMessage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUNumber)).BeginInit();
            this.SsWaiting.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxMessage
            // 
            this.gboxMessage.Controls.Add(this.lblLoadMessagefromFile);
            this.gboxMessage.Controls.Add(this.groupBox1);
            this.gboxMessage.Controls.Add(this.txtMessage);
            this.gboxMessage.Controls.Add(this.lblMessage);
            this.gboxMessage.Location = new System.Drawing.Point(12, 12);
            this.gboxMessage.Name = "gboxMessage";
            this.gboxMessage.Size = new System.Drawing.Size(434, 348);
            this.gboxMessage.TabIndex = 0;
            this.gboxMessage.TabStop = false;
            this.gboxMessage.Text = "Add New Message";
            // 
            // lblLoadMessagefromFile
            // 
            this.lblLoadMessagefromFile.AutoSize = true;
            this.lblLoadMessagefromFile.Location = new System.Drawing.Point(391, 29);
            this.lblLoadMessagefromFile.Name = "lblLoadMessagefromFile";
            this.lblLoadMessagefromFile.Size = new System.Drawing.Size(31, 13);
            this.lblLoadMessagefromFile.TabIndex = 5;
            this.lblLoadMessagefromFile.TabStop = true;
            this.lblLoadMessagefromFile.Text = "Load";
            this.lblLoadMessagefromFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.llSelectUsers);
            this.groupBox1.Controls.Add(this.rdoAccountForUser);
            this.groupBox1.Controls.Add(this.txtUsers);
            this.groupBox1.Controls.Add(this.rdoallAccount);
            this.groupBox1.Location = new System.Drawing.Point(24, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recivers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoRandomSelect);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nUNumber);
            this.groupBox2.Controls.Add(this.lblSelectFile);
            this.groupBox2.Controls.Add(this.lblSelectUsers);
            this.groupBox2.Controls.Add(this.rdoThisUsers);
            this.groupBox2.Controls.Add(this.rdoAll);
            this.groupBox2.Location = new System.Drawing.Point(11, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reciver Users";
            // 
            // rdoRandomSelect
            // 
            this.rdoRandomSelect.AutoSize = true;
            this.rdoRandomSelect.Location = new System.Drawing.Point(20, 56);
            this.rdoRandomSelect.Name = "rdoRandomSelect";
            this.rdoRandomSelect.Size = new System.Drawing.Size(117, 17);
            this.rdoRandomSelect.TabIndex = 7;
            this.rdoRandomSelect.Text = "Randomly Send To";
            this.rdoRandomSelect.UseVisualStyleBackColor = true;
            this.rdoRandomSelect.CheckedChanged += new System.EventHandler(this.rdoRandomSelect_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "followers of each account";
            // 
            // nUNumber
            // 
            this.nUNumber.Enabled = false;
            this.nUNumber.Location = new System.Drawing.Point(141, 53);
            this.nUNumber.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.nUNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUNumber.Name = "nUNumber";
            this.nUNumber.Size = new System.Drawing.Size(56, 20);
            this.nUNumber.TabIndex = 5;
            this.nUNumber.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Enabled = false;
            this.lblSelectFile.Location = new System.Drawing.Point(262, 21);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(106, 13);
            this.lblSelectFile.TabIndex = 3;
            this.lblSelectFile.TabStop = true;
            this.lblSelectFile.Text = "Select From Text File";
            this.lblSelectFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelectFile_LinkClicked);
            // 
            // lblSelectUsers
            // 
            this.lblSelectUsers.AutoSize = true;
            this.lblSelectUsers.Enabled = false;
            this.lblSelectUsers.Location = new System.Drawing.Point(172, 21);
            this.lblSelectUsers.Name = "lblSelectUsers";
            this.lblSelectUsers.Size = new System.Drawing.Size(84, 13);
            this.lblSelectUsers.TabIndex = 2;
            this.lblSelectUsers.TabStop = true;
            this.lblSelectUsers.Text = "Select Followers";
            this.lblSelectUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelectUsers_LinkClicked);
            // 
            // rdoThisUsers
            // 
            this.rdoThisUsers.AutoSize = true;
            this.rdoThisUsers.Location = new System.Drawing.Point(89, 19);
            this.rdoThisUsers.Name = "rdoThisUsers";
            this.rdoThisUsers.Size = new System.Drawing.Size(75, 17);
            this.rdoThisUsers.TabIndex = 0;
            this.rdoThisUsers.Text = "This Users";
            this.rdoThisUsers.UseVisualStyleBackColor = true;
            this.rdoThisUsers.CheckedChanged += new System.EventHandler(this.rdoThisUsers_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Checked = true;
            this.rdoAll.Location = new System.Drawing.Point(20, 19);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(61, 17);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All User";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // llSelectUsers
            // 
            this.llSelectUsers.AutoSize = true;
            this.llSelectUsers.Enabled = false;
            this.llSelectUsers.Location = new System.Drawing.Point(334, 50);
            this.llSelectUsers.Name = "llSelectUsers";
            this.llSelectUsers.Size = new System.Drawing.Size(37, 13);
            this.llSelectUsers.TabIndex = 2;
            this.llSelectUsers.TabStop = true;
            this.llSelectUsers.Text = "Select";
            this.llSelectUsers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSelectUsers_LinkClicked);
            // 
            // rdoAccountForUser
            // 
            this.rdoAccountForUser.AutoSize = true;
            this.rdoAccountForUser.Location = new System.Drawing.Point(11, 48);
            this.rdoAccountForUser.Name = "rdoAccountForUser";
            this.rdoAccountForUser.Size = new System.Drawing.Size(317, 17);
            this.rdoAccountForUser.TabIndex = 1;
            this.rdoAccountForUser.Text = "Follower of Account listed below(Name Sepated With Comma)";
            this.rdoAccountForUser.UseVisualStyleBackColor = true;
            this.rdoAccountForUser.CheckedChanged += new System.EventHandler(this.rdoAccountForUser_CheckedChanged);
            // 
            // txtUsers
            // 
            this.txtUsers.Enabled = false;
            this.txtUsers.Location = new System.Drawing.Point(31, 71);
            this.txtUsers.Multiline = true;
            this.txtUsers.Name = "txtUsers";
            this.txtUsers.Size = new System.Drawing.Size(340, 49);
            this.txtUsers.TabIndex = 3;
            this.txtUsers.TextChanged += new System.EventHandler(this.txtUsers_TextChanged);
            // 
            // rdoallAccount
            // 
            this.rdoallAccount.AutoSize = true;
            this.rdoallAccount.Checked = true;
            this.rdoallAccount.Location = new System.Drawing.Point(11, 25);
            this.rdoallAccount.Name = "rdoallAccount";
            this.rdoallAccount.Size = new System.Drawing.Size(154, 17);
            this.rdoallAccount.TabIndex = 0;
            this.rdoallAccount.TabStop = true;
            this.rdoallAccount.Text = "All Follower Of All Accounts";
            this.rdoallAccount.UseVisualStyleBackColor = true;
            this.rdoallAccount.CheckedChanged += new System.EventHandler(this.allAccount_CheckedChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(102, 29);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(287, 69);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtUsers_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(21, 29);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(77, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message Text:";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(297, 366);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Message";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSendNow
            // 
            this.btnSendNow.Enabled = false;
            this.btnSendNow.Location = new System.Drawing.Point(172, 366);
            this.btnSendNow.Name = "btnSendNow";
            this.btnSendNow.Size = new System.Drawing.Size(119, 23);
            this.btnSendNow.TabIndex = 2;
            this.btnSendNow.Text = "StartSending Now";
            this.btnSendNow.UseVisualStyleBackColor = true;
            this.btnSendNow.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(47, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SsWaiting
            // 
            this.SsWaiting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.SsWaiting.Location = new System.Drawing.Point(0, 403);
            this.SsWaiting.Name = "SsWaiting";
            this.SsWaiting.Size = new System.Drawing.Size(456, 22);
            this.SsWaiting.TabIndex = 4;
            this.SsWaiting.Text = "statusStrip1";
            this.SsWaiting.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel1.Text = "Working Please Wait ...";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // frmAddMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(456, 425);
            this.Controls.Add(this.SsWaiting);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSendNow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboxMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Message";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddMessage_FormClosing);
            this.Load += new System.EventHandler(this.frmAddMessage_Load);
            this.gboxMessage.ResumeLayout(false);
            this.gboxMessage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUNumber)).EndInit();
            this.SsWaiting.ResumeLayout(false);
            this.SsWaiting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSendNow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel llSelectUsers;
        private System.Windows.Forms.RadioButton rdoAccountForUser;
        private System.Windows.Forms.TextBox txtUsers;
        private System.Windows.Forms.RadioButton rdoallAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lblSelectFile;
        private System.Windows.Forms.LinkLabel lblSelectUsers;
        private System.Windows.Forms.RadioButton rdoThisUsers;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.NumericUpDown nUNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rdoRandomSelect;
        private System.Windows.Forms.LinkLabel lblLoadMessagefromFile;
        private System.Windows.Forms.StatusStrip SsWaiting;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}