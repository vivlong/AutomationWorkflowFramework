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

namespace DeveloperTools
{
    public partial class Main : Office2007Form
    {
        [DllImport("shell32.dll", EntryPoint = "ShellExecuteA")]
        public static extern int ShellExecute(int hwnd, String lpOperation, String lpFile, String lpParameters, String lpDirectory, int nShowCmd);

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Main()
        {
            InitializeComponent();
            this.Font = Classes.FontHelper.SetFormFontByUsingMemoryFont();
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
            Classes.SaveSetting.GetSkypeUser();
            Classes.SaveSetting.GetRestoreDBPath();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Classes.Modfunction.currentIP;
            toolStripStatusLabel3.Text = Classes.Modfunction.datetime_today.ToString("yyyyMMdd HH:mm:ss");
            if (!Classes.Modfunction.CheckForm("Frm_Publishing"))
            {
                this.panel_tabPage1.Controls.Clear();
                Frm_Publishing frmPB = new Frm_Publishing();
                frmPB.MdiParent = this;
                frmPB.Parent = this.panel_tabPage1;
                frmPB.Show();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text.Trim())
            {
                case "Publish Release":
                    if (!Classes.Modfunction.CheckForm("Frm_Publishing"))
                    {
                        this.panel_tabPage1.Controls.Clear();
                        Frm_Publishing frmPB = new Frm_Publishing();
                        frmPB.MdiParent = this;
                        frmPB.Parent = this.panel_tabPage1;
                        frmPB.Show();
                    }
                    break;
                case "EDI":
                    if (!Classes.Modfunction.CheckForm("Frm_Edi"))
                    {
                        this.panel_tabPage2.Controls.Clear();
                        Frm_Edi Frm_Edi = new Frm_Edi();
                        Frm_Edi.MdiParent = this;
                        Frm_Edi.Parent = this.panel_tabPage2;
                        Frm_Edi.Show();
                    }
                    break;
                case "Backup File/Folder":
                    if (!Classes.Modfunction.CheckForm("FrmBackupFF"))
                    {
                        this.panel_tabPage3.Controls.Clear();
                        FrmBackupFF frmBackupFF = new FrmBackupFF();
                        frmBackupFF.MdiParent = this;
                        frmBackupFF.Parent = this.panel_tabPage3;
                        frmBackupFF.Show();
                    }
                    break;
                case "Computer Info":
                    if (!Classes.Modfunction.CheckForm("Frm_ComputerInfo"))
                    {
                        this.panel_tabPage4.Controls.Clear();
                        Frm_ComputerInfo frmCI = new Frm_ComputerInfo();
                        frmCI.MdiParent = this;
                        frmCI.Parent = this.panel_tabPage4;
                        frmCI.Show();
                    }
                    break;
                case "Restore Database":
                    if (!Classes.Modfunction.CheckForm("Frm_RestoreDB"))
                    {
                        this.panel_tabPage5.Controls.Clear();
                        Frm_RestoreDB frmRDB = new Frm_RestoreDB();
                        frmRDB.MdiParent = this;
                        frmRDB.Parent = this.panel_tabPage5;
                        frmRDB.Show();
                    }
                    break;
                case "SQL Tools":
                    if (!Classes.Modfunction.CheckForm("Frm_SQLTool"))
                    {
                        this.panel_tabPage6.Controls.Clear();
                        Frm_SQLTool frmSQLT = new Frm_SQLTool();
                        frmSQLT.MdiParent = this;
                        frmSQLT.Parent = this.panel_tabPage6;
                        frmSQLT.Show();
                    }
                    break;
                case "Testing":
                    if (!Classes.Modfunction.CheckForm("Frm_Testing"))
                    {
                        this.panel_tabPage7.Controls.Clear();
                        Frm_Testing frmTest = new Frm_Testing();
                        frmTest.MdiParent = this;
                        frmTest.Parent = this.panel_tabPage7;
                        frmTest.Show();
                    }
                    break;
                //case "Cloud Storage":
                //    if (!Classes.Modfunction.CheckForm("FrmCloudStorage"))
                //    {
                //        this.panel_tabPage8.Controls.Clear();
                //        Frm_CloudStorage frmOSS = new Frm_CloudStorage();
                //        frmOSS.MdiParent = this;
                //        frmOSS.Parent = this.panel_tabPage8;
                //        frmOSS.Show();
                //    }
                //    break;
                case "Config":
                    if (!Classes.Modfunction.CheckForm("FrmConfig"))
                    {
                        this.panel_tabPage8.Controls.Clear();
                        FrmConfig frmConf = new FrmConfig();
                        frmConf.MdiParent = this;
                        frmConf.Parent = this.panel_tabPage8;
                        frmConf.Show();
                    }
                    break;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        
    }
}
