namespace TwitterAtomationWa
{
    partial class TwitterBrowser
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
            this.TBrowser = new System.Windows.Forms.WebBrowser();
            this.btnUserThisCode = new System.Windows.Forms.Button();
            this.btnClearCashe = new System.Windows.Forms.Button();
            this.btnLogou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBrowser
            // 
            this.TBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBrowser.Location = new System.Drawing.Point(0, 0);
            this.TBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TBrowser.Name = "TBrowser";
            this.TBrowser.ScriptErrorsSuppressed = true;
            this.TBrowser.Size = new System.Drawing.Size(987, 570);
            this.TBrowser.TabIndex = 0;
            this.TBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.TBrowser_DocumentCompleted);
            this.TBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.TBrowser_Navigated);
            this.TBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.TBrowser_Navigating);
            // 
            // btnUserThisCode
            // 
            this.btnUserThisCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserThisCode.Enabled = false;
            this.btnUserThisCode.Location = new System.Drawing.Point(749, 589);
            this.btnUserThisCode.Name = "btnUserThisCode";
            this.btnUserThisCode.Size = new System.Drawing.Size(226, 23);
            this.btnUserThisCode.TabIndex = 3;
            this.btnUserThisCode.Text = "User this access key";
            this.btnUserThisCode.UseVisualStyleBackColor = true;
            this.btnUserThisCode.Click += new System.EventHandler(this.btnUserThisCode_Click);
            // 
            // btnClearCashe
            // 
            this.btnClearCashe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearCashe.Location = new System.Drawing.Point(12, 589);
            this.btnClearCashe.Name = "btnClearCashe";
            this.btnClearCashe.Size = new System.Drawing.Size(119, 23);
            this.btnClearCashe.TabIndex = 1;
            this.btnClearCashe.Text = "Clear History";
            this.btnClearCashe.UseVisualStyleBackColor = true;
            this.btnClearCashe.Click += new System.EventHandler(this.btnClearCashe_Click);
            // 
            // btnLogou
            // 
            this.btnLogou.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogou.Location = new System.Drawing.Point(137, 589);
            this.btnLogou.Name = "btnLogou";
            this.btnLogou.Size = new System.Drawing.Size(118, 23);
            this.btnLogou.TabIndex = 2;
            this.btnLogou.Text = "Log Out";
            this.btnLogou.UseVisualStyleBackColor = true;
            this.btnLogou.Click += new System.EventHandler(this.btnLogou_Click);
            // 
            // TwitterBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 624);
            this.Controls.Add(this.btnLogou);
            this.Controls.Add(this.btnClearCashe);
            this.Controls.Add(this.btnUserThisCode);
            this.Controls.Add(this.TBrowser);
            this.MinimizeBox = false;
            this.Name = "TwitterBrowser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open Twitter";
            this.Load += new System.EventHandler(this.TwitterBrowser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser TBrowser;
        private System.Windows.Forms.Button btnUserThisCode;
        private System.Windows.Forms.Button btnClearCashe;
        private System.Windows.Forms.Button btnLogou;
    }
}