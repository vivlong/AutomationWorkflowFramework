namespace AWF
{
    partial class Frm_RestoreDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnClearConfig = new System.Windows.Forms.Button();
            this.lbl_IfExist = new System.Windows.Forms.Label();
            this.txtDBPath = new System.Windows.Forms.ComboBox();
            this.btnDBPath = new System.Windows.Forms.Button();
            this.strWebService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.pbDBAction = new System.Windows.Forms.ProgressBar();
            this.btnRestore = new System.Windows.Forms.Button();
            this.grpDatabase = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.chkUseWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSQLServerName = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.grpActions);
            this.panel1.Controls.Add(this.grpDatabase);
            this.panel1.Controls.Add(this.chkUseWindowsAuthentication);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSQLServerName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 363);
            this.panel1.TabIndex = 0;
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnClearConfig);
            this.grpActions.Controls.Add(this.lbl_IfExist);
            this.grpActions.Controls.Add(this.txtDBPath);
            this.grpActions.Controls.Add(this.btnDBPath);
            this.grpActions.Controls.Add(this.strWebService);
            this.grpActions.Controls.Add(this.label5);
            this.grpActions.Controls.Add(this.label4);
            this.grpActions.Controls.Add(this.txtDatabaseName);
            this.grpActions.Controls.Add(this.btnFile);
            this.grpActions.Controls.Add(this.txtFileName);
            this.grpActions.Controls.Add(this.pbDBAction);
            this.grpActions.Controls.Add(this.btnRestore);
            this.grpActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpActions.Location = new System.Drawing.Point(12, 142);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(599, 209);
            this.grpActions.TabIndex = 58;
            this.grpActions.TabStop = false;
            // 
            // btnClearConfig
            // 
            this.btnClearConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearConfig.Location = new System.Drawing.Point(490, 15);
            this.btnClearConfig.Name = "btnClearConfig";
            this.btnClearConfig.Size = new System.Drawing.Size(103, 24);
            this.btnClearConfig.TabIndex = 71;
            this.btnClearConfig.Text = "Clear config";
            this.btnClearConfig.UseVisualStyleBackColor = true;
            this.btnClearConfig.Click += new System.EventHandler(this.btnClearConfig_Click);
            // 
            // lbl_IfExist
            // 
            this.lbl_IfExist.AutoSize = true;
            this.lbl_IfExist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lbl_IfExist.Location = new System.Drawing.Point(351, 126);
            this.lbl_IfExist.Name = "lbl_IfExist";
            this.lbl_IfExist.Size = new System.Drawing.Size(91, 16);
            this.lbl_IfExist.TabIndex = 70;
            this.lbl_IfExist.Text = "Already exist !";
            this.lbl_IfExist.Visible = false;
            // 
            // txtDBPath
            // 
            this.txtDBPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBPath.FormattingEnabled = true;
            this.txtDBPath.Items.AddRange(new object[] {
            "E:\\Data\\",
            "C:\\Program Files\\Microsoft SQL Server\\MSSQL10_50.SQL2008\\MSSQL\\DATA\\"});
            this.txtDBPath.Location = new System.Drawing.Point(147, 151);
            this.txtDBPath.Name = "txtDBPath";
            this.txtDBPath.Size = new System.Drawing.Size(446, 23);
            this.txtDBPath.TabIndex = 69;
            this.txtDBPath.Text = "N:\\Customer_Database\\";
            // 
            // btnDBPath
            // 
            this.btnDBPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBPath.Location = new System.Drawing.Point(9, 150);
            this.btnDBPath.Name = "btnDBPath";
            this.btnDBPath.Size = new System.Drawing.Size(132, 24);
            this.btnDBPath.TabIndex = 68;
            this.btnDBPath.Text = "Set DB Path";
            this.btnDBPath.UseVisualStyleBackColor = true;
            this.btnDBPath.Click += new System.EventHandler(this.btnDBPath_Click);
            // 
            // strWebService
            // 
            this.strWebService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strWebService.FormattingEnabled = true;
            this.strWebService.Items.AddRange(new object[] {
            "\\\\192.168.0.230\\WebService\\Web.config",
            "\\\\192.168.0.236\\SysFreightWS\\Web.config",
            "\\\\192.168.0.84\\SysFreightWS\\Web.config",
            "C:\\Sysfreight\\WebService\\Web.config"});
            this.strWebService.Location = new System.Drawing.Point(147, 15);
            this.strWebService.Name = "strWebService";
            this.strWebService.Size = new System.Drawing.Size(334, 23);
            this.strWebService.TabIndex = 67;
            this.strWebService.Text = "\\\\192.168.0.230\\WebService\\Web.config";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Web Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Database Name";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(147, 123);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(198, 22);
            this.txtDatabaseName.TabIndex = 62;
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(9, 70);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(132, 24);
            this.btnFile.TabIndex = 61;
            this.btnFile.Text = "*.Bak File Path";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(147, 71);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(446, 21);
            this.txtFileName.TabIndex = 60;
            // 
            // pbDBAction
            // 
            this.pbDBAction.Location = new System.Drawing.Point(9, 179);
            this.pbDBAction.Name = "pbDBAction";
            this.pbDBAction.Size = new System.Drawing.Size(472, 22);
            this.pbDBAction.TabIndex = 59;
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(490, 178);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(103, 24);
            this.btnRestore.TabIndex = 37;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // grpDatabase
            // 
            this.grpDatabase.Controls.Add(this.btnRefresh);
            this.grpDatabase.Controls.Add(this.label6);
            this.grpDatabase.Controls.Add(this.cboDatabase);
            this.grpDatabase.Location = new System.Drawing.Point(12, 85);
            this.grpDatabase.Name = "grpDatabase";
            this.grpDatabase.Size = new System.Drawing.Size(599, 55);
            this.grpDatabase.TabIndex = 57;
            this.grpDatabase.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(484, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 24);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Database:";
            // 
            // cboDatabase
            // 
            this.cboDatabase.DisplayMember = "Name";
            this.cboDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(101, 18);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(377, 24);
            this.cboDatabase.TabIndex = 1;
            this.cboDatabase.ValueMember = "Name";
            // 
            // chkUseWindowsAuthentication
            // 
            this.chkUseWindowsAuthentication.AutoSize = true;
            this.chkUseWindowsAuthentication.Location = new System.Drawing.Point(255, 51);
            this.chkUseWindowsAuthentication.Name = "chkUseWindowsAuthentication";
            this.chkUseWindowsAuthentication.Size = new System.Drawing.Size(196, 20);
            this.chkUseWindowsAuthentication.TabIndex = 56;
            this.chkUseWindowsAuthentication.Text = "Use Windows Authentication";
            this.chkUseWindowsAuthentication.UseVisualStyleBackColor = true;
            this.chkUseWindowsAuthentication.CheckedChanged += new System.EventHandler(this.chkUseWindowsAuthentication_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(496, 47);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 24);
            this.btnConnect.TabIndex = 55;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(152, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(84, 21);
            this.txtPassword.TabIndex = 46;
            this.txtPassword.Text = "p@ssw0rd$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(152, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(84, 21);
            this.txtUserName.TabIndex = 44;
            this.txtUserName.Text = "sa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "SQL Server Name";
            // 
            // txtSQLServerName
            // 
            this.txtSQLServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQLServerName.FormattingEnabled = true;
            this.txtSQLServerName.Items.AddRange(new object[] {
            "192.168.0.230\\",
            "192.168.0.84\\SQL2008",
            "192.168.0.85\\SQL2012",
            "192.168.0.86\\SQL2014",
            "192.168.0.250\\",
            "127.0.0.1"});
            this.txtSQLServerName.Location = new System.Drawing.Point(152, 7);
            this.txtSQLServerName.Name = "txtSQLServerName";
            this.txtSQLServerName.Size = new System.Drawing.Size(459, 23);
            this.txtSQLServerName.TabIndex = 41;
            this.txtSQLServerName.Text = "192.168.0.230\\";
            // 
            // Frm_RestoreDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 363);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_RestoreDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_RestoreDB";
            this.Load += new System.EventHandler(this.Frm_RestoreDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            this.grpDatabase.ResumeLayout(false);
            this.grpDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtSQLServerName;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chkUseWindowsAuthentication;
        private System.Windows.Forms.GroupBox grpDatabase;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.ProgressBar pbDBAction;
        private System.Windows.Forms.ComboBox txtDBPath;
        private System.Windows.Forms.Button btnDBPath;
        private System.Windows.Forms.ComboBox strWebService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lbl_IfExist;
        private System.Windows.Forms.Button btnClearConfig;
    }
}