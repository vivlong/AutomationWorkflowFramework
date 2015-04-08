using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Collections;
using Newtonsoft.Json;

namespace AWF.Classes
{
    public static class SaveSetting
    {
        [Serializable]
        public class ConfigInfo
        {
            public ConfigInfo(){ }
            public string RestoreDBPath { get; set; }
            public ArrayList SkypeUser { get; set; }
        }

        [Serializable]
        public class ConfigSatuts
        {
            public ConfigSatuts() { }
            public string Status { get; set; }
        }

        public static string strRestoreDBPath = "";
        public static string strSkypes = "";
        private static ConfigInfo ci = null;

        public static ConfigInfo GetConfig()
        {
            string strURL = "http://www.sysfreight.net/setting.json";
            HttpWebResponse response = Classes.HttpHelper.CreateGetHttpResponse(strURL, 0, null, null);
            if (response == null)
            {
                strURL = "http://192.168.0.230/setting.json";
                response = Classes.HttpHelper.CreateGetHttpResponse(strURL, 0, null, null);
            }
            string json = Classes.HttpHelper.GetResponseString(response);
            ci = JsonConvert.DeserializeObject<ConfigInfo>(json);
            //Newtonsoft.Json.Linq.JObject jo = Newtonsoft.Json.Linq.JObject.Parse(json);
            return ci;
        }

        public static void GetRestoreDBPath()
        {
            ci = GetConfig();
            if (ci == null)
            {
                strRestoreDBPath = null;
            }
            else
            {
                strRestoreDBPath = ci.RestoreDBPath;
            }
        }

        public static void GetSkypeUser()
        {
            ci = GetConfig();
            if (ci == null)
            {
                strSkypes = null;
            }
            else
            {
                ArrayList al = ci.SkypeUser;
                string skypes = null;
                for (int i = 0; i <= al.Count - 1; i++)
                {
                    skypes = skypes + al[i].ToString() + ";";
                }
                if (skypes.LastIndexOf(';') == skypes.Length - 1)
                {
                    skypes = skypes.Substring(0, skypes.Length - 1);
                }
                strSkypes = skypes;
            }
        }

        public static bool SetConfig(IDictionary<string, string> parameters)
        {
            string strURL = "http://www.sysfreight.net/conf.php";
            HttpWebResponse response = Classes.HttpHelper.CreatePostHttpResponse(strURL, parameters, 0, null, null);
            if (response == null)
            {
                strURL = "http://192.168.0.230/conf.php";
                response = Classes.HttpHelper.CreatePostHttpResponse(strURL, parameters, 0, null, null);
            }
            string json = Classes.HttpHelper.GetResponseString(response);
            ConfigSatuts cs = JsonConvert.DeserializeObject<ConfigSatuts>(json);
            if (cs != null && cs.Status == "200")
                return true;
            return false;
        }

    }
}
