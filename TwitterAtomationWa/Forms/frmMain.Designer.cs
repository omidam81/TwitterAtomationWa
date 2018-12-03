namespace TwitterAtomationWa
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "db")]
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.messageGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearlog = new System.Windows.Forms.LinkLabel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnProxies = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAddMessage = new System.Windows.Forms.ToolStripButton();
            this.tsDeleteMessage = new System.Windows.Forms.ToolStripButton();
            this.tsImportMessage = new System.Windows.Forms.ToolStripButton();
            this.tsRemoveall = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnSetting = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nmSecondTo = new System.Windows.Forms.NumericUpDown();
            this.nmSecondFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SenderTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSettings = new System.Windows.Forms.Button();
            this.sTimer = new System.Windows.Forms.Timer(this.components);
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnWebSetting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.messageGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecondTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecondFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // messageGridView
            // 
            this.messageGridView.AllowUserToAddRows = false;
            this.messageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.messageGridView.Location = new System.Drawing.Point(3, 55);
            this.messageGridView.Name = "messageGridView";
            this.messageGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.messageGridView.Size = new System.Drawing.Size(602, 273);
            this.messageGridView.TabIndex = 1;
            this.messageGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.messageGridView.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.messageGridView_ColumnAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearlog);
            this.groupBox1.Controls.Add(this.txtLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(811, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log View";
            // 
            // btnClearlog
            // 
            this.btnClearlog.AutoSize = true;
            this.btnClearlog.Location = new System.Drawing.Point(734, 128);
            this.btnClearlog.Name = "btnClearlog";
            this.btnClearlog.Size = new System.Drawing.Size(66, 13);
            this.btnClearlog.TabIndex = 1;
            this.btnClearlog.TabStop = true;
            this.btnClearlog.Text = "Clear the log";
            this.btnClearlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnClearlog_LinkClicked);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLog.Location = new System.Drawing.Point(6, 19);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(799, 106);
            this.txtLog.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(626, 21);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(197, 37);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Users Management";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnProxies
            // 
            this.btnProxies.Location = new System.Drawing.Point(626, 64);
            this.btnProxies.Name = "btnProxies";
            this.btnProxies.Size = new System.Drawing.Size(197, 37);
            this.btnProxies.TabIndex = 3;
            this.btnProxies.Text = "Proxies Management";
            this.btnProxies.UseVisualStyleBackColor = true;
            this.btnProxies.Click += new System.EventHandler(this.btnProxies_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.messageGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 331);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Messages";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddMessage,
            this.tsDeleteMessage,
            this.tsImportMessage,
            this.tsRemoveall,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(602, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAddMessage
            // 
            this.tsAddMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddMessage.Image = global::TwitterAtomationWa.Properties.Resources._1355709906_Add;
            this.tsAddMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddMessage.Name = "tsAddMessage";
            this.tsAddMessage.Size = new System.Drawing.Size(23, 22);
            this.tsAddMessage.Text = "toolStripButton1";
            this.tsAddMessage.ToolTipText = "Add Message";
            this.tsAddMessage.Click += new System.EventHandler(this.tsAddMessage_Click);
            // 
            // tsDeleteMessage
            // 
            this.tsDeleteMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteMessage.Image = global::TwitterAtomationWa.Properties.Resources._1355709913_Delete;
            this.tsDeleteMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteMessage.Name = "tsDeleteMessage";
            this.tsDeleteMessage.Size = new System.Drawing.Size(23, 22);
            this.tsDeleteMessage.Text = "toolStripButton2";
            this.tsDeleteMessage.ToolTipText = "Delete Message";
            this.tsDeleteMessage.Click += new System.EventHandler(this.tsDeleteMessage_Click);
            // 
            // tsImportMessage
            // 
            this.tsImportMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsImportMessage.Image = ((System.Drawing.Image)(resources.GetObject("tsImportMessage.Image")));
            this.tsImportMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsImportMessage.Name = "tsImportMessage";
            this.tsImportMessage.Size = new System.Drawing.Size(23, 22);
            this.tsImportMessage.Text = "Import Message";
            this.tsImportMessage.Click += new System.EventHandler(this.tsImportMessage_Click);
            // 
            // tsRemoveall
            // 
            this.tsRemoveall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRemoveall.Image = global::TwitterAtomationWa.Properties.Resources._1362732071_file_delete;
            this.tsRemoveall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemoveall.Name = "tsRemoveall";
            this.tsRemoveall.Size = new System.Drawing.Size(23, 22);
            this.tsRemoveall.Text = "Remove all duplicated message";
            this.tsRemoveall.Click += new System.EventHandler(this.tsRemoveall_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::TwitterAtomationWa.Properties.Resources._1359543739_DeleteRed;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Remove Duplicated Recivers";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(626, 107);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(197, 37);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Application Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nmSecondTo);
            this.groupBox3.Controls.Add(this.nmSecondFrom);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnPause);
            this.groupBox3.Controls.Add(this.btnPlay);
            this.groupBox3.Location = new System.Drawing.Point(626, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 100);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sending Control";
            // 
            // nmSecondTo
            // 
            this.nmSecondTo.Location = new System.Drawing.Point(99, 70);
            this.nmSecondTo.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nmSecondTo.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmSecondTo.Name = "nmSecondTo";
            this.nmSecondTo.Size = new System.Drawing.Size(45, 20);
            this.nmSecondTo.TabIndex = 3;
            this.nmSecondTo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmSecondTo.ValueChanged += new System.EventHandler(this.nmSecond_ValueChanged);
            // 
            // nmSecondFrom
            // 
            this.nmSecondFrom.Location = new System.Drawing.Point(42, 70);
            this.nmSecondFrom.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nmSecondFrom.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmSecondFrom.Name = "nmSecondFrom";
            this.nmSecondFrom.Size = new System.Drawing.Size(45, 20);
            this.nmSecondFrom.TabIndex = 3;
            this.nmSecondFrom.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmSecondFrom.ValueChanged += new System.EventHandler(this.nmSecond_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delay";
            // 
            // btnPause
            // 
            this.btnPause.AutoSize = true;
            this.btnPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPause.Enabled = false;
            this.btnPause.Image = global::TwitterAtomationWa.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(9, 19);
            this.btnPause.Name = "btnPause";
            this.btnPause.Padding = new System.Windows.Forms.Padding(4);
            this.btnPause.Size = new System.Drawing.Size(46, 46);
            this.btnPause.TabIndex = 0;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlay.Image = global::TwitterAtomationWa.Properties.Resources.start;
            this.btnPlay.Location = new System.Drawing.Point(61, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Padding = new System.Windows.Forms.Padding(4);
            this.btnPlay.Size = new System.Drawing.Size(46, 46);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // SenderTimer
            // 
            this.SenderTimer.Interval = 3000;
            this.SenderTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(626, 150);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(197, 37);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Twitter Setting";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // sTimer
            // 
            this.sTimer.Enabled = true;
            this.sTimer.Interval = 60000;
            this.sTimer.Tick += new System.EventHandler(this.sTimer_Tick);
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataSource = typeof(TwitterAtomationWa.Message);
            // 
            // dataEntitiesBindingSource
            // 
            this.dataEntitiesBindingSource.DataSource = typeof(TwitterAtomationWa.DataEntities);
            // 
            // btnWebSetting
            // 
            this.btnWebSetting.Location = new System.Drawing.Point(626, 193);
            this.btnWebSetting.Name = "btnWebSetting";
            this.btnWebSetting.Size = new System.Drawing.Size(197, 37);
            this.btnWebSetting.TabIndex = 6;
            this.btnWebSetting.Text = "Web Setting";
            this.btnWebSetting.UseVisualStyleBackColor = true;
            this.btnWebSetting.Click += new System.EventHandler(this.btnWebSetting_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 506);
            this.Controls.Add(this.btnWebSetting);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnProxies);
            this.Controls.Add(this.btnUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitter Automation ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecondTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecondFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView messageGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnProxies;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsDeleteMessage;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private System.Windows.Forms.BindingSource dataEntitiesBindingSource;
        private System.Windows.Forms.Timer SenderTimer;
        private System.Windows.Forms.ToolStripButton tsAddMessage;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.NumericUpDown nmSecondTo;
        private System.Windows.Forms.NumericUpDown nmSecondFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tsImportMessage;
        private System.Windows.Forms.LinkLabel btnClearlog;
        private System.Windows.Forms.Timer sTimer;
        private System.Windows.Forms.ToolStripButton tsRemoveall;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btnWebSetting;
    }
}

