using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AWF.Classes;

namespace AWF
{
    public partial class Frm_SQLTool : Form
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
        public Frm_SQLTool()
        {
            InitializeComponent();
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
        }

        private void cmd_SaveNode_Click(object sender, EventArgs e)
        {
            int intI = 0;
            strsearviceName = txtServer.Text;
            searviceName = txtUserID.Text;
            strMima = txtPassword.Text;
            DataBaseName = cboDatabseList.Text;
            strConn = "server=" + strsearviceName + ";uid=" + searviceName + ";pwd=" + strMima + ";database=" + DataBaseName;
            strSQL = "Select * from wrApplist Where NodeName = '" + TextBox1.Text.ToString().Replace("'", "''") + "'";
              DataTable dt = SqlHelper.ExecuteDataTable(strConn, strSQL);
                if (dt.Rows.Count == 1)
                {
                    strSQL = "Insert into wrApplist(" + dt.Columns[0].ColumnName;
                    for (intI = 1; intI < dt.Columns.Count; intI++)
                    {
                        strSQL = strSQL + "," + dt.Columns[intI].ColumnName;

                    }
                    strSQL = strSQL + ") Values( " + dt.Rows[0][0];
                    for (intI = 1; intI < dt.Columns.Count; intI++)
                    {
                        strSQL = strSQL + "," + dt.Rows[0][intI];
                    }
                    strSQL = strSQL + "\r\n" + "\r\n" + "GO" + "\r\n" + "insert into wrRoleRight(RoleId,NodeName,UsrRight) select  RoleId,'" + TextBox1.Text.Trim().ToString() + "','N,O,E,D,U,C,P,A' from (select Distinct RoleId from wrRoleRight ) a";
                    RichTextBox1.Text = strSQL;
                }
          
        }
    }
}
