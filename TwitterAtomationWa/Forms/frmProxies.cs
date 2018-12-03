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
    public partial class frmProxies : Form
    {
        public frmProxies()
        {
            InitializeComponent();
        }

        TwitterAtomationWa.DataEntities db = new DataEntities();
        private void frmProxies_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Proxies;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            txtPort.Text = VerifyNumeric(txtPort.Text);
        }

        private string VerifyNumeric(string text)
        {
            double value = 0;
            double.TryParse(text, out value);
            return value.ToString(); // could format here too.
        }

        private void rdoUsername_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdoUsername.Checked)
                txtUsername.Enabled = txtPassword.Enabled = false;
            else txtPassword.Enabled = txtUsername.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var address = txtAddress.Text;
            var port = txtPort.Text;
            var proxyname = txtProxyName.Text;

            var username = txtUsername.Text;
            var password = txtPassword.Text;

            Proxy P;

            if (rdoAL.Checked)
            {
                P = new Proxy()
                {
                    DateCreated = DateTime.Now,
                    ProxyAddres = address,
                    ProxyPort = Convert.ToInt32(port),
                    ProxyName = proxyname,
                };
            }
            else
            {
                P = new Proxy()
                {
                    DateCreated = DateTime.Now,
                    ProxyAddres = address,
                    ProxyUsername = username,
                    ProxyPort = Convert.ToInt32(port),
                    ProxyName = proxyname,
                    ProxyPassword = password
                };
            }
            db.Proxies.AddObject(P); 
            db.SaveChanges();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Proxies.ToList();
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

            txtAddress.Text = "";
            txtPort.Text = "";
            txtProxyName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Proxy?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(dataGridView1.SelectedRows.Count > 0){

                    var xSelecteObject = dataGridView1.SelectedRows[0].DataBoundItem as Proxy;

                    var count = db.Messages.Count(aa => aa.ProxyID == xSelecteObject.ProxyId);
                    var b = true;
                    if (count > 0)
                    {
                        if (MessageBox.Show("There exist some Messages that use this proxy do you want delete it?", "Delete Proxy", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        {
                            var vMessages = db.Messages.Where(aa => aa.ProxyID == xSelecteObject.ProxyId);
                            foreach (var item in vMessages)
                            {
                                item.ProxyID = -1;
                            }
                            db.SaveChanges();
                            
                            b = true;
                        }
                        else
                        {
                            b = false;
                        }
                    }


                    if (b)
                    {
                        db.Proxies.DeleteObject(xSelecteObject);
                        db.SaveChanges();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = db.Proxies.ToList();
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtAddress.Text = txtPassword.Text = txtPort.Text = txtProxyName.Text = txtUsername.Text = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var xSelecteObject = dataGridView1.SelectedRows[0].DataBoundItem as Proxy;
                txtAddress.Text = xSelecteObject.ProxyAddres;
                txtPassword.Text = xSelecteObject.ProxyPassword;
                txtPort.Text = xSelecteObject.ProxyPort.ToString();
                txtProxyName.Text = xSelecteObject.ProxyName;
                txtUsername.Text = xSelecteObject.ProxyUsername;

                rdoUsername.Checked = !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text);
                rdoAL.Checked = !rdoUsername.Checked;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            bool b1 = !string.IsNullOrEmpty(txtAddress.Text) && !string.IsNullOrEmpty(txtProxyName.Text) && !string.IsNullOrEmpty(txtPort.Text);
            bool b2 = rdoAL.Checked || (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsername.Text));
            btnEdit.Enabled = btnAdd.Enabled = b2 && b1;

            btnEdit.Enabled &= (dataGridView1.SelectedRows.Count > 0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void rdoAL_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword_TextChanged(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

