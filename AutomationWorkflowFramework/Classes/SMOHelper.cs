﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace DeveloperTools.Classes
{
    public delegate void PercentCompleteChanging(object sender, PercentCompleteEventArgs e);
    public delegate void PercentCompleteDone(object sender, ServerMessageEventArgs e);

    public class SMOHelper
    {
        #region Events

        public event PercentCompleteDone BackupComplete;
        public event PercentCompleteDone RestoreComplete;
        public event PercentCompleteChanging BackupPercentCompleteChanging;
        public event PercentCompleteChanging RestorePercentCompleteChanging;

        #endregion

        #region Fields

        private string serverName = string.Empty;
        private string instance = string.Empty;
        private string version = string.Empty;
        private bool isLocal;
        private Server server = null;
        private string userName = string.Empty;
        private string password = string.Empty;
        private bool useWindowsAuthentication = true;
        private string testFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        #endregion

        #region Properties

        public bool IsLocal
        {
            get { return isLocal; }
            set { isLocal = value; }
        }
        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public string Instance
        {
            get { return instance; }
            set { instance = value; }
        }
        public string ServerName
        {
            get { return serverName; }
            set { serverName = value; }
        }
        public string ServerAndInstanceName
        {
            get
            {
                if (this.instance.Length > 0)
                    return this.serverName + @"\" + this.instance;
                else
                    return this.serverName;
            }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public bool UseWindowsAuthentication
        {
            get { return useWindowsAuthentication; }
            set { useWindowsAuthentication = value; }
        }

        public Server Server
        {
            get { return server; }
        }

        #endregion

        #region Constructors

        public SMOHelper()
        {
            this.server = new Server();
        }

        public SMOHelper(string serverAndInstanceName, string userName, string password, bool useWindowsAuthentication)
        {
            this.server = new Server();
            if (serverAndInstanceName.Contains(@"\"))
            {
                int slashPos = serverAndInstanceName.IndexOf('\\');
                this.serverName = serverAndInstanceName.Substring(0, slashPos);
                this.instance = serverAndInstanceName.Substring(slashPos + 1);
            }
            else
            {
                serverName = serverAndInstanceName;
                instance = string.Empty;
            }
            this.userName = userName;
            this.password = password;
            this.useWindowsAuthentication = useWindowsAuthentication;
        }

        #endregion

        #region Methods

        public void Connect()
        {
            server.ConnectionContext.ServerInstance = ServerAndInstanceName;
            if (this.useWindowsAuthentication)
            {
                server.ConnectionContext.LoginSecure = useWindowsAuthentication;
            }
            else
            {
                server.ConnectionContext.LoginSecure = this.useWindowsAuthentication;
                server.ConnectionContext.Login = this.userName;
                server.ConnectionContext.Password = this.password;
            }
            server.ConnectionContext.Connect();
        }

        #region Get Lists

        //public void foo()
        //{
        //    //  Get a list of SQL servers available on the network
        //    DataTable dtServers = SmoApplication.EnumAvailableSqlServers(false);
        //    foreach (DataRow row in dtServers.Rows)
        //    {
        //        string sqlServerName = row["Server"].ToString();
        //        if (row["Instance"] != null && row["Instance"].ToString().Length > 0)
        //            sqlServerName += @"\" + row["Instance"].ToString();
        //    }
        //}

        public List<string> GetDatabaseNameList()
        {
            List<string> dbList = new List<string>();
            foreach (Database db in server.Databases)
                dbList.Add(db.Name);
            return dbList;
        }

        public List<string> GetTableNameList(Database db)
        {
            List<string> tableList = new List<string>();
            foreach (Table table in db.Tables)
                tableList.Add(table.Name);
            return tableList;
        }

        public List<string> GetStoredProcedureNameList(Database db)
        {
            List<string> storedProcedureNameList = new List<string>();
            foreach (StoredProcedure storedProcedure in db.StoredProcedures)
                storedProcedureNameList.Add(storedProcedure.Name);
            return storedProcedureNameList;
        }

        public List<string> GetUserNameList(Database db)
        {
            List<string> userNameList = new List<string>();
            foreach (User user in db.Users)
                userNameList.Add(user.Name);
            return userNameList;
        }

        public List<string> GetViewNameList(Database db)
        {
            List<string> viewNameList = new List<string>();
            foreach (View view in db.Views)
                viewNameList.Add(view.Name);
            return viewNameList;
        }

        public List<string> GetColumnNameList(Table table)
        {
            List<string> columnList = new List<string>();
            foreach (Column column in table.Columns)
                columnList.Add(column.Name);
            return columnList;
        }

        #endregion

        public void BackupDatabase(string databaseName)
        {
            Console.WriteLine("*** Backing up ***");
            Backup backup = new Backup();
            backup.Action = BackupActionType.Database;
            backup.Database = databaseName;
            backup.Devices.Clear();
            backup.Incremental = false;
            backup.Initialize = true;
            backup.LogTruncation = BackupTruncateLogType.Truncate;
            string fileName = string.Format("{0}\\{1}.bak", testFolder, databaseName);
            BackupDeviceItem backupItemDevice = new BackupDeviceItem(fileName, DeviceType.File);
            backup.Devices.Add(backupItemDevice);
            backup.PercentCompleteNotification = 10;
            backup.PercentComplete += new PercentCompleteEventHandler(backup_PercentComplete);
            backup.Complete += new ServerMessageEventHandler(backup_Complete);
            backup.SqlBackup(server);
        }

        public void RestoreDB(string fileName, string databaseName, string DBPath)
        {
            Console.WriteLine("*** Restoring***");
            // Don't drop it! /// If you do, anyone with the default database of that DB will croak!
            //server.Databases[databaseName].Drop(); 
            Restore restore = new Restore();
            restore.Devices.Clear();
            //string fileName = string.Format("{0}\\{1}.bak", testFolder, databaseName);
            restore.Devices.Add(new BackupDeviceItem(fileName, DeviceType.File));

            // Just give it a new name
            //string destinationDatabaseName = string.Format("{0}_newly_restored", databaseName);
            string destinationDatabaseName = databaseName;

            // Go grab the current database's logical names for the data and log files
            // For this example, we assume there are 1 for each.
            Database currentDatabase = server.Databases[databaseName];
            string currentLogicalData = "";
            string currentLogicalLog = "";
            if (currentDatabase != null)
            {
                currentLogicalData = currentDatabase.FileGroups[0].Files[0].Name;
                currentLogicalLog = currentDatabase.LogFiles[0].Name;
                if (currentDatabase.ActiveConnections > 0)
                {
                    currentDatabase.SetOffline();
                    server.KillAllProcesses(destinationDatabaseName);
                    //currentDatabase.Drop();
                }
            }
            else
            {
                currentDatabase = server.Databases["master"];
                DataSet ds = currentDatabase.ExecuteWithResults(@"restore filelistonly from disk='" + fileName + "'");
                if( ds!=null && ds.Tables[0].Rows.Count>0 )
                {
                    currentLogicalData = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    currentLogicalLog = ds.Tables[0].Rows[1].ItemArray[0].ToString();
                }
            }
            // Now relocate the data and log files
            RelocateFile reloData = new RelocateFile(currentLogicalData,string.Format(@"{0}\{1}.mdf", DBPath, destinationDatabaseName));
            RelocateFile reloLog = new RelocateFile(currentLogicalLog, string.Format(@"{0}\{1}_Log.ldf", DBPath, destinationDatabaseName));
            restore.RelocateFiles.Add(reloData);
            restore.RelocateFiles.Add(reloLog);
            restore.Database = destinationDatabaseName;
            restore.ReplaceDatabase = true;
            restore.PercentCompleteNotification = 1;
            restore.PercentComplete += new PercentCompleteEventHandler(restore_PercentComplete);
            restore.Complete += new ServerMessageEventHandler(restore_Complete);
            restore.SqlRestore(server);
        }

        #endregion

        #region Event Handlers

        public void backup_Complete(object sender, ServerMessageEventArgs e)
        {
            Console.WriteLine("backup_Complete");
            if (BackupComplete != null)
                BackupComplete(sender, e);
        }
        public void restore_Complete(object sender, ServerMessageEventArgs e)
        {
            Console.WriteLine("restore_Complete");
            if (RestoreComplete != null)
                RestoreComplete(sender, e);
        }
        public void backup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            Console.WriteLine("backup_PercentComplete");
            if (BackupPercentCompleteChanging != null)
                BackupPercentCompleteChanging(sender, e);
        }
        public void restore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            Console.WriteLine("restore_PercentComplete");
            if (RestorePercentCompleteChanging != null)
                RestorePercentCompleteChanging(sender, e);
        }

        #endregion
    }
}
