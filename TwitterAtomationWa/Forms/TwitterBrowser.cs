using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterAtomationWa
{
    public partial class TwitterBrowser : Form
    {
        public TwitterBrowser()
        {
            InitializeComponent();
        }

        private void TwitterBrowser_Load(object sender, EventArgs e)
        {
           
            

        }

        public void Open(string url, Proxy P)
        {
            TBrowser.Url = new Uri(url);
        }

        private void TBrowser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }
        public string VerificationCode { get; private set; }
        private void TBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

           
        }

        private void btnUserThisCode_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        public Uri Uri { get; set; }

        internal void Open(Uri uri)
        {
            Uri = uri;
            TBrowser.Url = uri;
        }
        int count = 0;
        private void TBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (isLogout)
            {
                if (count++ == 2)
                {
                    isLogout = false;
                    TBrowser.Navigate(Uri);
                }
                return;
            }
            Uri = e.Url;

            if (TBrowser.Document != null)
            {
                String str = TBrowser.Document.Body.InnerHtml;
                
                //((mshtml.HTMLDocument)(((TBrowser.Document.DomDocument)))).documentElement.innerHTML;
                //TBrowser.Document.OpenNew(true);
                //TBrowser.Document.Write(str); 

                var regex = new Regex("<code>([0-9]*)</code>", RegexOptions.Multiline | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.Compiled);
                VerificationCode = regex.Match(str).Groups[1].Value;
                if (!string.IsNullOrEmpty(VerificationCode))
                {
                    this.Text = VerificationCode;
                    btnUserThisCode.Enabled = true;
                }
            }
        }

        private void btnClearCashe_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 255");
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 16");
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 32");
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2");
            System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8");

            System.Threading.Thread.Sleep(3000);


            TBrowser.Refresh(WebBrowserRefreshOption.Completely);

            TBrowser.Navigate(Uri);
        }
        bool isLogout = false;
        private void btnLogou_Click(object sender, EventArgs e)
        {
            TBrowser.Navigate("https://twitter.com/logout");
            //TBrowser.DocumentCompleted -= TBrowser_DocumentCompleted;

            isLogout = true;
                
        }
    }
}
