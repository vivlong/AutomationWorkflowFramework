using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DeveloperTools
{
    public partial class Frm_Edi : Form
    {
        public Frm_Edi()
        {
            InitializeComponent();
        }

        private void btn_EDI_Start_Click(object sender, EventArgs e)
        {
            string NewFolder = @"\\192.168.0.250\Other\Other " + Classes.Modfunction.datetime_today.ToString("yyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            if (!Directory.Exists(NewFolder))
            {
                Directory.CreateDirectory(NewFolder);
            }
            string FolderName = Classes.Modfunction.baseDPath + "Other";
            string[] files = Directory.GetFiles(FolderName);
            //int counts = files.Length;
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(NewFolder, name);
                File.Copy(file, dest, true);
            }
            MessageBox.Show("Send EDI to 250 Successful!");
        }
    }
}
