namespace AWF
{
    partial class frm_RequestDB
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
            this.cmd_INS = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chk_SelectAll = new System.Windows.Forms.CheckBox();
            this.cmdAddField = new System.Windows.Forms.Button();
            this.txt_FieldType = new System.Windows.Forms.TextBox();
            this.txt_FieldName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmd_Add = new System.Windows.Forms.Button();
            this.cmd_List = new System.Windows.Forms.Button();
            this.clb_newadd = new System.Windows.Forms.CheckedListBox();
            this.clb_tb = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Table = new System.Windows.Forms.ComboBox();
            this.cmdAddDatabase = new System.Windows.Forms.Button();
            this.cboDatabseList = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txt_ProgramingSummary = new System.Windows.Forms.TextBox();
            this.cmd_Update = new System.Windows.Forms.Button();
            this.lbl_trackno = new System.Windows.Forms.Label();
            this.txt_TrackNo = new System.Windows.Forms.TextBox();
            this.cmd_EXE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmd_EXE);
            this.panel1.Controls.Add(this.cmd_INS);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.chk_SelectAll);
            this.panel1.Controls.Add(this.cmdAddField);
            this.panel1.Controls.Add(this.txt_FieldType);
            this.panel1.Controls.Add(this.txt_FieldName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmd_Add);
            this.panel1.Controls.Add(this.cmd_List);
            this.panel1.Controls.Add(this.clb_newadd);
            this.panel1.Controls.Add(this.clb_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbo_Table);
            this.panel1.Controls.Add(this.cmdAddDatabase);
            this.panel1.Controls.Add(this.cboDatabseList);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.txtServer);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.txt_ProgramingSummary);
            this.panel1.Controls.Add(this.cmd_Update);
            this.panel1.Controls.Add(this.lbl_trackno);
            this.panel1.Controls.Add(this.txt_TrackNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 523);
            this.panel1.TabIndex = 1;
            // 
            // cmd_INS
            // 
            this.cmd_INS.Location = new System.Drawing.Point(527, 112);
            this.cmd_INS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_INS.Name = "cmd_INS";
            this.cmd_INS.Size = new System.Drawing.Size(65, 20);
            this.cmd_INS.TabIndex = 133;
            this.cmd_INS.Text = "执行";
            this.cmd_INS.UseVisualStyleBackColor = true;
            this.cmd_INS.Click += new System.EventHandler(this.cmd_INS_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 24);
            this.label9.TabIndex = 134;
            this.label9.Text = "格式：(.Net6072,xiaozhen,new add,Y \r\n TrackNo,CompleteByName,Remark,SpFlag)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 132;
            this.label8.Text = "起始行：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 112);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 131;
            // 
            // chk_SelectAll
            // 
            this.chk_SelectAll.AutoSize = true;
            this.chk_SelectAll.Location = new System.Drawing.Point(14, 112);
            this.chk_SelectAll.Name = "chk_SelectAll";
            this.chk_SelectAll.Size = new System.Drawing.Size(84, 16);
            this.chk_SelectAll.TabIndex = 130;
            this.chk_SelectAll.Text = "Select All";
            this.chk_SelectAll.UseVisualStyleBackColor = true;
            this.chk_SelectAll.CheckedChanged += new System.EventHandler(this.chk_SelectAll_CheckedChanged);
            // 
            // cmdAddField
            // 
            this.cmdAddField.Location = new System.Drawing.Point(419, 61);
            this.cmdAddField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdAddField.Name = "cmdAddField";
            this.cmdAddField.Size = new System.Drawing.Size(100, 22);
            this.cmdAddField.TabIndex = 129;
            this.cmdAddField.Text = "Add";
            this.cmdAddField.UseVisualStyleBackColor = true;
            this.cmdAddField.Click += new System.EventHandler(this.cmdAddField_Click);
            // 
            // txt_FieldType
            // 
            this.txt_FieldType.Location = new System.Drawing.Point(292, 61);
            this.txt_FieldType.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FieldType.Multiline = true;
            this.txt_FieldType.Name = "txt_FieldType";
            this.txt_FieldType.Size = new System.Drawing.Size(125, 20);
            this.txt_FieldType.TabIndex = 128;
            // 
            // txt_FieldName
            // 
            this.txt_FieldName.Location = new System.Drawing.Point(96, 61);
            this.txt_FieldName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FieldName.Multiline = true;
            this.txt_FieldName.Name = "txt_FieldName";
            this.txt_FieldName.Size = new System.Drawing.Size(125, 20);
            this.txt_FieldName.TabIndex = 127;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 126;
            this.label7.Text = "Field Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 125;
            this.label6.Text = "Field Name";
            // 
            // cmd_Add
            // 
            this.cmd_Add.Location = new System.Drawing.Point(163, 135);
            this.cmd_Add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_Add.Name = "cmd_Add";
            this.cmd_Add.Size = new System.Drawing.Size(24, 26);
            this.cmd_Add.TabIndex = 124;
            this.cmd_Add.Text = ">";
            this.cmd_Add.UseVisualStyleBackColor = true;
            this.cmd_Add.Click += new System.EventHandler(this.cmd_Add_Click);
            // 
            // cmd_List
            // 
            this.cmd_List.Location = new System.Drawing.Point(419, 34);
            this.cmd_List.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_List.Name = "cmd_List";
            this.cmd_List.Size = new System.Drawing.Size(100, 22);
            this.cmd_List.TabIndex = 123;
            this.cmd_List.Text = "List Field";
            this.cmd_List.UseVisualStyleBackColor = true;
            this.cmd_List.Click += new System.EventHandler(this.cmd_List_Click);
            // 
            // clb_newadd
            // 
            this.clb_newadd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clb_newadd.FormattingEnabled = true;
            this.clb_newadd.Location = new System.Drawing.Point(194, 135);
            this.clb_newadd.Name = "clb_newadd";
            this.clb_newadd.Size = new System.Drawing.Size(124, 388);
            this.clb_newadd.TabIndex = 122;
            // 
            // clb_tb
            // 
            this.clb_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clb_tb.FormattingEnabled = true;
            this.clb_tb.Location = new System.Drawing.Point(15, 134);
            this.clb_tb.Name = "clb_tb";
            this.clb_tb.Size = new System.Drawing.Size(141, 388);
            this.clb_tb.TabIndex = 121;
            this.clb_tb.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clb_tb_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 120;
            this.label1.Text = "Table";
            // 
            // cbo_Table
            // 
            this.cbo_Table.FormattingEnabled = true;
            this.cbo_Table.Location = new System.Drawing.Point(292, 34);
            this.cbo_Table.Name = "cbo_Table";
            this.cbo_Table.Size = new System.Drawing.Size(123, 20);
            this.cbo_Table.TabIndex = 119;
            // 
            // cmdAddDatabase
            // 
            this.cmdAddDatabase.Location = new System.Drawing.Point(569, 6);
            this.cmdAddDatabase.Name = "cmdAddDatabase";
            this.cmdAddDatabase.Size = new System.Drawing.Size(58, 24);
            this.cmdAddDatabase.TabIndex = 118;
            this.cmdAddDatabase.Text = "Connect";
            this.cmdAddDatabase.UseVisualStyleBackColor = true;
            this.cmdAddDatabase.Click += new System.EventHandler(this.cmdAddDatabase_Click);
            // 
            // cboDatabseList
            // 
            this.cboDatabseList.FormattingEnabled = true;
            this.cboDatabseList.Location = new System.Drawing.Point(96, 34);
            this.cboDatabseList.Name = "cboDatabseList";
            this.cboDatabseList.Size = new System.Drawing.Size(125, 20);
            this.cboDatabseList.TabIndex = 114;
            this.cboDatabseList.SelectedIndexChanged += new System.EventHandler(this.cboDatabseList_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(227, 9);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 12);
            this.Label4.TabIndex = 117;
            this.Label4.Text = "User ID";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(364, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 12);
            this.Label3.TabIndex = 116;
            this.Label3.Text = "Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 39);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(53, 12);
            this.Label2.TabIndex = 115;
            this.Label2.Text = "Database";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(439, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(123, 21);
            this.txtPassword.TabIndex = 113;
            this.txtPassword.Text = "p@ssw0rd$";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(287, 6);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(71, 21);
            this.txtUserID.TabIndex = 112;
            this.txtUserID.Text = "sa";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(96, 6);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(125, 21);
            this.txtServer.TabIndex = 111;
            this.txtServer.Text = "192.168.0.230";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(65, 12);
            this.Label5.TabIndex = 110;
            this.Label5.Text = "SQL Server";
            // 
            // txt_ProgramingSummary
            // 
            this.txt_ProgramingSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProgramingSummary.Location = new System.Drawing.Point(325, 135);
            this.txt_ProgramingSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ProgramingSummary.Multiline = true;
            this.txt_ProgramingSummary.Name = "txt_ProgramingSummary";
            this.txt_ProgramingSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ProgramingSummary.Size = new System.Drawing.Size(530, 385);
            this.txt_ProgramingSummary.TabIndex = 109;
            // 
            // cmd_Update
            // 
            this.cmd_Update.Location = new System.Drawing.Point(325, 112);
            this.cmd_Update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_Update.Name = "cmd_Update";
            this.cmd_Update.Size = new System.Drawing.Size(194, 20);
            this.cmd_Update.TabIndex = 108;
            this.cmd_Update.Text = "生成insert 脚本";
            this.cmd_Update.UseVisualStyleBackColor = true;
            this.cmd_Update.Click += new System.EventHandler(this.cmd_Update_Click);
            // 
            // lbl_trackno
            // 
            this.lbl_trackno.AutoSize = true;
            this.lbl_trackno.Location = new System.Drawing.Point(11, 95);
            this.lbl_trackno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trackno.Name = "lbl_trackno";
            this.lbl_trackno.Size = new System.Drawing.Size(65, 12);
            this.lbl_trackno.TabIndex = 92;
            this.lbl_trackno.Text = "需求编号：";
            // 
            // txt_TrackNo
            // 
            this.txt_TrackNo.Location = new System.Drawing.Point(115, 87);
            this.txt_TrackNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TrackNo.Multiline = true;
            this.txt_TrackNo.Name = "txt_TrackNo";
            this.txt_TrackNo.Size = new System.Drawing.Size(404, 20);
            this.txt_TrackNo.TabIndex = 91;
            this.txt_TrackNo.Leave += new System.EventHandler(this.txt_TrackNo_Leave);
            // 
            // cmd_EXE
            // 
            this.cmd_EXE.Location = new System.Drawing.Point(634, 8);
            this.cmd_EXE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_EXE.Name = "cmd_EXE";
            this.cmd_EXE.Size = new System.Drawing.Size(135, 20);
            this.cmd_EXE.TabIndex = 135;
            this.cmd_EXE.Text = "数据库脚本产生";
            this.cmd_EXE.UseVisualStyleBackColor = true;
            this.cmd_EXE.Click += new System.EventHandler(this.cmd_EXE_Click);
            // 
            // frm_RequestDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(879, 523);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_RequestDB";
            this.Text = "frm_RequestDB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_ProgramingSummary;
        private System.Windows.Forms.Button cmd_Update;
        private System.Windows.Forms.Label lbl_trackno;
        private System.Windows.Forms.TextBox txt_TrackNo;
        internal System.Windows.Forms.Button cmdAddDatabase;
        internal System.Windows.Forms.ComboBox cboDatabseList;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.TextBox txtServer;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.CheckedListBox clb_newadd;
        private System.Windows.Forms.CheckedListBox clb_tb;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cbo_Table;
        private System.Windows.Forms.Button cmd_Add;
        private System.Windows.Forms.Button cmd_List;
        private System.Windows.Forms.Button cmdAddField;
        private System.Windows.Forms.TextBox txt_FieldType;
        private System.Windows.Forms.TextBox txt_FieldName;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chk_SelectAll;
        private System.Windows.Forms.Button cmd_INS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmd_EXE;
    }
}