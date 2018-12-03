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

namespace TwitterAtomationWa
{
    public partial class frmAddMessage : Form
    {
        public frmAddMessage()
        {
            InitializeComponent();
        }

        TwitterAtomationWa.DataEntities en = new DataEntities();
        private void allAccount_CheckedChanged(object sender, EventArgs e)
        {
            txtUsers.Enabled = llSelectUsers.Enabled = !rdoallAccount.Checked;

            if (rdoallAccount.Checked)
            {
                txtUsers.Text = getALLUserText();
            }
            else
            {
                txtUsers.Text = "";
            }
        }

        private string getALLUserText()
        {
            var str = "";
            foreach (var item in en.Accounts)
            {
                str += item.ScreenName + ", ";
            }
            return str;
        }

        private void llSelectUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSelectUser select = new frmSelectUser();
            if (select.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtUsers.Text = select.SelectedMemberList;
            }
        }
        public bool CanClose { get; set; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SsWaiting.Visible = true;
            CanClose = false;


            DisableAllControl();


            
            System.Threading.Thread th = new System.Threading.Thread(new System.Threading.ThreadStart(DoAddMessage));
            th.Start();
        }

        private void DisableAllControl()
        {
            foreach (var item in this.Controls)
            {
                (item as Control).Enabled = false;
            }
        }

        private void EnabledAllControl()
        {
            foreach (var item in this.Controls)
            {
                (item as Control).Enabled = true;
            }
        }
        private void DoAddMessage()
        {
            var messags = txtMessage.Text.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in txtUsers.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    DeleteTempFollowersFile(item);
                }
            }
            foreach (string strmessage in messags)
            {
                List<TwitterAtomationWa.Message> Messages = new List<Message>();
                if (rdoRandomSelect.Checked)
                {
                    
                    Messages = GetRandomMessages(strmessage, 1, (int)nUNumber.Value);
                }
                else
                {
                    Messages = GetMessages(strmessage, 1);
                }
                int i = 0;
                foreach (var item in Messages)
                {
                    i++;

                    en.Messages.AddObject(item);
                    if(i % 150 == 0)
                        en.SaveChanges();
                }
                en.SaveChanges();
            }
            


            this.BeginInvoke(new MethodInvoker(delegate()
            {
                SsWaiting.Visible = false;
                CanClose = true;
                EnabledAllControl();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }));
        }

        private List<Message> GetRandomMessages(string message, int type, int Count)
        {
            List<Message> Messages = new List<Message>();

            string strusers = txtUsers.Text;
            string[] users = strusers.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in users)
            {
                var v = en.Accounts.FirstOrDefault(aa => aa.ScreenName == item);
                if (v != null)
                {
                    var followers = GetRandomUser(Count, v.ScreenName);
                    if (followers == null) continue;
                    foreach (var follower in followers)
                    {
                        TwitterAtomationWa.Message M = new Message()
                        {
                            DateCreated = DateTime.Now,
                            Message1 = message,
                            UserID = v.id,
                            rScreenName = follower.ScreenName,
                            Priority = type,
                            rUserID = follower.Id,
                            SenderscreenName = v.ScreenName
                        };
                        Messages.Add(M);
                    }
                }
            }
            return Messages;

        }

        private Twitterizer.TwitterUserCollection GetRandomUser(int Count, string sScreenName)
        {
            
            Twitterizer.TwitterUserCollection vUsers = new Twitterizer.TwitterUserCollection();
            List<string> ReadedUser = getUserFromFile(sScreenName);
            var vUser = TwitterAtomationWa.Classes.TwitterHelper.GetFollowers(sScreenName);
            var v = vUser.Where(aa => !ReadedUser.Contains(aa.ScreenName)).OrderBy(aa => Guid.NewGuid()).Take(Count).ToList();
            if (v.Count < Count)
            {
                DeleteTempFollowersFile(sScreenName);
                int xrCount = Count - v.Count;
                var vnext = vUser.OrderBy(aa => Guid.NewGuid()).Take(xrCount);
                foreach (var item in v)
                    vUsers.Add(item);
                foreach (var item in vnext)
                    vUsers.Add(item);
                AddUserToFile(sScreenName, vnext.Select(aa => aa.ScreenName).ToList());
            }
            else
            {
                AddUserToFile(sScreenName, v.Select(aa => aa.ScreenName).ToList());
                foreach (var item in v)
                {
                    vUsers.Add(item);
                }
                
            }
            return vUsers;
        }

        private void DeleteTempFollowersFile(string sScreenName)
        {
            var fileName = string.Format("{0}/tmp/{1}.send", new FileInfo(Application.ExecutablePath).DirectoryName, sScreenName);

            if (File.Exists(fileName))
                File.Delete(fileName);
        }

        private List<string> getUserFromFile(string sScreenName)
        {
            var fileName = string.Format("{0}/tmp/{1}.send", new FileInfo(Application.ExecutablePath).DirectoryName, sScreenName);
            var directoryName = new FileInfo(Application.ExecutablePath).DirectoryName;
            if (File.Exists(fileName))
            {
                StreamReader reader =  File.OpenText(fileName);
                var users = reader.ReadToEnd().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var tUsers = new List<string>();
                foreach (var item in users)
                {
                    tUsers.Add(item);
                }
                reader.Close();
                return tUsers;
               
            }
            return new List<string>();
        }

        private void AddUserToFile(string sScreenName, List<string> Users)
        {
            var fileName = string.Format("{0}/tmp/{1}.send", new FileInfo(Application.ExecutablePath).DirectoryName, sScreenName);
            StreamWriter w;
            if (!File.Exists(fileName))
            {
                if (!Directory.Exists(new FileInfo(Application.ExecutablePath).DirectoryName))
                    Directory.CreateDirectory(new FileInfo(Application.ExecutablePath).DirectoryName);
                w = new StreamWriter(File.Create(fileName));
            }
            else
            {
                w = new StreamWriter(fileName, true);
            }
            foreach (var item in Users)
            {
                w.WriteLine(item);
            }
            w.Close();
        }


        private List<Message> GetMessages(string message, int type)
        {
            List<Message> Messages = new List<Message>();
            if (rdoAll.Checked)
            {
                string strusers = txtUsers.Text;
                string[] users = strusers.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in users)
                {


                    var str = item.Trim();



                    var v = en.Accounts.FirstOrDefault(aa => aa.ScreenName == str);
                    if (v != null)
                    {
                        var followers = Classes.TwitterHelper.GetFollowers(v.ScreenName);

                        if (followers == null) continue;
                        foreach (var follower in followers)
                        {
                            TwitterAtomationWa.Message M = new Message()
                            {
                                DateCreated = DateTime.Now,
                                Message1 = message,
                                UserID = v.id,
                                rScreenName = follower.ScreenName,
                                Priority = type,
                                rUserID = follower.Id,
                                SenderscreenName = v.ScreenName
                            };
                            Messages.Add(M);
                        }
                    }

                }

            }
            else
            {
                foreach (var follower in Users)
                {
                    var cuser = follower.Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[0];
                    var rmoteUser = follower.Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)[1];
                    var v = en.Accounts.FirstOrDefault(aa => aa.ScreenName == cuser);
                    TwitterAtomationWa.Message M = new Message()
                    {
                        DateCreated = DateTime.Now,
                        Message1 = message,
                        UserID = v.id,
                        rScreenName = rmoteUser,
                        Priority = type,
                        SenderscreenName = v.ScreenName
                    };
                    Messages.Add(M);
                }
            }
            return Messages;
        }

        private void txtUsers_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = btnSendNow.Enabled = (!string.IsNullOrEmpty(txtMessage.Text) &&
                (rdoallAccount.Checked || !string.IsNullOrEmpty(txtUsers.Text)));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddMessage_Load(object sender, EventArgs e)
        {
            txtUsers.Text = getALLUserText();
            CanClose = true;
        }

        private void rdoAccountForUser_CheckedChanged(object sender, EventArgs e)
        {

        }


        public string[] Users { get; set; }

        private void rdoThisUsers_CheckedChanged(object sender, EventArgs e)
        {
            lblSelectFile.Enabled = lblSelectUsers.Enabled = rdoThisUsers.Checked;
        }

        private void lblSelectFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            Open.Filter = "Text Files|*.txt;";

            if (Open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var str = new StreamReader(Open.OpenFile()).ReadToEnd();
                Users = str.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private void lblSelectUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var user = txtUsers.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            frmSelectFollowers flowers = new frmSelectFollowers(user);
            if (flowers.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.Users = flowers.SelectedUser;
            }

        }

        private void rdoRandomSelect_CheckedChanged(object sender, EventArgs e)
        {
            nUNumber.Enabled = ((sender) as CheckBox).Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader reader = new StreamReader(open.OpenFile());
                var st = reader.ReadToEnd();
                reader.Close();
                txtMessage.Text = st;
            }
        }

        private void frmAddMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CanClose;
        }
    }
}
