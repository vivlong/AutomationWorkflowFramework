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
            string strCommand = "Select TrackNo,''as [Today Completed tasks],FixVersion as [Fix Version],ActualCompletionDate as[Actual Completion Date],ProgrammingSummary as[Programming Summary],TestSummary as[Test Summary],Form,RequestDescription as [Request Description],CompleteByName as[Complete By Name],TestByName as[Test By Name],TestDate as[Test Date],TestResultFlag as [Test Result] from sasr1";
            connString = @"Server=" + txt_SqlAddress.Text + ";DataBase=" + cbm_database.Text + ";UID=" + txt_user.Text + ";PWD=" + txt_password.Text + ";";
            dt = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strCommand);
            Get_TableName(strTableName);
            AWF.Classes.ConfHelper.SaveConf(txt_SqlAddress.Text, cbm_database.Text, txt_user.Text, txt_password.Text,tex_url.Text);
            MessageBox.Show("数据库连接成功");
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
              //  MessageBox.Show("确定添加表");
            }
            //不允许dataGridView显示添加行，负责导出时会报最后一行未实例化错误
            dataGridView1.AllowUserToAddRows = false;
            try
            {
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
                    mySheet.SetColumnWidth(3, 30 * 256);
                    mySheet.SetColumnWidth(4, 12 * 256);
                    mySheet.SetColumnWidth(5, 12 * 256);
                    mySheet.SetColumnWidth(6, 12 * 256);
                    mySheet.SetColumnWidth(7, 12 * 256);
                    mySheet.SetColumnWidth(8, 12 * 256);
                    mySheet.SetColumnWidth(9, 12 * 256);
                    mySheet.SetColumnWidth(10, 12 * 256);
                    mySheet.SetColumnWidth(11, 12 * 256);

                    //设置字体的颜色
                    //ICellStyle style_Body = workbook.CreateCellStyle();
                    //IFont font_Body = workbook.CreateFont();
                    //font_Body.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                    //font_Body.FontHeightInPoints = 10;
                    //style_Body.SetFont(font_Body);


                    ICellStyle styleHead = workbook.CreateCellStyle();
                    IFont font = workbook.CreateFont();
                    font.FontHeightInPoints = 10;
                    font.FontName = "Arial Unicode MS";
                    font.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                    styleHead.SetFont(font);
                    styleHead.FillPattern = FillPattern.SolidForeground;
                    styleHead.FillForegroundColor = HSSFColor.Yellow.Index;
                    styleHead.WrapText = true;
                    styleHead.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    styleHead.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                    styleHead.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleHead.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleHead.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleHead.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;


                    ICellStyle style1 = workbook.CreateCellStyle();
                         IFont fontStyle= workbook.CreateFont();
                     fontStyle.FontName = "Arial Unicode MS";
                    fontStyle.FontHeightInPoints = 10;

                    style1.SetFont(fontStyle);
                    style1.FillPattern = FillPattern.SolidForeground;
                     style1.FillForegroundColor = HSSFColor.Yellow.Index;
                     style1.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                     style1.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                    style1.WrapText = true;
                    style1.Indention = 0;
                    style1.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    style1.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    style1.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    style1.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;


                    ICellStyle TodayComletedTaskStyle = workbook.CreateCellStyle();
                    TodayComletedTaskStyle.FillPattern = FillPattern.SolidForeground;
                    TodayComletedTaskStyle.FillForegroundColor = HSSFColor.Yellow.Index;
                    IFont TodayCompletedTaskfont = workbook.CreateFont();
                    TodayCompletedTaskfont.FontName = "Arial Unicode MS";
                    TodayCompletedTaskfont.Color = HSSFColor.OliveGreen.Red.Index;
                    TodayComletedTaskStyle.SetFont(TodayCompletedTaskfont);
                    TodayComletedTaskStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    TodayComletedTaskStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                    TodayComletedTaskStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    TodayComletedTaskStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    TodayComletedTaskStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    TodayComletedTaskStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;

                    ICellStyle headCellStyle = workbook.CreateCellStyle();
                    headCellStyle.FillPattern = FillPattern.SolidForeground;
                    headCellStyle.FillForegroundColor = HSSFColor.Yellow.Index;
                    headCellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    headCellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                    IFont headCellfont = workbook.CreateFont();
                    headCellfont.Color = HSSFColor.OliveGreen.Red.Index;
                    headCellfont.FontHeightInPoints = 10;
                    headCellfont.FontName = "Arial Unicode MS";
                    headCellfont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                    headCellStyle.SetFont(headCellfont);

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
                    strColumName[0] = "Track No";
                    strColumName[3] = "Today Completed tasks";
                    strColumName[4] = "Fix Version";
                    strColumName[6] = "Actual Completion Date";
                    strColumName[7] = "Programming Summary";
                    strColumName[11] = "Test Summary";
                    strColumName[1] = "Form";
                    strColumName[2] = "Request Description";
                    strColumName[5] = "Complete By Name";
                    strColumName[8] = "Test By Name";
                    strColumName[9] = "Test Date";
                    strColumName[10] = "Test Result";
                    //填写表头
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        rowHead.CreateCell(i, CellType.String).SetCellValue(dataGridView1.Columns[strColumName[i]].HeaderText.ToString());

                        if (i == 3)
                        {

                            rowHead.Cells[3].CellStyle = headCellStyle;
                            rowHead.HeightInPoints = 2 * mySheet.DefaultRowHeight * 1 / 20;
                        }
                        else
                        {
                            rowHead.Cells[i].CellStyle = styleHead;
                            rowHead.HeightInPoints = 2 * mySheet.DefaultRowHeight * 1 / 20;

                        }

                    }

                    //填写内容
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        IRow row = mySheet.CreateRow(i + 1);

                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {


                            if (j == 6)
                            {
                                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                                row.CreateCell(j, CellType.String).SetCellValue(System.DateTime.Now.ToString(System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd MMM,yyyy"));
                                row.Cells[6].CellStyle = style1;      
                            }
                            else if (j == 9)
                            {
                                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                                row.CreateCell(j, CellType.String).SetCellValue(System.DateTime.Now.ToString(System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "dd MMM,yyyy"));
                                row.Cells[9].CellStyle = style1; 
                            }

                            else
                            {

                                row.CreateCell(j, CellType.String).SetCellValue(dataGridView1.Rows[i].Cells[strColumName[j]].Value.ToString());
                                row.Cells[j].CellStyle = style1; 
                           
                            }



                            if (j == 3)
                            {
                                row.Cells[3].CellStyle = TodayComletedTaskStyle;
                                row.HeightInPoints = 3 * mySheet.DefaultRowHeight / 20;
                            }
                            else
                            {
                                row.Cells[j].CellStyle = style1;
                                row.HeightInPoints = 3 * mySheet.DefaultRowHeight / 20;

                            }



                        }
                    }

                    using (FileStream stream = File.OpenWrite(fileDialog.FileName))
                    {

                        workbook.Write(stream);
                        stream.Close();
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
            catch 
            {
                MessageBox.Show("请先关闭当前的Excel文件");
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
            try
            {
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
                    font.FontName = "Arial Unicode MS";
                    font.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                    styleExp2.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                      styleExp2.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExp2.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExp2.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExp2.SetFont(font);


                    ICellStyle styleExpCell = workbook.CreateCellStyle();
                    IFont fontExpCell = workbook.CreateFont();
                    font.FontHeightInPoints = 10;
                    font.FontName = "Arial Unicode MS";
               
                    styleExpCell.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExpCell.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExpCell.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExpCell.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExpCell.SetFont(fontExpCell);

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
                        rowHead.HeightInPoints = 2 * mySheet.DefaultRowHeight * 1 / 20;
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
                                row.HeightInPoints = 2 * mySheet.DefaultRowHeight / 20;
                                row.Cells[0].CellStyle = styleExpCell;

                            }
                            else
                            {
                                row.CreateCell(j, CellType.String).SetCellValue(dataGridView2.Rows[i].Cells[j].Value.ToString());
                                row.HeightInPoints = 2 * mySheet.DefaultRowHeight / 20;
                                row.Cells[j].CellStyle = styleExpCell;

                            }

                        }


                    }

                    using (FileStream stream = File.OpenWrite(fileDialog.FileName))
                    {
                        workbook.Write(stream);
                        stream.Close();
                    }
                    MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GC.Collect();
                }
                catch
                {
                    MessageBox.Show("所填写的名字不存在");
                }
            }
            catch
            { 
               
                    MessageBox.Show("请先关闭当前的Excel文件");
            
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
            tex_url.Text = cj.RequestXls.TextUrl;
            this.connString = @"Server=" + txt_SqlAddress.Text + ";DataBase=" + cbm_database.Text + ";UID=" + txt_user.Text + ";PWD=" + txt_password.Text + ";";
            Get_TableName(strTableName);
            try
            {
                DataTable dt1 = AWF.Classes.SqlHelper.ExecuteDataTable(connString, "Select GetDate()");
                if (dt1 != null)
                {
                    this.txtPublishDate.Text = Convert.ToDateTime(dt1.Rows[0][0]).ToString("yyyy-MM-dd");
                }
            }
            catch { }

           
           
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

        private string sqlSafe(string strValue)
        {
            return strValue.Replace("'", "''");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string strCb1 = cbm_Table.Text;
            string strSelect,strFitler;
            string strTx4 = sqlSafe(txt_search.Text);
            strSelect = "Select TrackNo AS [Track No],''as [Today Completed tasks],FixVersion as [Fix Version],ActualCompletionDate as[Actual Completion Date],ProgrammingSummary as[Programming Summary],TestSummary as[Test Summary],Form,RequestDescription as [Request Description],CompleteByName as[Complete By Name],TestByName as[Test By Name],TestDate as[Test Date],TestResultFlag as [Test Result] from sasr1 ";
            string strSasr2 = "select Sasr1.ActualCompletionDate as Date, Sasr2.TrackNo,Sasr2.TableName,Sasr2.FieldName,Sasr2.Type as DateType,Sasr2.LEN as Length,Sasr2.SPFlag as StoreProcedureName,Sasr2.TriggerName,Sasr2.Remark from Sasr2 ,sasr1 where Sasr2.TrackNo=sasr1.TrackNo";
            if (tabControl1.SelectedTab == tabPage1)
            {
                dt.Clear();
                if (strCb1 == "")
                {
                  // strSelect = "Select TrackNo,Form,RequestDescription,''as TodayCompletedtasks,FixVersion,CompleteByName,ActualCompletionDate,ProgrammingSummary,TestByName,TestDate,TestResultFlag as TestResult,TestSummary  from sasr1";

                //    MessageBox.Show("请连接数据库");
                }

                else if (strCb1 == "sasr1.ActualCompletionDate")
                {
                    //查找某一年
                    if (strTx4.Length <= 4)
                    {
                        strSelect = strSelect + " where " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'";
                    }
                    else
                    {
                        //查找具体某一天
                        DateTime date = Convert.ToDateTime(strTx4);
                        strSelect = strSelect + " where ActualCompletionDate='" + date + "'";
                    }
                }
                else if (strCb1 == "sasr1.TestDate")
                {
                    //查找某一年
                    if (strTx4.Length <= 4)
                    {
                        strSelect = strSelect + " where " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'";
                    }
                    else
                    {
                        //查找具体某一天
                        DateTime date = Convert.ToDateTime(strTx4);
                        strSelect = strSelect + " where ActualCompletionDate='" + date + "'";
                    }

                }
                else
                {
                    // "Select TrackNo,Form,RequestDescription,''as  [Today Completed tasks],FixVersion,CompleteByName,ActualCompletionDate,ProgrammingSummary,TestByName,TestDate,TestResultFlag,TestSummary  from sasr1
                //    strSelect = "Select TrackNo,Form,RequestDescription,''as TodayCompletedtasks,FixVersion,CompleteByName,ActualCompletionDate,ProgrammingSummary,TestByName,TestDate,TestResultFlag,TestSummary  from sasr1 where " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'";
                    strSelect = strSelect + " where " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'";      
                }
                //strSelect = strSelect + strFitler;
                DataTable dt2 = new DataTable();
                dt2 = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strSelect);
                dgv_sars1.DataSource = dt2;
                dgv_sars1.Columns["Track No"].ReadOnly = true;
                dgv_sars1.AllowUserToResizeRows = true;
                dgv_sars1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
                dgv_sars1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv_sars1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv_sars1.Columns["Today Completed tasks"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                dgv_sars1.RowsDefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                if (strCb1 == "")
                {
                    //strSasr2 = "select CONVERT(varchar(100), GETDATE(), 106) as Date,TrackNo,TableName,FieldName,Type,LEN,SPFlag,TriggerFlag,Remark from Sasr2 ";
                 
                }

                else if (strCb1 == "sasr1.ActualCompletionDate")
                {
                    //查找某一年
                    if (strTx4.Length <= 4)
                    {
                        strSasr2 =strSasr2 +" AND " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'";
                    }
                    else
                    {
                        //查找具体某一天
                        DateTime date = Convert.ToDateTime(strTx4);
                        strSasr2 = strSasr2 + " AND ActualCompletionDate='" + date + "'";
                    }
                }

                else if (strCb1 == "sasr1.TestDate")
                {
                    //查找某一年
                    if (strTx4.Length <= 4)
                    {
                        strSasr2 = strSasr2 + " AND " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'";
                    }
                    else
                    {
                        //查找具体某一天
                        DateTime date = Convert.ToDateTime(strTx4);
                        strSasr2 = strSasr2 + " AND ActualCompletionDate='" + date + "'";
                    }
                }

                else
                {
                    //   strSasr2 = "select CONVERT(varchar(100), GETDATE(), 106) as Date,TrackNo,TableName,FieldName,Type,LEN,SPFlag,TriggerFlag,Remark from Sasr2 where " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'"; 
                    strSasr2 = strSasr2 + " and " + strCb1 + " " + "like" + " " + "'%" + strTx4 + "%'";
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
           // string fileSource = @"\\192.168.0.250\Net Application\" + date1.ToString("yyMMdd") + " Update(Version " + vlue + "." + fileSourceDir + ")";
            string fileSource = @"\\" + tex_url.Text.ToString()+ @"\" + date1.ToString("yyMMdd") + " Update(Version " + vlue + "." + fileSourceDir + ")";
            while (!Directory.Exists(fileSource))
            {

                date1 = date1.AddDays(-1);
                fileSource = @"\\" + tex_url.Text.ToString()+ @"\" + date1.ToString("yyMMdd") + " Update(Version " + vlue + "." + fileSourceDir + ")";
                if (date1.Date < DateTime.Now.AddYears(-3))
                {
                    return;
                }
            }
            //创建的版本号+1
            int filebackupDir = fileSourceDir + 1;
            //时间
            int date4 = date3;
            //此路径是与复制文件夹同一路径 自己本机测试的话要自己新建文件夹存储
          string backupDir = @"\\" + tex_url.Text.ToString() + @"\" + date4 + " Update(Version " + vlue + "." + filebackupDir + ")";
          // string backupDir = @"D:\Request By Deo\" + date4 + " Update(Version " + vlue + "." + filebackupDir + ")";
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
                cbm_Table.Text = "";
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

        private void com_version_SelectedValueChanged(object sender, EventArgs e)
        {
            string NewP = Classes.Modfunction.baseDPath + "New SysFreight Source " + this.com_version .SelectedItem.ToString().Replace(".", "") + @"\SysFreight\SysFreightMain\SysFreight.vbproj.user";
            if (AWF.Classes.Modfunction.pingIPAddress("192.168.0.236"))
            {
                if (File.Exists(NewP))
                {
                    using (StreamReader objReader = new StreamReader(NewP))
                    {
                        string sLine = "";
                        System.Collections.ArrayList LineList = new System.Collections.ArrayList();
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
                        txt_versionName.Text =( int.Parse(CurrentVersion)-1).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("当前版本源码路径不存在!");
                }
            }
        }

        private void cmdVersionSearch_Click(object sender, EventArgs e)
        {
            string strSelect, strFitler, strFitler2;
            strSelect = "Select TrackNo AS [Track No],case (right(rtrim(isnull(ProgrammingSummary,'')),4)) when 'Done' then 'Fix this request form' else '' end as [Today Completed tasks],FixVersion as [Fix Version],ActualCompletionDate as[Actual Completion Date],ProgrammingSummary as[Programming Summary],TestSummary as[Test Summary],Form,RequestDescription as [Request Description],CompleteByName as[Complete By Name],TestByName as[Test By Name],TestDate as[Test Date],TestResultFlag as [Test Result] from sasr1 ";
            string strSasr2 = "select b.ActualCompletionDate as Date, a.TrackNo,a.TableName,a.FieldName,a.Type as DateType,a.LEN as Length,a.SPFlag as StoreProcedureName,a.TriggerName,a.Remark from Sasr2 a,sasr1 b where a.TrackNo=b.TrackNo";
            strFitler = " FixVersion like '%" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text + "%' AND convert(char(10),ActualCompletionDate,20)='" + this.txtPublishDate.Text + "'";
            strFitler2 = " b.FixVersion like '%" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text + "%' AND convert(char(10),a.ModifyAt,20)='" + this.txtPublishDate.Text + "'";
            strSelect = strSelect + " Where " + strFitler;
            strSasr2 = strSasr2 + " AND " + strFitler2;
            DataTable dt_Select = new DataTable();
            dt_Select = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strSelect);
            for (int intI = 0; intI < dt_Select.Rows.Count; intI++)
            {
                if (dt_Select.Rows[intI]["Today Completed tasks"] == null || dt_Select.Rows[intI]["Today Completed tasks"] =="")
                {
                    string strFixInfo;
                    int intIndex = 0;
                    intIndex = dt_Select.Rows[intI]["Programming Summary"].ToString().IndexOf(this.txtPublishDate.Text.Substring(3).Replace ("-",""));
                    strFixInfo = dt_Select.Rows[intI]["Programming Summary"].ToString().Substring(intIndex-1);
                    string[] strInfo;
                    if (strFixInfo.IndexOf(":")>0)
                    { 
                    strInfo = strFixInfo.Substring(strFixInfo.IndexOf(":")).Split( ':');
                    string Fix;
                    Fix = "";
                    if (dt_Select.Rows[intI]["Test Summary"].ToString().IndexOf(strInfo[1].Trim()) > 0)
                    {
                        Fix = dt_Select.Rows[intI]["Test Summary"].ToString().Substring(dt_Select.Rows[intI]["Test Summary"].ToString().IndexOf(strInfo[1].Trim()) +strInfo[1].Trim().Length  + 1);
                        dt_Select.Rows[intI]["Today Completed tasks"] = Fix;
                    }
                    if (Fix == "")
                    {
                        string strProgr = dt_Select.Rows[intI]["Programming Summary"].ToString();
                        strProgr=strProgr.Substring(strProgr.LastIndexOf( this.com_version.SelectedItem.ToString()));

                        if (dt_Select.Rows[intI]["Test Summary"].ToString().IndexOf(strProgr.Trim()) > 0)
                    {
                        Fix = dt_Select.Rows[intI]["Test Summary"].ToString().Substring(dt_Select.Rows[intI]["Test Summary"].ToString().IndexOf(strProgr.Trim()) + strProgr.Trim().Length + 1);
                        dt_Select.Rows[intI]["Today Completed tasks"] = Fix;
                    }
                    }
                    }
                }
            }
                dgv_sars1.DataSource = dt_Select; 
            dgv_sars1.Columns["Track No"].ReadOnly = true;
            dgv_sars1.AllowUserToResizeRows = true;
            dgv_sars1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv_sars1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_sars1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_sars1.Columns["Today Completed tasks"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            dgv_sars1.RowsDefaultCellStyle.BackColor = Color.Yellow;
            DataTable dt_Select2 = new DataTable();
            dt_Select2 = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strSasr2);
            dgv_sasr2.DataSource = dt_Select2;
            lblCount.Text = "总行数 ： " + (dgv_sars1.Rows.Count-1).ToString();
            label2.Text = "总行数 ： " + (dgv_sasr2.Rows.Count - 1).ToString();
            txt_editionSasr1.Text = DateTime.Now.ToString("yyMMdd") + " V_" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text;
        }
    }
}
