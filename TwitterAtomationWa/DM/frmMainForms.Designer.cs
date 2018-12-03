namespace TwitterAtomationWa.DM
{
    partial class frmMainForms
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAddAccount = new System.Windows.Forms.ToolStripButton();
            this.tsNewMessage = new System.Windows.Forms.ToolStripButton();
            this.tsSetting = new System.Windows.Forms.ToolStripButton();
            this.tsProxyButton = new System.Windows.Forms.ToolStripButton();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsAccount = new System.Windows.Forms.ListBox();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new TwitterAtomationWa.DataDataSet();
            this.lsMessage = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountTableAdapter = new TwitterAtomationWa.DataDataSetTableAdapters.AccountTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddAccount,
            this.tsNewMessage,
            this.tsSetting,
            this.tsProxyButton,
            this.tsRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(764, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAddAccount
            // 
            this.tsAddAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddAccount.Image = global::TwitterAtomationWa.Properties.Resources._1355709906_Add;
            this.tsAddAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddAccount.Name = "tsAddAccount";
            this.tsAddAccount.Size = new System.Drawing.Size(23, 22);
            this.tsAddAccount.Text = "Add Account";
            this.tsAddAccount.Click += new System.EventHandler(this.tsAddAccount_Click);
            // 
            // tsNewMessage
            // 
            this.tsNewMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNewMessage.Image = global::TwitterAtomationWa.Properties.Resources.new_message;
            this.tsNewMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNewMessage.Name = "tsNewMessage";
            this.tsNewMessage.Size = new System.Drawing.Size(23, 22);
            this.tsNewMessage.Text = "New Message";
            // 
            // tsSetting
            // 
            this.tsSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSetting.Image = global::TwitterAtomationWa.Properties.Resources._1359306214_setting;
            this.tsSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSetting.Name = "tsSetting";
            this.tsSetting.Size = new System.Drawing.Size(23, 22);
            this.tsSetting.Text = "Twitter Setting";
            this.tsSetting.Click += new System.EventHandler(this.tsSetting_Click);
            // 
            // tsProxyButton
            // 
            this.tsProxyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsProxyButton.Image = global::TwitterAtomationWa.Properties.Resources._1359501520_preferences_system_network_proxy;
            this.tsProxyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProxyButton.Name = "tsProxyButton";
            this.tsProxyButton.Size = new System.Drawing.Size(23, 22);
            this.tsProxyButton.Text = "Proxies";
            this.tsProxyButton.Click += new System.EventHandler(this.tsProxyButton_Click);
            // 
            // tsRefresh
            // 
            this.tsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRefresh.Image = global::TwitterAtomationWa.Properties.Resources._1360224303_adept_update;
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsRefresh.Text = "Refresh Accounts";
            this.tsRefresh.Click += new System.EventHandler(this.tsRefresh_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsAccount);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsMessage);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(764, 433);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 1;
            // 
            // lsAccount
            // 
            this.lsAccount.DataSource = this.accountBindingSource;
            this.lsAccount.DisplayMember = "ScreenName";
            this.lsAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsAccount.FormattingEnabled = true;
            this.lsAccount.IntegralHeight = false;
            this.lsAccount.ItemHeight = 20;
            this.lsAccount.Location = new System.Drawing.Point(0, 0);
            this.lsAccount.Name = "lsAccount";
            this.lsAccount.Size = new System.Drawing.Size(146, 433);
            this.lsAccount.TabIndex = 0;
            this.lsAccount.Click += new System.EventHandler(this.lsAccount_Click);
            this.lsAccount.SelectedIndexChanged += new System.EventHandler(this.lsAccount_SelectedIndexChanged);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "Account";
            this.accountBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lsMessage
            // 
            this.lsMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lsMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsMessage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsMessage.FormattingEnabled = true;
            this.lsMessage.ItemHeight = 70;
            this.lsMessage.Location = new System.Drawing.Point(0, 0);
            this.lsMessage.Margin = new System.Windows.Forms.Padding(5);
            this.lsMessage.Name = "lsMessage";
            this.lsMessage.Size = new System.Drawing.Size(614, 433);
            this.lsMessage.TabIndex = 0;
            this.lsMessage.Click += new System.EventHandler(this.lsMessage_Click);
            this.lsMessage.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsMessage_DrawItem);
            this.lsMessage.SelectedIndexChanged += new System.EventHandler(this.lsMessage_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 433);
            this.panel1.TabIndex = 1;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 433);
            this.panel2.TabIndex = 2;
            // 
            // frmMainForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainForms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twitter DM Client";
            this.Load += new System.EventHandler(this.frmMainForms_Load);
            this.Shown += new System.EventHandler(this.frmMainForms_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAddAccount;
        private System.Windows.Forms.ToolStripButton tsNewMessage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListBox lsMessage;
        public System.Windows.Forms.ListBox lsAccount;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private DataDataSetTableAdapters.AccountTableAdapter accountTableAdapter;
        private System.Windows.Forms.ToolStripButton tsSetting;
        private System.Windows.Forms.ToolStripButton tsProxyButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton tsRefresh;
    }
}