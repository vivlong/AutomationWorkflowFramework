using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.HSSF.Util;
using Newtonsoft.Json;

namespace AWF
{
    public partial class Frm_RequestXls : Form
    {
        private string strTableName = "sasr1";
        private DataTable dt = new DataTable();
        private DataSet ds1 = new DataSet();
        private List<string> Serverlist = new List<string>();
        private string connString = "";
            
        public Frm_RequestXls()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            dt.Clear();
            string strCommand = "Select TrackNo,Form,RequestDescription,''as TodayCompletedtasks,FixVersion,CompleteByName,ActualCompletionDate,ProgrammingSummary,TestByName,TestDate,TestResultFlag,TestSummary from sasr1";
            connString = @"Server=" + txt_SqlAddress.Text + ";DataBase=" + cbm_database.Text + ";UID=" + txt_user.Text + ";PWD=" + txt_password.Text + ";";
            dt = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strCommand);
            Get_TableName(strTableName);
            AWF.Classes.ConfHelper.SaveConf(txt_SqlAddress.Text, cbm_database.Text, txt_user.Text, txt_password.Text);
        }

        //导出
        public static void ExportToExcel(DataGridView dataGridView1, string sheetName)
        {
            int rowCount = dataGridView1.RowCount;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Microsoft Excel|*.xls";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //   return;
                MessageBox.Show("确定添加表");
            }
            //不允许dataGridView显示添加行，负责导出时会报最后一行未实例化错误
            dataGridView1.AllowUserToAddRows = false;

            FileStream readfile = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read);

            //HSSFWorkbook适合word2003 XSSFWorkbook适应2007
            HSSFWorkbook workbook = new HSSFWorkbook(readfile);
            //工作蒲
            //  ISheet mySheetG = workbook.GetSheet(sheetName); 
            try
            {
                ISheet mySheet = workbook.CreateSheet(sheetName);
                //设置表格的宽度
                mySheet.SetColumnWidth(2, 50 * 256);
                mySheet.SetColumnWidth(3, 40 * 256);

                //mySheet.DefaultColumnWidth = 1* 256;             
                ICellStyle styleHead = workbook.CreateCellStyle();
                IFont font = workbook.CreateFont();
                font.FontHeightInPoints = 10;
                font.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                styleHead.SetFont(font);
                styleHead.FillPattern = FillPattern.SolidForeground;
                styleHead.FillForegroundColor = HSSFColor.Yellow.Index;

                ICellStyle style1 = workbook.CreateCellStyle();
                style1.FillPattern = FillPattern.SolidForeground;
                style1.FillForegroundColor = HSSFColor.Yellow.Index;

                // HSSFRow mySourceStyleRow = (HSSFRow)mySheet.GetRow(InsertRowIndex - 1);
                HSSFRow mySourceStyleRow = (HSSFRow)mySheet.CreateRow(0);

                try
                {
                    mySheet.ShiftRows(1, mySheet.LastRowNum, rowCount, true, true);

                    for (int i = 1; i < rowCount; i++)
                    {
                        HSSFRow targetRow = null;
                        HSSFCell sourceCell = null;
                        HSSFCell targetCell = null;
                        mySheet.DefaultRowHeight = 1 / 10 * 200;

                        targetRow = (HSSFRow)mySheet.CreateRow(i + 1);
                        for (int m = mySourceStyleRow.FirstCellNum - 1; m < mySourceStyleRow.LastCellNum; m++)
                        {
                            sourceCell = (HSSFCell)mySourceStyleRow.GetCell(m);
                            if (sourceCell == null)
                                continue;
                            targetCell = (HSSFCell)targetRow.CreateCell(m);
                            //targetCell.Encoding = sourceCell.Encoding;
                            targetCell.CellStyle = sourceCell.CellStyle;
                            targetCell.SetCellType(sourceCell.CellType);
                        }
                    }
                }
                catch { }

                HSSFRow firstTargetRow = (HSSFRow)mySheet.GetRow(1);
                HSSFCell firstSourceCell = null;
                HSSFCell firstTargetCell = null;
                for (int m = mySourceStyleRow.FirstCellNum; m < mySourceStyleRow.LastCellNum; m++)
                {
                    firstSourceCell = (HSSFCell)mySourceStyleRow.GetCell(m);
                    if (firstSourceCell == null)
                        continue;
                    firstTargetCell = (HSSFCell)firstTargetRow.CreateCell(m);
                    //   firstTargetCell.Encoding = firstSourceCell.Encoding;
                    firstTargetCell.CellStyle = firstSourceCell.CellStyle;
                    firstTargetCell.SetCellType(firstSourceCell.CellType);
                }

                IRow rowHead = mySheet.CreateRow(0);
                string[] strColumName = new string[12];
                strColumName[0] = "TrackNo";
                strColumName[1] = "Form";
                strColumName[11] = "RequestDescription";
                strColumName[3] = "TodayCompletedtasks";
                strColumName[4] = "FixVersion";
                strColumName[5] = "CompleteByName";
                strColumName[6] = "ActualCompletionDate";
                strColumName[7] = "ProgrammingSummary";
                strColumName[8] = "TestByName";
                strColumName[9] = "TestDate";
                strColumName[10] = "TestResultFlag";
                strColumName[2] = "TestSummary";
                //填写表头
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    rowHead.CreateCell(i, CellType.String).SetCellValue(dataGridView1.Columns[strColumName[i]].HeaderText.ToString());
                    rowHead.Cells[i].CellStyle = styleHead;

                }

                //填写内容
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    IRow row = mySheet.CreateRow(i + 1);
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        row.CreateCell(j, CellType.String).SetCellValue(dataGridView1.Rows[i].Cells[strColumName[j]].Value.ToString());
                        row.Cells[j].CellStyle = style1;
                    }
                }

                using (FileStream stream = File.OpenWrite(fileDialog.FileName))
                {
                    workbook.Write(stream);
                    readfile.Close();
                }
                MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GC.Collect();
            }
            catch
            {
                MessageBox.Show("你所创建的表已存在");
            }
        }

        public static void ExportToExcel2(DataGridView dataGridView2, string sheetName2)
        {
            int rowCount = dataGridView2.RowCount;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Microsoft Excel|*.xls";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("确定插入数据吗");
                //  return;
            }
            //不允许dataGridView显示添加行，负责导出时会报最后一行未实例化错误
            dataGridView2.AllowUserToAddRows = false;

            FileStream readfile = new FileStream(fileDialog.FileName, FileMode.Open, FileAccess.Read);
            HSSFWorkbook workbook = new HSSFWorkbook(readfile);
            //工作蒲

            //ISheet mySheet = workbook.CreateSheet(sheetName);
            //try catch用于HSSFRow mySourceStyleRow = (HSSFRow)mySheet.CreateRow(0);的错误
            try
            {
                ISheet mySheet = workbook.GetSheet(sheetName2);
                mySheet.SetColumnWidth(0, 12 * 256);
                mySheet.SetColumnWidth(3, 25 * 256);
                mySheet.SetColumnWidth(6, 25 * 256);
                mySheet.SetColumnWidth(7, 25 * 256);
                mySheet.SetColumnWidth(8, 25 * 256);
                //  mySheet.DefaultRowHeight = 1/20;
                // HSSFRow mySourceStyleRow = (HSSFRow)mySheet.GetRow(InsertRowIndex - 1);
                ICellStyle styleExp2 = workbook.CreateCellStyle();
                IFont font = workbook.CreateFont();
                font.FontHeightInPoints = 10;
                font.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                styleExp2.SetFont(font);

                HSSFRow mySourceStyleRow = (HSSFRow)mySheet.CreateRow(0);

                try
                {
                    mySheet.ShiftRows(1, mySheet.LastRowNum, rowCount, true, false);
                    for (int i = 1; i < rowCount; i++)
                    {
                        HSSFRow targetRow = null;
                        HSSFCell sourceCell = null;
                        HSSFCell targetCell = null;
                        targetRow = (HSSFRow)mySheet.CreateRow(i + 1);
                        for (int m = mySourceStyleRow.FirstCellNum - 1; m < mySourceStyleRow.LastCellNum; m++)
                        {
                            sourceCell = (HSSFCell)mySourceStyleRow.GetCell(m);
                            if (sourceCell == null)
                                continue;
                            targetCell = (HSSFCell)targetRow.CreateCell(m);
                            //targetCell.Encoding = sourceCell.Encoding;
                            targetCell.CellStyle = sourceCell.CellStyle;
                            targetCell.SetCellType(sourceCell.CellType);
                        }
                    }
                }

                catch
                {
                    //MessageBox.Show("error");

                }
                HSSFRow firstTargetRow = (HSSFRow)mySheet.GetRow(1);
                HSSFCell firstSourceCell = null;
                HSSFCell firstTargetCell = null;
                for (int m = mySourceStyleRow.FirstCellNum; m < mySourceStyleRow.LastCellNum; m++)
                {
                    firstSourceCell = (HSSFCell)mySourceStyleRow.GetCell(m);
                    if (firstSourceCell == null)
                        continue;
                    firstTargetCell = (HSSFCell)firstTargetRow.CreateCell(m);
                    //   firstTargetCell.Encoding = firstSourceCell.Encoding;
                    firstTargetCell.CellStyle = firstSourceCell.CellStyle;
                    firstTargetCell.SetCellType(firstSourceCell.CellType);
                }

                IRow rowHead = mySheet.CreateRow(0);

                //填写表头
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    rowHead.CreateCell(i, CellType.String).SetCellValue(dataGridView2.Columns[i].HeaderText.ToString());
                    rowHead.Cells[i].CellStyle = styleExp2;
                }

                //填写内容
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    IRow row = mySheet.CreateRow(i + 1);
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        if (j == 0)
                        {
                            // row.CreateCell(j, CellType.String).SetCellValue(System.DateTime.Now.ToString("dd MM yyyy"));
                            //   row.CreateCell(j, CellType.String).SetCellValue(System.DateTime.Now.GetDateTimeFormats("dd MMM yyyy"));
                            //   select CONVERT(varchar(100), GETDATE(), 106) as date from sasr1;
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                            // row.CreateCell(j, CellType.String).SetCellValue(System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd");
                            row.CreateCell(j, CellType.String).SetCellValue(System.DateTime.Now.ToString(System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd MMM,yyyy"));
                        }
                        else
                        {
                            row.CreateCell(j, CellType.String).SetCellValue(dataGridView2.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                }
                using (FileStream stream = File.OpenWrite(fileDialog.FileName))
                {
                    workbook.Write(stream);
                }
                MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GC.Collect();
            }
            catch
            {
                MessageBox.Show("所填写的名字不存在");
            }
        }

        private void Frm_RequestXls_Load(object sender, EventArgs e)
        {
            AWF.Classes.ConfHelper.confJson cj = new Classes.ConfHelper.confJson();
            string strConfPath = System.Windows.Forms.Application.StartupPath + @"\config.json";
            cj = AWF.Classes.ConfHelper.GetConf(strConfPath);
            txt_SqlAddress.Text = cj.RequestXls.DbServer;
            cbm_database.Text = cj.RequestXls.DbName;
            txt_user.Text = cj.RequestXls.DbUid;
            txt_password.Text = cj.RequestXls.DbPwd;
            this.connString = @"Server=" + txt_SqlAddress.Text + ";DataBase=" + cbm_database.Text + ";UID=" + txt_user.Text + ";PWD=" + txt_password.Text + ";";
        }

        private void Get_TableName(string strT)
        {
            string strCommand = "SELECT Name FROM SysColumns WHERE id=Object_Id('" + strT + "')";
            DataTable dt1 = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strCommand);
            if (dt1 != null)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    Serverlist.Add(dt1.Rows[i][0].ToString());
                    cbm_Table.Items.Add(strT + "." + Serverlist[i]);
                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            string editon = txt_editionSasr1.Text.Trim();
            if (editon == "")
            {
                MessageBox.Show("请输入名字");
                txt_editionSasr1.Focus();
            }
            else
            {
                ExportToExcel(dgv_sars1, editon);
            }
        }

        private void btn_ExportPage2_Click(object sender, EventArgs e)
        {
            String editon = txt_edition.Text.Trim();
            if (editon == "")
            {
                MessageBox.Show("请输入名字");
                txt_edition.Focus();
            }
            else
            {
                ExportToExcel2(dgv_sasr2, editon);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string strCb1 = cbm_Table.Text;
            string strSelect;
            string strTx4 = txt_search.Text;
            if (tabControl1.SelectedTab == tabPage1)
            {
                dt.Clear();
                if (strCb1 == "")
                {
                    //  strSelect = "Select TrackNo,''as TodayCompletedtasks,FixVersion,ActualCompletionDate,ProgrammingSummary,TestSummary,Form,RequestDescription,CompleteByName,TestByName,TestDate,TestResultFlag as TestResult from sasr1";
                    strSelect = "Select TrackNo,Form,RequestDescription,''as TodayCompletedtasks,FixVersion,CompleteByName,ActualCompletionDate,ProgrammingSummary,TestByName,TestDate,TestResultFlag,TestSummary  from sasr1";

                }
                else
                {
                    // "Select TrackNo,Form,RequestDescription,''as TodayCompletedtasks,FixVersion,CompleteByName,ActualCompletionDate,ProgrammingSummary,TestByName,TestDate,TestResultFlag,TestSummary  from sasr1
                    strSelect = "Select TrackNo,Form,RequestDescription,''as TodayCompletedtasks,FixVersion,CompleteByName,ActualCompletionDate,ProgrammingSummary,TestByName,TestDate,TestResultFlag,TestSummary  from sasr1 where " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'";
                }
                DataTable dt2 = new DataTable();
                dt2 = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strSelect);
                dgv_sars1.DataSource = dt2;
                dgv_sars1.Columns["TrackNo"].ReadOnly = true;
                dgv_sars1.AllowUserToResizeRows = true;
                dgv_sars1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgv_sars1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv_sars1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv_sars1.Columns["TodayCompletedtasks"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                dgv_sars1.RowsDefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                string strSasr2;
                if (strCb1 == "")
                {
                    //strSasr2 = "select CONVERT(varchar(100), GETDATE(), 106) as Date,TrackNo,TableName,FieldName,Type,LEN,SPFlag,TriggerFlag,Remark from Sasr2 ";
                    strSasr2 = "select b.ActualCompletionDate as Date, a.TrackNo,a.TableName,a.FieldName,a.Type as DateType,a.LEN as Length,a.SPFlag as StoreProcedureName,a.TriggerName,a.Remark from Sasr2 a,sasr1 b where a.TrackNo=b.TrackNo";
                }
                else
                {
                    //   strSasr2 = "select CONVERT(varchar(100), GETDATE(), 106) as Date,TrackNo,TableName,FieldName,Type,LEN,SPFlag,TriggerFlag,Remark from Sasr2 where " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'"; 
                    strSasr2 = "select Sasr1.ActualCompletionDate as Date, Sasr2.TrackNo,Sasr2.TableName,Sasr2.FieldName,Sasr2.Type as DateType,Sasr2.LEN as Length,Sasr2.SPFlag as StoreProcedureName,Sasr2.TriggerName,Sasr2.Remark from Sasr2 ,sasr1  where Sasr2.TrackNo=Sasr1.TrackNo and " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'";
                }
                DataTable dt_page2 = new DataTable();
                dt_page2 = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strSasr2);
                dgv_sasr2.DataSource = dt_page2;
            }
        }

        private void CopyAllFiles(string fpath, string tpath)
        {
            if (Directory.Exists(fpath))
            {
                foreach (string f in Directory.GetFiles(fpath))
                {
                    string filename = Path.GetFileName(f);
                    if (!Directory.Exists(tpath))
                    {
                        Directory.CreateDirectory(tpath);
                    }
                    if (filename.Substring(filename.Length - 4) != ".zip")
                    {
                        File.Copy(f, Path.Combine(tpath, filename), true);
                    }
                }
                foreach (string f in Directory.GetDirectories(fpath))
                {
                    CopyAllFiles(f, tpath + "\\" + Path.GetFileName(f));
                }
            }
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            int fileSourceDir = int.Parse(txt_versionName.Text.Trim());
            string vlue = com_version.SelectedItem.ToString();
            DateTime date1 = DateTime.Now;
            string date2 = String.Format("{0:yyMMdd}", date1).ToString();
            int date3 = int.Parse(date2);
            // string fileSource = @"\\192.168.0.250\Net Application\" + date3 + " Update(Version 7.0.3." + fileSourceDir + ")";
            string fileSource = @"\\192.168.0.250\Net Application\110905 Update(Version " + vlue + "." + fileSourceDir + ")";
            //创建的版本号+1
            int filebackupDir = fileSourceDir + 1;
            //时间
            int date4 = date3;
            string backupDir = @"D:\Request By Deo\" + date4 + " Update(Version 7.0.3." + filebackupDir + ")";
            tex_url.Text = backupDir;
            //    string fileType = "xls";
            CopyAllFiles(fileSource, backupDir);
        }

        //dataGridView 单元格结束编辑时间
        private void dgv_sars1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //获取当前编辑的单元格行数
            int i = dgv_sars1.CurrentRow.Index;
            //获取当前编辑的单元格的第一列值
            string strFri = dgv_sars1.Rows[i].Cells[0].Value.ToString();
            //获取当前编辑的单元格列名
            string strHead = dgv_sars1.Columns[dgv_sars1.CurrentCell.ColumnIndex].HeaderText;
            //获取当前编辑的单元格的值
            string strUpa = dgv_sars1.CurrentCell.Value.ToString();

            string SQLUp = "update sasr1 set " + strHead + "=" + "'" + strUpa + "'" + " where TrackNo=" + "'" + strFri + "'";

            if (!strHead.Equals("TodayCompletedtasks"))
            {
                AWF.Classes.SqlHelper.ExecuteNonQuery(connString, SQLUp);
            }
        }

        private void dgv_sasr2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            String aaa = dgv_sasr2.Columns[dgv_sasr2.CurrentCell.ColumnIndex].HeaderText;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                String str_dgv_sasr2_value = dgv_sasr2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (aaa == "TrackNo")
                {
                    String selectStr = "Select RequestDescription from sasr1 where TrackNo=" + "'" + str_dgv_sasr2_value + "'";
                    DataTable dt_Select = new DataTable();
                    dt_Select = AWF.Classes.SqlHelper.ExecuteDataTable(connString, selectStr);
                    for (int i = 0; i < dt_Select.Rows.Count; i++)
                    {
                        String strReq = "当前选中的ResquestDescriPtion 为" + "\\n" + dt_Select.Rows[i][0].ToString();
                        txt_ReDes.Text = strReq;
                    }
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                Serverlist.Clear();
                cbm_Table.Items.Clear();
                strTableName = "sasr1";
                Get_TableName(strTableName);
            }
            else
            {
                Serverlist.Clear();
                strTableName = "sasr2";
                Get_TableName(strTableName);
            }
        }
    }
}
