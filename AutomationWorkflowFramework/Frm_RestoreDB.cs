using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Xml;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace DeveloperTools
{
    public partial class Frm_RestoreDB : Form
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Classes.SMOHelper smoHelper = null;
        public string connString = @"Server=192.168.0.230;DataBase=master;UID=sa;PWD=p@ssw0rd$;";
        public string strXml = @"\\192.168.0.230\WebService\Web.config";
        public string DBPath = @"N:\Customer_Database\";
        public string DESKey = "F322186F";
        public string DESIV = "F322186F";
        public bool RestoreStatus = false;
        public string fileName = "";
        public string dataBaseName = "";
       
        public Frm_RestoreDB()
        {
            InitializeComponent();
        }

        private string DESEncrypt(string strPlain, string strDESKey, string strDESIV)
        {
            string DESEncrypt = "";
            try
            {
                byte[] bytesDESKey = ASCIIEncoding.ASCII.GetBytes(strDESKey);
                byte[] bytesDESIV = ASCIIEncoding.ASCII.GetBytes(strDESIV);
                byte[] inputByteArray = Encoding.Default.GetBytes(strPlain);
                DESCryptoServiceProvider desEncrypt = new DESCryptoServiceProvider();
                desEncrypt.Key = bytesDESKey;
                desEncrypt.IV = bytesDESIV;
                MemoryStream msEncrypt = new MemoryStream();
                CryptoStream csEncrypt = new CryptoStream(msEncrypt, desEncrypt.CreateEncryptor(), CryptoStreamMode.Write);
                csEncrypt.Write(inputByteArray, 0, inputByteArray.Length);
                csEncrypt.FlushFinalBlock();
                StringBuilder str = new StringBuilder();
                foreach (byte b in msEncrypt.ToArray())
                {
                    str.AppendFormat("{0:X2}", b);
                }
                csEncrypt.Close();
                msEncrypt.Close();
                DESEncrypt = str.ToString();
            }
            catch
            {
            }
            return DESEncrypt;
        }
       
        private bool SetWebConfig(string dataBaseName, string strXml)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(strXml);
                Boolean IfExist = false;
                foreach (XmlNode node in xmlDoc["configuration"]["appSettings"].ChildNodes)
                {
                    if (node.Name == "add")
                    {
                        if (node.Attributes["key"].Value.ToString() == dataBaseName)
                        {
                            IfExist = true;
                            break;
                        }
                    }
                }
                if (!IfExist)
                {
                    string pwd = DESEncrypt(txtPassword.Text.Trim().ToString(), DESKey, DESIV).ToString();
                    XmlNode node = xmlDoc["configuration"]["appSettings"].ChildNodes[xmlDoc["configuration"]["appSettings"].ChildNodes.Count - 1].Clone();
                    node.Attributes["key"].Value = dataBaseName;
                    node.Attributes["value"].Value = txtSQLServerName.Text.Trim().ToString() + "," + dataBaseName + "," + txtUserName.Text.Trim().ToString() + "," + pwd + ",0,ConnectionString1";
                    xmlDoc["configuration"]["appSettings"].AppendChild(node);
                }
                IfExist = false;
                foreach (XmlNode node in xmlDoc["configuration"]["appSettings"].ChildNodes)
                {
                    if (node.Name == "add")
                    {
                        if (node.Attributes["key"].Value.ToString() == "DataBase")
                        {
                            string DatabaseNames = node.Attributes["value"].Value.ToString();
                            string[] DatabaseName = DatabaseNames.Split(',');
                            foreach (string strDatabaseName in DatabaseName)
                            {
                                if (strDatabaseName == dataBaseName)
                                {
                                    IfExist = true;
                                    break;
                                }
                            }
                            if (!IfExist)
                            {
                                node.Attributes["value"].Value = DatabaseNames + "," + dataBaseName;
                                break;
                            }
                        }
                    }
                }
                xmlDoc.Save(strXml);
            }
            catch
            {
            }
            return true;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog df = new OpenFileDialog();
            df.InitialDirectory = Classes.SaveSetting.strRestoreDBPath;//@"\\192.168.0.230\PublicShare\Database";
            df.Filter = "bak files (*.bak)|*.bak|All files (*.*)|*.*";
            df.FilterIndex = 1;
            df.RestoreDirectory = true;
            DialogResult result = df.ShowDialog();
            if (result == DialogResult.OK)
            {
                string FileName = df.FileName;
                if (FileName != "")
                {
                    txtFileName.Text = FileName;
                    string strSafeName = df.SafeFileName;
                    string[] str = strSafeName.Split(' ');
                    string[] str1 = str[0].Trim().Split('_');
                    txtDatabaseName.Text = str1[0].Trim();
                    if (cboDatabase.Items.Contains(txtDatabaseName.Text))
                    {
                        cboDatabase.SelectedItem = txtDatabaseName.Text;
                        lbl_IfExist.Text = "Already exist ! Continue will do replace.";
                        lbl_IfExist.ForeColor = Color.Red;
                    }
                    else 
                    {
                        lbl_IfExist.Text = "This is a new database !";
                        lbl_IfExist.ForeColor = Color.Black;
                    }
                    lbl_IfExist.Visible = true;
                }
            }
        }

        private void btnDBPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog df = new FolderBrowserDialog();
            DialogResult result = df.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderPath = df.SelectedPath;
                if (folderPath != "")
                {
                    txtDBPath.Text = folderPath;
                }
            }
        }

        private void Frm_RestoreDB_Load(object sender, EventArgs e)
        {
            grpDatabase.Enabled = false;
            grpActions.Enabled = false;
            chkUseWindowsAuthentication.Checked = false;
            txtSQLServerName.Focus();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            grpDatabase.Enabled = false;
            try
            {
                if (txtSQLServerName.Text.Length == 0)
                    return;
                if (!chkUseWindowsAuthentication.Checked && txtUserName.Text.Length == 0 && txtPassword.Text.Length == 0)
                    return;
                smoHelper = new Classes.SMOHelper(txtSQLServerName.Text.Trim(), txtUserName.Text.Trim(), txtPassword.Text.Trim(), chkUseWindowsAuthentication.Checked);
                smoHelper.Connect();
                if (smoHelper.Server != null)
                {
                    smoHelper.BackupPercentCompleteChanging += Backup_PercentCompleteChanging;
                    smoHelper.BackupComplete += Backup_Complete;
                    smoHelper.RestorePercentCompleteChanging += Restore_PercentCompleteChanging;
                    smoHelper.RestoreComplete += Restore_Complete;
                    cboDatabase.DataSource = smoHelper.GetDatabaseNameList();
                    cboDatabase.Focus();
                    grpDatabase.Enabled = true;
                    grpActions.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Connect MSSQL Server Failed!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Connect MSSQL Server Failed! See errors in *.Log"); Log.Debug(ex.Message,ex); }
            finally { GC.Collect(); }
        }

        private void RefreshCboDatabase(string databaseName)
        {
            try
            {
                smoHelper = new Classes.SMOHelper(txtSQLServerName.Text.Trim(), txtUserName.Text.Trim(), txtPassword.Text.Trim(), chkUseWindowsAuthentication.Checked);
                smoHelper.Connect();
                if (smoHelper.Server != null)
                {
                    smoHelper.BackupPercentCompleteChanging += Backup_PercentCompleteChanging;
                    smoHelper.BackupComplete += Backup_Complete;
                    smoHelper.RestorePercentCompleteChanging += Restore_PercentCompleteChanging;
                    smoHelper.RestoreComplete += Restore_Complete;
                    cboDatabase.DataSource = smoHelper.GetDatabaseNameList();
                    cboDatabase.SelectedItem = databaseName;
                }
                else
                {
                    MessageBox.Show("Refresh MSSQL Server Failed!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Refresh MSSQL Server Failed! See errors in *.Log"); Log.Debug(ex.Message, ex); }
            finally { GC.Collect(); }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            grpActions.Enabled = false;
            try
            {
                if (cboDatabase.SelectedIndex >= 0)
                {
                    Database db = smoHelper.Server.Databases[cboDatabase.SelectedValue.ToString()];
                    if (db == null)
                        return;
                    grpActions.Enabled = true; 
                }
            }
            catch (Exception ex) { MessageBox.Show("Refresh MSSQL Server Failed! See errors in *.Log"); Log.Debug(ex.Message, ex); }
            finally { GC.Collect(); }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileName.Text.Length == 0)
                    return;
                panel1.Enabled = false;
                pbDBAction.Enabled = true;
                pbDBAction.Maximum = 100;
                pbDBAction.Style = ProgressBarStyle.Blocks;
                pbDBAction.Value = 0;
                pbDBAction.Step = 1;
                smoHelper.RestoreDB(txtFileName.Text.Trim(), txtDatabaseName.Text.Trim(), txtDBPath.Text.Trim());
            }
            catch (Exception ex) { Log.Debug(ex.Message, ex); }
            finally { panel1.Enabled = true; GC.Collect(); }
        }

        private void chkUseWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = !chkUseWindowsAuthentication.Checked;
            txtPassword.Enabled = !chkUseWindowsAuthentication.Checked;
        }

        public void Backup_Complete(object sender, ServerMessageEventArgs e)
        {
            pbDBAction.Value = pbDBAction.Maximum;
            string databaseName = ((Backup)sender).Database;
            string msg = string.Format("Database {0} has been backed up successfully!", databaseName);
            MessageBox.Show(msg);
            pbDBAction.Value = 0;
        }
        public void Backup_PercentCompleteChanging(object sender, PercentCompleteEventArgs e)
        {
            pbDBAction.PerformStep();
        }
        public void Restore_Complete(object sender, ServerMessageEventArgs e)
        {
            pbDBAction.Value = pbDBAction.Maximum;
            string databaseName = ((Restore)sender).Database;
            string msg = string.Format("Database {0} has been restored successfully!", databaseName);
            strXml = strWebService.Text.Trim().ToString();
            SetWebConfig(databaseName, strXml);
            MessageBox.Show(msg);
            pbDBAction.Value = 0;
            RefreshCboDatabase(databaseName);
            lbl_IfExist.Visible = false;
            txtDatabaseName.Text = "";
            txtFileName.Text = "";
        }
        public void Restore_PercentCompleteChanging(object sender, PercentCompleteEventArgs e)
        {
            System.Windows.Forms.Application.DoEvents();
            pbDBAction.PerformStep();
        }

        private void btnClearConfig_Click(object sender, EventArgs e)
        {
            try
            {
                btnClearConfig.Enabled = false;
                strXml = strWebService.Text.ToString();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(strXml);
                XmlElement root = xmlDoc["configuration"]["appSettings"];
                XmlNodeList xnl = xmlDoc["configuration"]["appSettings"].ChildNodes;
                int ChildNodesCount = xnl.Count;
                for (int i = ChildNodesCount - 1; i >= 0; i--)
                {
                    XmlNode node = xnl[i];
                    if (node.Name == "add")
                    {
                        if (node.Attributes["key"].Value.ToString() != "AuthenticationTicket.Timeout" && node.Attributes["key"].Value.ToString() != "ConnectionString1" && node.Attributes["key"].Value.ToString() != "ConnectionString2" && node.Attributes["key"].Value.ToString() != "ConnectionString3" && node.Attributes["key"].Value.ToString() != "DataBase")
                        {
                            xmlDoc["configuration"]["appSettings"].RemoveChild(node);
                        }
                        else if (node.Attributes["key"].Value.ToString() == "DataBase")
                        {
                            string DatabaseNames = "";
                            for (int j = 0; j <= cboDatabase.Items.Count - 1; j++)
                            {
                                if (cboDatabase.Items[j].ToString().ToUpper() != "CCFREIGHT" && cboDatabase.Items[j].ToString().ToUpper() != "CC8FREIGHT")
                                {
                                    DatabaseNames = DatabaseNames + cboDatabase.Items[j].ToString() + ",";
                                }
                            }
                            DatabaseNames = "CC8Freight,CCFreight," + DatabaseNames;
                            if (DatabaseNames.LastIndexOf(',') == DatabaseNames.Length - 1)
                            {
                                DatabaseNames = DatabaseNames.Substring(0, DatabaseNames.Length - 1);
                            }
                            node.Attributes["value"].Value = DatabaseNames;
                        }
                    }
                }
                for (int i = 0; i <= cboDatabase.Items.Count - 1; i++)
                {
                    string pwd = DESEncrypt(txtPassword.Text.Trim().ToString(), DESKey, DESIV).ToString();
                    XmlElement newXE = xmlDoc.CreateElement("add");
                    newXE.SetAttribute("key", cboDatabase.Items[i].ToString());
                    newXE.SetAttribute("value", txtSQLServerName.Text.Trim().ToString() + "," + cboDatabase.Items[i].ToString() + "," + txtUserName.Text.Trim().ToString() + "," + pwd + ",0,ConnectionString1");
                    root.AppendChild(newXE);
                }
                xmlDoc.Save(strXml);
                MessageBox.Show("Reset WebService Config Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnClearConfig.Enabled = true;
            }
        }
    }
}
