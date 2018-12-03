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
    public partial class frmSelectUserProxy : Form
    {
        public frmSelectUserProxy()
        {
            InitializeComponent();
        }
        public string ProxyAddress { get; set; }

        DataEntities db = new DataEntities();
        private void frmSelectUserProxy_Load(object sender, EventArgs e)
        {
            gvProxyList.DataSource = db.Proxies.ToList();
        }

        private void gvProxyList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvProxyList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            btnOk.Enabled = false;
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                btnOk.Enabled = true;

                if (gvProxyList.SelectedRows.Count > 0)
                {
                    var v = gvProxyList.SelectedRows[0].DataBoundItem as Proxy;

                    this.ProxyAddress = v.ProxyAddres + ":" + ((v.ProxyPort == null) ? "80" : v.ProxyPort.ToString()) + ":" + v.ProxyUsername + ":" + v.ProxyPassword;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
