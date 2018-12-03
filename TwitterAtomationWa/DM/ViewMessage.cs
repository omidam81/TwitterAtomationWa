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
    public partial class ViewMessage : Form
    {
        public ViewMessage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            DM.frmReplayMessage rep = new DM.frmReplayMessage();
            rep.SenderScreenName = Message.To;
            rep.ReciverName = Message.From;
            this.Close();
            rep.ShowDialog();
        }
        private DM.DMMessage _message;
        public DM.DMMessage Message
        {
            get { return _message; }
            set
            {
                _message = value;
                lblFrom.Text = "From: " + _message.From;
                txtMessage.Text = _message.Message;

                lblDate.Text = _message.DateSended.ToString();


            }
        }

        private void ViewMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
