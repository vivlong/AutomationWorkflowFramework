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
using AWF.Classes;

namespace AWF
{
    public partial class Frm_RequestXls : Form
    {
        private string strTableName = "sasr1";
        private DataTable dt = new DataTable();
        private DataSet ds1 = new DataSet();
        private List<string> Serverlist = new List<string>();
        private string connString = "";
        private int FieldCount = 0;
            
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
        public static Boolean ExportToExcel(DataGridView dataGridView1, string sheetName,string strFilePathAndName)
        {
            if (dataGridView1.RowCount == 0) { return false ; }
            int rowCount = dataGridView1.RowCount;
            if (strFilePathAndName==null || strFilePathAndName == "")
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Microsoft Excel|*.xls";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    strFilePathAndName = fileDialog.FileName;
                    //   return;
                    //  MessageBox.Show("确定添加表");
                }
            }            
            //不允许dataGridView显示添加行，负责导出时会报最后一行未实例化错误
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                FileStream readfile = new FileStream(strFilePathAndName, FileMode.Open, FileAccess.Read);
          
                //HSSFWorkbook适合word2003 XSSFWorkbook适应2007
                HSSFWorkbook workbook = new HSSFWorkbook(readfile);
          
                //工作蒲
                //  ISheet mySheetG = workbook.GetSheet(sheetName); 
                try
                {
                    ISheet mySheet = workbook.CreateSheet(sheetName);
                    workbook.SetActiveSheet(workbook.GetSheetIndex(mySheet));
                    //设置表格的宽度
                    mySheet.SetColumnWidth(2, 50 * 256);
                    mySheet.SetColumnWidth(3, 30 * 256);
                    mySheet.SetColumnWidth(4, 11* 256);
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
                 fontStyle.FontHeightInPoints =10;
                    style1.SetFont(fontStyle);
                    style1.FillPattern = FillPattern.SolidForeground;
                     style1.FillForegroundColor = HSSFColor.Yellow.Index;
                     style1.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
                     style1.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                   style1.WrapText = true;
                    //缩进
                    style1.Indention = 0;
                  
                    style1.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    style1.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    style1.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    style1.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;





                    //对Complete By Name ,Actual Completion,Test By Name,Test Date 进行格式操作
                    ICellStyle styleCACT= workbook.CreateCellStyle();
                    IFont fontstyleCACT = workbook.CreateFont();
                    fontstyleCACT.FontName = "Arial Unicode MS";
                    fontstyleCACT.FontHeightInPoints = 10;
                    styleCACT.WrapText = true;
                    styleCACT.SetFont(fontstyleCACT);
                    styleCACT.FillPattern = FillPattern.SolidForeground;
                    styleCACT.FillForegroundColor = HSSFColor.Yellow.Index;
                    styleCACT.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                    styleCACT.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;            
                    styleCACT.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleCACT.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleCACT.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleCACT.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;



                    ICellStyle TodayComletedTaskStyle = workbook.CreateCellStyle();
                    TodayComletedTaskStyle.FillPattern = FillPattern.SolidForeground;
                    TodayComletedTaskStyle.FillForegroundColor = HSSFColor.Yellow.Index;
                    IFont TodayCompletedTaskfont = workbook.CreateFont();
                    TodayCompletedTaskfont.FontName = "Arial Unicode MS";
                    TodayCompletedTaskfont.Color = HSSFColor.OliveGreen.Red.Index;
                    TodayComletedTaskStyle.SetFont(TodayCompletedTaskfont);
                    TodayComletedTaskStyle.WrapText = true;
                    TodayComletedTaskStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
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
                            rowHead.HeightInPoints = 4* mySheet.DefaultRowHeight * 1 / 20;
                        }
                        else
                        {
                            rowHead.Cells[i].CellStyle = styleHead;
                            rowHead.HeightInPoints = 4 * mySheet.DefaultRowHeight * 1 / 20;

                        }

                    }

                    //填写内容
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        IRow row = mySheet.CreateRow(i + 1);

                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (j == 2)
                            {
                                string strValue="";
                                strValue=dataGridView1.Rows[i].Cells[strColumName[j]].Value.ToString();
                                while (strValue.IndexOf("  ")>0)
                                {
                                 strValue=   strValue.Replace("  ", " ");
                                }
                               strValue= strValue.Replace("\n", "\t");
                           
                                row.CreateCell(j, CellType.String).SetCellValue(strValue);  
                            
                            }

                            else if (j == 6)
                            {
                                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                                string strValue = "";

                                if (dataGridView1.Rows[i].Cells[strColumName[j]].Value != null && dataGridView1.Rows[i].Cells[strColumName[j]].Value.ToString().Length > 0)
                                {
                                    strValue = ((DateTime)dataGridView1.Rows[i].Cells[strColumName[j]].Value).ToString("dd MMM,yyyy");
                                }

                                row.CreateCell(j, CellType.String).SetCellValue(strValue);


                            }
                            else if (j == 9)
                            {
                                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                                string strValue = "";

                                if (dataGridView1.Rows[i].Cells[strColumName[j]].Value != null && dataGridView1.Rows[i].Cells[strColumName[j]].Value.ToString().Length > 0)
                                {
                                    strValue = ((DateTime)dataGridView1.Rows[i].Cells[strColumName[j]].Value).ToString("dd MMM,yyyy");
                                }

                                row.CreateCell(j, CellType.String).SetCellValue(strValue);
                            }


                            else
                            {


                                row.CreateCell(j, CellType.String).SetCellValue(dataGridView1.Rows[i].Cells[strColumName[j]].Value.ToString().Trim());

                            }



                            if (j == 3)
                            {
                                row.Cells[3].CellStyle = TodayComletedTaskStyle; 
                                //设置行的高度
                               row.HeightInPoints =5 * mySheet.DefaultRowHeight / 20;
                            }
                            else if (j == 5 || j == 6 || j == 8 || j == 9)
                                
                            {
                               row.Cells[j].CellStyle = styleCACT;
                            row.HeightInPoints = 5 * mySheet.DefaultRowHeight / 20;
                            }
                            else
                            {
                                row.Cells[j].CellStyle = style1;
                                row.HeightInPoints = 5 * mySheet.DefaultRowHeight / 20;

                            }



                        }
                    }

                    using (FileStream stream = File.OpenWrite(strFilePathAndName))
                    {

                        workbook.Write(stream);
                        stream.Close();
                        readfile.Close();
                    }
                    //MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GC.Collect();
                    return true;
                }

                catch
                {
                    MessageBox.Show("你所创建的表已存在");
                    dataGridView1.AllowUserToAddRows = true;
                  
                    return false;
                }
            }
            catch 
            {
                MessageBox.Show("请先关闭当前的Excel文件");
                dataGridView1.AllowUserToAddRows = true;
                  
                return false;
            }
        }
 


        public Boolean ExportToExcel2(DataGridView dataGridView2, string sheetName2,string strFileName)
        {
            if (this.dgv_sasr2.RowCount == 0) { return false ; }
            if (label2.Text == "") { return false ; }
            int rowCount = FieldCount;
            if (strFileName == null || strFileName == "")
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Microsoft Excel|*.xls";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    strFileName = fileDialog.FileName;
                }
            }
            
            //不允许dataGridView显示添加行，负责导出时会报最后一行未实例化错误
            dataGridView2.AllowUserToAddRows = false;
            try
            {
                FileStream readfile = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
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
                    font.FontHeightInPoints = 12;
                    font.FontName = "Arial Unicode MS";
                    styleExp2.SetFont(font);
                    font.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                    styleExp2.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                      styleExp2.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExp2.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExp2.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                    


                    ICellStyle styleExpCell = workbook.CreateCellStyle();
                    IFont fontExpCell = workbook.CreateFont();
                    font.FontHeightInPoints = 12;
                    font.FontName = "Arial Unicode MS";
                    styleExpCell.VerticalAlignment = VerticalAlignment.Center;
                    styleExpCell.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Left;
                    styleExpCell.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExpCell.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExpCell.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExpCell.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                    styleExpCell.SetFont(fontExpCell);

                    HSSFRow mySourceStyleRow = (HSSFRow)mySheet.GetRow(2);

                    try
                    {
                        mySheet.ShiftRows(2, mySheet.LastRowNum, rowCount, true, false);
                        for (int i = 0; i < rowCount - 2; i++)
                        {
                            HSSFRow targetRow = null;
                            HSSFCell sourceCell = null;
                            HSSFCell targetCell = null;
                            targetRow = (HSSFRow)mySheet.CreateRow(i + 2);
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
                    //HSSFRow firstTargetRow = (HSSFRow)mySheet.CreateRow(3);
                    //HSSFCell firstSourceCell = null;
                    //HSSFCell firstTargetCell = null;
                    //for (int m = mySourceStyleRow.FirstCellNum; m < mySourceStyleRow.LastCellNum; m++)
                    //{
                    //    firstSourceCell = (HSSFCell)mySourceStyleRow.GetCell(m);
                    //    if (firstSourceCell == null)
                    //        continue;
                    //    firstTargetCell = (HSSFCell)firstTargetRow.CreateCell(m);
                    //    //   firstTargetCell.Encoding = firstSourceCell.Encoding;
                    //    firstTargetCell.CellStyle = firstSourceCell.CellStyle;
                    //    firstTargetCell.SetCellType(firstSourceCell.CellType);
                    //}

                   // IRow rowHead = mySheet.CreateRow(0);

                   //// 填写表头
                   // for (int i = 0; i < dataGridView2.Columns.Count; i++)
                   // {
                   //     rowHead.CreateCell(i, CellType.String).SetCellValue(dataGridView2.Columns[i].HeaderText.ToString());
                   //     rowHead.Cells[i].CellStyle = styleExp2;
                   //     rowHead.HeightInPoints = 2 * mySheet.DefaultRowHeight * 1 / 20;
                   // }

                    //填写内容
                    for (int i = 0; i < rowCount; i++)
                    {
                        IRow row = mySheet.CreateRow(i + 2);
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

                    using (FileStream stream = File.OpenWrite(strFileName))
                    {
                        workbook.Write(stream);
                        stream.Close();
                    }
                    //MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GC.Collect();
                    return true;
                }
                catch
                {
                    MessageBox.Show("所填写的名字不存在");
                    return false;
                }
            }
            catch
            { 
               
                    MessageBox.Show("请先关闭当前的Excel文件");
                    return false;
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
                    disCurrentDate.Text = this.txtPublishDate.Text;
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
                if (ExportToExcel(dgv_sars1, editon, "") == true)
                {
                    MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_sars1.AllowUserToAddRows = true;
                }
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
               if( ExportToExcel2(dgv_sasr2, editon,"")==true)
               {
                   MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
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
           if(MessageBox.Show ("确认核对完所有信息，Request信息和数据库修改，并要做导出操作？","保存",MessageBoxButtons.YesNo)==  System.Windows.Forms.DialogResult.No ){return ;}
            int fileSourceDir = int.Parse(txt_versionName.Text.Trim())-1;
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
            int date4 = int.Parse(this.txtPublishDate .Text.Replace("-","").Substring(2));
       
            //此路径是与复制文件夹同一路径 自己本机测试的话要自己新建文件夹存储
         //    string backupDir = @"D:\Request By Deo\" + date4 + " Update(Version " + vlue + "." + filebackupDir + ")";
             string backupDir =  @"\\" + tex_url.Text.ToString() + @"\" + date4 + " Update(Version " + vlue + "." + filebackupDir + ")";
            tex_url.Text = backupDir;
            //    string fileType = "xls";
            CopyAllFiles(fileSource, backupDir);
            string strExcelName= backupDir + @"\Version " + vlue + ".xx Update tasks.xls";
            if ((File.Exists(strExcelName))==false )
            {
                strExcelName = backupDir + @"\Version" + vlue + ".xx Update tasks.xls";
            }
            ExportToExcel(dgv_sars1, this.txt_editionSasr1.Text.Trim(), strExcelName);
            ExportToExcel2(dgv_sasr2, txt_edition.Text.Trim(), backupDir + @"\Database Change & App List " + vlue.Replace (".","") + ".xls");
            MessageBox.Show("导出数据成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        tex_url.Text = "192.168.0.250\\Net Application";
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
             tex_url.Text = "192.168.0.250\\Net Application";
            string strSelect, strFitler, strFitler2;
            strSelect = "Select TrackNo AS [Track No],case (right(rtrim(isnull(ProgrammingSummary,'')),4)) when 'Done' then 'Fix this request form' else '' end as [Today Completed tasks],FixVersion as [Fix Version],ActualCompletionDate as[Actual Completion Date],ProgrammingSummary as[Programming Summary],TestSummary as[Test Summary],Form,RequestDescription as [Request Description],CompleteByName as[Complete By Name],TestByName as[Test By Name],TestDate as[Test Date],TestResultFlag as [Test Result] from sasr1 ";
            string strSasr2 = "select b.ActualCompletionDate as Date, a.TrackNo,a.TableName,a.FieldName,a.Type as DateType,a.LEN as Length,a.SPFlag as StoreProcedureName,a.TriggerName,a.Remark from Sasr2 a,sasr1 b where a.TrackNo=b.TrackNo";
            
            
            if (disCurrentDate.Text == this.txtPublishDate.Text)
            {
                strFitler = " (FixVersion like '%" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text + "%' AND convert(char(10),ActualCompletionDate,20)='" + this.txtPublishDate.Text + "')  OR ( FixVersion like '%" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text + "%')";
                strFitler2 = " b.FixVersion like '%" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text + "%' AND convert(char(10),a.ModifyAt,20)='" + this.txtPublishDate.Text + "'";
            }
            else
            {
                strFitler = "(( FixVersion like '%" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text + "%' AND convert(char(10),ActualCompletionDate,20)='" + this.txtPublishDate.Text + "') OR ( FixVersion like '%" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text + "%'))";
                strFitler2 = "(( b.FixVersion like '%" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text + "%' AND convert(char(10),a.ModifyAt,20)='" + this.txtPublishDate.Text + "'))";
            }
            strSelect = strSelect + " Where " + strFitler + " order by TrackNo desc";
            strSasr2 = strSasr2 + " AND " + strFitler2 + " Order by b.TrackNo desc,a.TableName";
            DataTable dt_Select = new DataTable();
            dt_Select = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strSelect);
            for (int intI = 0; intI < dt_Select.Rows.Count; intI++)
            {


                if (dt_Select.Rows[intI]["Test Result"].ToString() == "Y" || dt_Select.Rows[intI]["Test Result"].ToString() == null || dt_Select.Rows[intI]["Test Result"].ToString()=="")
                {

                    dt_Select.Rows[intI]["Today Completed tasks"] = "Fix this request form";
                }

                else if (dt_Select.Rows[intI]["Today Completed tasks"] == null || dt_Select.Rows[intI]["Today Completed tasks"].ToString() == "")
                {
                    string strFixInfo;
                    int intIndex = 0;
                    intIndex = dt_Select.Rows[intI]["Programming Summary"].ToString().IndexOf(this.txtPublishDate.Text.Substring(3).Replace("-", ""));
                    if (intIndex <= 0) { intIndex = 1; }
                    strFixInfo = dt_Select.Rows[intI]["Programming Summary"].ToString().Substring(intIndex - 1);
                    string[] strInfo;
                    if (strFixInfo.IndexOf(":") > 0)
                    {
                        strInfo = strFixInfo.Substring(strFixInfo.IndexOf(":")).Split(':');
                        string Fix;
                        Fix = "";
                        if (dt_Select.Rows[intI]["Test Summary"].ToString().IndexOf(strInfo[1].Trim()) > 0)
                        {
                            Fix = dt_Select.Rows[intI]["Test Summary"].ToString().Substring(dt_Select.Rows[intI]["Test Summary"].ToString().IndexOf(strInfo[1].Trim())- 1);
                            dt_Select.Rows[intI]["Today Completed tasks"] ="Fix " + Fix;
                        }
                        if (Fix == "")
                        {
                            string strProgr = dt_Select.Rows[intI]["Programming Summary"].ToString();
                            strProgr = strProgr.Substring(strProgr.LastIndexOf(this.com_version.SelectedItem.ToString()));

                            if (dt_Select.Rows[intI]["Test Summary"].ToString().IndexOf(strProgr.Trim()) > 0)
                            {
                                Fix = dt_Select.Rows[intI]["Test Summary"].ToString().Substring(dt_Select.Rows[intI]["Test Summary"].ToString().IndexOf(strProgr.Trim()));
                                string strReject = dt_Select.Rows[intI]["Test Summary"].ToString().Substring(0,dt_Select.Rows[intI]["Test Summary"].ToString().IndexOf(strProgr.Trim())-1);
                                if (strReject.LastIndexOf("\n") > 0)
                                { strReject = strReject.Substring(strReject.LastIndexOf("\n") + "\n".Length); }

                                dt_Select.Rows[intI]["Today Completed tasks"] ="Fix " + strReject + Fix;
                            }
                        }
                        if (Fix == "")
                        {
                            string strProgr = strInfo[strInfo.Length -1];
                            strProgr = strProgr.Trim().Substring(5).Trim();
                            Fix = "";
                            if (dt_Select.Rows[intI]["Request Description"].ToString().IndexOf(strProgr.Trim()) > 0)
                            {
                                Fix = dt_Select.Rows[intI]["Request Description"].ToString().Substring(dt_Select.Rows[intI]["Request Description"].ToString().IndexOf(strProgr.Trim())  );
                                string strReject = dt_Select.Rows[intI]["Request Description"].ToString().Substring(0, dt_Select.Rows[intI]["Request Description"].ToString().IndexOf(strProgr.Trim()) );
                                if (strReject.LastIndexOf("\n") > 0)
                                { strReject = strReject.Substring(strReject.LastIndexOf("\n")+"\n".Length ); }
                                dt_Select.Rows[intI]["Today Completed tasks"] = "Fix " + strReject + Fix;
                            }
                        }

                    }
                }
            }
                dgv_sars1.DataSource = dt_Select; 
            dgv_sars1.Columns["Track No"].ReadOnly = true;
            dgv_sars1.AllowUserToResizeRows = true;
            dgv_sars1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_sars1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgv_sars1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
         
            dgv_sars1.Columns["Today Completed tasks"].DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            dgv_sars1.RowsDefaultCellStyle.BackColor = Color.Yellow;
            DataTable dt_Select2 = new DataTable();
            dt_Select2 = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strSasr2);
            dgv_sasr2.DataSource = dt_Select2;
            lblCount.Text = "总行数 ： " + (dgv_sars1.Rows.Count-1).ToString();
            label2.Text = "总行数 ： " + (dgv_sasr2.Rows.Count).ToString();
            FieldCount = dgv_sasr2.Rows.Count ;
            txt_editionSasr1.Text = this.txtPublishDate.Text.Replace("-", "").Substring(2) + " V_" + this.com_version.SelectedItem.ToString() + "." + this.txt_versionName.Text;
        }

        private void dgv_sars1_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            switch (dgv_sars1.Columns[e.ColumnIndex].Name)
            {
                case "Request Description":

                    e.Value = dgv_sars1.Rows[e.RowIndex].Cells[dgv_sars1.Columns[e.ColumnIndex].Name].Value.ToString().Trim();
                    break;
            } 
               
        }

        private void dgv_sars1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            {
                if (e.Value is string)
                    e.Value = e.Value.ToString().Trim();
            }
        }

        private void dgv_sars1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           // String strdag_sasr1 = dgv_sars1.Columns[dgv_sars1.CurrentCell.ColumnIndex].HeaderText;
           if(e.RowIndex>=0 && e.ColumnIndex>=0)
           {
               String str_dgv_sasr1_value = dgv_sars1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
              string strSelect = "";
              txt_RequestDescripiton.Text =  str_dgv_sasr1_value;
             // DataTable dt_Select = new DataTable();

       

             //  if (strdag_sasr1 == "Request Description")
             //{ 
          
             //   strSelect = "select RequestDescription from sasr1 Where RequestDescription=" + "'" + str_dgv_sasr1_value + "'";
             //   dt_Select = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strSelect);
             //   for(int intI = 0; intI < dt_Select.Rows.Count; intI++)
             //  {
             //   string strValue = dt_Select.Rows[intI][0].ToString();
             //   txt_RequestDescripiton.Text = strValue;

             //    }
              //}

              // else if (strdag_sasr1 == "Track No")
              // {
              //     strSelect = "select TrackNo from sasr1 Where TrackNo=" + "'" + str_dgv_sasr1_value + "'";
              //     dt_Select = AWF.Classes.SqlHelper.ExecuteDataTable(connString, strSelect);
              //     for (int intI = 0; intI < dt_Select.Rows.Count; intI++)
              //     {
              //         string strValue = dt_Select.Rows[intI][0].ToString();
              //         txt_RequestDescripiton.Text = strValue;

              //     }
              // }

           }

           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cmdUpdateGrid_Click(object sender, EventArgs e)
        {
            dgv_sars1.CurrentCell .Value = this.txt_RequestDescripiton.Text;
        }
   
    }
}
