using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AWF.Classes;
using System.Text.RegularExpressions;

namespace AWF
{
    public partial class frm_RequestDB : Form
    {
        private string CDEC_SEPARATOR = ".";
        private string CTHS_SEPARATOR = ",";
        private string DataBaseName = "master";
        private string strsearviceName = "(local)";
        private string searviceName = "Sa";
        private string strMima = "";
        private bool blnUseWindow;
        private string strSQL = "";
        private string strConn = "";
        public string[] arrSQL;
        public frm_RequestDB()
        {
            InitializeComponent();
        }
        private void BindingFieldName()
        {
            string sqlcen;
            string sqlOrder;
            sqlOrder = "order by c.name,c.colorder";
            sqlcen = "select  '0' as [Value],c.[name],[type]= T.name + CASE T.xtype WHEN 41 THEN '('+CAST(C.scale AS VARCHAR) +')'    -- time" + "\r\n" +
             "WHEN 42 THEN '('+CAST(C.scale AS VARCHAR) +')'                                        -- datetime2" + "\r\n" +
               "WHEN 43 THEN '('+CAST(C.scale AS VARCHAR) +')'                                        -- datetimeoffset" + "\r\n" +
               "WHEN 106 THEN '('+CAST(C.[prec]  AS VARCHAR)+','+ CAST(C.scale AS VARCHAR) +')'    -- decimal" + "\r\n" +
               "WHEN 108 THEN '('+CAST(C.[prec]  AS VARCHAR)+','+ CAST(C.scale AS VARCHAR) +')'    -- numeric" + "\r\n" +
               "WHEN 165 THEN '('+ISNULL(CAST(NULLIF(C.prec,-1) AS VARCHAR),'MAX') +')'        -- varbinary" + "\r\n" +
               "WHEN 167 THEN '('+ISNULL(CAST(NULLIF(C.prec,-1) AS VARCHAR),'MAX') +')'        -- varchar" + "\r\n" +
               "WHEN 173 THEN '('+ISNULL(CAST(NULLIF(C.prec,-1) AS VARCHAR),'MAX') +')'        -- binary" + "\r\n" +
               "WHEN 175 THEN '('+ISNULL(CAST(NULLIF(C.prec,-1) AS VARCHAR),'MAX') +')'        -- char" + "\r\n" +
               "WHEN 231 THEN '('+ISNULL(CAST(NULLIF(C.prec,-1) AS VARCHAR),'MAX') +')'        -- nvarchar" + "\r\n" +
               "WHEN 239 THEN '('+ISNULL(CAST(NULLIF(C.prec,-1) AS VARCHAR),'MAX') +')'        -- nchar" + "\r\n" +
               "ELSE ''" + "\r\n" +
           "End" + "\r\n" +
               ",'" + cbo_Table.Text + "' AS [Tablename] from syscolumns c left join systypes t on c.xtype=t.xtype" + "\r\n" +
               "where id=(select id from sysobjects o where o.xtype='U' and o.name='" + cbo_Table.Text.ToString() + "') and t.name<>'sysname'" + "\r\n" + sqlOrder;
            DataTable dt = SqlHelper.ExecuteDataTable(strConn, sqlcen);
         
            if (dt.Rows.Count > 0)
            {
                //clb_tb.Items.Clear();
                this.clb_tb.DataSource = dt;
                this.clb_tb.DisplayMember = "Name";
                this.clb_tb.ValueMember = "Value";
                //for (int intI = 1; intI < dt.Rows.Count; intI++)
                //{
                //    clb_tb.Items.Add (dt.Rows[intI]["Name"]);
                    
                   
                //}
            }
        }

        private void cmdAddDatabase_Click(object sender, EventArgs e)
        {
            strsearviceName = txtServer.Text;
            searviceName = txtUserID.Text;
            strMima = txtPassword.Text;
            DataBaseName = "master";
            int intI = 0;
            strConn = "server=" + strsearviceName + ";uid=" + searviceName + ";pwd=" + strMima + ";database=" + DataBaseName;
            strSQL = "select name from sysdatabases Order by name";
            DataTable dt = SqlHelper.ExecuteDataTable(strConn, strSQL);
            if (dt.Rows.Count > 0)
            {
                for (intI = 1; intI < dt.Rows.Count; intI++)
                {
                    cboDatabseList.Items.Add(dt.Rows[intI][0]);

                }
            }

            MessageBox.Show("连接成功，请选择数据库！");
            cboDatabseList.Focus();

            //strSQL = "select name from sysobjects where xtype='U' order by name";
            //dt = SqlHelper.ExecuteDataTable(strConn, strSQL);
            //if (dt.Rows.Count > 0)
            //{
            //    for (intI = 1; intI < dt.Rows.Count; intI++)
            //    {
            //        cbo_Table.Items.Add(dt.Rows[intI][0]);

            //    }
            //}
        }

        private void cmd_List_Click(object sender, EventArgs e)
        {
            BindingFieldName();
        }



        public object _ { get; set; }

        private void cboDatabseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            strsearviceName = txtServer.Text;
            searviceName = txtUserID.Text;
            strMima = txtPassword.Text;
            DataBaseName = cboDatabseList.Text;
            int intI = 0;
            strConn = "server=" + strsearviceName + ";uid=" + searviceName + ";pwd=" + strMima + ";database=" + DataBaseName;
            strSQL = "select name from sysobjects where xtype='U' order by name";
            DataTable dt = SqlHelper.ExecuteDataTable(strConn, strSQL);
            if (dt.Rows.Count > 0)
            {
                cbo_Table.Items.Clear();
                for (intI = 1; intI < dt.Rows.Count; intI++)
                {
                    cbo_Table.Items.Add(dt.Rows[intI][0]);

                }
            }
        }

        private void cmd_Add_Click(object sender, EventArgs e)
        {
           for(int i=0;i<clb_tb.Items.Count ;i++)
           {
               if (clb_tb.GetItemChecked(i))
               {
                   clb_newadd.Items.Add(clb_tb.Items[i]);
               }


           }

           for (int i = 0; i < clb_newadd.Items.Count; i++)
           {
               clb_newadd.SetItemChecked(i, true); 
           }
           this.clb_newadd.DisplayMember = "Name";
           this.clb_newadd.ValueMember = "Value";
        }

        private void clb_tb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }

        private void chk_SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_SelectAll.Checked  == true)
            {             
                    for (int i = 0; i < clb_tb.Items.Count; i++)
                    {
                        clb_tb.SetItemChecked(i, true);
                        //clb_newadd.Items.Add(clb_tb.CheckedItems);
                    }
                    
            }
        }



        private void cmd_Update_Click(object sender, EventArgs e)
        {
            if (! String.IsNullOrEmpty(txt_TrackNo.Text.ToString()))
            {  txt_ProgramingSummary.Text = CreateSQL(); }
            else
            {
                MessageBox.Show("请输入TrackNo和完成人,格式：(.Net6072,xiaozhen,new add,Y ,TrackNo,CompleteByName,Remark,SpFlag)");
            }
        
        }

        private void cmd_INS_Click(object sender, EventArgs e)
        {
          for(int i=0;i< arrSQL.Length; i++)

          {
             string m_strConn = "server=" + strsearviceName + ";uid=" + searviceName + ";pwd=" + strMima + ";database= RequestForm" ;

             int j = SqlHelper.ExecuteNonQuery(m_strConn, CommandType.Text, arrSQL[i]);
              if (j!=-1)
              {
                    //MessageBox.Show("恭喜你，成功导入数据！");
              }
          
          }
          MessageBox.Show("恭喜你，成功导入数据！");

        }

         public string CreateSQL()
        {
            string m_strsql="";

            string strsql;
            string cl = "\r\n";
            string[] var;
            int intI = 1;
            if (!string.IsNullOrEmpty(textBox1.Text.ToString()))
            { intI = int.Parse(textBox1.Text.ToString()); }
            var = txt_TrackNo.Text.Split(',');
            if (var.Length > 2)
            {
                arrSQL=new string[clb_newadd.CheckedItems.Count];
                for (int i = 0; i < clb_newadd.CheckedItems.Count ; i++)
                {
                    DataRowView dv = ((DataRowView)clb_newadd.CheckedItems[i]);
                    string Dname = dv["name"].ToString();
                    string Dtype = dv["type"].ToString();
                    string TableName = dv["Tablename"].ToString();
                    string Dlen = "";
                    if (Dtype.IndexOf('(') != 0)
                    {
                        Dlen = Dtype.ToString().Substring(Dtype.IndexOf('('), Dtype.Length - Dtype.IndexOf('('));
                        Dtype = Dtype.ToString().Substring(0, Dtype.IndexOf('('));
                        Dlen = Dlen.Replace('(', ' ');
                        Dlen = Dlen.Replace(')', ' ');

                    }

                    strsql = "INSERT INTO [Sasr2]" +
                    "([TrackNo],[LineItemNo],[ModifyBy],[ModifyAt],[TableName],[FieldName],[Type],[Len],[ViewFlag],[SPFlag],[TriggerFlag],[Remark],[TrxNo])" +
                    "VALUES('" + var[0] + "','" + intI.ToString() + "','" + var[1] + "','" + Classes.Modfunction.datetime_today.ToString("yyyy-MM-dd") + "','" + TableName + "','" + Dname + "','" + Dtype + "','" + Dlen + "','Y','" + var[3] + "','N','" + var[2] + "',(select top 1 TrxNo from sasr1 where TrackNo='" + var[0] + "'))";
                  
                    arrSQL[i]=strsql ;

                    m_strsql = m_strsql + strsql +   cl + "GO" + cl;
                    intI = intI + 1;
                }
            }
            return m_strsql;

        }
    }
}
