namespace AWF
{
    partial class Frm_Request
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
            this.txt_ProgramingSummary = new System.Windows.Forms.TextBox();
            this.cmd_Update = new System.Windows.Forms.Button();
            this.txt_TestSummary = new System.Windows.Forms.TextBox();
            this.cmd_Load = new System.Windows.Forms.Button();
            this.grd_sasr1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MulTrackNo = new System.Windows.Forms.TextBox();
            this.txt_RequestDes = new System.Windows.Forms.TextBox();
            this.gb_BuildNo = new System.Windows.Forms.GroupBox();
            this.cbo_SpecialName = new System.Windows.Forms.ComboBox();
            this.lbl_BuildNo = new System.Windows.Forms.Label();
            this.txt_BuildNo = new System.Windows.Forms.TextBox();
            this.lbl_SpecialName = new System.Windows.Forms.Label();
            this.gb_Version = new System.Windows.Forms.GroupBox();
            this.rB_v706 = new System.Windows.Forms.RadioButton();
            this.rB_v701 = new System.Windows.Forms.RadioButton();
            this.rB_v702 = new System.Windows.Forms.RadioButton();
            this.rB_v703 = new System.Windows.Forms.RadioButton();
            this.rB_v802 = new System.Windows.Forms.RadioButton();
            this.rB_v704 = new System.Windows.Forms.RadioButton();
            this.rB_v705 = new System.Windows.Forms.RadioButton();
            this.rB_v801 = new System.Windows.Forms.RadioButton();
            this.lbl_programmer = new System.Windows.Forms.Label();
            this.cbo_Programmer = new System.Windows.Forms.ComboBox();
            this.lbl_trackno = new System.Windows.Forms.Label();
            this.txt_TrackNo = new System.Windows.Forms.TextBox();
            this.chk_Today = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_sasr1)).BeginInit();
            this.gb_BuildNo.SuspendLayout();
            this.gb_Version.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_ProgramingSummary);
            this.panel1.Controls.Add(this.cmd_Update);
            this.panel1.Controls.Add(this.txt_TestSummary);
            this.panel1.Controls.Add(this.cmd_Load);
            this.panel1.Controls.Add(this.grd_sasr1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_MulTrackNo);
            this.panel1.Controls.Add(this.txt_RequestDes);
            this.panel1.Controls.Add(this.gb_BuildNo);
            this.panel1.Controls.Add(this.gb_Version);
            this.panel1.Controls.Add(this.lbl_programmer);
            this.panel1.Controls.Add(this.cbo_Programmer);
            this.panel1.Controls.Add(this.lbl_trackno);
            this.panel1.Controls.Add(this.txt_TrackNo);
            this.panel1.Controls.Add(this.chk_Today);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 454);
            this.panel1.TabIndex = 0;
            // 
            // txt_ProgramingSummary
            // 
            this.txt_ProgramingSummary.Location = new System.Drawing.Point(26, 355);
            this.txt_ProgramingSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_ProgramingSummary.Multiline = true;
            this.txt_ProgramingSummary.Name = "txt_ProgramingSummary";
            this.txt_ProgramingSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ProgramingSummary.Size = new System.Drawing.Size(411, 75);
            this.txt_ProgramingSummary.TabIndex = 109;
            this.txt_ProgramingSummary.TextChanged += new System.EventHandler(this.txt_ProgramingSummary_TextChanged);
            // 
            // cmd_Update
            // 
            this.cmd_Update.Location = new System.Drawing.Point(734, 119);
            this.cmd_Update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_Update.Name = "cmd_Update";
            this.cmd_Update.Size = new System.Drawing.Size(100, 26);
            this.cmd_Update.TabIndex = 108;
            this.cmd_Update.Text = "Update";
            this.cmd_Update.UseVisualStyleBackColor = true;
            this.cmd_Update.Click += new System.EventHandler(this.cmd_Update_Click);
            // 
            // txt_TestSummary
            // 
            this.txt_TestSummary.Location = new System.Drawing.Point(445, 355);
            this.txt_TestSummary.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TestSummary.Multiline = true;
            this.txt_TestSummary.Name = "txt_TestSummary";
            this.txt_TestSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_TestSummary.Size = new System.Drawing.Size(415, 75);
            this.txt_TestSummary.TabIndex = 107;
            // 
            // cmd_Load
            // 
            this.cmd_Load.Location = new System.Drawing.Point(624, 119);
            this.cmd_Load.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_Load.Name = "cmd_Load";
            this.cmd_Load.Size = new System.Drawing.Size(102, 26);
            this.cmd_Load.TabIndex = 106;
            this.cmd_Load.Text = "Load";
            this.cmd_Load.UseVisualStyleBackColor = true;
            this.cmd_Load.Click += new System.EventHandler(this.button1_Click);
            // 
            // grd_sasr1
            // 
            this.grd_sasr1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grd_sasr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_sasr1.Location = new System.Drawing.Point(26, 183);
            this.grd_sasr1.Name = "grd_sasr1";
            this.grd_sasr1.RowTemplate.Height = 23;
            this.grd_sasr1.Size = new System.Drawing.Size(834, 166);
            this.grd_sasr1.TabIndex = 105;
            this.grd_sasr1.SelectionChanged += new System.EventHandler(this.grd_sasr1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 104;
            this.label1.Text = "需求编号 : （, 区分）";
            // 
            // txt_MulTrackNo
            // 
            this.txt_MulTrackNo.Location = new System.Drawing.Point(249, 149);
            this.txt_MulTrackNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MulTrackNo.Multiline = true;
            this.txt_MulTrackNo.Name = "txt_MulTrackNo";
            this.txt_MulTrackNo.Size = new System.Drawing.Size(611, 27);
            this.txt_MulTrackNo.TabIndex = 103;
            // 
            // txt_RequestDes
            // 
            this.txt_RequestDes.Location = new System.Drawing.Point(26, 355);
            this.txt_RequestDes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_RequestDes.Multiline = true;
            this.txt_RequestDes.Name = "txt_RequestDes";
            this.txt_RequestDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_RequestDes.Size = new System.Drawing.Size(165, 75);
            this.txt_RequestDes.TabIndex = 100;
            // 
            // gb_BuildNo
            // 
            this.gb_BuildNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_BuildNo.Controls.Add(this.cbo_SpecialName);
            this.gb_BuildNo.Controls.Add(this.lbl_BuildNo);
            this.gb_BuildNo.Controls.Add(this.txt_BuildNo);
            this.gb_BuildNo.Controls.Add(this.lbl_SpecialName);
            this.gb_BuildNo.Location = new System.Drawing.Point(21, 57);
            this.gb_BuildNo.Name = "gb_BuildNo";
            this.gb_BuildNo.Size = new System.Drawing.Size(849, 55);
            this.gb_BuildNo.TabIndex = 99;
            this.gb_BuildNo.TabStop = false;
            this.gb_BuildNo.Text = "确认版本修订号";
            // 
            // cbo_SpecialName
            // 
            this.cbo_SpecialName.FormattingEnabled = true;
            this.cbo_SpecialName.Location = new System.Drawing.Point(473, 18);
            this.cbo_SpecialName.Name = "cbo_SpecialName";
            this.cbo_SpecialName.Size = new System.Drawing.Size(257, 27);
            this.cbo_SpecialName.TabIndex = 52;
            this.cbo_SpecialName.Leave += new System.EventHandler(this.cbo_SpecialName_Leave);
            // 
            // lbl_BuildNo
            // 
            this.lbl_BuildNo.AutoSize = true;
            this.lbl_BuildNo.Location = new System.Drawing.Point(135, 21);
            this.lbl_BuildNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BuildNo.Name = "lbl_BuildNo";
            this.lbl_BuildNo.Size = new System.Drawing.Size(65, 19);
            this.lbl_BuildNo.TabIndex = 44;
            this.lbl_BuildNo.Text = "Build No.";
            // 
            // txt_BuildNo
            // 
            this.txt_BuildNo.Location = new System.Drawing.Point(220, 20);
            this.txt_BuildNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_BuildNo.Name = "txt_BuildNo";
            this.txt_BuildNo.Size = new System.Drawing.Size(103, 24);
            this.txt_BuildNo.TabIndex = 50;
            this.txt_BuildNo.TextChanged += new System.EventHandler(this.txt_BuildNo_TextChanged);
            // 
            // lbl_SpecialName
            // 
            this.lbl_SpecialName.AutoSize = true;
            this.lbl_SpecialName.Location = new System.Drawing.Point(369, 21);
            this.lbl_SpecialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SpecialName.Name = "lbl_SpecialName";
            this.lbl_SpecialName.Size = new System.Drawing.Size(87, 19);
            this.lbl_SpecialName.TabIndex = 46;
            this.lbl_SpecialName.Text = "特殊版本名称";
            // 
            // gb_Version
            // 
            this.gb_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Version.Controls.Add(this.rB_v706);
            this.gb_Version.Controls.Add(this.rB_v701);
            this.gb_Version.Controls.Add(this.rB_v702);
            this.gb_Version.Controls.Add(this.rB_v703);
            this.gb_Version.Controls.Add(this.rB_v802);
            this.gb_Version.Controls.Add(this.rB_v704);
            this.gb_Version.Controls.Add(this.rB_v705);
            this.gb_Version.Controls.Add(this.rB_v801);
            this.gb_Version.Location = new System.Drawing.Point(21, 0);
            this.gb_Version.Name = "gb_Version";
            this.gb_Version.Size = new System.Drawing.Size(849, 55);
            this.gb_Version.TabIndex = 98;
            this.gb_Version.TabStop = false;
            this.gb_Version.Text = "选择版本";
            // 
            // rB_v706
            // 
            this.rB_v706.AutoSize = true;
            this.rB_v706.Location = new System.Drawing.Point(564, 19);
            this.rB_v706.Margin = new System.Windows.Forms.Padding(4);
            this.rB_v706.Name = "rB_v706";
            this.rB_v706.Size = new System.Drawing.Size(82, 23);
            this.rB_v706.TabIndex = 49;
            this.rB_v706.TabStop = true;
            this.rB_v706.Text = "Ver 7.0.6";
            this.rB_v706.UseVisualStyleBackColor = true;
            // 
            // rB_v701
            // 
            this.rB_v701.AutoSize = true;
            this.rB_v701.Location = new System.Drawing.Point(74, 19);
            this.rB_v701.Margin = new System.Windows.Forms.Padding(4);
            this.rB_v701.Name = "rB_v701";
            this.rB_v701.Size = new System.Drawing.Size(82, 23);
            this.rB_v701.TabIndex = 42;
            this.rB_v701.TabStop = true;
            this.rB_v701.Text = "Ver 7.0.1";
            this.rB_v701.UseVisualStyleBackColor = true;
            // 
            // rB_v702
            // 
            this.rB_v702.AutoSize = true;
            this.rB_v702.Location = new System.Drawing.Point(172, 19);
            this.rB_v702.Margin = new System.Windows.Forms.Padding(4);
            this.rB_v702.Name = "rB_v702";
            this.rB_v702.Size = new System.Drawing.Size(82, 23);
            this.rB_v702.TabIndex = 43;
            this.rB_v702.TabStop = true;
            this.rB_v702.Text = "Ver 7.0.2";
            this.rB_v702.UseVisualStyleBackColor = true;
            // 
            // rB_v703
            // 
            this.rB_v703.AutoSize = true;
            this.rB_v703.Location = new System.Drawing.Point(270, 19);
            this.rB_v703.Margin = new System.Windows.Forms.Padding(4);
            this.rB_v703.Name = "rB_v703";
            this.rB_v703.Size = new System.Drawing.Size(82, 23);
            this.rB_v703.TabIndex = 45;
            this.rB_v703.TabStop = true;
            this.rB_v703.Text = "Ver 7.0.3";
            this.rB_v703.UseVisualStyleBackColor = true;
            // 
            // rB_v802
            // 
            this.rB_v802.AutoSize = true;
            this.rB_v802.Location = new System.Drawing.Point(760, 19);
            this.rB_v802.Margin = new System.Windows.Forms.Padding(4);
            this.rB_v802.Name = "rB_v802";
            this.rB_v802.Size = new System.Drawing.Size(82, 23);
            this.rB_v802.TabIndex = 80;
            this.rB_v802.TabStop = true;
            this.rB_v802.Text = "Ver 8.0.2";
            this.rB_v802.UseVisualStyleBackColor = true;
            // 
            // rB_v704
            // 
            this.rB_v704.AutoSize = true;
            this.rB_v704.Location = new System.Drawing.Point(368, 19);
            this.rB_v704.Margin = new System.Windows.Forms.Padding(4);
            this.rB_v704.Name = "rB_v704";
            this.rB_v704.Size = new System.Drawing.Size(82, 23);
            this.rB_v704.TabIndex = 47;
            this.rB_v704.TabStop = true;
            this.rB_v704.Text = "Ver 7.0.4";
            this.rB_v704.UseVisualStyleBackColor = true;
            // 
            // rB_v705
            // 
            this.rB_v705.AutoSize = true;
            this.rB_v705.Location = new System.Drawing.Point(466, 19);
            this.rB_v705.Margin = new System.Windows.Forms.Padding(4);
            this.rB_v705.Name = "rB_v705";
            this.rB_v705.Size = new System.Drawing.Size(82, 23);
            this.rB_v705.TabIndex = 48;
            this.rB_v705.TabStop = true;
            this.rB_v705.Text = "Ver 7.0.5";
            this.rB_v705.UseVisualStyleBackColor = true;
            // 
            // rB_v801
            // 
            this.rB_v801.AutoSize = true;
            this.rB_v801.Location = new System.Drawing.Point(662, 19);
            this.rB_v801.Margin = new System.Windows.Forms.Padding(4);
            this.rB_v801.Name = "rB_v801";
            this.rB_v801.Size = new System.Drawing.Size(82, 23);
            this.rB_v801.TabIndex = 59;
            this.rB_v801.TabStop = true;
            this.rB_v801.Text = "Ver 8.0.1";
            this.rB_v801.UseVisualStyleBackColor = true;
            // 
            // lbl_programmer
            // 
            this.lbl_programmer.AutoSize = true;
            this.lbl_programmer.Location = new System.Drawing.Point(390, 121);
            this.lbl_programmer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_programmer.Name = "lbl_programmer";
            this.lbl_programmer.Size = new System.Drawing.Size(100, 19);
            this.lbl_programmer.TabIndex = 94;
            this.lbl_programmer.Text = "需求指派对象：";
            // 
            // cbo_Programmer
            // 
            this.cbo_Programmer.DisplayMember = "Name";
            this.cbo_Programmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Programmer.FormattingEnabled = true;
            this.cbo_Programmer.Items.AddRange(new object[] {
            "decheng",
            "xiaozhen",
            "liaozheng",
            "tangxc"});
            this.cbo_Programmer.Location = new System.Drawing.Point(497, 117);
            this.cbo_Programmer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Programmer.Name = "cbo_Programmer";
            this.cbo_Programmer.Size = new System.Drawing.Size(120, 27);
            this.cbo_Programmer.TabIndex = 93;
            this.cbo_Programmer.ValueMember = "Name";
            // 
            // lbl_trackno
            // 
            this.lbl_trackno.AutoSize = true;
            this.lbl_trackno.Location = new System.Drawing.Point(28, 118);
            this.lbl_trackno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trackno.Name = "lbl_trackno";
            this.lbl_trackno.Size = new System.Drawing.Size(74, 19);
            this.lbl_trackno.TabIndex = 92;
            this.lbl_trackno.Text = "需求编号：";
            // 
            // txt_TrackNo
            // 
            this.txt_TrackNo.Location = new System.Drawing.Point(249, 118);
            this.txt_TrackNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TrackNo.Multiline = true;
            this.txt_TrackNo.Name = "txt_TrackNo";
            this.txt_TrackNo.Size = new System.Drawing.Size(95, 27);
            this.txt_TrackNo.TabIndex = 91;
            this.txt_TrackNo.Leave += new System.EventHandler(this.txt_TrackNo_Leave);
            // 
            // chk_Today
            // 
            this.chk_Today.AutoSize = true;
            this.chk_Today.Location = new System.Drawing.Point(32, 161);
            this.chk_Today.Name = "chk_Today";
            this.chk_Today.Size = new System.Drawing.Size(128, 23);
            this.chk_Today.TabIndex = 110;
            this.chk_Today.Text = "Complete Today";
            this.chk_Today.UseVisualStyleBackColor = true;
            // 
            // Frm_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 454);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Request_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_sasr1)).EndInit();
            this.gb_BuildNo.ResumeLayout(false);
            this.gb_BuildNo.PerformLayout();
            this.gb_Version.ResumeLayout(false);
            this.gb_Version.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_programmer;
        private System.Windows.Forms.ComboBox cbo_Programmer;
        private System.Windows.Forms.Label lbl_trackno;
        private System.Windows.Forms.TextBox txt_TrackNo;
        private System.Windows.Forms.GroupBox gb_BuildNo;
        private System.Windows.Forms.ComboBox cbo_SpecialName;
        private System.Windows.Forms.Label lbl_BuildNo;
        private System.Windows.Forms.TextBox txt_BuildNo;
        private System.Windows.Forms.Label lbl_SpecialName;
        private System.Windows.Forms.GroupBox gb_Version;
        private System.Windows.Forms.RadioButton rB_v706;
        private System.Windows.Forms.RadioButton rB_v701;
        private System.Windows.Forms.RadioButton rB_v702;
        private System.Windows.Forms.RadioButton rB_v703;
        private System.Windows.Forms.RadioButton rB_v802;
        private System.Windows.Forms.RadioButton rB_v704;
        private System.Windows.Forms.RadioButton rB_v705;
        private System.Windows.Forms.RadioButton rB_v801;
        private System.Windows.Forms.TextBox txt_RequestDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MulTrackNo;
        private System.Windows.Forms.DataGridView grd_sasr1;
        private System.Windows.Forms.Button cmd_Load;
        private System.Windows.Forms.TextBox txt_TestSummary;
        private System.Windows.Forms.Button cmd_Update;
        private System.Windows.Forms.TextBox txt_ProgramingSummary;
        private System.Windows.Forms.CheckBox chk_Today;


    }
}