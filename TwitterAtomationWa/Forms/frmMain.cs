using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twitterizer;

namespace TwitterAtomationWa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        TwitterAtomationWa.DataEntities db;
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                db = new DataEntities();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            messageGridView.DataSource = null;
            messageGridView.DataSource = db.Messages.Where(aa => aa.DateSended == null).OrderBy(zz => zz.nextTryDate);
        }

        private void btnProxies_Click(object sender, EventArgs e)
        {
            frmProxies p = new frmProxies();
            p.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUserManagement user = new frmUserManagement();
            user.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSetting s = new frmSetting();
            s.ShowDialog();
        }

        private void tsAddMessage_Click(object sender, EventArgs e)
        {
            frmAddMessage add = new frmAddMessage();

            if (add.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                messageGridView.DataSource = db.Messages.Where(a => a.DateSended == null).OrderBy(aa => aa.nextTryDate).ToArray();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SenderTimer.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendNextMessage();
        }


        private void SendNextMessage(Account item)
        {
            var Message = db.Messages.Where(aa => aa.DateSended == null && aa.UserID == item.id).OrderBy(a => Guid.NewGuid()).FirstOrDefault();

            if (Message == null) return;

            int xMessageCount = GetLastOneHourMessagesCount(Message, item);

            if (xMessageCount > Classes.AppSetting.MessageCount)
            {
                AddMessage("Message Form " + item.ScreenName + " Are exceed Limit");
                Message.nextTryDate = DateTime.Now.AddMinutes(10);
                db.SaveChanges();
                return;
            }

            RequestResult result = RequestResult.ConnectionFailure;

            var bResValue = Classes.TwitterHelper.SendDmMessage(Message.UserID, Message.rScreenName, Message.Message1, out result);

            if (bResValue)
            {
                AddMessage(string.Format("({0}) Message Send To @{1}.", Message.SenderscreenName, Message.rScreenName));

                //db.Messages.DeleteObject(v);
                Message.DateSended = DateTime.Now;
                db.SaveChanges();

                messageGridView.DataSource = null;
                int x = db.Messages.Count(aa => aa.DateSended == null);
                messageGridView.DataSource = db.Messages.Where(aa => aa.DateSended == null).OrderBy(aa => aa.nextTryDate);


            }
            else
            {
                //Message.nextTryDate = DateTime.Now.AddMonths(10);
                try
                {
                    db.Messages.DeleteObject(Message);
                    db.SaveChanges();
                }
                catch
                {
                }
                messageGridView.DataSource = db.Messages.Where(aa => aa.DateSended == null).OrderBy(aa => aa.nextTryDate);
                AddMessage("Message not send to " + Message.rScreenName + ".");
            }
        }
        private void SendNextMessage()
        {
            foreach (var item in db.Accounts)
            {
                var Message = db.Messages.Where(aa => aa.DateSended == null && aa.UserID == item.id).OrderBy(a => a.nextTryDate).FirstOrDefault();

                if (Message == null) continue;

                int xMessageCount = GetLastOneHourMessagesCount(Message, item);

                if (xMessageCount > Classes.AppSetting.MessageCount)
                {
                    AddMessage("Message Form " + item.ScreenName + " Are exceed Limit");
                    Message.nextTryDate = DateTime.Now.AddMinutes(10);
                    db.SaveChanges();
                    continue;
                }

                RequestResult result = RequestResult.ConnectionFailure;

                var bResValue = Classes.TwitterHelper.SendDmMessage(Message.UserID, Message.rScreenName, Message.Message1, out result);

                if (bResValue)
                {

                    AddMessage(string.Format("({0}) Message Send To @{1}.", Message.SenderscreenName, Message.rScreenName));


                    //db.Messages.DeleteObject(v);
                    Message.DateSended = DateTime.Now;
                    db.SaveChanges();

                    messageGridView.DataSource = null;
                    int x = db.Messages.Count(aa => aa.DateSended == null);
                    messageGridView.DataSource = db.Messages.Where(aa => aa.DateSended == null).OrderBy(aa => aa.nextTryDate);


                }
                else
                {
                    try
                    {
                        Message.nextTryDate = DateTime.Now.AddMonths(10);
                        db.SaveChanges();
                    }
                    catch
                    {
                    }
                    messageGridView.DataSource = db.Messages.Where(aa => aa.DateSended == null).OrderBy(aa => aa.nextTryDate);
                    AddMessage("Message not send to " + Message.rScreenName + ".");
                }
            }

            if (db.Messages.Where(aa => aa.DateSended == null).Count() == 0)
            {

                AddMessage("All Message Are Sended.");

                btnPause_Click(null, new EventArgs());

            }
        }

        private int GetLastOneHourMessagesCount(Message Message, Account item)
        {
            if (Message == null) return 0;
            var lastH = DateTime.Now.Subtract(new TimeSpan(0, 1, 0, 0, 0));
            var v = db.Messages.Count(aa => (aa.DateSended >= lastH && aa.UserID == Message.UserID));
            return v;
        }

        private int GetLastOneHourMessagesCount(Message message)
        {
            if(message == null) return 0;
            var lastH = DateTime.Now.Subtract(new TimeSpan(0, 1, 0, 0, 0));
            var v = db.Messages.Count(aa => (aa.DateSended >= lastH && aa.UserID == message.UserID));
            return v;

        }

        private void AddMessage(string Message)
        {
            txtLog.Invoke(new MethodInvoker(delegate {

                txtLog.AppendText(Message + Environment.NewLine);

                txtLog.SelectionStart = txtLog.TextLength;

                txtLog.ScrollToCaret();
            
            }));

            AddTextToFile(Message);
        }

        private void AddTextToFile(string Message)
        {
            var vMessage = DateTime.Now.ToString() + " : " + Message;

            var FilePath = Path.Combine(new FileInfo(Application.ExecutablePath).DirectoryName, "logs.txt");
            System.IO.File.AppendAllText(FilePath, vMessage + Environment.NewLine);
        }

        List<Timer> T = new List<Timer>();

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //SenderTimer.Enabled = true;
            btnPlay.Enabled = false;
            btnPause.Enabled = true;
            //SendNextMessage();

            foreach (var item in db.Accounts)
            {
                if (TimerNotExist(item.ScreenName))
                {
                    Timer timer = new Timer();
                    timer.Interval = new Random().Next((int)nmSecondFrom.Value, (int)nmSecondTo.Value) * 1000;
                    timer.Tag = item;
                    timer.Tick += T_Tick;
                    T.Add(timer);
                    timer.Start();
                }
                else
                {
                    Timer timer = getTimer(item);
                    timer.Start();
                }
            }
        }

        Timer getTimer(Account C)
        {
            return T.FirstOrDefault(a => (a.Tag as Account) == C);
        }
        void T_Tick(object sender, EventArgs e)
        {
            var timer = (sender as Timer);
            var account = timer.Tag as Account;
            SendNextMessage(account);

            int xCount = db.Messages.Count(aa => (aa.DateSended == null) && aa.UserID == account.id);

            if (xCount == 0)
            {
                timer.Stop();

                var vEEE = false;

                foreach (var item in T)
                    vEEE |= item.Enabled;

                if (!vEEE)
                {
                    AddMessage("All Message Are Sended.");

                    btnPause_Click(null, new EventArgs());
                }
            }
        }

        private bool TimerNotExist(string ScreenName)
        {
            var v = T.FirstOrDefault(a => (a.Tag as Account).ScreenName == ScreenName);
            if (v == null) return true;
            else return true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //SenderTimer.Enabled = false;
            btnPlay.Enabled = true;
            btnPause.Enabled = false;

            foreach (var item in T)
            {
                item.Stop();
            }
        }

        private void nmSecond_ValueChanged(object sender, EventArgs e)
        {
            SenderTimer.Interval = 1000 * (int)nmSecondFrom.Value;
        }

        private void tsDeleteMessage_Click(object sender, EventArgs e)
        {
            if (messageGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do You want to remove message(s)?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        foreach (DataGridViewRow item in messageGridView.SelectedRows)
                        {
                            var itemB = item.DataBoundItem;
                            db.Messages.DeleteObject(itemB as Message);
                            
                        }

                        db.SaveChanges();
                        messageGridView.DataSource = null;
                        messageGridView.DataSource = db.Messages.Where(aa => aa.DateSended == null).OrderBy(aa => aa.nextTryDate).ToList();    
                        
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmTwitterSetting Tsetting = new frmTwitterSetting();
            Tsetting.ShowDialog();
        }

        private void messageGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            switch (e.Column.HeaderText)
            {
                case "Message1":
                    e.Column.HeaderText = "Message Text";
                    e.Column.Width = 200;
                    break;
                case "id":
                    e.Column.Visible = false;
                    break;
                case "UserID":
                    e.Column.Visible = false;
                    break;
                case "ProxyID":
                    e.Column.Visible = false;
                    break;
                case "Priority":
                    e.Column.Visible = false;
                    break;
                case "DateCreated":
                    e.Column.Visible = false;
                    break;
                case "DateSended":
                    e.Column.Visible = false;
                    break;
                case "rScreenName":
                    e.Column.HeaderText = "Reciver Screen Name";
                    e.Column.Width = 150;
                    break;
                case "rUserID":
                    e.Column.Visible = false;
                    break;

                case "nextTryDate":
                    e.Column.Visible = false;
                    break;
                case "SenderscreenName":

                    e.Column.HeaderText = "Sender";
                    e.Column.Width = 150;
                    e.Column.Frozen = true;
                    e.Column.DisplayIndex = 0;

                    break;
                default:
                    
                    break;
            }
        }

        private void tsImportMessage_Click(object sender, EventArgs e)
        {
            frmImportMessage import = new frmImportMessage();
            if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void btnClearlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtLog.Clear();
        }

        private void sTimer_Tick(object sender, EventArgs e)
        {
            var date = DateTime.Now;
            if (Classes.AppSetting.Uinterval)
            {
                int hs = Classes.AppSetting.Fh;
                int ms = Classes.AppSetting.Fm;

                int he = Classes.AppSetting.Th;
                int me = Classes.AppSetting.Tm;

                int stime = hs * 60 + ms;
                int etime = he * 60 + me;

                int ctime = date.Hour * 60 + date.Minute;


                if (ctime <= etime && ctime >= stime)
                {
                    if (btnPlay.Enabled)
                    {
                        if (Classes.AppSetting.AutoStart)
                            btnPlay_Click(btnPause, new EventArgs());
                    }
                }
                else
                {
                    if (btnPause.Enabled)
                        btnPause_Click(btnPause, new EventArgs());
                }
            }
        }

        private void tsRemoveall_Click(object sender, EventArgs e)
        {
            var messages = db.Messages.Where(aa => aa.DateSended == null).OrderBy(zz => zz.nextTryDate);
            var messagearray = messages.ToArray();

            List<int> DeletedMessageID = new List<int>();

            foreach (DataGridViewRow item in messageGridView.Rows)
            {
                var message = item.DataBoundItem as Message;
                if (DeletedMessageID.Contains(message.id)) continue;

                var dMessages = messagearray.Where(aa => aa.rScreenName == message.rScreenName && aa.Message1 == message.Message1 && aa.id != message.id);

                if (dMessages.Count() >= 0)
                    foreach (var dMessage in dMessages)
                        DeletedMessageID.Add(dMessage.id);


            }

            foreach (var item in DeletedMessageID)
            {
                db.Messages.DeleteObject(db.Messages.FirstOrDefault(aa => aa.id == item));
            }
            db.SaveChanges();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var messages = db.Messages.Where(aa => aa.DateSended == null).OrderBy(zz => zz.nextTryDate);
            var messagearray = messages.ToArray();

            List<int> DeletedMessageID = new List<int>();

            foreach (DataGridViewRow item in messageGridView.Rows)
            {
                var message = item.DataBoundItem as Message;
                if (DeletedMessageID.Contains(message.id)) continue;

                var dMessages = messagearray.Where(aa => aa.rScreenName == message.rScreenName && aa.id != message.id);

                if (dMessages.Count() >= 0)
                    foreach (var dMessage in dMessages)
                        DeletedMessageID.Add(dMessage.id);


            }

            foreach (var item in DeletedMessageID)
            {
                db.Messages.DeleteObject(db.Messages.FirstOrDefault(aa => aa.id == item));
            }
            db.SaveChanges();
        }

        private void btnWebSetting_Click(object sender, EventArgs e)
        {
            Forms.frmWebSetting web = new Forms.frmWebSetting();
            web.ShowDialog();
        }
    }
}
