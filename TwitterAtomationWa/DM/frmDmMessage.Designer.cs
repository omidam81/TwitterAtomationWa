namespace TwitterAtomationWa.DM
{
    partial class frmDmMessage
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lsMessage = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(395, 343);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 49);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 343);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(377, 49);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // lsMessage
            // 
            this.lsMessage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lsMessage.FormattingEnabled = true;
            this.lsMessage.ItemHeight = 80;
            this.lsMessage.Location = new System.Drawing.Point(12, 12);
            this.lsMessage.Name = "lsMessage";
            this.lsMessage.Size = new System.Drawing.Size(458, 304);
            this.lsMessage.TabIndex = 2;
            this.lsMessage.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lsMessage_DrawItem);
            this.lsMessage.ClientSizeChanged += new System.EventHandler(this.lsMessage_ClientSizeChanged);
            this.lsMessage.Validating += new System.ComponentModel.CancelEventHandler(this.lsMessage_Validating);
            // 
            // frmDmMessage
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 401);
            this.Controls.Add(this.lsMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDmMessage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "@ScreenName";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDmMessage_FormClosing);
            this.Load += new System.EventHandler(this.frmDmMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox lsMessage;
    }
}