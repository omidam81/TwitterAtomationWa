using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TwitterAtomationWa.Forms
{
    public partial class frmWebSetting : Form
    {
        public frmWebSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSetting();
        }

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWebSetting_Load(object sender, EventArgs e)
        {
            LoadSetting();
        }

        private void SaveSetting()
        {
            Classes.AppSetting.WebUrl = txtUrl.Text;
            Classes.AppSetting.Password = txtPassword.Text;
            Classes.AppSetting.Username = txtUsername.Text;
        }

        private void LoadSetting()
        {
            txtUrl.Text = Classes.AppSetting.WebUrl;
            txtPassword.Text = Classes.AppSetting.Password;
            txtUsername.Text = Classes.AppSetting.Username;
        }

        private void txtUrl_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }
}
