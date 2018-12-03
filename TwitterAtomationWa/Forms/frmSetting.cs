using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitterAtomationWa
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            txtConsumerKey.Text = Classes.AppSetting.ConsumerKey;
            txtConsumerSecret.Text = Classes.AppSetting.ConsumerSecret;
        }

        TwitterAtomationWa.DataEntities en = new DataEntities();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Classes.AppSetting.ConsumerKey = txtConsumerKey.Text;
            Classes.AppSetting.ConsumerSecret = txtConsumerSecret.Text;


            int count = en.Accounts.Count();

            //if (count > 0)
            //{
            //    MessageBox.Show("You need to change the accounts tokens to continue using of theme, Please go to Account managemant form and change your account token to continue using account"); 

            //}
            this.Close();
        }
    }
}
