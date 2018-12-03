using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Twitterizer;

namespace TwitterAtomationWa.DM
{
    public partial class frmMainForms : Form
    {
        public frmMainForms()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMainForms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.Account' table. You can move, or remove it, as needed.
            //this.accountTableAdapter.Fill(this.dataDataSet.Account);



        }

        private void tsAddAccount_Click(object sender, EventArgs e)
        {
            frmUserManagement user = new frmUserManagement();
            user.ShowDialog();
        }

        private void lsAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lsMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmMainForms_Shown(object sender, EventArgs e)
        {
            lsAccount.DataSource = new TwitterAtomationWa.DataEntities().Accounts;
            lsAccount.DataSourceChanged += lsAccount_DataSourceChanged;
        }

        void lsAccount_DataSourceChanged(object sender, EventArgs e)
        {
            if (lsAccount.Items.Count > 0)
            {
                lsAccount.SelectedItem = lsAccount.Items[0];
                lsAccount_Click(lsAccount, new EventArgs());
            }
        }

        private void lsAccount_Click(object sender, EventArgs e)
        {
            lsMessage.Enabled = lsAccount.Enabled = false;

            if (lsAccount.SelectedIndex != -1)
            {
                System.Threading.Thread T = new System.Threading.Thread(new System.Threading.ThreadStart(LoadMessage));
                T.IsBackground = true;
                T.Start();
                
            }
        }

        private void LoadMessage()
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    panel2.Enabled = false;
                }));
                var SelectedItem = (TwitterAtomationWa.Account)this.Invoke(new Func<TwitterAtomationWa.Account>(() => lsAccount.SelectedItem as TwitterAtomationWa.Account));

                Twitterizer.TwitterDirectMessageCollection messages = this.CurrentDMMessages = TwitterAtomationWa.Classes.TwitterHelper.GetDms((SelectedItem as TwitterAtomationWa.Account).ScreenName);


                List<TwitterUserAddition> Users = getSenderUser(messages);

                this.Invoke(new MethodInvoker(delegate()
                {
                    lsMessage.DataSource = Users;
                    //lsMessage.DisplayMember = "Message";
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    lsMessage.Enabled = lsAccount.Enabled = true;
                    panel2.Enabled = true;
                }));
            }
        }

        public List<TwitterUserAddition> getSenderUser(Twitterizer.TwitterDirectMessageCollection messages)
        {
            var user = messages.Select(a => a.Sender).Union(messages.Select(aa => aa.Recipient));

            var use = from a in user
                       group a  by a.ScreenName into grouping
                       select grouping;

            List<TwitterUserAddition> additions = new List<TwitterUserAddition>();
            foreach (var item in use)
            {
                additions.Add(new TwitterUserAddition(item.FirstOrDefault()));
            }


            var SelectedItem = (TwitterAtomationWa.Account)this.Invoke(new Func<TwitterAtomationWa.Account>(() => lsAccount.SelectedItem as TwitterAtomationWa.Account));
            additions.Remove(additions.FirstOrDefault(aa => aa.TwitterUser.ScreenName == SelectedItem.ScreenName));
            
            return additions;
        }

        private void lsMessage_Click(object sender, EventArgs e)
        {
            if (lsMessage.SelectedItem != null)
            {
                DM.frmDmMessage message = new DM.frmDmMessage();
                message.CurrentScreenName = ((TwitterAtomationWa.Account)this.Invoke(new Func<TwitterAtomationWa.Account>(() => lsAccount.SelectedItem as TwitterAtomationWa.Account))).ScreenName;
                message.RemoteScreenName = (lsMessage.SelectedItem as TwitterUserAddition).TwitterUser.ScreenName;
                message.Messages = CurrentDMMessages;
                message.ShowDialog();
                //lsAccount_Click(null, null);
            }
        }

        private void lsMessage_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var item = lsMessage.Items[e.Index];
            
            var dmUser = item as TwitterUserAddition;
            
            e.Graphics.DrawLine(new Pen(Color.FromArgb(100, 100, 100), 3), new Point(0, e.Bounds.Bottom), new Point(e.Bounds.Width, e.Bounds.Bottom));
            e.Graphics.DrawImage(dmUser.UserImage, new Rectangle(10 + e.Bounds.Left, 10 + e.Bounds.Top, 50, 50));
            e.Graphics.DrawString(dmUser.TwitterUser.ScreenName, new Font(this.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Pixel), new SolidBrush(Color.Gray), new PointF(70 + e.Bounds.Left, 20 + e.Bounds.Top));


            TwitterDirectMessage firstMessage = GetFirstMessage(dmUser);

            e.Graphics.DrawString(firstMessage.Text, new Font(this.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Pixel), new SolidBrush(Color.Gray), new PointF(70 + e.Bounds.Left, 40 + e.Bounds.Top));
            e.Graphics.DrawString(firstMessage.CreatedDate.ToShortDateString(), new Font(this.Font.FontFamily, 14, FontStyle.Bold, GraphicsUnit.Pixel), new SolidBrush(Color.Gray), new PointF(e.Bounds.Right, e.Bounds.Top + 5), new StringFormat() { Alignment = StringAlignment.Far });


        }

        private TwitterDirectMessage GetFirstMessage(TwitterUserAddition dmUser)
        {
            var message = CurrentDMMessages.Where(aa => aa.SenderScreenName == dmUser.TwitterUser.ScreenName ||
                                                        aa.RecipientScreenName == dmUser.TwitterUser.ScreenName
                ).OrderByDescending(aa => aa.CreatedDate).FirstOrDefault();
                return message;

        }
        private void tsSetting_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
        }

        private void tsProxyButton_Click(object sender, EventArgs e)
        {
            frmProxies frm = new frmProxies();

            frm.ShowDialog();
        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            lsAccount.DataSource = null;
            lsAccount.DisplayMember = "ScreenName";
            lsAccount.DataSource = new TwitterAtomationWa.DataEntities().Accounts;
            lsAccount.DataSourceChanged += lsAccount_DataSourceChanged;
        }

        public Twitterizer.TwitterDirectMessageCollection CurrentDMMessages { get; set; }
    }

    public class TwitterUserAddition
    {
        public Twitterizer.TwitterUser TwitterUser { get; set; }
        public Image UserImage { get; set; }

        public TwitterUserAddition(TwitterUser user)
        {
            
            this.TwitterUser = user;
            try
            {
                var Imagebyte = new WebClient().DownloadData(user.ProfileImageLocation);
                UserImage = Image.FromStream(new MemoryStream(Imagebyte));
            }
            catch (Exception ex)
            {
                UserImage = global::TwitterAtomationWa.Properties.Resources.NoImages;
            }
        }
    }
}
