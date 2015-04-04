using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AWF
{
    public partial class Frm_BackupFF : Form
    {
        private string strSourceName;

        public Frm_BackupFF()
        {
            InitializeComponent();
            strSourceName = "";
        }

        private void btn_Backup_Folders_Select_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string folderPath = fbd.SelectedPath;
                    if (String.IsNullOrEmpty(folderPath))
                    {
                        txt_Backup_Folder_path.Text = folderPath;
                    }
                }
            }
        }

        private void btn_Backup_Folders_Start_Click(object sender, EventArgs e)
        {
            if (txt_Backup_Folder_path.Text.Length > 0 && Directory.Exists(txt_Backup_Folder_path.Text.Trim()))
            {
                Classes.ZipHelper.ZipFileDirectory(txt_Backup_Folder_path.Text.Trim(), txt_Backup_Folder_path.Text.Trim() + "_" + Classes.Modfunction.datetime_today.ToString("yyMMdd",System.Globalization.DateTimeFormatInfo.InvariantInfo) + ".zip");
            }
        }

        private void cmdSourceSendto_Click(object sender, EventArgs e)
        {
            string OriginalPath = @"\\192.168.0.250\Net Application";
            string DestinationPath = @"\\192.168.0.250\chiyung\Net";
            string[] files = Directory.GetDirectories(OriginalPath);
            int intStart = int.Parse(this.txtFrom.Text);
            int intTo = int.Parse(this.txtTo.Text);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                int intNew = 0;
                if (name.Length > 6)
                    intNew = int.Parse(name.Substring(0, 6));
                if (intNew >= intStart && intNew <= intTo)
                {
                    if (!Directory.Exists(DestinationPath + @"\" + name))
                        Directory.CreateDirectory(DestinationPath + @"\" + name);
                    SendFolderAllField(file, DestinationPath + @"\" + name);
                    this.strSourceName = @"New SysFreight Source" + this.strSourceName.Substring(@"sysfreightupdate_".Length - 1);
                    string strNewSourceName = Classes.Modfunction.baseDPath + this.strSourceName;
                    string nameNew = Path.GetFileName(strNewSourceName);
                    string dest = Path.Combine(DestinationPath + @"\" + name, nameNew);
                    File.Copy(strNewSourceName, dest, true);
                }
            }
        }
        private void SendFolderAllField(string strSource, string strTo)
        {
            string[] files = Directory.GetFiles(strSource);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(strTo, name);
                File.Copy(file, dest, true);
                if (name.Length > @"sysfreightupdate_".Length && name.Substring(0, @"sysfreightupdate_".Length) == @"sysfreightupdate_")
                {
                    strSourceName = name;
                }
            }
            files = Directory.GetDirectories(strSource);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                if (!Directory.Exists(strTo + @"\" + name))
                    Directory.CreateDirectory(strTo + @"\" + name);
                SendFolderAllField(file, strTo + @"\" + name);
            }
        }

    }
}
