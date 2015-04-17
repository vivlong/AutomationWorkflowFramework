using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;
using System.Threading;
using System.Diagnostics;
using System.Net;
using DevComponents.DotNetBar;
using AWF.Classes;


namespace AWF
{
    public partial class Frm_Request : Office2007Form
    {
        public String strConn;
        public string strSQL;
        public string m_TrackNo;
        public string m_VersionName;
        public Frm_Request()
        {
            InitializeComponent();
        }
        private void Frm_Request_Load(object sender, EventArgs e)
        {
           strConn = "Data Source=192.168.0.230;database=RequestForm;" + "uid=sa;" + "pwd=p@ssw0rd$;" + "Integrated Security=false";
     
            this.rB_v701.CheckedChanged += new EventHandler(version_CheckedChanged);
            this.rB_v702.CheckedChanged += new EventHandler(version_CheckedChanged);
            this.rB_v703.CheckedChanged += new EventHandler(version_CheckedChanged);
            this.rB_v704.CheckedChanged += new EventHandler(version_CheckedChanged);
            this.rB_v705.CheckedChanged += new EventHandler(version_CheckedChanged);
            this.rB_v706.CheckedChanged += new EventHandler(version_CheckedChanged);
            this.rB_v801.CheckedChanged += new EventHandler(version_CheckedChanged);
            this.rB_v802.CheckedChanged += new EventHandler(version_CheckedChanged);

            rB_v802.Focus();
            rB_v802.Checked = true;
        }


        public string GetVer()
        {
            string strVer = "";
            if (rB_v701.Checked)
            {
                strVer = "7.0.1";
            }
            else if (rB_v702.Checked)
            {
                strVer = "7.0.2";
            }
            else if (rB_v703.Checked)
            {
                strVer = "7.0.3";
            }
            else if (rB_v704.Checked)
            {
                strVer = "7.0.4";
            }
            else if (rB_v705.Checked)
            {
                strVer = "7.0.5";
            }
            else if (rB_v706.Checked)
            {
                strVer = "7.0.6";
            }
            else if (rB_v801.Checked)
            {
                strVer = "8.0.1";
            }
            else if (rB_v802.Checked)
            {
                strVer = "8.0.2";
            }
            else
            {
                MessageBox.Show("请选择一个版本!");
            }
            return strVer;
        }

        private void version_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                string strVer = GetVer();
                string NewP = Classes.Modfunction.baseDPath + "New SysFreight Source " + strVer.Replace(".", "") + @"\SysFreight\SysFreightMain\SysFreight.vbproj.user";
                if (AWF.Classes.Modfunction.pingIPAddress("192.168.0.236"))
                {
                    if (File.Exists(NewP))
                    {
                        using (StreamReader objReader = new StreamReader(NewP))
                        {
                            string sLine = "";
                            ArrayList LineList = new ArrayList();
                            while (sLine != null)
                            {
                                sLine = objReader.ReadLine();
                                if (!string.IsNullOrEmpty(sLine))
                                    LineList.Add(sLine);
                            }
                            string CurrentVersion = LineList[11].ToString();
                            CurrentVersion = CurrentVersion.Replace("<ApplicationRevision>", "");
                            CurrentVersion = CurrentVersion.Replace("</ApplicationRevision>", "");
                            CurrentVersion = CurrentVersion.Replace(" ", "");
                            CurrentVersion = CurrentVersion.Trim().ToString();
                            txt_BuildNo.Text = CurrentVersion;
                            m_VersionName = strVer + "." + txt_BuildNo.Text.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("当前版本源码路径不存在!");
                    }
                }
            }
        }
        //private void btn_UpdateRequest_Click(object sender, EventArgs e)
        //{
            
        //   string strVer = GetVer();
        //   strSQL = "Select * From Sasr1 where TrackNo='" + m_TrackNo + "'";
        //   DataTable dt = SqlHelper.ExecuteDataTable(strConn, strSQL);

        //        if (dt.Rows.Count > 0)

        //        {

        //           string m_strFixVersion;

        //           m_strFixVersion = dt.Rows[0]["FixVersion"].ToString();

        //            if (m_strFixVersion != "")

        //            {

        //                strSQL = "Update Sasr1 set FixVersion ='" + m_strFixVersion + ";" + strVer + "." + txt_BuildNo.Text.ToString() + "' And ActualCompleteDate ='" + Classes.Modfunction.datetime_today.ToString("yy-MM-dd") + "' ANd ProgrammingSummary =ProgrammingSummary + '" + Classes.Modfunction.datetime_today.ToString("yyMMdd") + "(" + strVer + "." + txt_BuildNo.Text.ToString() + ")" + cbo_Programmer.Text.ToString() + "Fixed ";

        //                strSQL = strSQL + " And FormName ='' Where TrackNo='" + m_TrackNo +"'";

        //               int i = SqlHelper.ExecuteNonQuery(strConn, CommandType.Text, strSQL);





        //          }

        //           else

        //          {

        //              strSQL = "Update Sasr1 set UpdateBy ='" + cbo_Programmer.Text.ToString() + "', FixVersion ='" + strVer + "." + txt_BuildNo.Text.ToString() + "'And ActualCompleteDate ='" + Classes.Modfunction.datetime_today.ToString("yy-MM-dd") + "' ANd ProgrammingSummary ='" + Classes.Modfunction.datetime_today.ToString("yyMMdd") + "(" + strVer + "." + txt_BuildNo.Text.ToString() + ")" + cbo_Programmer.Text.ToString() + " done ";
        //              strSQL = strSQL + " And FormName ='' Where TrackNo='" + m_TrackNo + "'";

        //                int i = SqlHelper.ExecuteNonQuery(strConn, CommandType.Text, strSQL);



        //           }
 

 
        //        }
 	
       
        //}

        private void txt_TrackNo_Leave(object sender, EventArgs e)
        {
            
          
            if (!string.IsNullOrEmpty(txt_TrackNo.Text))
            {
                m_TrackNo = txt_TrackNo.Text;

                if (m_TrackNo.Substring(0,4)!=".Net")
                {
                    m_TrackNo = ".Net" + m_TrackNo;
                }
                strSQL = "Select * From Sasr1 where TrackNo='" + m_TrackNo + "'";
                DataTable dt = SqlHelper.ExecuteDataTable(strConn, strSQL);

                if (dt.Rows.Count > 0)
                {
                    txt_RequestDes.Text = dt.Rows[0]["RequestDescription"].ToString();
                    cbo_Programmer.Text  = dt.Rows[0]["AssignToName"].ToString();
                    string[] m_strFormName;
                    m_strFormName = dt.Rows[0]["Form"].ToString().Split(',');
                   
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] m_mulTrackNo;
            string m_strFilter;
            m_strFilter = "";
            string strVer = GetVer();
            if (txt_MulTrackNo.Text != "")
            {
                     m_mulTrackNo = txt_MulTrackNo.Text.Split(',');
                for (int i = 0; i < m_mulTrackNo.Length; i++)
                {
                 
                    if (m_mulTrackNo[i].Substring(0, 3).ToLower()  == "Net".ToLower() )
                    {
                        m_mulTrackNo[i] = "." + m_mulTrackNo[i];
                    }  
                    else if (m_mulTrackNo[i].Substring(0, 4) != ".Net")
                    {
                        m_mulTrackNo[i] = ".Net" + m_mulTrackNo[i];
                    }
                }

              
         
                for (int i = 0; i < m_mulTrackNo.Length; i++)
                {
                    if (i == m_mulTrackNo.Length - 1)
                    {
                        m_strFilter = m_strFilter + "'" + m_mulTrackNo[i] + "'";
                    }
                    else
                    {
                        m_strFilter = m_strFilter + "'" + m_mulTrackNo[i] + "',";
                    }
                }
            }
            if (m_strFilter != "")
            {
                m_strFilter = " And TrackNo in (" + m_strFilter + ")";
            }
            else
            {
                if (!string.IsNullOrEmpty(cbo_Programmer.Text.ToString()))
                { m_strFilter = m_strFilter + "And AssignToName ='" + cbo_Programmer.Text.ToString() + "'"; }
                if (!string.IsNullOrEmpty(txt_TrackNo.Text.ToString()))
                { m_strFilter = m_strFilter + "And TrackNo ='" + txt_TrackNo.Text.ToString() + "'"; }
             }

            if (m_strFilter !="()")
            { strSQL = "Select TrackNo, FormName,ActualCompletionDate,FixVersion,ProgrammingSummary,Form,TestSummary,RequestDescription,TestResultFlag From Sasr1 where left(Version,2)<>'VB'   " + m_strFilter + " Order by TrxNo desc"; }
           else
              {
                  strSQL = "Select TrackNo, FormName,ActualCompletionDate,FixVersion,ProgrammingSummary,Form,TestSummary,RequestDescription,TestResultFlag From Sasr1 where left(Version,2)<>'VB' AND Isnull(FixVersion,'')='' Order by TrxNo desc";
              }
            DataTable dt = SqlHelper.ExecuteDataTable(strConn, strSQL);
            //自动填写
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string m_strFormName = GetFormName(dt.Rows[i]["Form"].ToString());
                    //FormName
                    if (string.IsNullOrEmpty(dt.Rows[i]["FormName"].ToString()))
                    {  
                        dt.Rows[i]["FormName"] = m_strFormName;
                    }
                    // ActualCompletionDate
                    dt.Rows[i]["ActualCompletionDate"] = Classes.Modfunction.datetime_today.ToString("yyyy-MM-dd");
                    // FixVersion
                    if (string.IsNullOrEmpty(dt.Rows[i]["FixVersion"].ToString()))
                    {
                        dt.Rows[i]["FixVersion"] = "V" + m_VersionName;
                    }
                    else
                    {
                        dt.Rows[i]["FixVersion"] = dt.Rows[i]["FixVersion"] + "," + "V" + m_VersionName;
                    }
                   // ProgrammingSummary
                    if (string.IsNullOrEmpty(dt.Rows[i]["ProgrammingSummary"].ToString()))
                    {
                        dt.Rows[i]["ProgrammingSummary"] = Classes.Modfunction.datetime_today.ToString("yyMMdd") + "(" + m_VersionName + ")" + cbo_Programmer.Text.ToString() + " done ";
                    }
                    else
                    {
                     // dt.Rows[i]["ProgrammingSummary"] = Classes.Modfunction.datetime_today.ToString("yyMMdd") + "(" + m_VersionName + ")" + cbo_Programmer.Text.ToString() + " done ";
                        dt.Rows[i]["ProgrammingSummary"] = Classes.Modfunction.datetime_today.ToString("yyMMdd") + "(" + m_VersionName + ")" + cbo_Programmer.Text.ToString() + " done ";
                    }
                   
                }

                grd_sasr1.DataSource = dt;
                //grd_sasr1.Columns[0].HeaderText = "Track No";
                grd_sasr1.Columns[0].ReadOnly = true;
                grd_sasr1.Columns["ProgrammingSummary"].Width = 600;
                
            }
        }

        private void grd_sasr1_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_sasr1.RowCount >0)
               if( grd_sasr1.CurrentRow != null )
               {
                   {
                       txt_RequestDes.Text = Modfunction.CheckNull(grd_sasr1.Rows[grd_sasr1.CurrentRow.Index].Cells["RequestDescription"].Value).ToString().Replace("\n", "\r\n");
                       txt_TestSummary.Text   = grd_sasr1.Rows[grd_sasr1.CurrentRow.Index].Cells["TestSummary"].Value.ToString().Replace("\n","\r\n") ;
                    txt_ProgramingSummary.Text = Modfunction.CheckNull(grd_sasr1.Rows[grd_sasr1.CurrentRow.Index].Cells["ProgrammingSummary"].Value).ToString().Replace("\n", "\r\n");
                }
           }
        }
        private string GetFormName(string strFormName)
        {
            string m_FrmName="";
            string[] m_strFormName;
            m_strFormName = strFormName.Split(',');
            for (int i = 0; i < m_strFormName.Length; i++)
            {
                switch (m_strFormName[i].ToLower())
                {
                    case "sea import consol":
                        m_strFormName[i] = "frmeConsolImport";
                        break;
                    case "sea export consol":
                        m_strFormName[i] = "frmeConsolExport";
                        break;
                    case "sibl1":
                        m_strFormName[i] = "frme" + m_strFormName[i] + "frmeSibl1_TP";
                        break;
                    case "JobCosting":
                        m_strFormName[i] = "frmsShowJobCost";
                        break;
                    default:
                        m_strFormName[i] = "frme" + m_strFormName[i];
                        break;

                }

                if (i == m_strFormName.Length - 1)
                {
                    m_FrmName = m_FrmName + m_strFormName[i];

                }
                else
                {
                    m_FrmName = m_FrmName + m_strFormName[i] + ",";
                }
            }

            return m_FrmName;
        }

        private void cbo_SpecialName_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cbo_SpecialName.Text.ToString()))
            {
                m_VersionName = m_VersionName + "(Special-" + cbo_SpecialName.Text.ToString() + ")";
            }
        }

        private void txt_ProgramingSummary_TextChanged(object sender, EventArgs e)
        {
            if (grd_sasr1.RowCount > 0)
                if (grd_sasr1.CurrentRow != null)
                {
                    {
                        //    txt_RequestDes.Text = Modfunction.CheckNull(grd_sasr1.Rows[grd_sasr1.CurrentRow.Index].Cells["RequestDescription"].Value).ToString().Replace("\n", "\r\n");
                        //    txt_TestSummary.Text = grd_sasr1.Rows[grd_sasr1.CurrentRow.Index].Cells["TestSummary"].Value.ToString().Replace("\n", "\r\n");
                        //    txt_ProgramingSummary.Text = Modfunction.CheckNull(grd_sasr1.Rows[grd_sasr1.CurrentRow.Index].Cells["ProgrammingSummary"].Value).ToString().Replace("\n", "\r\n");
                        grd_sasr1.Rows[grd_sasr1.CurrentRow.Index].Cells["ProgrammingSummary"].Value = txt_ProgramingSummary.Text.ToString();
                    }
                }
        }

        private void cmd_Update_Click(object sender, EventArgs e)
        {
               DialogResult dgrt = MessageBox.Show("确认是否一键完成Request Form 填写！","Message",MessageBoxButtons.YesNo);
               if (dgrt == System.Windows.Forms.DialogResult.Yes )
               {
                   for (int i=0; i < grd_sasr1.Rows.Count-1;i++ )
                   {
                       string m_programmerSummary="";
                       if ( !string.IsNullOrEmpty(grd_sasr1.Rows[i].Cells["ProgrammingSummary"].Value.ToString()))

                       {   
                           m_programmerSummary = grd_sasr1.Rows[i].Cells["ProgrammingSummary"].Value.ToString().Replace("\r\n","\n");

                       }
                       if (Classes.Modfunction.CheckNull(grd_sasr1.Rows[i].Cells["TestResultFlag"].Value).ToString() == "Y")
                       {
                           DialogResult aa = MessageBox.Show("该Request Form 已经Pass了，确定是否更新？", "Message", MessageBoxButtons.YesNo);
                           if (aa == System.Windows.Forms.DialogResult.Yes)
                           {
                               strSQL = "Update Sasr1 set FixVersion ='" + Classes.Modfunction.CheckNull(grd_sasr1.Rows[i].Cells["FixVersion"].Value).ToString() + "' , ActualCompletionDate ='" + grd_sasr1.Rows[i].Cells["ActualCompletionDate"].Value.ToString() + "' , ProgrammingSummary ='" + m_programmerSummary + "' , CompleteByName ='" + cbo_Programmer.Text  + "'";
                               strSQL = strSQL + " , FormName ='" + Classes.Modfunction.CheckNull(grd_sasr1.Rows[i].Cells["FormName"].Value).ToString() + "' Where TrackNo='" + grd_sasr1.Rows[i].Cells["TrackNo"].Value.ToString() + "'";

                               int j = SqlHelper.ExecuteNonQuery(strConn, CommandType.Text, strSQL);

                           }
                       }
                       else
                       {
                           strSQL = "Update Sasr1 set FixVersion ='" + Classes.Modfunction.CheckNull(grd_sasr1.Rows[i].Cells["FixVersion"].Value).ToString() + "' , ActualCompletionDate ='" + grd_sasr1.Rows[i].Cells["ActualCompletionDate"].Value.ToString() + "' , ProgrammingSummary ='" + m_programmerSummary + "' , CompleteByName ='" + cbo_Programmer.Text + "'";
                           strSQL = strSQL + " , FormName ='" + Classes.Modfunction.CheckNull(grd_sasr1.Rows[i].Cells["FormName"].Value).ToString() + "' Where TrackNo='" + grd_sasr1.Rows[i].Cells["TrackNo"].Value.ToString() + "'";

                           int j = SqlHelper.ExecuteNonQuery(strConn, CommandType.Text, strSQL);

                       }
                  }
                     //  m_strActualCompletionDate = "";

               
                   
                   
                   }
                   MessageBox.Show("恭喜你，填写成功！");
             
        }

        private void txt_BuildNo_TextChanged(object sender, EventArgs e)
        {
            string strVer = GetVer();
            m_VersionName = strVer + "." + txt_BuildNo.Text.ToString();
            if (!string.IsNullOrEmpty(cbo_SpecialName.Text.ToString()))
            {
                m_VersionName = m_VersionName + "(Special-" + cbo_SpecialName.Text.ToString() + ")";
            }
        }

        private void txt_BuildNo_Leave(object sender, EventArgs e)
        {
            string strVer = GetVer();
            m_VersionName = strVer + "." + txt_BuildNo.Text.ToString();
            if (!string.IsNullOrEmpty(cbo_SpecialName.Text.ToString()))
            {
                m_VersionName = m_VersionName + "(Special-" + cbo_SpecialName.Text.ToString() + ")";
            }
        }
      
    }
}
