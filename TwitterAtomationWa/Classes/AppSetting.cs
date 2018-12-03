using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterAtomationWa.Classes
{
    public class AppSetting
    {
        public static string ConsumerKey { get { return GetKeyValue("ConsumerKey"); } set { SetKayValue("ConsumerKey", value); } }
        public static string ConsumerSecret { get { return GetKeyValue("ConsumerSecret"); } set { SetKayValue("ConsumerSecret", value); } }
        public static bool UseProxy { get { return Convert.ToBoolean(GetKeyValue("UserProxy")); } set { SetKayValue("UserProxy", value.ToString()); } }
        public static int MessageCount { get { return Convert.ToInt32(GetKeyValue("MessageCount")); } set { SetKayValue("MessageCount", value.ToString()); } }
        public static int RetryCount { get { return Convert.ToInt32(GetKeyValue("RetryCount")); } set { SetKayValue("RetryCount", value.ToString()); } }
        private static string GetKeyValue(string name)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return configuration.AppSettings.Settings[name].Value;
        }
        private static void SetKayValue(string name, string val)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[name].Value = val;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");

        }
        public static bool DontSendReplicated { get { return Convert.ToBoolean(GetKeyValue("UserProxy")); } set { SetKayValue("UserProxy", value.ToString()); } }
        public static bool Uinterval { get { return Convert.ToBoolean(GetKeyValue("Uinterval")); } set { SetKayValue("Uinterval", value.ToString()); } }
        public static int Fh { get { return Convert.ToInt32(GetKeyValue("Fh")); } set { SetKayValue("Fh", value.ToString()); } }
        public static int Fm { get { return Convert.ToInt32(GetKeyValue("Fm")); } set { SetKayValue("Fm", value.ToString()); } }
        public static int Th { get { return Convert.ToInt32(GetKeyValue("Th")); } set { SetKayValue("Th", value.ToString()); } }
        public static int Tm { get { return Convert.ToInt32(GetKeyValue("Tm")); } set { SetKayValue("Tm", value.ToString()); } }
        public static bool AutoStart { get { return Convert.ToBoolean(GetKeyValue("AutoStart")); } set { SetKayValue("AutoStart", value.ToString()); } }
        public static string WebUrl { get { return GetKeyValue("webUrl"); } set { SetKayValue("webUrl", value); } }
        public static string Username { get { return GetKeyValue("Username"); } set { SetKayValue("Username", value); } }
        public static string Password { get { return GetKeyValue("Password"); } set { SetKayValue("Password", value); } }

        public static string PostUrl
        {
            get
            {
                if (string.IsNullOrWhiteSpace(WebUrl)) return "";
                if (WebUrl.EndsWith("/"))
                    WebUrl = WebUrl.Remove(WebUrl.Length - 1);
                return WebUrl + "/Message/CanSendMessage";
            }
        }
        public static bool UseCentralDatabase { get { return Convert.ToBoolean(GetKeyValue("usecentraldatabase")); } set { SetKayValue("usecentraldatabase", value.ToString()); } }

        
    }
}
