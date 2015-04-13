namespace AWF
{
    partial class Frm_Publishing
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
            this.gb_Publish = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cmd_CreatFolder = new System.Windows.Forms.Button();
            this.cmd_OpenFolder = new System.Windows.Forms.Button();
            this.cmd_Published2Zip = new System.Windows.Forms.Button();
            this.cmd_SendTo = new System.Windows.Forms.Button();
            this.cmd_SelectFolder = new System.Windows.Forms.Button();
            this.cmd_BackUp = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btn_rebuild = new System.Windows.Forms.Button();
            this.btn_publish = new System.Windows.Forms.Button();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gb_Publish.SuspendLayout();
            this.gb_BuildNo.SuspendLayout();
            this.gb_Version.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gb_Publish);
            this.panel1.Controls.Add(this.gb_BuildNo);
            this.panel1.Controls.Add(this.gb_Version);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 454);
            this.panel1.TabIndex = 0;
            // 
            // gb_Publish
            // 
            this.gb_Publish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Publish.Controls.Add(this.progressBar1);
            this.gb_Publish.Controls.Add(this.cmd_CreatFolder);
            this.gb_Publish.Controls.Add(this.cmd_OpenFolder);
            this.gb_Publish.Controls.Add(this.cmd_Published2Zip);
            this.gb_Publish.Controls.Add(this.cmd_SendTo);
            this.gb_Publish.Controls.Add(this.cmd_SelectFolder);
            this.gb_Publish.Controls.Add(this.cmd_BackUp);
            this.gb_Publish.Controls.Add(this.txtFolder);
            this.gb_Publish.Controls.Add(this.btn_rebuild);
            this.gb_Publish.Controls.Add(this.btn_publish);
            this.gb_Publish.Location = new System.Drawing.Point(12, 126);
            this.gb_Publish.Name = "gb_Publish";
            this.gb_Publish.Size = new System.Drawing.Size(849, 225);
            this.gb_Publish.TabIndex = 86;
            this.gb_Publish.TabStop = false;
            this.gb_Publish.Text = "发布版本";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(244, 148);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 42);
            this.progressBar1.TabIndex = 63;
            this.progressBar1.Visible = false;
            // 
            // cmd_CreatFolder
            // 
            this.cmd_CreatFolder.Location = new System.Drawing.Point(74, 24);
            this.cmd_CreatFolder.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_CreatFolder.Name = "cmd_CreatFolder";
            this.cmd_CreatFolder.Size = new System.Drawing.Size(212, 31);
            this.cmd_CreatFolder.TabIndex = 57;
            this.cmd_CreatFolder.Text = " 建立 当前版本文件夹";
            this.cmd_CreatFolder.UseVisualStyleBackColor = true;
            this.cmd_CreatFolder.Click += new System.EventHandler(this.cmd_CreatFolder_Click);
            // 
            // cmd_OpenFolder
            // 
            this.cmd_OpenFolder.Location = new System.Drawing.Point(333, 24);
            this.cmd_OpenFolder.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_OpenFolder.Name = "cmd_OpenFolder";
            this.cmd_OpenFolder.Size = new System.Drawing.Size(212, 31);
            this.cmd_OpenFolder.TabIndex = 58;
            this.cmd_OpenFolder.Text = "打开 当前版本文件夹";
            this.cmd_OpenFolder.UseVisualStyleBackColor = true;
            this.cmd_OpenFolder.Click += new System.EventHandler(this.cmd_OpenFolder_Click);
            // 
            // cmd_Published2Zip
            // 
            this.cmd_Published2Zip.Location = new System.Drawing.Point(74, 104);
            this.cmd_Published2Zip.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Published2Zip.Name = "cmd_Published2Zip";
            this.cmd_Published2Zip.Size = new System.Drawing.Size(212, 31);
            this.cmd_Published2Zip.TabIndex = 52;
            this.cmd_Published2Zip.Text = "打包发布的文件至部署文件夹";
            this.cmd_Published2Zip.UseVisualStyleBackColor = true;
            this.cmd_Published2Zip.Click += new System.EventHandler(this.cmd_Published2Zip_Click);
            // 
            // cmd_SendTo
            // 
            this.cmd_SendTo.Location = new System.Drawing.Point(333, 104);
            this.cmd_SendTo.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_SendTo.Name = "cmd_SendTo";
            this.cmd_SendTo.Size = new System.Drawing.Size(212, 31);
            this.cmd_SendTo.TabIndex = 53;
            this.cmd_SendTo.Text = "将部署文件夹发送至250";
            this.cmd_SendTo.UseVisualStyleBackColor = true;
            this.cmd_SendTo.Click += new System.EventHandler(this.cmd_SendTo_Click);
            // 
            // cmd_SelectFolder
            // 
            this.cmd_SelectFolder.Location = new System.Drawing.Point(74, 144);
            this.cmd_SelectFolder.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_SelectFolder.Name = "cmd_SelectFolder";
            this.cmd_SelectFolder.Size = new System.Drawing.Size(212, 31);
            this.cmd_SelectFolder.TabIndex = 61;
            this.cmd_SelectFolder.Text = "选择要压缩的文件夹";
            this.cmd_SelectFolder.UseVisualStyleBackColor = true;
            this.cmd_SelectFolder.Click += new System.EventHandler(this.cmd_SelectFolder_Click);
            // 
            // cmd_BackUp
            // 
            this.cmd_BackUp.Location = new System.Drawing.Point(74, 184);
            this.cmd_BackUp.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_BackUp.Name = "cmd_BackUp";
            this.cmd_BackUp.Size = new System.Drawing.Size(212, 31);
            this.cmd_BackUp.TabIndex = 60;
            this.cmd_BackUp.Text = "备份源码";
            this.cmd_BackUp.UseVisualStyleBackColor = true;
            this.cmd_BackUp.Click += new System.EventHandler(this.cmd_BackUp_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(333, 148);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(501, 24);
            this.txtFolder.TabIndex = 62;
            // 
            // btn_rebuild
            // 
            this.btn_rebuild.Enabled = false;
            this.btn_rebuild.Location = new System.Drawing.Point(74, 64);
            this.btn_rebuild.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rebuild.Name = "btn_rebuild";
            this.btn_rebuild.Size = new System.Drawing.Size(212, 31);
            this.btn_rebuild.TabIndex = 69;
            this.btn_rebuild.Text = "编译并生成";
            this.btn_rebuild.UseVisualStyleBackColor = true;
            this.btn_rebuild.Click += new System.EventHandler(this.btn_rebuild_Click);
            // 
            // btn_publish
            // 
            this.btn_publish.Enabled = false;
            this.btn_publish.Location = new System.Drawing.Point(333, 64);
            this.btn_publish.Margin = new System.Windows.Forms.Padding(4);
            this.btn_publish.Name = "btn_publish";
            this.btn_publish.Size = new System.Drawing.Size(212, 31);
            this.btn_publish.TabIndex = 70;
            this.btn_publish.Text = "发布";
            this.btn_publish.UseVisualStyleBackColor = true;
            // 
            // gb_BuildNo
            // 
            this.gb_BuildNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_BuildNo.Controls.Add(this.cbo_SpecialName);
            this.gb_BuildNo.Controls.Add(this.lbl_BuildNo);
            this.gb_BuildNo.Controls.Add(this.txt_BuildNo);
            this.gb_BuildNo.Controls.Add(this.lbl_SpecialName);
            this.gb_BuildNo.Location = new System.Drawing.Point(12, 69);
            this.gb_BuildNo.Name = "gb_BuildNo";
            this.gb_BuildNo.Size = new System.Drawing.Size(849, 55);
            this.gb_BuildNo.TabIndex = 85;
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
            this.gb_Version.Location = new System.Drawing.Point(12, 12);
            this.gb_Version.Name = "gb_Version";
            this.gb_Version.Size = new System.Drawing.Size(849, 55);
            this.gb_Version.TabIndex = 84;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(355, 361);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(758, 331);
            this.textBox1.TabIndex = 71;
            this.textBox1.Visible = false;
            // 
            // Frm_Publishing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 454);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Publishing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Publishing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Publish.ResumeLayout(false);
            this.gb_Publish.PerformLayout();
            this.gb_BuildNo.ResumeLayout(false);
            this.gb_BuildNo.PerformLayout();
            this.gb_Version.ResumeLayout(false);
            this.gb_Version.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button cmd_SelectFolder;
        private System.Windows.Forms.Button cmd_BackUp;
        private System.Windows.Forms.RadioButton rB_v801;
        private System.Windows.Forms.Button cmd_OpenFolder;
        private System.Windows.Forms.Button cmd_CreatFolder;
        private System.Windows.Forms.RadioButton rB_v706;
        private System.Windows.Forms.Button cmd_Published2Zip;
        private System.Windows.Forms.RadioButton rB_v705;
        private System.Windows.Forms.RadioButton rB_v704;
        private System.Windows.Forms.RadioButton rB_v703;
        private System.Windows.Forms.RadioButton rB_v702;
        private System.Windows.Forms.Button cmd_SendTo;
        private System.Windows.Forms.Label lbl_SpecialName;
        private System.Windows.Forms.Label lbl_BuildNo;
        private System.Windows.Forms.TextBox txt_BuildNo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_publish;
        private System.Windows.Forms.Button btn_rebuild;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rB_v701;
        private System.Windows.Forms.RadioButton rB_v802;
        private System.Windows.Forms.GroupBox gb_Version;
        private System.Windows.Forms.GroupBox gb_BuildNo;
        private System.Windows.Forms.ComboBox cbo_SpecialName;
        private System.Windows.Forms.GroupBox gb_Publish;
    }
}