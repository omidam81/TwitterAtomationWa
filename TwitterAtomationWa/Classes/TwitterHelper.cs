using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterAtomationWa.DM;
using Twitterizer;

namespace TwitterAtomationWa.Classes
{
    public class TwitterHelper
    {
        public static bool SendDmMessage(string SenderScreenName, string ReciverScreenName, string Message, out RequestResult Result)
        {
            var vUser = GetUser(SenderScreenName);
            if (vUser == null) { Result = RequestResult.Unknown; return false; }
            if (!Classes.AppSetting.UseProxy || string.IsNullOrWhiteSpace(vUser.ProxyAddress))
            {
                OAuthTokens Oa = GetUserOAuthTokens(SenderScreenName);
                if (!CanSendMessage(AppSetting.Username, AppSetting.Password, ReciverScreenName, Message, SenderScreenName)) { Result = RequestResult.Unauthorized; return false; }

                var omRes = TwitterDirectMessage.Send(Oa, ReciverScreenName, Message);
                if (omRes.Result == RequestResult.Unauthorized)
                {
                    if (LoginUser(vUser.ScreenName, vUser.Name, vUser.ProxyAddress))
                    {
                        return SendDmMessage(SenderScreenName, ReciverScreenName, Message, out Result);
                    }
                    else
                    {
                        DeleteUser(vUser);
                        Result = RequestResult.NotAcceptable;
                        return false;
                    }
                }
                Result = omRes.Result;
                return (Result == RequestResult.Success);
            }
            else
            {
                var Proxy = vUser.ProxyAddress;

                var option = new OptionalProperties();
                option.Proxy = GetProxy(Proxy);
                OAuthTokens Oa = GetUserOAuthTokens(SenderScreenName);
                if (!CanSendMessage(AppSetting.Username, AppSetting.Password, ReciverScreenName, Message, SenderScreenName)) { Result = RequestResult.Unauthorized; return false; }
                var omRes = TwitterDirectMessage.Send(Oa, ReciverScreenName, Message, null);
                Result = omRes.Result;
                return (Result == RequestResult.Success);

            }
        }

        private static void DeleteUser(Account vUser)
        {
            var db = new TwitterAtomationWa.DataEntities();
            var messages = db.Messages.Where(aa => aa.SenderscreenName == vUser.ScreenName);
            foreach (var message in messages)
            {
                db.Messages.DeleteObject(message);
                db.SaveChanges();
            }
            var vU = db.Accounts.FirstOrDefault(aa => aa.ScreenName == vUser.ScreenName);
            
            db.Accounts.DeleteObject(vU);
            db.SaveChanges();

            SaveDeleteUserInTempFile(vUser);
        }

        private static void SaveDeleteUserInTempFile(Account vUser)
        {
            var pathToSave = Path.Combine(new FileInfo(Application.ExecutablePath).DirectoryName, "DeletedUser.file");
            if (File.Exists(pathToSave))
            {
                StreamWriter writer = File.CreateText(pathToSave);

                writer.WriteLine(vUser.ScreenName + " : " + vUser.Name + " : " + vUser.ProxyAddress);
                writer.Close();
            }
            else
            {
                StreamWriter writer = new StreamWriter(File.OpenWrite(pathToSave));
                writer.WriteLine(vUser.ScreenName + " : " + vUser.Name + " : " + vUser.ProxyAddress);
                writer.Close();
            }
        }

        private static System.Net.WebProxy GetProxy(string Proxy)
        {
            try
            {
                string[] str = Proxy.Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var username = str[2];
                var address = str[0];
                var port = str[1];
                var password = str[3];
                System.Net.WebProxy proxy = new System.Net.WebProxy(address, Convert.ToInt32(port));
                proxy.Credentials = new System.Net.NetworkCredential(username, password);
                return proxy;
            }
            catch
            {
                return null;
            }

        }

        public static Account GetUser(string SenderScreenName)
        {
            var db = new DataEntities();
            return db.Accounts.FirstOrDefault(aa => aa.ScreenName == SenderScreenName);
        }

        public static void SendMessageToAllFollowers(string SenderScreenName, string Message)
        {

        }
        public static OAuthTokens GetUserOAuthTokens(string screenName)
        {
            TwitterAtomationWa.DataEntities en = new DataEntities();

            var user = en.Accounts.FirstOrDefault(aa => aa.ScreenName == screenName);
            if (user == null) return null;
            return new OAuthTokens() { AccessToken = user.Token, AccessTokenSecret = user.TokenSecret, ConsumerKey = AppSetting.ConsumerKey, ConsumerSecret = AppSetting.ConsumerSecret };
        }

        public static TwitterUserCollection GetFollowers(string screenName)
        {
            #region Check that is Titter Follower are Loaded before
            string AppPath = new FileInfo(Application.ExecutablePath).DirectoryName;
            string tempFDirectory = Path.Combine(AppPath, string.Format("{0}/tmp/{1}.tmp", AppPath, screenName));

            if (File.Exists(tempFDirectory))
            {
                FileInfo F = new FileInfo(tempFDirectory);

                if (F.CreationTime.Subtract(DateTime.Now).Hours < 100)
                {
                    StreamReader R = new StreamReader(F.Open(FileMode.Open));
                    var FileContent = R.ReadToEnd();
                    R.Close();
                    return JsonConvert.DeserializeObject<TwitterUserCollection>(FileContent);
                }
            }
            #endregion
            TwitterUserCollection twitterUser = new TwitterUserCollection();
            long Curssor = -1;
            while (true)
            {
                if (Curssor == 0) break;
                var folo = TwitterFriendship.Followers(GetUserOAuthTokens(screenName), new FollowersOptions() { Cursor = Curssor });
                var xO = JsonConvert.DeserializeObject<TwitterFollowersPage>(folo.Content);
                if (xO.users == null) return twitterUser;
                foreach (var item in xO.users)
                {
                    twitterUser.Add(new TwitterUser { Id = item.id, ScreenName = item.screen_name, Name = item.name, Description = item.description, ProfileImageLocation = item.profile_image_url });
                }

                Curssor = xO.next_cursor;
            }
            #region Save File For Later Use
            var wFileContent = JsonConvert.SerializeObject(twitterUser);
            if (!Directory.Exists(String.Format("{0}/tmp", AppPath)))
            {
                Directory.CreateDirectory(String.Format("{0}/tmp", AppPath));
            }

            if (File.Exists(tempFDirectory)) File.Delete(tempFDirectory);
            StreamWriter w = new StreamWriter(tempFDirectory);
            w.Write(wFileContent);
            w.Close();
            #endregion
            return twitterUser;
        }

        public static bool SendDmMessage(int? SenderUserID, string ReciverScreenName, string Message, out RequestResult Result)
        {

            if (SenderUserID.HasValue)
            {

                var v = new TwitterAtomationWa.DataEntities().Accounts.FirstOrDefault(a => a.id == SenderUserID);

                if (v != null)

                    return SendDmMessage(v.ScreenName, ReciverScreenName, Message, out Result);
            }

            Result = RequestResult.Unknown;
            return false;

        }

        public static TwitterDirectMessageCollection GetDms(string SenderScreenName)
        {
            var vUser = GetUser(SenderScreenName);
            if (vUser == null) { return null; }
            TwitterDirectMessageCollection message = new TwitterDirectMessageCollection();
            if (!Classes.AppSetting.UseProxy || string.IsNullOrWhiteSpace(vUser.ProxyAddress))
            {
                OAuthTokens Oa = GetUserOAuthTokens(SenderScreenName);
                var v = Twitterizer.TwitterDirectMessage.DirectMessages(Oa);
                var v2 = Twitterizer.TwitterDirectMessage.DirectMessagesSent(Oa);
                if (v.Result == RequestResult.Success)
                {
                    foreach (var item in v.ResponseObject)
                    {
                        message.Add(item);
                    }
                }
                else if(v.Result == RequestResult.Unauthorized)
                {
                    LoginUser(vUser.ScreenName, vUser.Name, vUser.ProxyAddress);
                    return GetDms(SenderScreenName);
                }

                if (v2.Result == RequestResult.Success)
                {
                    foreach (var item in v2.ResponseObject)
                    {
                        message.Add(item);
                    }
                }
                else if (v.Result == RequestResult.Unauthorized)
                {
                    LoginUser(vUser.ScreenName, vUser.Name, vUser.ProxyAddress);
                    return GetDms(SenderScreenName);
                }



                //message = new TwitterDirectMessageCollection();
            }
            else
            {
                var Proxy = vUser.ProxyAddress;

                var option = new OptionalProperties();
                OAuthTokens Oa = GetUserOAuthTokens(SenderScreenName);
                DirectMessagesOptions op = new DirectMessagesOptions();
                op.Proxy = GetProxy(Proxy);
                var v = Twitterizer.TwitterDirectMessage.DirectMessages(Oa, op);
                var v2 = Twitterizer.TwitterDirectMessage.DirectMessagesSent(Oa, new DirectMessagesSentOptions() { Proxy = op.Proxy });

                if (v.Result == RequestResult.Success)
                {
                    foreach (var item in v.ResponseObject)
                    {
                        message.Add(item);
                    }
                }
                else if (v.Result == RequestResult.Unauthorized)
                {
                    LoginUser(vUser.ScreenName, vUser.Name, vUser.ProxyAddress);
                    return GetDms(SenderScreenName);
                }
                if (v2.Result == RequestResult.Success)
                {
                    foreach (var item in v2.ResponseObject)
                    {
                        /*message.Add(new DMMessage()
                        {
                            DateSended = item.CreatedDate,
                            From = item.Sender.ScreenName,
                            Message = item.Text,
                            Title = item.Text,
                            To = item.RecipientScreenName
                        });*/

                        message.Add(item);
                    }
                }
                else if (v.Result == RequestResult.Unauthorized)
                {
                    LoginUser(vUser.ScreenName, vUser.Name, vUser.ProxyAddress);
                    return GetDms(SenderScreenName);
                }


                //message = message.OrderByDescending(aa => aa.DateSended).ToList();


            }

            return message;



        }

        public static OAuthTokens getToken(string CurrentScreenName)
        {
            throw new NotImplementedException();
        }


        public static bool LoginUser(string username, string password, string proxyaddress = "")
        {
            try
            {
                
                #region Login Part

                WebProxy P = GetProxy(proxyaddress);

                OAuthTokenResponse requestToken = OAuthUtility.GetRequestToken(Classes.AppSetting.ConsumerKey, Classes.AppSetting.ConsumerSecret, "oob");
                // Direct or instruct the user to the following address:
                Uri authorizationUri = OAuthUtility.BuildAuthorizationUri(requestToken.Token);
                //authenticity_token=aa84db7931040b1ed321372ae2b001ccf4f6e20e&oauth_token=uT3RaA72ld4sIZMwtUxlx1021VRjCkS0VEPyeYj3Fys&session%5Busername_or_email%5D=omidam81&session%5Bpassword%5D=omidomid

                HttpWebRequest R = (HttpWebRequest)HttpWebRequest.Create(authorizationUri);
                R.Proxy = P;
                CookieContainer Cookies = new CookieContainer();
                R.CookieContainer = Cookies;
                using (HttpWebResponse W = (HttpWebResponse)R.GetResponse())
                {

                    System.IO.StreamReader sr = new System.IO.StreamReader(W.GetResponseStream());

                    var str1111 = sr.ReadToEnd();
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(str1111);
                    var authenticity_token = doc.DocumentNode.SelectSingleNode("//input[@name='authenticity_token']").Attributes["value"].Value;
                    string url = string.Format("authenticity_token={0}&oauth_token={1}&session%5Busername_or_email%5D={2}&session%5Bpassword%5D={3}",
                        authenticity_token, requestToken.Token, username, password);
                    url = "https://twitter.com/oauth/authorize?" + System.Web.HttpUtility.HtmlDecode(url);

                    HttpWebRequest RP = (HttpWebRequest)HttpWebRequest.Create(url);
                    RP.Proxy = P;


                    RP.Method = "POST";
                    RP.CookieContainer = new CookieContainer();
                    foreach (Cookie item in W.Cookies)
                        RP.CookieContainer.Add(item);
                    HttpWebResponse WP = (HttpWebResponse)RP.GetResponse();
                    sr = new System.IO.StreamReader(WP.GetResponseStream());
                    str1111 = sr.ReadToEnd();
                    doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(str1111);
                #endregion
                    var code = doc.DocumentNode.SelectSingleNode("//kbd[@aria-labelledby='code-desc']/code").InnerHtml;
                    OAuthTokenResponse resp = OAuthUtility.GetAccessToken(Classes.AppSetting.ConsumerKey, Classes.AppSetting.ConsumerSecret, requestToken.Token, code);
                    #region Save To Database
                    var db = new TwitterAtomationWa.DataEntities();
                    var account = db.Accounts.FirstOrDefault(aa => aa.ScreenName == username);
                    if (account == null)
                    {
                        account = new Account()
                        {
                            DateCreated = DateTime.Now,
                            TokenSecret = resp.TokenSecret,
                            Token = resp.Token,
                            ScreenName = resp.ScreenName,
                            Name = password,
                            ProxyAddress = proxyaddress
                        };
                        db.Accounts.AddObject(account);
                        db.SaveChanges();

                    }
                    else
                    {
                        account.Token = resp.Token;
                        account.TokenSecret = resp.TokenSecret;
                        account.ProxyAddress = proxyaddress;
                        db.SaveChanges();
                    }

                }
                


                return true;
                #endregion
            }
            catch
            {
                return false;
            }



        }

        public static bool CanSendMessage(string username, string password, string followers, string message, string sender)
        {
            if (!Classes.AppSetting.UseCentralDatabase) return false;
            var client = new WebClient();
            string strWebData =string.Format("username={0}&password={1}&followers={2}&message={3}&sender={4}",username, password, followers, message, sender);
            strWebData = Classes.AppSetting.PostUrl + "?" + strWebData;

            var result = client.DownloadString(strWebData);
            if (result == "unautorized") { return false; }

            bool b1;
            if (bool.TryParse(result, out b1))
                return b1;
            return false;


        }
    }

    public class TwitterFollowersPage
    {
        public long previous_cursor = -1;
        public string previous_cursor_str = "-1";
        public long next_cursor;
        public string next_cursor_str = "-1";
        public mTwitterUser[] users;
    }

    public class mTwitterUser
    {
        public string profile_sidebar_fill_color;
        public string profile_sidebar_border_color;
        public bool? profile_background_tile;
        public string name;
        public string profile_image_url;
        public string created_at;
        public string location;
        public bool? follow_request_sent;
        public string profile_link_color;
        public bool? is_translator;
        public string id_str;
        public bool? default_profile;
        public bool? contributors_enabled;
        public int favourites_count;
        public string url;
        public string profile_image_url_https;
        public string utc_offset;
        public int id;
        public bool? profile_use_background_image;
        public int listed_count;
        public string profile_text_color;
        public string lang;
        public int followers_count;
        public bool? Protected;
        public bool? notifications;
        public string profile_background_image_url_https;
        public string profile_background_color;
        public bool? verified;
        public bool? geo_enabled;
        public string time_zone;
        public string description;
        public bool? default_profile_image;
        public string profile_background_image_url;
        public int statuses_count;
        public int friends_count;
        public bool? following;
        public string screen_name;
    }

    public class mTwitterUser2
    {
        public int id;
        public bool? default_profile;
        public int followers_count;
        public string url;
        public bool? contributors_enabled;
        public string time_zone;
        public string profile_image_url_https;
        public string profile_background_color;
        public string utc_offset;
        public bool? verified;
        public string name;
        public int listed_count;
        public bool? geo_enabled;
        public string lang;
        public string profile_background_image_url;
        public string location;
        public string profile_link_color;
        public bool? Protected;
        public string profile_image_url;
        public string profile_background_image_url_https;
        public bool? is_translator;
        public bool? profile_use_background_image;
        public bool? notifications;
        public bool? follow_request_sent;
        public string screen_name;
        public string profile_text_color;
        public string id_str;
        public bool? default_profile_image;
        public bool? following;
        public int favourites_count;
        public int friends_count;
        public string profile_sidebar_border_color;
        public int statuses_count;
        public string created_at;
        public bool? profile_background_tile;
        public string description;
        public string profile_sidebar_fill_color;
    }

    public class myTwitterMessage
    {
        public mTwitterUser sender { get; set; }
        public mTwitterUser recipient { get; set; }
        public DateTime created_at { get; set; }
        public string text { get; set; }

    }

}
