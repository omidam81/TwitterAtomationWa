namespace TwitterAtomationWa
{
    partial class frmSelectFollowers
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
            this.lblSaveTextFile = new System.Windows.Forms.LinkLabel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectedMember = new System.Windows.Forms.ListBox();
            this.lboxAllUser = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnDeselectall = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSaveTextFile);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnDeselectall);
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSelectedMember);
            this.groupBox1.Controls.Add(this.lboxAllUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Followers Receivers";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSaveTextFile
            // 
            this.lblSaveTextFile.AutoSize = true;
            this.lblSaveTextFile.Location = new System.Drawing.Point(259, 250);
            this.lblSaveTextFile.Name = "lblSaveTextFile";
            this.lblSaveTextFile.Size = new System.Drawing.Size(138, 13);
            this.lblSaveTextFile.TabIndex = 6;
            this.lblSaveTextFile.TabStop = true;
            this.lblSaveTextFile.Text = "Save Followers To Text File";
            this.lblSaveTextFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSaveTextFile_LinkClicked);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(194, 147);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(56, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 109);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Followers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Followers";
            // 
            // lblSelectedMember
            // 
            this.lblSelectedMember.FormattingEnabled = true;
            this.lblSelectedMember.Location = new System.Drawing.Point(259, 47);
            this.lblSelectedMember.Name = "lblSelectedMember";
            this.lblSelectedMember.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lblSelectedMember.Size = new System.Drawing.Size(169, 199);
            this.lblSelectedMember.TabIndex = 3;
            // 
            // lboxAllUser
            // 
            this.lboxAllUser.DisplayMember = "Accounts";
            this.lboxAllUser.FormattingEnabled = true;
            this.lboxAllUser.Location = new System.Drawing.Point(19, 48);
            this.lboxAllUser.Name = "lboxAllUser";
            this.lboxAllUser.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lboxAllUser.Size = new System.Drawing.Size(169, 186);
            this.lboxAllUser.TabIndex = 1;
            this.lboxAllUser.ValueMember = "Accounts";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(304, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(385, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Select";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(19, 240);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(65, 23);
            this.btnSelectAll.TabIndex = 4;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnDeselectall
            // 
            this.btnDeselectall.Location = new System.Drawing.Point(90, 240);
            this.btnDeselectall.Name = "btnDeselectall";
            this.btnDeselectall.Size = new System.Drawing.Size(65, 23);
            this.btnDeselectall.TabIndex = 4;
            this.btnDeselectall.Text = "DeSelect All";
            this.btnDeselectall.UseVisualStyleBackColor = true;
            this.btnDeselectall.Click += new System.EventHandler(this.btnDeselectall_Click);
            // 
            // frmSelectFollowers
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(470, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectFollowers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Followers Receivers";
            this.Load += new System.EventHandler(this.frmSelectFollowers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lblSelectedMember;
        private System.Windows.Forms.ListBox lboxAllUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.LinkLabel lblSaveTextFile;
        private System.Windows.Forms.Button btnDeselectall;
        private System.Windows.Forms.Button btnSelectAll;
    }
}