using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterAtomationWa.Classes;
using Twitterizer;

namespace TwitterAtomationWa
{
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
        }

        TwitterAtomationWa.DataEntities db = new DataEntities();
        private void btnGetInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread T = new Thread(new ThreadStart(GetAccessKey));
            T.SetApartmentState(ApartmentState.STA);
            statusStrip1.Visible = true;
            groupBox1.Enabled = false;
            T.Start();
        }

        private void GetAccessKey()
        {
            try
            {
                OAuthTokenResponse requestToken = OAuthUtility.GetRequestToken(Classes.AppSetting.ConsumerKey, Classes.AppSetting.ConsumerSecret, "oob");
                // Direct or instruct the user to the following address:
                Uri authorizationUri = OAuthUtility.BuildAuthorizationUri(requestToken.Token);
                lbltoken.BeginInvoke(new MethodInvoker(delegate()
                {
                    lbltoken.Text = requestToken.Token;
                }));
                TwitterBrowser B = new TwitterBrowser();
                B.Open(authorizationUri);
                if (B.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.BeginInvoke(new MethodInvoker(delegate()
                    {
                        txtPassword.Text = B.VerificationCode;
                        txtPassword.Enabled = true;
                        statusStrip1.Visible = false;
                        groupBox1.Enabled = true;
                    }));
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

                this.BeginInvoke(new MethodInvoker(delegate()
                {
                    txtPassword.Enabled = true;
                    statusStrip1.Visible = false;
                    groupBox1.Enabled = true;
                }));
            }
        }

        

        private void txtDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you Want to delete this account(s)?", "Delete Account", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                    {




                        var account = item.DataBoundItem as Account;

                        var messages = db.Messages.Where(aa => aa.SenderscreenName == account.ScreenName);
                        foreach (var message in messages)
                            db.Messages.DeleteObject(message);
                        db.Accounts.DeleteObject(account);
                        db.SaveChanges();
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = db.Accounts.ToList();
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TwitterHelper.LoginUser(txtScreenName.Text, txtPassword.Text, txtProxyAddress.Text))
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = db.Accounts.ToList();
                txtPassword.Text = txtScreenName.Text = txtProxyAddress.Text = "";
            }
            else
            {
                MessageBox.Show("Something is Wrong");
            }
        }

        private bool tryToResolveProxy(out string proxy)
        {
            var strProxy = txtProxyAddress.Text;
            proxy = "";
            if (string.IsNullOrWhiteSpace(txtProxyAddress.Text)) return true;

            string[] strParts = strProxy.Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);


            if (strParts.Count() != 4)
            {
                MessageBox.Show("Format is not Correct!", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Information);
                proxy = null;
                return false;
            }

            proxy = strProxy;


            return true;
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Accounts.ToList();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var item = dataGridView1.SelectedRows[0].DataBoundItem as Account;
                var strMessage = "Screen Name:" + item.ScreenName + Environment.NewLine;
                strMessage += "Token:" + item.Token;
                strMessage += "Token Secret:" + item.TokenSecret;
                MessageBox.Show(strMessage);
            }
        }

        private void txtSecret_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = !string.IsNullOrWhiteSpace(txtScreenName.Text)
                &&
                !string.IsNullOrWhiteSpace(txtPassword.Text);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkSelectProxy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSelectUserProxy P = new frmSelectUserProxy();
            if (P.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtProxyAddress.Text = P.ProxyAddress;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count  > 0)
            {
                var item = dataGridView1.SelectedRows[0].DataBoundItem as Account;
                txtScreenName.Text = item.ScreenName;
                txtProxyAddress.Text = item.ProxyAddress;
                txtPassword.Text = item.Name;
            }
            

        }
    }
}
