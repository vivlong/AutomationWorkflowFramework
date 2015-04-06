using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AWF.Classes
{
    public class ConfHelper
    {
        public struct confJson
        {
            public struct requestXls
            {
                public string DbServer { get; set; }
                public string DbName { get; set; }
                public string DbUid { get; set; }
                public string DbPwd { get; set; }
            }
            public requestXls RequestXls;
        }
        public confJson ConfJson;

        public static confJson GetConf(string strConfPath)
        {
            confJson cj = new confJson();
            if (File.Exists(strConfPath))
            {
                try
                {
                    using (StreamReader sw = new StreamReader(strConfPath))
                    {
                        string str = sw.ReadLine();
                        if (!string.IsNullOrEmpty(str))
                        {
                            cj = (confJson)JsonConvert.DeserializeObject(str, typeof(confJson));
                        }
                    }
                }
                catch(Exception ex){ }
            }
            return cj;
        }

        public static void SaveConf(string strDbServer, string strDbName, string strDbUid, string strDbPwd)
        {
            confJson cj = new confJson();
            string strConfPath = System.Windows.Forms.Application.StartupPath + @"\config.json";
            cj = GetConf(strConfPath);
            cj.RequestXls.DbServer = strDbServer;
            cj.RequestXls.DbName = strDbName;
            cj.RequestXls.DbUid = strDbUid;
            cj.RequestXls.DbPwd = strDbPwd;
            try
            {
                using (StreamWriter sw = new StreamWriter(strConfPath, false))
                {
                    string str = JsonConvert.SerializeObject(cj);
                    sw.WriteLine(str);
                }
            }
            catch(Exception ex){ }
        }
    }
}
