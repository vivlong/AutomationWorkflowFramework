﻿namespace AWF
{
    partial class Frm_RequestXls
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.disCurrentDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPublishDate = new System.Windows.Forms.TextBox();
            this.cmdVersionSearch = new System.Windows.Forms.Button();
            this.cbm_Table = new System.Windows.Forms.ComboBox();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.tex_url = new System.Windows.Forms.TextBox();
            this.txt_versionName = new System.Windows.Forms.TextBox();
            this.com_version = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.gb_ConnetDB = new System.Windows.Forms.GroupBox();
            this.lbl_DbAddress = new System.Windows.Forms.Label();
            this.txt_SqlAddress = new System.Windows.Forms.TextBox();
            this.cbm_database = new System.Windows.Forms.ComboBox();
            this.lbl_DbName = new System.Windows.Forms.Label();
            this.lbl_DbUid = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.lbl_DbPwd = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmdUpdateGrid = new System.Windows.Forms.Button();
            this.txt_RequestDescripiton = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txt_editionSasr1 = new System.Windows.Forms.TextBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.dgv_sars1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ReDes = new System.Windows.Forms.TextBox();
            this.txt_edition = new System.Windows.Forms.TextBox();
            this.btn_ExportPage2 = new System.Windows.Forms.Button();
            this.dgv_sasr2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gb_ConnetDB.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sars1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sasr2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSpecial);
            this.panel1.Controls.Add(this.disCurrentDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPublishDate);
            this.panel1.Controls.Add(this.cmdVersionSearch);
            this.panel1.Controls.Add(this.cbm_Table);
            this.panel1.Controls.Add(this.btn_Copy);
            this.panel1.Controls.Add(this.tex_url);
            this.panel1.Controls.Add(this.txt_versionName);
            this.panel1.Controls.Add(this.com_version);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.gb_ConnetDB);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 498);
            this.panel1.TabIndex = 0;
            // 
            // disCurrentDate
            // 
            this.disCurrentDate.AutoSize = true;
            this.disCurrentDate.Location = new System.Drawing.Point(34, 74);
            this.disCurrentDate.Name = "disCurrentDate";
            this.disCurrentDate.Size = new System.Drawing.Size(45, 19);
            this.disCurrentDate.TabIndex = 44;
            this.disCurrentDate.Text = "label3";
            this.disCurrentDate.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "生成日期";
            // 
            // txtPublishDate
            // 
            this.txtPublishDate.Location = new System.Drawing.Point(109, 60);
            this.txtPublishDate.Name = "txtPublishDate";
            this.txtPublishDate.Size = new System.Drawing.Size(101, 24);
            this.txtPublishDate.TabIndex = 42;
            // 
            // cmdVersionSearch
            // 
            this.cmdVersionSearch.Location = new System.Drawing.Point(557, 87);
            this.cmdVersionSearch.Name = "cmdVersionSearch";
            this.cmdVersionSearch.Size = new System.Drawing.Size(75, 27);
            this.cmdVersionSearch.TabIndex = 41;
            this.cmdVersionSearch.Text = "查找";
            this.cmdVersionSearch.UseVisualStyleBackColor = true;
            this.cmdVersionSearch.Click += new System.EventHandler(this.cmdVersionSearch_Click);
            // 
            // cbm_Table
            // 
            this.cbm_Table.FormattingEnabled = true;
            this.cbm_Table.Location = new System.Drawing.Point(238, 58);
            this.cbm_Table.Name = "cbm_Table";
            this.cbm_Table.Size = new System.Drawing.Size(181, 27);
            this.cbm_Table.TabIndex = 39;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Location = new System.Drawing.Point(940, 87);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(75, 26);
            this.btn_Copy.TabIndex = 35;
            this.btn_Copy.Text = "保存";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // tex_url
            // 
            this.tex_url.Location = new System.Drawing.Point(634, 88);
            this.tex_url.Name = "tex_url";
            this.tex_url.Size = new System.Drawing.Size(298, 24);
            this.tex_url.TabIndex = 38;
            // 
            // txt_versionName
            // 
            this.txt_versionName.Location = new System.Drawing.Point(303, 88);
            this.txt_versionName.Name = "txt_versionName";
            this.txt_versionName.Size = new System.Drawing.Size(55, 24);
            this.txt_versionName.TabIndex = 37;
            // 
            // com_version
            // 
            this.com_version.FormattingEnabled = true;
            this.com_version.Items.AddRange(new object[] {
            "7.0.1",
            "7.0.2",
            "7.0.3",
            "8.0.1",
            "8.0.2",
            "8.0.3"});
            this.com_version.Location = new System.Drawing.Point(239, 87);
            this.com_version.Name = "com_version";
            this.com_version.Size = new System.Drawing.Size(61, 27);
            this.com_version.TabIndex = 36;
            this.com_version.SelectedValueChanged += new System.EventHandler(this.com_version_SelectedValueChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(939, 56);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 26);
            this.btn_Search.TabIndex = 33;
            this.btn_Search.Text = "查找";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(425, 58);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(508, 24);
            this.txt_search.TabIndex = 32;
            // 
            // gb_ConnetDB
            // 
            this.gb_ConnetDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_ConnetDB.Controls.Add(this.lbl_DbAddress);
            this.gb_ConnetDB.Controls.Add(this.txt_SqlAddress);
            this.gb_ConnetDB.Controls.Add(this.cbm_database);
            this.gb_ConnetDB.Controls.Add(this.lbl_DbName);
            this.gb_ConnetDB.Controls.Add(this.lbl_DbUid);
            this.gb_ConnetDB.Controls.Add(this.txt_user);
            this.gb_ConnetDB.Controls.Add(this.lbl_DbPwd);
            this.gb_ConnetDB.Controls.Add(this.txt_password);
            this.gb_ConnetDB.Controls.Add(this.btn_Connect);
            this.gb_ConnetDB.Location = new System.Drawing.Point(4, 4);
            this.gb_ConnetDB.Name = "gb_ConnetDB";
            this.gb_ConnetDB.Size = new System.Drawing.Size(1143, 50);
            this.gb_ConnetDB.TabIndex = 40;
            this.gb_ConnetDB.TabStop = false;
            this.gb_ConnetDB.Text = " 连接数据库";
            // 
            // lbl_DbAddress
            // 
            this.lbl_DbAddress.AutoSize = true;
            this.lbl_DbAddress.Location = new System.Drawing.Point(101, 20);
            this.lbl_DbAddress.Name = "lbl_DbAddress";
            this.lbl_DbAddress.Size = new System.Drawing.Size(74, 19);
            this.lbl_DbAddress.TabIndex = 35;
            this.lbl_DbAddress.Text = "数据库地址";
            // 
            // txt_SqlAddress
            // 
            this.txt_SqlAddress.Location = new System.Drawing.Point(181, 18);
            this.txt_SqlAddress.Name = "txt_SqlAddress";
            this.txt_SqlAddress.Size = new System.Drawing.Size(141, 24);
            this.txt_SqlAddress.TabIndex = 36;
            this.txt_SqlAddress.Text = "192.168.0.230";
            // 
            // cbm_database
            // 
            this.cbm_database.FormattingEnabled = true;
            this.cbm_database.Location = new System.Drawing.Point(395, 17);
            this.cbm_database.Name = "cbm_database";
            this.cbm_database.Size = new System.Drawing.Size(91, 27);
            this.cbm_database.TabIndex = 43;
            // 
            // lbl_DbName
            // 
            this.lbl_DbName.AutoSize = true;
            this.lbl_DbName.Location = new System.Drawing.Point(328, 20);
            this.lbl_DbName.Name = "lbl_DbName";
            this.lbl_DbName.Size = new System.Drawing.Size(61, 19);
            this.lbl_DbName.TabIndex = 42;
            this.lbl_DbName.Text = "数据库名";
            // 
            // lbl_DbUid
            // 
            this.lbl_DbUid.AutoSize = true;
            this.lbl_DbUid.Location = new System.Drawing.Point(492, 20);
            this.lbl_DbUid.Name = "lbl_DbUid";
            this.lbl_DbUid.Size = new System.Drawing.Size(55, 19);
            this.lbl_DbUid.TabIndex = 37;
            this.lbl_DbUid.Text = "User ID";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(553, 17);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(91, 24);
            this.txt_user.TabIndex = 38;
            // 
            // lbl_DbPwd
            // 
            this.lbl_DbPwd.AutoSize = true;
            this.lbl_DbPwd.Location = new System.Drawing.Point(650, 20);
            this.lbl_DbPwd.Name = "lbl_DbPwd";
            this.lbl_DbPwd.Size = new System.Drawing.Size(67, 19);
            this.lbl_DbPwd.TabIndex = 39;
            this.lbl_DbPwd.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(723, 17);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 24);
            this.txt_password.TabIndex = 40;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(829, 14);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(78, 28);
            this.btn_Connect.TabIndex = 41;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 408);
            this.tabControl1.TabIndex = 23;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cmdUpdateGrid);
            this.tabPage1.Controls.Add(this.txt_RequestDescripiton);
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.txt_editionSasr1);
            this.tabPage1.Controls.Add(this.btn_Export);
            this.tabPage1.Controls.Add(this.dgv_sars1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1142, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Version Update tasks";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdUpdateGrid
            // 
            this.cmdUpdateGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdUpdateGrid.Location = new System.Drawing.Point(261, 292);
            this.cmdUpdateGrid.Name = "cmdUpdateGrid";
            this.cmdUpdateGrid.Size = new System.Drawing.Size(72, 23);
            this.cmdUpdateGrid.TabIndex = 20;
            this.cmdUpdateGrid.Text = "修改";
            this.cmdUpdateGrid.UseVisualStyleBackColor = true;
            this.cmdUpdateGrid.Click += new System.EventHandler(this.cmdUpdateGrid_Click);
            // 
            // txt_RequestDescripiton
            // 
            this.txt_RequestDescripiton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RequestDescripiton.Location = new System.Drawing.Point(346, 262);
            this.txt_RequestDescripiton.Multiline = true;
            this.txt_RequestDescripiton.Name = "txt_RequestDescripiton";
            this.txt_RequestDescripiton.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_RequestDescripiton.Size = new System.Drawing.Size(789, 86);
            this.txt_RequestDescripiton.TabIndex = 19;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(24, 296);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(45, 19);
            this.lblCount.TabIndex = 18;
            this.lblCount.Text = "label1";
            // 
            // txt_editionSasr1
            // 
            this.txt_editionSasr1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_editionSasr1.Location = new System.Drawing.Point(96, 262);
            this.txt_editionSasr1.Name = "txt_editionSasr1";
            this.txt_editionSasr1.Size = new System.Drawing.Size(236, 24);
            this.txt_editionSasr1.TabIndex = 17;
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Export.Location = new System.Drawing.Point(14, 262);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 13;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // dgv_sars1
            // 
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sars1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_sars1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sars1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sars1.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_sars1.Location = new System.Drawing.Point(3, 3);
            this.dgv_sars1.Name = "dgv_sars1";
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sars1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_sars1.RowTemplate.Height = 23;
            this.dgv_sars1.Size = new System.Drawing.Size(1136, 253);
            this.dgv_sars1.TabIndex = 12;
            this.dgv_sars1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_sars1_CellFormatting);
            this.dgv_sars1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_sars1_CellMouseClick);
            this.dgv_sars1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgv_sars1_CellValueNeeded);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_ReDes);
            this.tabPage2.Controls.Add(this.txt_edition);
            this.tabPage2.Controls.Add(this.btn_ExportPage2);
            this.tabPage2.Controls.Add(this.dgv_sasr2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1142, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "filed";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "label1";
            // 
            // txt_ReDes
            // 
            this.txt_ReDes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ReDes.Location = new System.Drawing.Point(852, 6);
            this.txt_ReDes.Multiline = true;
            this.txt_ReDes.Name = "txt_ReDes";
            this.txt_ReDes.Size = new System.Drawing.Size(284, 301);
            this.txt_ReDes.TabIndex = 17;
            // 
            // txt_edition
            // 
            this.txt_edition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_edition.Location = new System.Drawing.Point(166, 340);
            this.txt_edition.Name = "txt_edition";
            this.txt_edition.Size = new System.Drawing.Size(100, 24);
            this.txt_edition.TabIndex = 16;
            this.txt_edition.Text = "field";
            // 
            // btn_ExportPage2
            // 
            this.btn_ExportPage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ExportPage2.Location = new System.Drawing.Point(70, 339);
            this.btn_ExportPage2.Name = "btn_ExportPage2";
            this.btn_ExportPage2.Size = new System.Drawing.Size(79, 24);
            this.btn_ExportPage2.TabIndex = 1;
            this.btn_ExportPage2.Text = "Export";
            this.btn_ExportPage2.UseVisualStyleBackColor = true;
            this.btn_ExportPage2.Click += new System.EventHandler(this.btn_ExportPage2_Click);
            // 
            // dgv_sasr2
            // 
            this.dgv_sasr2.AllowUserToAddRows = false;
            this.dgv_sasr2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sasr2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sasr2.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_sasr2.Location = new System.Drawing.Point(0, 6);
            this.dgv_sasr2.Name = "dgv_sasr2";
            this.dgv_sasr2.RowTemplate.Height = 23;
            this.dgv_sasr2.Size = new System.Drawing.Size(846, 327);
            this.dgv_sasr2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(154, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "整理完成 打包到Reuqest.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(346, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(789, 24);
            this.textBox1.TabIndex = 22;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(406, 167);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 42);
            this.progressBar1.TabIndex = 64;
            this.progressBar1.Visible = false;
            // 
            // txtSpecial
            // 
            this.txtSpecial.Location = new System.Drawing.Point(361, 88);
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(190, 24);
            this.txtSpecial.TabIndex = 65;
            // 
            // Frm_RequestXls
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1152, 498);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_RequestXls";
            this.Text = "Frm_RequestXls";
            this.Load += new System.EventHandler(this.Frm_RequestXls_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_ConnetDB.ResumeLayout(false);
            this.gb_ConnetDB.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sars1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sasr2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbm_Table;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.TextBox tex_url;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_editionSasr1;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.DataGridView dgv_sars1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_ReDes;
        private System.Windows.Forms.TextBox txt_edition;
        private System.Windows.Forms.Button btn_ExportPage2;
        private System.Windows.Forms.DataGridView dgv_sasr2;
        private System.Windows.Forms.TextBox txt_versionName;
        private System.Windows.Forms.ComboBox com_version;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox gb_ConnetDB;
        private System.Windows.Forms.Label lbl_DbAddress;
        private System.Windows.Forms.TextBox txt_SqlAddress;
        private System.Windows.Forms.ComboBox cbm_database;
        private System.Windows.Forms.Label lbl_DbName;
        private System.Windows.Forms.Label lbl_DbUid;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_DbPwd;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button cmdVersionSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublishDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label disCurrentDate;
        private System.Windows.Forms.TextBox txt_RequestDescripiton;
        private System.Windows.Forms.Button cmdUpdateGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtSpecial;

    }
}