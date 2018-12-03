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
    public partial class frmSelectUser : Form
    {
        List<Account> SelectedMember = new List<Account>();
        public frmSelectUser()
        {
            InitializeComponent();
        }
        TwitterAtomationWa.DataEntities da = new DataEntities();
        private void frmSelectUser_Load(object sender, EventArgs e)
        {
            foreach (var item in (from a in da.Accounts
                                  select a))
            {
                lboxAllUser.Items.Add(item);
            }
            lboxAllUser.DisplayMember = "ScreenName";
            lboxAllUser.ValueMember = "id";

            lblSelectedMember.DisplayMember = "ScreenName";
            lblSelectedMember.ValueMember = "id";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        }
        public string SelectedMemberList { get; set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            foreach (var item in lblSelectedMember.Items)
                SelectedMemberList += (item as Account).ScreenName + ",";

            this.Close();
        }
    }
}
