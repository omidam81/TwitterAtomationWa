using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;

namespace TwitterAtomationWa
{
    public partial class frmSelectFollowers : Form
    {
        public frmSelectFollowers()
        {
            InitializeComponent();
        }


        public string[] Users { get; set; }

        public frmSelectFollowers(string[] users)
        {
            InitializeComponent();
            this.Users = users;
        }

        private void frmSelectFollowers_Load(object sender, EventArgs e)
        {
            foreach (var item in Users)
            {
                if (string.IsNullOrWhiteSpace(item)) continue;
                TwitterUserCollection allUser = Classes.TwitterHelper.GetFollowers(item);
                foreach (var user in allUser)
                {

                    AddUser(item + ":" + user.ScreenName);
                } 
            }
        }

        private void AddUser(string User)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                if (Classes.AppSetting.DontSendReplicated)
                {
                    if (!lboxAllUser.Items.Contains(Users)) lboxAllUser.Items.Add(User);
                }
                else
                {
                    lboxAllUser.Items.Add(User);
                }
            }));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lboxAllUser.SelectedItems.Count > 0)
            {

                for (int x = lboxAllUser.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = lboxAllUser.SelectedIndices[x];
                    lblSelectedMember.Items.Add(lboxAllUser.Items[idx]);
                    lboxAllUser.Items.RemoveAt(idx);
                }
            }

            if (lblSelectedMember.Items.Count > 0) btnOk.Enabled = true;
            else btnOk.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lblSelectedMember.SelectedItems.Count > 0)
            {

                for (int x = lblSelectedMember.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int idx = lblSelectedMember.SelectedIndices[x];
                    lboxAllUser.Items.Add(lblSelectedMember.Items[idx]);
                    lblSelectedMember.Items.RemoveAt(idx);
                }
            }

            if (lblSelectedMember.Items.Count > 0) btnOk.Enabled = true;
            else btnOk.Enabled = false;
        }

        private void lblSaveTextFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog File = new SaveFileDialog();
            File.Filter = "Text Files|*.txt;";

            if (File.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var strFile = new StreamWriter(File.OpenFile());
                strFile.Write(GetSelectedUser());
                strFile.Close();
            }
        }

        public string GetSelectedUser()
        {
            var strSelectedUser = "";

            foreach (var item in lblSelectedMember.Items)
            {
                strSelectedUser += item as string + Environment.NewLine;
            }
            return strSelectedUser;
        }

        public string[] SelectedUser
        {
            get { return GetSelectedUser().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries); }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            lboxAllUser.Visible = false;
            for (int i = 0; i < lboxAllUser.Items.Count; i++)
            {
                lboxAllUser.SetSelected(i, true);
            }
            lboxAllUser.Visible = true;
        }

        private void btnDeselectall_Click(object sender, EventArgs e)
        {
            lboxAllUser.Visible = false;
            for (int i = 0; i < lboxAllUser.Items.Count; i++)
            {
                lboxAllUser.SetSelected(i, false);
            }
            lboxAllUser.Visible = true;
        }
    }
}
