using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using DevComponents.DotNetBar;

namespace AWF
{
    public partial class Main : Office2007Form
    {
        //[DllImport("shell32.dll", EntryPoint = "ShellExecuteA")]
        //public static extern int ShellExecute(int hwnd, String lpOperation, String lpFile, String lpParameters, String lpDirectory, int nShowCmd);
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Main()
        {
            InitializeComponent();
            //this.Font = Classes.FontHelper.SetFormFontByUsingMemoryFont();
            Classes.Modfunction.Get_Win32_Processor();
            Classes.Modfunction.Get_Win32_BaseBoard();
            Classes.Modfunction.Get_Win32_PhysicalMemory();
            Classes.Modfunction.Get_Win32_BIOS();
            if (!Classes.Modfunction.Get_IP_Address())
            {
                MessageBox.Show("Invalid Network Interface Controller Address!");
                System.Environment.Exit(0); 
            }
            //Qiniu.Conf.Config.ACCESS_KEY = "88_zth5M0BXGRvLHBJM59I3yTJbjzRAFhVZqGkKz";
            //Qiniu.Conf.Config.SECRET_KEY = "s8HnQb5fSM0vDE7kTt1Ab42nPR9lkPkuSiMDtGI-";
            Classes.Modfunction.Get_UTC_Datetime();
            //Classes.SaveSetting.GetSkypeUser();
            //Classes.SaveSetting.GetRestoreDBPath();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.pbMenu1.Click += new EventHandler(pbMenu1_Click);
            this.pbMenu2.Click += new EventHandler(pbMenu2_Click);
            this.pbMenu3.Click += new EventHandler(pbMenu3_Click);
            this.pbMenu4.Click += new EventHandler(pbMenu4_Click);
            this.pbMenu5.Click += new EventHandler(pbMenu5_Click);
            this.pbMenu6.Click += new EventHandler(pbMenu6_Click);
            this.pbMenu7.Click += new EventHandler(pbMenu7_Click);
            this.pbMenu8.Click += new EventHandler(pbMenu8_Click);
            this.pbMenu9.Click += new EventHandler(pbMenu9_Click);
            this.pbMenu10.Click += new EventHandler(pbMenu10_Click);

            this.toolStripStatusLabel1.Text = Classes.Modfunction.currentIP;
            this.toolStripStatusLabel3.Text = Classes.Modfunction.datetime_today.ToString("yyyyMMdd HH:mm:ss");
        }


        #region  菜单各项点击事件
        private void pbMenu1_Click(object sender, EventArgs e)
        {
            if (!AWF.Classes.Modfunction.CheckForm("Frm_Publishing"))
            {
                this.panel_Form.Controls.Clear();
                Frm_Publishing frmPB = new Frm_Publishing();
                frmPB.MdiParent = this;
                frmPB.Parent = this.panel_Form;
                frmPB.Show();
            }
        }

        private void pbMenu2_Click(object sender, EventArgs e)
        {
            if (!AWF.Classes.Modfunction.CheckForm("Frm_Edi"))
            {
                this.panel_Form.Controls.Clear();
                Frm_Edi Frm_Edi = new Frm_Edi();
                Frm_Edi.MdiParent = this;
                Frm_Edi.Parent = this.panel_Form;
                Frm_Edi.Show();
            }
        }

        private void pbMenu3_Click(object sender, EventArgs e)
        {
        }

        private void pbMenu4_Click(object sender, EventArgs e)
        {
        }

        private void pbMenu5_Click(object sender, EventArgs e)
        {
        }

        private void pbMenu6_Click(object sender, EventArgs e)
        {
        }

        private void pbMenu7_Click(object sender, EventArgs e)
        {
        }

        private void pbMenu8_Click(object sender, EventArgs e)
        {
        }

        private void pbMenu9_Click(object sender, EventArgs e)
        {
        }

        private void pbMenu10_Click(object sender, EventArgs e)
        {
        }

        private void no_Click(object sender, EventArgs e) { }
        #endregion

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        
    }
}
