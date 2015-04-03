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
    public partial class FrmBackupFF : Form
    {
        public FrmBackupFF()
        {
            InitializeComponent();
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
    }
}
