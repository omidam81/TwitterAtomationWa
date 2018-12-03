namespace TwitterAtomationWa
{
    partial class frmTwitterSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkInterValTime = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAutostart = new System.Windows.Forms.CheckBox();
            this.Tm = new System.Windows.Forms.NumericUpDown();
            this.Th = new System.Windows.Forms.NumericUpDown();
            this.Fm = new System.Windows.Forms.NumericUpDown();
            this.Fh = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDontSendReplicated = new System.Windows.Forms.CheckBox();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.nUMessageCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkUseCentraldatabase = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMessageCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUseCentraldatabase);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.chkInterValTime);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkDontSendReplicated);
            this.groupBox1.Controls.Add(this.chkUseProxy);
            this.groupBox1.Controls.Add(this.nUMessageCount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sending Message Setting";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(141, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // chkInterValTime
            // 
            this.chkInterValTime.AutoSize = true;
            this.chkInterValTime.Location = new System.Drawing.Point(26, 157);
            this.chkInterValTime.Name = "chkInterValTime";
            this.chkInterValTime.Size = new System.Drawing.Size(108, 17);
            this.chkInterValTime.TabIndex = 0;
            this.chkInterValTime.Text = "User Interval time";
            this.chkInterValTime.UseVisualStyleBackColor = true;
            this.chkInterValTime.CheckedChanged += new System.EventHandler(this.chkInterValTime_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAutostart);
            this.groupBox2.Controls.Add(this.Tm);
            this.groupBox2.Controls.Add(this.Th);
            this.groupBox2.Controls.Add(this.Fm);
            this.groupBox2.Controls.Add(this.Fh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(19, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // chkAutostart
            // 
            this.chkAutostart.AutoSize = true;
            this.chkAutostart.Location = new System.Drawing.Point(163, 42);
            this.chkAutostart.Name = "chkAutostart";
            this.chkAutostart.Size = new System.Drawing.Size(71, 17);
            this.chkAutostart.TabIndex = 3;
            this.chkAutostart.Text = "Auto start";
            this.chkAutostart.UseVisualStyleBackColor = true;
            // 
            // Tm
            // 
            this.Tm.Location = new System.Drawing.Point(102, 59);
            this.Tm.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Tm.Name = "Tm";
            this.Tm.Size = new System.Drawing.Size(35, 20);
            this.Tm.TabIndex = 2;
            // 
            // Th
            // 
            this.Th.Location = new System.Drawing.Point(61, 59);
            this.Th.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Th.Name = "Th";
            this.Th.Size = new System.Drawing.Size(35, 20);
            this.Th.TabIndex = 2;
            this.Th.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // Fm
            // 
            this.Fm.Location = new System.Drawing.Point(102, 23);
            this.Fm.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Fm.Name = "Fm";
            this.Fm.Size = new System.Drawing.Size(35, 20);
            this.Fm.TabIndex = 2;
            // 
            // Fh
            // 
            this.Fh.Location = new System.Drawing.Point(61, 23);
            this.Fh.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Fh.Name = "Fh";
            this.Fh.Size = new System.Drawing.Size(35, 20);
            this.Fh.TabIndex = 2;
            this.Fh.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // chkDontSendReplicated
            // 
            this.chkDontSendReplicated.AutoSize = true;
            this.chkDontSendReplicated.Location = new System.Drawing.Point(26, 76);
            this.chkDontSendReplicated.Name = "chkDontSendReplicated";
            this.chkDontSendReplicated.Size = new System.Drawing.Size(242, 17);
            this.chkDontSendReplicated.TabIndex = 2;
            this.chkDontSendReplicated.Text = "Don\'t Send Message To Replicated Followers";
            this.chkDontSendReplicated.UseVisualStyleBackColor = true;
            this.chkDontSendReplicated.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.AutoSize = true;
            this.chkUseProxy.Location = new System.Drawing.Point(26, 53);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(161, 17);
            this.chkUseProxy.TabIndex = 2;
            this.chkUseProxy.Text = "User Proxy to send Message";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // nUMessageCount
            // 
            this.nUMessageCount.Location = new System.Drawing.Point(182, 19);
            this.nUMessageCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUMessageCount.Name = "nUMessageCount";
            this.nUMessageCount.Size = new System.Drawing.Size(62, 20);
            this.nUMessageCount.TabIndex = 1;
            this.nUMessageCount.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Message Retry Count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Message count per hour:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(152, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Setting";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkUseCentraldatabase
            // 
            this.chkUseCentraldatabase.AutoSize = true;
            this.chkUseCentraldatabase.Location = new System.Drawing.Point(26, 99);
            this.chkUseCentraldatabase.Name = "chkUseCentraldatabase";
            this.chkUseCentraldatabase.Size = new System.Drawing.Size(130, 17);
            this.chkUseCentraldatabase.TabIndex = 5;
            this.chkUseCentraldatabase.Text = "Use Central Database";
            this.chkUseCentraldatabase.UseVisualStyleBackColor = true;
            // 
            // frmTwitterSetting
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(357, 310);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTwitterSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.frmTwitterSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Th)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMessageCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.NumericUpDown nUMessageCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkDontSendReplicated;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAutostart;
        private System.Windows.Forms.NumericUpDown Tm;
        private System.Windows.Forms.NumericUpDown Th;
        private System.Windows.Forms.NumericUpDown Fm;
        private System.Windows.Forms.NumericUpDown Fh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkInterValTime;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkUseCentraldatabase;
    }
}