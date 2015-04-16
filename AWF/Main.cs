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
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Main()
        {
            InitializeComponent();
            //this.Font = Classes.FontHelper.SetFormFontByUsingMemoryFont();
            if (!Classes.Modfunction.Get_IP_Address())
            {
                MessageBox.Show("Invalid Network Interface Controller Address!");
            }
            //Qiniu.Conf.Config.ACCESS_KEY = "88_zth5M0BXGRvLHBJM59I3yTJbjzRAFhVZqGkKz";
            //Qiniu.Conf.Config.SECRET_KEY = "s8HnQb5fSM0vDE7kTt1Ab42nPR9lkPkuSiMDtGI-";
            Classes.Modfunction.Get_UTC_Datetime();
            //Classes.SaveSetting.GetSkypeUser();
            //Classes.SaveSetting.GetRestoreDBPath();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.btn_Menu1.Click += new EventHandler(pbMenu1_Click);
            this.btn_Menu2.Click += new EventHandler(pbMenu2_Click);
            this.btn_Menu3.Click += new EventHandler(pbMenu3_Click);
            this.btn_Menu4.Click += new EventHandler(pbMenu4_Click);
            this.btn_Menu5.Click += new EventHandler(pbMenu5_Click);
            this.btn_Menu6.Click += new EventHandler(pbMenu6_Click);
            this.btn_Menu7.Click += new EventHandler(pbMenu7_Click);
            this.btn_Menu8.Click += new EventHandler(pbMenu8_Click);
            this.btn_Menu9.Click += new EventHandler(pbMenu9_Click);
            this.btn_Menu10.Click += new EventHandler(pbMenu10_Click);

            this.toolStripStatusLabel1.Text = Classes.Modfunction.currentIP;
            this.toolStripStatusLabel3.Text = Classes.Modfunction.datetime_today.ToString("yyyyMMdd HH:mm:ss");
            this.pbMenu1_Click(sender, new EventArgs());
        }

        private void showMdiForm(Form frm)
        {
            this.panel_Form.Controls.Clear();
            frm.MdiParent = this;
            frm.Parent = this.panel_Form;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        #region  菜单点击事件
        private void pbMenu1_Click(object sender, EventArgs e)
        {
            showMdiForm(new Frm_Request());
        }

        private void pbMenu2_Click(object sender, EventArgs e)
        {
            showMdiForm(new Frm_Publishing());
        }

        private void pbMenu3_Click(object sender, EventArgs e)
        {
            showMdiForm(new Frm_Edi());
        }

        private void pbMenu4_Click(object sender, EventArgs e)
        {
            showMdiForm(new Frm_BackupFF());
        }

        private void pbMenu5_Click(object sender, EventArgs e)
        {
            showMdiForm(new Frm_RestoreDB());
        }

        private void pbMenu6_Click(object sender, EventArgs e)
        {
            showMdiForm(new Frm_SQLTool());
        }

        private void pbMenu7_Click(object sender, EventArgs e)
        {
            showMdiForm(new Frm_Testing());
        }

        private void pbMenu8_Click(object sender, EventArgs e)
        {
            showMdiForm(new Frm_RequestXls());
        }

        private void pbMenu9_Click(object sender, EventArgs e)
        {
            showMdiForm(new frm_RequestDB());
        }

        private void pbMenu10_Click(object sender, EventArgs e)
        {
            showMdiForm(new Frm_Config());
        }

        private void no_Click(object sender, EventArgs e) { }
        #endregion

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        
    }
}
