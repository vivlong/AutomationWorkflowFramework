using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Newtonsoft.Json;
using System.IO;

namespace AWF
{
    public partial class Frm_Config : Form
    {
        public Frm_Config()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            this.txtSkype.Text = Classes.SaveSetting.strSkypes;
            this.txtDBFilePath.Text = Classes.SaveSetting.strRestoreDBPath;
        }

        private void cmdSaveConfig_Click(object sender, EventArgs e)
        {
            string[] users = this.txtSkype.Text.Trim().Split(';');
            ArrayList al = new ArrayList();
            for (int i = 0; i <= users.Length - 1; i++)
            {
                al.Add(users[i]);
            }
            Classes.SaveSetting.ConfigInfo ci = new Classes.SaveSetting.ConfigInfo();
            ci.RestoreDBPath = this.txtDBFilePath.Text.Trim();
            ci.SkypeUser = al;
            string json = JsonConvert.SerializeObject(ci);
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("json", json);
            if(Classes.SaveSetting.SetConfig(parameters))
                MessageBox.Show("Save Sccuess!");
        }

        private void btn_SaveConf_Click(object sender, EventArgs e)
        {
            
        }
    }
}
