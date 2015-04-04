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

namespace AWF
{
    public partial class Frm_Publishing : Office2007Form
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        public const int WM_CLOSE = 0x10;

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        delegate void updateUI(string msg);
        updateUI ShowTextDelegate;

        public string ver;
        private bool blnIsDeploy;
        public string strUpdateZipTime="";

        public Frm_Publishing()
        {
            InitializeComponent();
            ShowTextDelegate = new updateUI(ShowText);
            progressBar1.Location = new Point((panel1.Width / 2 - progressBar1.Width / 2), (panel1.Height / 2 - progressBar1.Height / 2));
        }

        private void Frm_Publishing_Load(object sender, EventArgs e)
        {
            rB_v802.Checked = true;
            rB_v802.Focus();
        }

        public string GetVer()
        {
            if (rB_v701.Checked)
            {
                ver = "7.0.1";
            }
            else if (rB_v702.Checked)
            {
                ver = "7.0.2";
            }
            else if (rB_v703.Checked)
            {
                ver = "7.0.3";
            }
            else if (rB_v704.Checked)
            {
                ver = "7.0.4";
            }
            else if (rB_v705.Checked)
            {
                ver = "7.0.5";
            }
            else if (rB_v706.Checked)
            {
                ver = "7.0.6";
            }
            else if (rB_v801.Checked)
            {
                ver = "8.0.1";
            }
            else if (rB_v802.Checked)
            {
                ver = "8.0.2";
            }
            else
            {
                MessageBox.Show("Pls select a Version!");
            }
            return ver;
        }

        public static void DeleteDir(string AimPath)
        {
            try
            {
                if (AimPath[AimPath.Length - 1] != Path.DirectorySeparatorChar)
                {
                    AimPath += Path.DirectorySeparatorChar;
                }
                string[] filelist = Directory.GetFileSystemEntries(AimPath);
                foreach (string file in filelist)
                {
                    if (Directory.Exists(file))
                    {
                        DeleteDir(AimPath + Path.GetFileName(file));
                    }
                    else
                    {
                        File.Delete(AimPath + Path.GetFileName(file));
                    }
                }
                Directory.Delete(AimPath, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void StartKiller()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            KillMessageBox();
            ((System.Windows.Forms.Timer)sender).Stop();
        }

        private void KillMessageBox()
        {
            IntPtr ptr = FindWindow(null, "Message");
            if (ptr != IntPtr.Zero)
            {
                PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
        }

        private void cmdCreatFolder_Click(object sender, EventArgs e)
        {
            ver = GetVer();
            string verName = "";
            if (txtVer.Text != "")
            {
                verName = "Version " + ver + "." + txtVer.Text.Trim().ToString();
                string NewFolder = Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + verName + ")";//121129 Update(Version 7.0.3.577)
                if (cbo_SpecialName.Text != "")
                {
                    string strSpecialName = "Special-" + cbo_SpecialName.Text.Replace(" ","");
                    NewFolder = Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + verName + ")(" + strSpecialName + ")";//121129 Update(Version 7.0.3.577)(Special)
                }
                NewFolder = Classes.Modfunction.baseDPath + @"SysFreight Update\EXCEL\" + NewFolder;
                if (!Directory.Exists(NewFolder))
                {
                    Directory.CreateDirectory(NewFolder);
                    MessageBox.Show("Creat Successful!");
                }
                else
                {
                    MessageBox.Show("Already exist!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Build No.");
            }
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            ver = GetVer();
            string verName = "";
            if (txtVer.Text != "")
            {
                verName = "Version " + ver + "." + txtVer.Text.Trim().ToString();
                string NewFolder = Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + verName + ")";//121129 Update(Version 7.0.3.577)
                if (cbo_SpecialName.Text != "")
                {
                    string strSpecialName = "Special-" + cbo_SpecialName.Text.Replace(" ", "");
                    NewFolder = Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + verName + ")(" + strSpecialName + ")";//121129 Update(Version 7.0.3.577)(Special)
                }
                NewFolder = Classes.Modfunction.baseDPath + @"SysFreight Update\EXCEL\" + NewFolder;
                if (!Directory.Exists(NewFolder))
                {
                    MessageBox.Show("Please Create Folder First.");
                }
                else
                {
                    System.Diagnostics.Process.Start("explorer.exe", NewFolder);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Build No.");
            }
        }
        
        private void cmdPublished2Zip_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = false;
                progressBar1.Value = 0;
                progressBar1.Maximum = 1000;
                progressBar1.Enabled = true;
                progressBar1.Visible = true;
                //
                ver = GetVer();
                string update_publish_path = AWF.Classes.Modfunction.baseDPath + @"PublishFolder\sysfreightupdate\publish";
                AWF.Classes.Modfunction.deleteFilesAndFolders(update_publish_path);
                //
                string filepath = Classes.Modfunction.baseDPath + @"PublishFolder\sysfreight";
                AWF.Classes.Modfunction.copyFilesAndFolders(update_publish_path, filepath);
                //
                if (txtVer.Text != "")
                {
                    string verName = "sysfreightupdate_" + ver.Replace(".", "_") + "_";
                    string strTime = Classes.Modfunction.datetime_today.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmm");
                    strUpdateZipTime = strTime;
                    if (cbo_SpecialName.Text != "")
                    {
                        string strSpecialName = "Special-" + cbo_SpecialName.Text.Replace(" ", "");
                        strTime += "(" + strSpecialName + ")";
                    }
                    string ogFileName = verName + txtVer.Text.Trim().ToString() + "_" + strTime;
                    string ZipName = Classes.Modfunction.baseDPath + @"PublishFolder\" + ogFileName + ".zip";
                    string SourcePatch = Classes.Modfunction.baseDPath + @"PublishFolder\sysfreightupdate";
                    string tempFolder_Master = ZipName.Substring(0, ZipName.Length - 4);
                    string tempFolder_Sub = tempFolder_Master + "\\" + ogFileName;
                    Directory.CreateDirectory(tempFolder_Master);
                    DirectoryInfo DInfo = new DirectoryInfo(SourcePatch);
                    DInfo.MoveTo(tempFolder_Sub);
                    Classes.ZipThread thPub2Zip = new Classes.ZipThread(tempFolder_Master, ZipName); //Thread thPub2Zip = new Thread(delegate() {  });
                    thPub2Zip.start();
                    while (thPub2Zip.threadState() == System.Threading.ThreadState.Running)
                    {
                        Application.DoEvents();
                        if (progressBar1.Value == progressBar1.Maximum)
                        {
                            progressBar1.Value = 0;
                        }
                        progressBar1.Value += 1;
                    }
                    thPub2Zip.abort();
                    progressBar1.Visible = false;
                    panel1.Enabled = true;
                    progressBar1.Enabled = false;
                    if (File.Exists(ZipName))
                    {
                        string xlsFolder = Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + "Version " + ver + "." + txtVer.Text.Trim().ToString() + ")";
                        if (cbo_SpecialName.Text != "")
                        {
                            string strSpecialName = "Special-" + cbo_SpecialName.Text.Replace(" ", "");
                            xlsFolder = Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + "Version " + ver + "." + txtVer.Text.Trim().ToString() + ")(" + strSpecialName + ")";
                        }
                        string xls = Classes.Modfunction.baseDPath + @"SysFreight Update\EXCEL\" + xlsFolder;
                        if (Directory.Exists(xls))
                        {
                            File.Move(ZipName, xls + @"\" + verName + txtVer.Text.Trim().ToString() + "_" + strTime + ".zip");
                        }
                        MessageBox.Show("Published to Zip Successful!");
                    }
                    else
                    {
                        MessageBox.Show("Published to Zip Faild!");
                        string path = @"D:\PublishFolder\sysfreightupdate\publish"; 
                        System.Diagnostics.Process.Start("explorer.exe", path); 
                    }
                    DirectoryInfo DInfoNew = new DirectoryInfo(tempFolder_Sub);
                    DInfoNew.MoveTo(SourcePatch);
                    if (Directory.Exists(tempFolder_Master))
                    {
                        Directory.Delete(tempFolder_Master);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Build No.");
                }
            }
            catch (Exception ex) { Log.Debug(ex.Message,ex); }
            finally { GC.Collect(); }
        }

        private void cmdSendTo_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                ver = GetVer();
                string verName = "";
                if (txtVer.Text != "")
                {
                    panel1.Enabled = false;
                    progressBar1.Value = 0;
                    progressBar1.Enabled = true;
                    progressBar1.Maximum = 10000;
                    progressBar1.Visible = true;

                    verName = "Version " + ver + "." + txtVer.Text.Trim().ToString();
                    //
                    string xls = Classes.Modfunction.baseDPath + @"SysFreight Update\EXCEL\" + Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + verName + ")";
                    string NewFolder = @"\\192.168.0.250\Net Application\" + Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + verName + ")";//121129 Update(Version 7.0.3.577)
                    if (cbo_SpecialName.Text != "")
                    {
                        string strSpecialName = "Special-" + cbo_SpecialName.Text.Replace(" ", "");
                        xls = Classes.Modfunction.baseDPath + @"SysFreight Update\EXCEL\" + Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + verName + ")(" + strSpecialName + ")";
                        NewFolder = @"\\192.168.0.250\Net Application\" + Classes.Modfunction.datetime_today.ToString("yyMMdd") + " Update(" + verName + ")(" + strSpecialName + ")";//121129 Update(Version 7.0.3.577)
                    }
                    if (!Directory.Exists(NewFolder))
                        Directory.CreateDirectory(NewFolder);
                    string[] files = Directory.GetFiles(xls);
                    foreach (string file in files)
                    {
                        string name = Path.GetFileName(file);
                        string dest = Path.Combine(NewFolder, name);
                        File.Copy(file, dest, true);
                        if (progressBar1.Value == progressBar1.Maximum)
                        {
                            progressBar1.Value = 0;
                        }
                        progressBar1.Value += 1;
                    }
                    progressBar1.Visible = false;
                    panel1.Enabled = true;
                    progressBar1.Enabled = false;
                    if (Directory.Exists(NewFolder))
                    {
                        Clipboard.Clear();
                        string specialText = cbo_SpecialName.Text.Trim();
                        if (specialText != "")
                        {
                            specialText = "(Special-" + specialText + ")";
                        }
                        Clipboard.SetDataObject(verName + specialText + " send to 250.");
                        DialogResult dgrt = MessageBox.Show("Send Successful! Would you like to backup source code?","Send To 250",MessageBoxButtons.YesNo);
                        if (dgrt == System.Windows.Forms.DialogResult.OK)
                        {
                            if (cbo_SpecialName.Text.Length > 0)
                            {
                                MessageBox.Show("The Special Version Should Be Backup Manually!");
                                cmdSelectFolder_Click(cmdSelectFolder, e);
                            }
                            else
                            {
                                cmdBackUp_Click(cmdBackUp, e);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Send Faild!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Build No.");
                }

            }
            catch (Exception ex) { }
            finally { GC.Collect(); }
        }

        private void cmdSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog df = new FolderBrowserDialog();
            df.SelectedPath = Classes.Modfunction.baseDPath;
            DialogResult result = df.ShowDialog();
             if (result == DialogResult.OK)   
             {
                 string folderPath = df.SelectedPath;
                 if (folderPath != "")
                 {
                     txtFolder.Text = folderPath;
                 }
            }
        }

        private void cmdBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                ver = GetVer();
                if (txtVer.Text != "")
                {
                    panel1.Enabled = false;
                    progressBar1.Value = 0;
                    progressBar1.Enabled = true;
                    progressBar1.Maximum = 10000;
                    progressBar1.Visible = true;

                    string SourcePatch = "";
                    string strTime = Classes.Modfunction.datetime_today.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmm");
                    if (strUpdateZipTime != "")
                    {
                        strTime = strUpdateZipTime;
                    }
                    if (cbo_SpecialName.Text != "")
                    {
                        string strSpecialName = "Special-" + cbo_SpecialName.Text.Replace(" ", "");
                        strTime += "(" + strSpecialName + ")";
                    }
                    if (txtFolder.Text != "")
                    {
                        SourcePatch = txtFolder.Text;
                        string NewP = Classes.Modfunction.baseDPath + @"New SysFreight Source_" + ver.Replace(".", "_") + "_" + txtVer.Text.Trim().ToString() + "_" + strTime;
                        if (Directory.Exists(NewP))
                        {
                            DeleteDir(NewP);
                        }
                        DirectoryInfo DInfo = new DirectoryInfo(SourcePatch);
                        try
                        {
                            DInfo.MoveTo(NewP);
                            SourcePatch = NewP;
                        }
                        catch (Exception ex)
                        {
                            SourcePatch = "";
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                    else
                    {
                        SourcePatch = Classes.Modfunction.baseDPath + "New SysFreight Source " + ver.Replace(".", "");
                    }
                    string ZipName = Classes.Modfunction.baseDPath + "New SysFreight Source_" + ver.Replace(".", "_") + "_" + txtVer.Text.Trim().ToString() + "_" + strTime + ".zip";
                    Classes.ZipThread thZip = new Classes.ZipThread(SourcePatch, ZipName);
                    thZip.start();
                    while (thZip.threadState() == System.Threading.ThreadState.Running)
                    {
                        Application.DoEvents();
                        if (progressBar1.Value == progressBar1.Maximum)
                        {
                            progressBar1.Value = 0;
                        }
                        progressBar1.Value += 1;
                    }
                    thZip.abort();
                    progressBar1.Visible = false;
                    panel1.Enabled = true;
                    progressBar1.Enabled = false;
                    //
                    if (File.Exists(ZipName))
                    {
                        StartKiller();
                        MessageBox.Show("BackUp Successful!", "Message");
                        Environment.Exit(0);
                    }
                    else
                    {
                        MessageBox.Show("BackUp Faild!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Build No. and make sure of right directory of SourceCode.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { GC.Collect(); }
        }

        private void version_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton tb = (RadioButton)sender;
            if (tb.Checked)
            {
                ver = GetVer();
                string NewP = Classes.Modfunction.baseDPath + "New SysFreight Source " + ver.Replace(".", "") + @"\SysFreight\SysFreightMain\SysFreight.vbproj.user";
                if (AWF.Classes.Modfunction.pingIPAddress("192.168.0.236"))
                {
                    if (File.Exists(NewP))
                    {
                        StreamReader objReader = new StreamReader(NewP);
                        string sLine = "";
                        ArrayList LineList = new ArrayList();
                        while (sLine != null)
                        {
                            sLine = objReader.ReadLine();
                            if (sLine != null && !sLine.Equals(""))
                                LineList.Add(sLine);
                        }
                        objReader.Close();
                        string CurrentVersion = LineList[11].ToString();
                        CurrentVersion = CurrentVersion.Replace("<ApplicationRevision>", "");
                        CurrentVersion = CurrentVersion.Replace("</ApplicationRevision>", "");
                        CurrentVersion = CurrentVersion.Replace(" ", "");
                        CurrentVersion = CurrentVersion.Trim().ToString();
                        txtVer.Text = CurrentVersion;
                    }
                    else
                    {
                        MessageBox.Show("This Version's Source Code Does Not Exist!");
                    }
                }                
            }
        }

        private void btn_rebuild_Click(object sender, EventArgs e)
        {
            try
            {
                blnIsDeploy = false;
                panel1.Enabled = false;
                textBox1.Top = txtVer.Top;
                textBox1.Left = cmdSelectFolder.Left;
                textBox1.Enabled = true;
                textBox1.Visible = true;
                Thread rebuild = new Thread(new ThreadStart(RebuildAll));
                rebuild.Start();
                while (rebuild.ThreadState == System.Threading.ThreadState.Running)
                {
                    Application.DoEvents();
                }
                rebuild.Abort();
                int len = textBox1.Text.Length;
                if (textBox1.Text.Length > 0)
                {
                    string output = textBox1.Text.Substring(len - 50);
                    string[] str = output.Split(',');
                    string[] str1 = str[0].Split(':');
                    int success = int.Parse(str1[1].Substring(0, 3));
                    int failed = int.Parse(str[1].Substring(0, 3));
                    int jump = int.Parse(str[2].Substring(0, 3));
                    if (success > 0 && failed == 0 && jump == 0)
                    {
                        MessageBox.Show("Rebuild Success");
                    }
                    else
                    {
                        MessageBox.Show("Rebuild Failed");
                    }
                }
                textBox1.Visible = false;
                panel1.Enabled = true;
            }
            catch (Exception ex) { Log.Debug(ex.Message, ex); }
            finally
            {
                textBox1.Visible = false;
                panel1.Enabled = true;
                blnIsDeploy = false;
                GC.Collect();
            }
        }

        private void RebuildAll()
        {
            try
            {
                string deploy;
                if (blnIsDeploy) deploy = " deploy"; else deploy = "";
                System.IO.StreamReader sr;
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + @"\build.bat";
                if (Classes.Modfunction.cpu_AddressWidth == "64")
                {
                    p.StartInfo.Arguments = "(x86)" + deploy;
                }
                else
                {
                    p.StartInfo.Arguments = "" + deploy;
                }
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                sr = p.StandardOutput;
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine() + "\r\n";
                    this.BeginInvoke(ShowTextDelegate, str);
                }
                sr.Close();
                p.WaitForExit();
                p.Close();
            }
            catch (Exception ex) { Log.Debug(ex.Message, ex); }
            finally { GC.Collect(); }
        }

        private void ShowText(string msg)
        {
            textBox1.Text += msg;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }

        //private void btn_publish_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        blnIsDeploy = true;
        //        panel1.Enabled = false;
        //        textBox1.Top = txtVer.Top;
        //        textBox1.Left = cmdSelectFolder.Left;
        //        textBox1.Enabled = true;
        //        textBox1.Visible = true;
        //        Thread publish = new Thread(new ThreadStart(PublishAll));
        //        publish.Start();
        //        while (publish.ThreadState == System.Threading.ThreadState.Running)
        //        {
        //            Application.DoEvents();
        //        }
        //        publish.Abort();
        //        textBox1.Visible = false;
        //        panel1.Enabled = true;
        //    }
        //    catch (Exception ex) { Log.Debug(ex.Message, ex); }
        //    finally
        //    {
        //        textBox1.Visible = false;
        //        panel1.Enabled = true;
        //        blnIsDeploy = false;
        //        GC.Collect();
        //    }
        //}

        //private void PublishAll()
        //{
        //    try
        //    {
        //        string deploy;
        //        if (blnIsDeploy) deploy = " deploy"; else deploy = "";
        //        System.IO.StreamReader sr;
        //        Process p = new Process();
        //        p.StartInfo.FileName = Application.StartupPath + @"C:\Program Files\Microsoft Visual Studio 8\VC\vcvarsall.bat";
        //        if (Classes.Modfunction.cpu_AddressWidth == "64")
        //        {
        //            p.StartInfo.Arguments = "(x86)" + deploy;
        //        }
        //        else
        //        {
        //            p.StartInfo.Arguments = "" + deploy;
        //        }
        //        p.StartInfo.UseShellExecute = false;
        //        p.StartInfo.RedirectStandardInput = true;
        //        p.StartInfo.RedirectStandardOutput = true;
        //        p.StartInfo.RedirectStandardError = true;
        //        p.StartInfo.CreateNoWindow = true;
        //        p.Start();
        //        sr = p.StandardOutput;
        //        while (!sr.EndOfStream)
        //        {
        //            string str = sr.ReadLine() + "\r\n";
        //            this.BeginInvoke(ShowTextDelegate, str);
        //        }
        //        sr.Close();
        //        p.WaitForExit();
        //        p.Close();
        //    }
        //    catch (Exception ex) { Log.Debug(ex.Message, ex); }
        //    finally { GC.Collect(); }
        //}

        //private void btn_DownloadRequestXls_Click(object sender, EventArgs e)
        //{
        //    string dtime = Classes.Modfunction.datetime_today.ToString("yyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        //    string url = "";
        //    string requestNos = txt_TrackNo.Text.Trim().ToString().Replace(";", ",").Replace(" ", "");
        //    if (requestNos.Length < 1 || cbo_Programmer.Text.ToString().Length < 1)
        //    {
        //        MessageBox.Show("Track No and Dev by Must be entered!");
        //        return;
        //    }
        //    else
        //    {
        //        System.Net.ServicePointManager.DefaultConnectionLimit = 120;
        //        string[] requsetNo = requestNos.Split(',');
        //        int[] reqNo = new int[requsetNo.Length];
        //        for (int i = 0; i < requsetNo.Length; i++)
        //        {
        //            reqNo[i] = int.Parse(requsetNo[i]);
        //        }
        //        //ArrayList list = new ArrayList(reqNo);
        //        //Classes.SortingAlgorithm sort = new Classes.SortingAlgorithm();
        //        //sort.BubbleSorter(list);
        //        foreach (string reNo in requsetNo)
        //        {
        //            int baseID = 9000;
        //            int baseRequestNo = 5508;
        //            int MNo = int.Parse(reNo);
        //            int MaxRequestID = (MNo - baseRequestNo) + baseID + 10;
        //            int MinRequestID = (MNo - baseRequestNo) + baseID - 5;
        //            string author = cbo_Programmer.SelectedItem.ToString();
        //            for (int i = MinRequestID; i <= MaxRequestID; i++)
        //            {
        //                string fileName = ".NET" + reNo.ToString() + "-" + dtime + "-" + author + ".xls";
        //                url = "http://218.6.71.82:8081/RequestForm/Attach/Request/" + i.ToString(System.Globalization.NumberFormatInfo.InvariantInfo) + "/";
        //                string filePath = url + fileName;
        //                if (IsWebResourceAvailable(filePath))
        //                {
        //                    ver = GetVer();
        //                    string verName = "";
        //                    if (txtVer.Text != "")
        //                    {
        //                        verName = "Version " + ver + "." + txtVer.Text.Trim().ToString();
        //                        string NewFolder = Classes.Modfunction.datetime_today.ToString("yyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo) + " Update(" + verName + ")";//121129 Update(Version 7.0.3.577)
        //                        if (cbo_SpecialName.Text != "")
        //                        {
        //                            string strSpecialName = "Special-" + cbo_SpecialName.Text.Replace(" ", "");
        //                            NewFolder = Classes.Modfunction.datetime_today.ToString("yyMMdd", System.Globalization.DateTimeFormatInfo.InvariantInfo) + " Update(" + verName + ")(" + strSpecialName + ")";//121129 Update(Version 7.0.3.577)(Special)
        //                        }
        //                        NewFolder = Classes.Modfunction.baseDPath + @"SysFreight Update\EXCEL\" + NewFolder;
        //                        if (!Directory.Exists(NewFolder))
        //                        {
        //                            MessageBox.Show("Please Create Folder First.");
        //                        }
        //                        else
        //                        {
        //                            if (!File.Exists(NewFolder + @"\" + fileName))
        //                            {
        //                                DownloadFile(filePath, NewFolder + @"\" + fileName);
        //                                StartKiller();
        //                                MessageBox.Show("Download daily requestform scucess!", "Message");
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Please Enter Build No.");
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //static bool IsWebResourceAvailable(string webResourceAddress)
        //{
        //    GC.Collect();
        //    bool isOk = false;
        //    HttpWebRequest req = null;
        //    HttpWebResponse res = null;
        //    try
        //    {
        //        req = (HttpWebRequest)WebRequest.CreateDefault(new Uri(webResourceAddress));
        //        req.KeepAlive = false;
        //        req.Method = "HEAD";
        //        req.Timeout = 1000;
        //        res = (HttpWebResponse)req.GetResponse();
        //        if (res.StatusCode == HttpStatusCode.OK)
        //        {
        //            isOk = true;
        //        }
        //    }
        //    catch (WebException wex)
        //    {
        //        System.Diagnostics.Trace.Write(wex.Message);
        //        isOk = false;
        //    }
        //    finally
        //    {
        //        if (res != null)
        //        {
        //            res.Close();
        //            res = null;
        //        }
        //        req.Abort();
        //        req = null;
        //        GC.Collect();
        //    }
        //    return isOk;
        //}

        //public void DownloadFile(string URL, string filename)
        //{
        //    GC.Collect();
        //    HttpWebRequest Myrq = null;
        //    HttpWebResponse myrp = null;
        //    try
        //    {
        //        Myrq = (HttpWebRequest)HttpWebRequest.Create(URL);
        //        Myrq.KeepAlive = false;
        //        myrp = (HttpWebResponse)Myrq.GetResponse();
        //        long totalBytes = myrp.ContentLength;
        //        System.IO.Stream st = myrp.GetResponseStream();
        //        System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
        //        long totalDownloadedByte = 0;
        //        byte[] by = new byte[1024];
        //        int osize = st.Read(by, 0, (int)by.Length);
        //        while (osize > 0)
        //        {
        //            totalDownloadedByte = osize + totalDownloadedByte;
        //            System.Windows.Forms.Application.DoEvents();
        //            so.Write(by, 0, osize);
        //            osize = st.Read(by, 0, (int)by.Length);
        //        }
        //        so.Close();
        //        so.Dispose();
        //        st.Close();
        //        st.Dispose();
        //    }
        //    catch (System.Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (myrp != null)
        //        {
        //            myrp.Close();
        //            myrp = null;
        //        }
        //        Myrq.Abort();
        //        Myrq = null;
        //        GC.Collect();
        //    }
        //}

        //private void btn_UploadToCloud_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        panel1.Enabled = false;
        //        progressBar1.Value = 0;
        //        progressBar1.Maximum = 100;
        //        progressBar1.Style = ProgressBarStyle.Blocks;
        //        progressBar1.Step = 1;
        //        progressBar1.Enabled = true;
        //        progressBar1.Visible = true;

        //        OpenFileDialog df = new OpenFileDialog();
        //        df.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //        df.Filter = "ZIP files (*.zip)|*.zip|All files (*.*)|*.*";
        //        df.FilterIndex = 1;
        //        df.RestoreDirectory = true;
        //        DialogResult result = df.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            string FileName = df.SafeFileName;
        //            string fname = df.FileName;
        //            if (FileName != "")
        //            {
        //                string bucket = "sysmagic";
        //                string keyName = "SysFreight/dotNet/" + ver + "/" + FileName;
        //                byte[] bytes = Encoding.UTF8.GetBytes(keyName);
        //                string key = Encoding.UTF8.GetString(bytes);
        //                Qiniu.RS.RSClient client = new Qiniu.RS.RSClient();
        //                Qiniu.RS.Entry entry = client.Stat(new Qiniu.RS.EntryPath(bucket, key));
        //                if (entry.OK)
        //                {
        //                    Qiniu.RPC.CallRet ret = client.Delete(new Qiniu.RS.EntryPath(bucket, key));
        //                } 
        //                ResumablePutFile(bucket, key, fname);
        //                string baseUrl = Qiniu.RS.GetPolicy.MakeBaseUrl("sysmagic.qiniudn.com", txt_OSSkey.Text);
        //                txt_OSSDowloadUrl.Text = baseUrl;
        //                Clipboard.Clear();
        //                Clipboard.SetDataObject(baseUrl);
        //            }
        //        }
        //        progressBar1.Value = 0; 
        //        progressBar1.Visible = false;
        //        panel1.Enabled = true;
        //        progressBar1.Enabled = false;
        //    }
        //    catch (Exception ex) { Log.Debug(ex.Message, ex); }
        //    finally { panel1.Enabled = true; progressBar1.Enabled = false; GC.Collect(); }
        //}

        //public void ResumablePutFile(string bucket, string key, string fname)
        //{
        //    Qiniu.RS.PutPolicy policy = new Qiniu.RS.PutPolicy(bucket, 3600);
        //    string upToken = policy.Token();
        //    Qiniu.IO.Resumable.Settings setting = new Qiniu.IO.Resumable.Settings();
        //    Qiniu.IO.Resumable.ResumablePutExtra extra = new Qiniu.IO.Resumable.ResumablePutExtra();
        //    Qiniu.IO.Resumable.ResumablePut client = new Qiniu.IO.Resumable.ResumablePut(setting, extra);
        //    client.Progress += new Action<float>((p) =>
        //    {
        //        progressBar1.Value = (Int32)(p * 100);
        //    }
        //    );
        //    client.PutFinished += new EventHandler<Qiniu.RPC.CallRet>((o, ret) =>
        //    {
        //        if (ret.OK)
        //        {
        //            MessageBox.Show("Upload success!");
        //            txt_OSSkey.Text = key;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Upload failed:{0}", ret.Response);
        //        }
        //    });
        //    client.PutFile(upToken, fname, key);//Guid.NewGuid().ToString()            
        //}

        //private void btn_GetDownloadUrl_Click(object sender, EventArgs e)
        //{
        //    string baseUrl = Qiniu.RS.GetPolicy.MakeBaseUrl("sysmagic.qiniudn.com", txt_OSSkey.Text);
        //    string private_url = Qiniu.RS.GetPolicy.MakeRequest(baseUrl);
        //    txt_OSSDowloadUrl.Text = private_url;
        //    Clipboard.Clear();
        //    Clipboard.SetDataObject(private_url);
        //}
    }
}
