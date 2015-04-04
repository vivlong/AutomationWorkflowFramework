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
            this.cmd_CreatFolder = new System.Windows.Forms.Button();
            this.cmd_Open = new System.Windows.Forms.Button();
            this.cmdPublished2Zip = new System.Windows.Forms.Button();
            this.cmdSendTo = new System.Windows.Forms.Button();
            this.cmdSelectFolder = new System.Windows.Forms.Button();
            this.cmdBackUp = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btn_rebuild = new System.Windows.Forms.Button();
            this.btn_publish = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gb_BuildNo = new System.Windows.Forms.GroupBox();
            this.cbo_SpecialName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.gb_Publish.Controls.Add(this.cmd_CreatFolder);
            this.gb_Publish.Controls.Add(this.cmd_Open);
            this.gb_Publish.Controls.Add(this.cmdPublished2Zip);
            this.gb_Publish.Controls.Add(this.cmdSendTo);
            this.gb_Publish.Controls.Add(this.cmdSelectFolder);
            this.gb_Publish.Controls.Add(this.cmdBackUp);
            this.gb_Publish.Controls.Add(this.txtFolder);
            this.gb_Publish.Controls.Add(this.btn_rebuild);
            this.gb_Publish.Controls.Add(this.btn_publish);
            this.gb_Publish.Controls.Add(this.progressBar1);
            this.gb_Publish.Location = new System.Drawing.Point(12, 126);
            this.gb_Publish.Name = "gb_Publish";
            this.gb_Publish.Size = new System.Drawing.Size(849, 225);
            this.gb_Publish.TabIndex = 86;
            this.gb_Publish.TabStop = false;
            this.gb_Publish.Text = "发布版本";
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
            this.cmd_CreatFolder.Click += new System.EventHandler(this.cmdCreatFolder_Click);
            // 
            // cmd_Open
            // 
            this.cmd_Open.Location = new System.Drawing.Point(333, 24);
            this.cmd_Open.Margin = new System.Windows.Forms.Padding(4);
            this.cmd_Open.Name = "cmd_Open";
            this.cmd_Open.Size = new System.Drawing.Size(212, 31);
            this.cmd_Open.TabIndex = 58;
            this.cmd_Open.Text = "打开 当前版本文件夹";
            this.cmd_Open.UseVisualStyleBackColor = true;
            this.cmd_Open.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmdPublished2Zip
            // 
            this.cmdPublished2Zip.Location = new System.Drawing.Point(74, 104);
            this.cmdPublished2Zip.Margin = new System.Windows.Forms.Padding(4);
            this.cmdPublished2Zip.Name = "cmdPublished2Zip";
            this.cmdPublished2Zip.Size = new System.Drawing.Size(212, 31);
            this.cmdPublished2Zip.TabIndex = 52;
            this.cmdPublished2Zip.Text = "打包发布的文件至部署文件夹";
            this.cmdPublished2Zip.UseVisualStyleBackColor = true;
            this.cmdPublished2Zip.Click += new System.EventHandler(this.cmdPublished2Zip_Click);
            // 
            // cmdSendTo
            // 
            this.cmdSendTo.Location = new System.Drawing.Point(333, 104);
            this.cmdSendTo.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSendTo.Name = "cmdSendTo";
            this.cmdSendTo.Size = new System.Drawing.Size(212, 31);
            this.cmdSendTo.TabIndex = 53;
            this.cmdSendTo.Text = "将部署文件夹发送至250";
            this.cmdSendTo.UseVisualStyleBackColor = true;
            this.cmdSendTo.Click += new System.EventHandler(this.cmdSendTo_Click);
            // 
            // cmdSelectFolder
            // 
            this.cmdSelectFolder.Location = new System.Drawing.Point(74, 144);
            this.cmdSelectFolder.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSelectFolder.Name = "cmdSelectFolder";
            this.cmdSelectFolder.Size = new System.Drawing.Size(212, 31);
            this.cmdSelectFolder.TabIndex = 61;
            this.cmdSelectFolder.Text = "选择要压缩的文件夹";
            this.cmdSelectFolder.UseVisualStyleBackColor = true;
            this.cmdSelectFolder.Click += new System.EventHandler(this.cmdSelectFolder_Click);
            // 
            // cmdBackUp
            // 
            this.cmdBackUp.Location = new System.Drawing.Point(74, 184);
            this.cmdBackUp.Margin = new System.Windows.Forms.Padding(4);
            this.cmdBackUp.Name = "cmdBackUp";
            this.cmdBackUp.Size = new System.Drawing.Size(212, 31);
            this.cmdBackUp.TabIndex = 60;
            this.cmdBackUp.Text = "备份源码";
            this.cmdBackUp.UseVisualStyleBackColor = true;
            this.cmdBackUp.Click += new System.EventHandler(this.cmdBackUp_Click);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(247, 95);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 42);
            this.progressBar1.TabIndex = 63;
            this.progressBar1.Visible = false;
            // 
            // gb_BuildNo
            // 
            this.gb_BuildNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_BuildNo.Controls.Add(this.cbo_SpecialName);
            this.gb_BuildNo.Controls.Add(this.label1);
            this.gb_BuildNo.Controls.Add(this.txtVer);
            this.gb_BuildNo.Controls.Add(this.label2);
            this.gb_BuildNo.Location = new System.Drawing.Point(12, 69);
            this.gb_BuildNo.Name = "gb_BuildNo";
            this.gb_BuildNo.Size = new System.Drawing.Size(849, 55);
            this.gb_BuildNo.TabIndex = 85;
            this.gb_BuildNo.TabStop = false;
            this.gb_BuildNo.Text = "确认版本号";
            // 
            // cbo_SpecialName
            // 
            this.cbo_SpecialName.FormattingEnabled = true;
            this.cbo_SpecialName.Location = new System.Drawing.Point(473, 18);
            this.cbo_SpecialName.Name = "cbo_SpecialName";
            this.cbo_SpecialName.Size = new System.Drawing.Size(257, 27);
            this.cbo_SpecialName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Build No.";
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(220, 20);
            this.txtVer.Margin = new System.Windows.Forms.Padding(4);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(103, 24);
            this.txtVer.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "特殊版本名称";
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
            this.rB_v706.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
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
            this.rB_v701.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
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
            this.rB_v702.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
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
            this.rB_v703.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
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
            this.rB_v802.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
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
            this.rB_v704.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
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
            this.rB_v705.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
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
            this.rB_v801.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
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
        private System.Windows.Forms.Button cmdSelectFolder;
        private System.Windows.Forms.Button cmdBackUp;
        private System.Windows.Forms.RadioButton rB_v801;
        private System.Windows.Forms.Button cmd_Open;
        private System.Windows.Forms.Button cmd_CreatFolder;
        private System.Windows.Forms.RadioButton rB_v706;
        private System.Windows.Forms.Button cmdPublished2Zip;
        private System.Windows.Forms.RadioButton rB_v705;
        private System.Windows.Forms.RadioButton rB_v704;
        private System.Windows.Forms.RadioButton rB_v703;
        private System.Windows.Forms.RadioButton rB_v702;
        private System.Windows.Forms.Button cmdSendTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVer;
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