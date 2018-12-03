namespace TwitterAtomationWa
{
    partial class frmSelectUserProxy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvProxyList = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.proxyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proxyAddresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyUsernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProxyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proxyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvProxyList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Proxy";
            // 
            // gvProxyList
            // 
            this.gvProxyList.AllowUserToAddRows = false;
            this.gvProxyList.AllowUserToDeleteRows = false;
            this.gvProxyList.AllowUserToResizeColumns = false;
            this.gvProxyList.AllowUserToResizeRows = false;
            this.gvProxyList.AutoGenerateColumns = false;
            this.gvProxyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProxyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proxyAddresDataGridViewTextBoxColumn,
            this.proxyPortDataGridViewTextBoxColumn,
            this.proxyUsernameDataGridViewTextBoxColumn});
            this.gvProxyList.DataSource = this.proxyBindingSource;
            this.gvProxyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvProxyList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvProxyList.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gvProxyList.Location = new System.Drawing.Point(3, 16);
            this.gvProxyList.Name = "gvProxyList";
            this.gvProxyList.ReadOnly = true;
            this.gvProxyList.Size = new System.Drawing.Size(453, 287);
            this.gvProxyList.TabIndex = 0;
            this.gvProxyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProxyList_CellContentClick);
            this.gvProxyList.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.gvProxyList_RowStateChanged);
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(395, 324);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Select";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(314, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // proxyBindingSource
            // 
            this.proxyBindingSource.DataSource = typeof(TwitterAtomationWa.Proxy);
            // 
            // proxyAddresDataGridViewTextBoxColumn
            // 
            this.proxyAddresDataGridViewTextBoxColumn.DataPropertyName = "ProxyAddres";
            this.proxyAddresDataGridViewTextBoxColumn.HeaderText = "IP";
            this.proxyAddresDataGridViewTextBoxColumn.Name = "proxyAddresDataGridViewTextBoxColumn";
            // 
            // proxyPortDataGridViewTextBoxColumn
            // 
            this.proxyPortDataGridViewTextBoxColumn.DataPropertyName = "ProxyPort";
            this.proxyPortDataGridViewTextBoxColumn.HeaderText = "Port";
            this.proxyPortDataGridViewTextBoxColumn.Name = "proxyPortDataGridViewTextBoxColumn";
            // 
            // proxyUsernameDataGridViewTextBoxColumn
            // 
            this.proxyUsernameDataGridViewTextBoxColumn.DataPropertyName = "ProxyUsername";
            this.proxyUsernameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.proxyUsernameDataGridViewTextBoxColumn.Name = "proxyUsernameDataGridViewTextBoxColumn";
            // 
            // frmSelectUserProxy
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(482, 351);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectUserProxy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Proxy";
            this.Load += new System.EventHandler(this.frmSelectUserProxy_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProxyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proxyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvProxyList;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyAddresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyPortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyUsernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proxyBindingSource;
    }
}