using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TwitterAtomationWa.DM
{
    public partial class frmReplayMessage : Form
    {
        public frmReplayMessage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            Twitterizer.RequestResult Result = Twitterizer.RequestResult.Unknown;
            Classes.TwitterHelper.SendDmMessage(SenderScreenName, _ReciverName, txtMessage.Text, out Result);

            if (Result == Twitterizer.RequestResult.Success)
            {
                MessageBox.Show("Message Send Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Message Not Send!");
            }
        }


        private string _ReciverName;
        public string ReciverName { get { return _ReciverName; } set { _ReciverName = value; txtTo.Text = _ReciverName; } }
        public string SenderScreenName { get; set; }



        private void frmReplayMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
