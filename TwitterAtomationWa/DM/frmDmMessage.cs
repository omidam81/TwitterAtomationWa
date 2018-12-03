using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using TwitterAtomationWa.Classes;
using Twitterizer;

namespace TwitterAtomationWa.DM
{
    public partial class frmDmMessage : Form
    {
        public frmDmMessage()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Twitterizer.RequestResult R = Twitterizer.RequestResult.Unknown;
            TwitterAtomationWa.Classes.TwitterHelper.SendDmMessage(this.CurrentScreenName, this.RemoteScreenName, txtMessage.Text, out R);

            if (R == Twitterizer.RequestResult.Success)
            {
                this.Text = "";

                AddMessage(this.CurrentScreenName, this.RemoteScreenName, this.Text, DateTime.Now);

                //this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    
                //this.Close();
            }
            else
            {
               // MessageBox.Show(R.ToString());
            }


        }

        private void AddMessage(string screenName, string RemoteScreenName, string Text, DateTime dateTime)
        {
        }
        Twitterizer.Streaming.TwitterStream T;
        private void frmDmMessage_Load(object sender, EventArgs e)
        {
            T = new Twitterizer.Streaming.TwitterStream(TwitterAtomationWa.Classes.TwitterHelper.GetUserOAuthTokens(CurrentScreenName), "", new Twitterizer.Streaming.StreamOptions());
            T.StartUserStream(null, null, null, null, new Twitterizer.Streaming.DirectMessageCreatedCallback(MessageC), new Twitterizer.Streaming.DirectMessageDeletedCallback(MessageR), null, new Twitterizer.Streaming.RawJsonCallback(JsonResult));
        }

        private void JsonResult(string json)
        {
            //throw new NotImplementedException();
            try
            {
                if (json.StartsWith("{\"direct_message\":"))
                {
                    try
                    {
                        //var SelectedItem = (TwitterAtomationWa.Account)this.Invoke(new Func<TwitterAtomationWa.Account>(() => lsAccount.SelectedItem as TwitterAtomationWa.Account));

                        Twitterizer.TwitterDirectMessageCollection messages = Program.main.CurrentDMMessages = TwitterAtomationWa.Classes.TwitterHelper.GetDms(CurrentScreenName);


                        List<TwitterUserAddition> Users = Program.main.getSenderUser(messages);

                        Program.main.Invoke(new MethodInvoker(delegate()
                        {
                            Program.main.lsMessage.DataSource = Users;
                            this.Messages = messages;
                            //lsMessage.DisplayMember = "Message";
                        }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        
                        Program.main.Invoke(new MethodInvoker(delegate
                        {
                            lsMessage.Enabled = Program.main.lsAccount.Enabled = true;
                            Program.main.panel2.Enabled = true;
                        }));

                        SafeClose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void SafeClose()
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new Action(SafeClose));
                return;
            }
            Close();
        }



        private void MessageR(Twitterizer.Streaming.TwitterStreamDeletedEvent status)
        {
            
        }

        private void MessageC(Twitterizer.TwitterDirectMessage status)
        {
            this.Messages.Add(status);
            lsMessage.DataSource = this.Messages;
        }

        public Twitterizer.TwitterDirectMessageCollection _Messages;


        public Twitterizer.TwitterDirectMessageCollection Messages
        {
            set
            {
                var V = value.Where(aa => 
                    (aa.Recipient.ScreenName == CurrentScreenName && aa.Sender.ScreenName == RemoteScreenName) ||
                    (aa.Recipient.ScreenName == RemoteScreenName && aa.Sender.ScreenName == CurrentScreenName)).OrderBy(aa => aa.CreatedDate).ToArray();


                _Messages = new Twitterizer.TwitterDirectMessageCollection();

                foreach (var item in V)
                {
                    _Messages.Add(item);
                }

                this.lsMessage.DataSource = _Messages;
            }

            get
            {
                return _Messages;
            }
        }

        private void lsMessage_DrawItem(object sender, DrawItemEventArgs e)
        {
            Twitterizer.TwitterDirectMessage message = lsMessage.Items[e.Index] as Twitterizer.TwitterDirectMessage;

            bool b1 = (message.SenderScreenName == CurrentScreenName);
            if (b1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                StringFormat sFormat = new StringFormat();
                sFormat.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(message.SenderScreenName, new Font(this.Font.FontFamily, 10, FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(e.Bounds.Right, e.Bounds.Top), sFormat);
                e.Graphics.DrawString(message.Text, new Font(this.Font.FontFamily, 9, FontStyle.Italic), new SolidBrush(Color.Gray), new RectangleF(e.Bounds.Left, e.Bounds.Top + 18, e.Bounds.Width, 40), sFormat);
                e.Graphics.DrawString(message.CreatedDate.ToLongDateString(), new Font(this.Font.FontFamily, 8, FontStyle.Bold), new SolidBrush(Color.Gray), new PointF(e.Bounds.Right, e.Bounds.Bottom - 15), sFormat);
                e.Graphics.DrawLine(new Pen(Color.Gray, 2), new Point(e.Bounds.Left, e.Bounds.Bottom - 1), new Point(e.Bounds.Right, e.Bounds.Bottom - 1));
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.WhiteSmoke), e.Bounds);
                e.Graphics.DrawString(message.SenderScreenName, new Font(this.Font.FontFamily, 10, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(e.Bounds.Left
                    , e.Bounds.Top));
                e.Graphics.DrawString(message.Text, new Font(this.Font.FontFamily, 9, FontStyle.Italic), new SolidBrush(Color.Black), new RectangleF(e.Bounds.Left, e.Bounds.Top + 18, e.Bounds.Width, 40));
                e.Graphics.DrawString(message.CreatedDate.ToLongDateString(), new Font(this.Font.FontFamily, 8, FontStyle.Bold), new SolidBrush(Color.Black), new PointF(e.Bounds.Left, e.Bounds.Bottom - 15));
                e.Graphics.DrawLine(new Pen(Color.Black, 2), new Point(e.Bounds.Left, e.Bounds.Bottom - 1), new Point(e.Bounds.Right, e.Bounds.Bottom - 1));
            }


        }


        public string CurrentScreenName { get; set; }
        private string _RemoteScreenName = "";
        public string RemoteScreenName { get { return _RemoteScreenName; } set { _RemoteScreenName = value; this.Text = _RemoteScreenName; } }

        private void lsMessage_ClientSizeChanged(object sender, EventArgs e)
        {
            int visibleItems = lsMessage.ClientSize.Height / lsMessage.ItemHeight;
            lsMessage.TopIndex = Math.Max(lsMessage.Items.Count - visibleItems + 1, 0);
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            this.btnSend.Enabled = !string.IsNullOrWhiteSpace(txtMessage.Text);
        }

        private void frmDmMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            T.EndStream();
        }

        private void lsMessage_Validating(object sender, CancelEventArgs e)
        {
            lsMessage.SelectedIndex = lsMessage.Items.Count - 1;
        }
    }
}
