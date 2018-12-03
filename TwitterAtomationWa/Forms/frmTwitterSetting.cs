using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TwitterAtomationWa
{
    public partial class frmTwitterSetting : Form
    {
        public frmTwitterSetting()
        {
            InitializeComponent();
        }

        private void frmTwitterSetting_Load(object sender, EventArgs e)
        {
            nUMessageCount.Value = TwitterAtomationWa.Classes.AppSetting.MessageCount;
            chkUseProxy.Checked = TwitterAtomationWa.Classes.AppSetting.UseProxy;
            chkDontSendReplicated.Checked = TwitterAtomationWa.Classes.AppSetting.DontSendReplicated;
            Th.Value = TwitterAtomationWa.Classes.AppSetting.Th;
            Tm.Value = TwitterAtomationWa.Classes.AppSetting.Tm;
            Fh.Value = TwitterAtomationWa.Classes.AppSetting.Fh;
            Fm.Value = TwitterAtomationWa.Classes.AppSetting.Fm;
            chkInterValTime.Checked = TwitterAtomationWa.Classes.AppSetting.Uinterval;
            chkAutostart.Checked = TwitterAtomationWa.Classes.AppSetting.AutoStart;
            chkUseCentraldatabase.Checked = TwitterAtomationWa.Classes.AppSetting.UseCentralDatabase;
            comboBox1.Text = TwitterAtomationWa.Classes.AppSetting.RetryCount.ToString();
        }

        private void chkUseProxy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TwitterAtomationWa.Classes.AppSetting.MessageCount = (int)nUMessageCount.Value;
            TwitterAtomationWa.Classes.AppSetting.UseProxy = chkUseProxy.Checked;
            TwitterAtomationWa.Classes.AppSetting.Th = (int)Th.Value;
            TwitterAtomationWa.Classes.AppSetting.Tm = (int)Tm.Value;
            TwitterAtomationWa.Classes.AppSetting.Fh = (int)Fh.Value;
            TwitterAtomationWa.Classes.AppSetting.Fm = (int)Fm.Value;
            TwitterAtomationWa.Classes.AppSetting.Uinterval = chkInterValTime.Checked;
            TwitterAtomationWa.Classes.AppSetting.AutoStart = chkAutostart.Checked;
            TwitterAtomationWa.Classes.AppSetting.RetryCount = comboBox1.SelectedIndex + 1;
            TwitterAtomationWa.Classes.AppSetting.UseCentralDatabase = chkUseCentraldatabase.Checked;
            this.Close();
        }

        private void chkInterValTime_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = chkInterValTime.Checked;
        }
    }
}
