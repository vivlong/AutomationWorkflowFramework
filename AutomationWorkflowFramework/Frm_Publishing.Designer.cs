namespace DeveloperTools
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
            this.rB_v802 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_programmer = new System.Windows.Forms.Label();
            this.cbo_Programmer = new System.Windows.Forms.ComboBox();
            this.lbl_trackno = new System.Windows.Forms.Label();
            this.txt_TrackNo = new System.Windows.Forms.TextBox();
            this.btn_DownloadRequestXls = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_publish = new System.Windows.Forms.Button();
            this.btn_rebuild = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.cmdSourceSendto = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.cmdSelectFolder = new System.Windows.Forms.Button();
            this.cmdBackUp = new System.Windows.Forms.Button();
            this.rB_v801 = new System.Windows.Forms.RadioButton();
            this.cmd_Open = new System.Windows.Forms.Button();
            this.cmd_CreatFolder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdPublished2Zip = new System.Windows.Forms.Button();
            this.v75 = new System.Windows.Forms.RadioButton();
            this.rB_v704 = new System.Windows.Forms.RadioButton();
            this.rB_v703 = new System.Windows.Forms.RadioButton();
            this.rB_v702 = new System.Windows.Forms.RadioButton();
            this.cmdSendTo = new System.Windows.Forms.Button();
            this.txt_SpecialName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.v71 = new System.Windows.Forms.RadioButton();
            this.v76 = new System.Windows.Forms.RadioButton();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtFormName);
            this.panel1.Controls.Add(this.rB_v802);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lbl_programmer);
            this.panel1.Controls.Add(this.cbo_Programmer);
            this.panel1.Controls.Add(this.lbl_trackno);
            this.panel1.Controls.Add(this.txt_TrackNo);
            this.panel1.Controls.Add(this.btn_DownloadRequestXls);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_publish);
            this.panel1.Controls.Add(this.btn_rebuild);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.cmdSourceSendto);
            this.panel1.Controls.Add(this.txtFolder);
            this.panel1.Controls.Add(this.cmdSelectFolder);
            this.panel1.Controls.Add(this.cmdBackUp);
            this.panel1.Controls.Add(this.rB_v801);
            this.panel1.Controls.Add(this.cmd_Open);
            this.panel1.Controls.Add(this.cmd_CreatFolder);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmdPublished2Zip);
            this.panel1.Controls.Add(this.v75);
            this.panel1.Controls.Add(this.rB_v704);
            this.panel1.Controls.Add(this.rB_v703);
            this.panel1.Controls.Add(this.rB_v702);
            this.panel1.Controls.Add(this.cmdSendTo);
            this.panel1.Controls.Add(this.txt_SpecialName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtVer);
            this.panel1.Controls.Add(this.v71);
            this.panel1.Controls.Add(this.v76);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 410);
            this.panel1.TabIndex = 0;
            // 
            // rB_v802
            // 
            this.rB_v802.AutoSize = true;
            this.rB_v802.Location = new System.Drawing.Point(658, 9);
            this.rB_v802.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rB_v802.Name = "rB_v802";
            this.rB_v802.Size = new System.Drawing.Size(84, 21);
            this.rB_v802.TabIndex = 80;
            this.rB_v802.TabStop = true;
            this.rB_v802.Text = "Ver 8.0.2";
            this.rB_v802.UseVisualStyleBackColor = true;
            this.rB_v802.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(244, 263);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(330, 35);
            this.progressBar1.TabIndex = 63;
            this.progressBar1.Visible = false;
            // 
            // lbl_programmer
            // 
            this.lbl_programmer.AutoSize = true;
            this.lbl_programmer.Location = new System.Drawing.Point(482, 111);
            this.lbl_programmer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_programmer.Name = "lbl_programmer";
            this.lbl_programmer.Size = new System.Drawing.Size(94, 17);
            this.lbl_programmer.TabIndex = 79;
            this.lbl_programmer.Text = "Programmer :";
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
            this.cbo_Programmer.Location = new System.Drawing.Point(622, 108);
            this.cbo_Programmer.Name = "cbo_Programmer";
            this.cbo_Programmer.Size = new System.Drawing.Size(120, 24);
            this.cbo_Programmer.TabIndex = 78;
            this.cbo_Programmer.ValueMember = "Name";
            // 
            // lbl_trackno
            // 
            this.lbl_trackno.AutoSize = true;
            this.lbl_trackno.Location = new System.Drawing.Point(14, 111);
            this.lbl_trackno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trackno.Name = "lbl_trackno";
            this.lbl_trackno.Size = new System.Drawing.Size(171, 17);
            this.lbl_trackno.TabIndex = 77;
            this.lbl_trackno.Text = "Track No : （; or Space）";
            // 
            // txt_TrackNo
            // 
            this.txt_TrackNo.Location = new System.Drawing.Point(241, 108);
            this.txt_TrackNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TrackNo.Multiline = true;
            this.txt_TrackNo.Name = "txt_TrackNo";
            this.txt_TrackNo.Size = new System.Drawing.Size(212, 55);
            this.txt_TrackNo.TabIndex = 76;
            // 
            // btn_DownloadRequestXls
            // 
            this.btn_DownloadRequestXls.Location = new System.Drawing.Point(523, 138);
            this.btn_DownloadRequestXls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DownloadRequestXls.Name = "btn_DownloadRequestXls";
            this.btn_DownloadRequestXls.Size = new System.Drawing.Size(219, 26);
            this.btn_DownloadRequestXls.TabIndex = 75;
            this.btn_DownloadRequestXls.Text = "Auto Export XLS to Folder";
            this.btn_DownloadRequestXls.UseVisualStyleBackColor = true;
            this.btn_DownloadRequestXls.Click += new System.EventHandler(this.btn_DownloadRequestXls_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(757, 354);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(543, 228);
            this.textBox1.TabIndex = 71;
            this.textBox1.Visible = false;
            // 
            // btn_publish
            // 
            this.btn_publish.Enabled = false;
            this.btn_publish.Location = new System.Drawing.Point(20, 263);
            this.btn_publish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_publish.Name = "btn_publish";
            this.btn_publish.Size = new System.Drawing.Size(172, 26);
            this.btn_publish.TabIndex = 70;
            this.btn_publish.Text = "Publish Deploy";
            this.btn_publish.UseVisualStyleBackColor = true;
            this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
            // 
            // btn_rebuild
            // 
            this.btn_rebuild.Enabled = false;
            this.btn_rebuild.Location = new System.Drawing.Point(17, 230);
            this.btn_rebuild.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_rebuild.Name = "btn_rebuild";
            this.btn_rebuild.Size = new System.Drawing.Size(172, 26);
            this.btn_rebuild.TabIndex = 69;
            this.btn_rebuild.Text = "Rebuild All";
            this.btn_rebuild.UseVisualStyleBackColor = true;
            this.btn_rebuild.Click += new System.EventHandler(this.btn_rebuild_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "From ";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(419, 336);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(79, 23);
            this.txtTo.TabIndex = 66;
            this.txtTo.Text = "131218";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(297, 336);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(79, 23);
            this.txtFrom.TabIndex = 65;
            this.txtFrom.Text = "131218";
            // 
            // cmdSourceSendto
            // 
            this.cmdSourceSendto.Location = new System.Drawing.Point(20, 336);
            this.cmdSourceSendto.Name = "cmdSourceSendto";
            this.cmdSourceSendto.Size = new System.Drawing.Size(172, 26);
            this.cmdSourceSendto.TabIndex = 64;
            this.cmdSourceSendto.Text = " Backup/Send Source to 250";
            this.cmdSourceSendto.UseVisualStyleBackColor = true;
            this.cmdSourceSendto.Click += new System.EventHandler(this.cmdSourceSendto_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(244, 304);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(501, 23);
            this.txtFolder.TabIndex = 62;
            // 
            // cmdSelectFolder
            // 
            this.cmdSelectFolder.Location = new System.Drawing.Point(20, 302);
            this.cmdSelectFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSelectFolder.Name = "cmdSelectFolder";
            this.cmdSelectFolder.Size = new System.Drawing.Size(172, 26);
            this.cmdSelectFolder.TabIndex = 61;
            this.cmdSelectFolder.Text = "Select Folder To ZIP";
            this.cmdSelectFolder.UseVisualStyleBackColor = true;
            this.cmdSelectFolder.Click += new System.EventHandler(this.cmdSelectFolder_Click);
            // 
            // cmdBackUp
            // 
            this.cmdBackUp.Location = new System.Drawing.Point(551, 333);
            this.cmdBackUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdBackUp.Name = "cmdBackUp";
            this.cmdBackUp.Size = new System.Drawing.Size(194, 26);
            this.cmdBackUp.TabIndex = 60;
            this.cmdBackUp.Text = "BackUp SourceCode";
            this.cmdBackUp.UseVisualStyleBackColor = true;
            this.cmdBackUp.Click += new System.EventHandler(this.cmdBackUp_Click);
            // 
            // rB_v801
            // 
            this.rB_v801.AutoSize = true;
            this.rB_v801.Location = new System.Drawing.Point(549, 9);
            this.rB_v801.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rB_v801.Name = "rB_v801";
            this.rB_v801.Size = new System.Drawing.Size(84, 21);
            this.rB_v801.TabIndex = 59;
            this.rB_v801.TabStop = true;
            this.rB_v801.Text = "Ver 8.0.1";
            this.rB_v801.UseVisualStyleBackColor = true;
            this.rB_v801.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
            // 
            // cmd_Open
            // 
            this.cmd_Open.Location = new System.Drawing.Point(564, 76);
            this.cmd_Open.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_Open.Name = "cmd_Open";
            this.cmd_Open.Size = new System.Drawing.Size(178, 26);
            this.cmd_Open.TabIndex = 58;
            this.cmd_Open.Text = "Open EXCEL Folder";
            this.cmd_Open.UseVisualStyleBackColor = true;
            this.cmd_Open.Click += new System.EventHandler(this.cmdOpen_Click);
            // 
            // cmd_CreatFolder
            // 
            this.cmd_CreatFolder.Location = new System.Drawing.Point(241, 76);
            this.cmd_CreatFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmd_CreatFolder.Name = "cmd_CreatFolder";
            this.cmd_CreatFolder.Size = new System.Drawing.Size(289, 26);
            this.cmd_CreatFolder.TabIndex = 57;
            this.cmd_CreatFolder.Text = "Create Current Version EXCEL Folder";
            this.cmd_CreatFolder.UseVisualStyleBackColor = true;
            this.cmd_CreatFolder.Click += new System.EventHandler(this.cmdCreatFolder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Step 3: One by one click";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 34);
            this.label4.TabIndex = 55;
            this.label4.Text = "Step 2 : Enter BuildNo\r\n              and Other Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Step 1 : Select Version";
            // 
            // cmdPublished2Zip
            // 
            this.cmdPublished2Zip.Location = new System.Drawing.Point(241, 231);
            this.cmdPublished2Zip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdPublished2Zip.Name = "cmdPublished2Zip";
            this.cmdPublished2Zip.Size = new System.Drawing.Size(212, 26);
            this.cmdPublished2Zip.TabIndex = 52;
            this.cmdPublished2Zip.Text = "Get Published to Zip";
            this.cmdPublished2Zip.UseVisualStyleBackColor = true;
            this.cmdPublished2Zip.Click += new System.EventHandler(this.cmdPublished2Zip_Click);
            // 
            // v75
            // 
            this.v75.AutoSize = true;
            this.v75.Location = new System.Drawing.Point(549, 9);
            this.v75.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.v75.Name = "v75";
            this.v75.Size = new System.Drawing.Size(84, 21);
            this.v75.TabIndex = 48;
            this.v75.TabStop = true;
            this.v75.Text = "Ver 7.0.5";
            this.v75.UseVisualStyleBackColor = true;
            this.v75.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
            // 
            // rB_v704
            // 
            this.rB_v704.AutoSize = true;
            this.rB_v704.Location = new System.Drawing.Point(440, 9);
            this.rB_v704.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rB_v704.Name = "rB_v704";
            this.rB_v704.Size = new System.Drawing.Size(84, 21);
            this.rB_v704.TabIndex = 47;
            this.rB_v704.TabStop = true;
            this.rB_v704.Text = "Ver 7.0.4";
            this.rB_v704.UseVisualStyleBackColor = true;
            this.rB_v704.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
            // 
            // rB_v703
            // 
            this.rB_v703.AutoSize = true;
            this.rB_v703.Location = new System.Drawing.Point(331, 9);
            this.rB_v703.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rB_v703.Name = "rB_v703";
            this.rB_v703.Size = new System.Drawing.Size(84, 21);
            this.rB_v703.TabIndex = 45;
            this.rB_v703.TabStop = true;
            this.rB_v703.Text = "Ver 7.0.3";
            this.rB_v703.UseVisualStyleBackColor = true;
            this.rB_v703.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
            // 
            // rB_v702
            // 
            this.rB_v702.AutoSize = true;
            this.rB_v702.Location = new System.Drawing.Point(222, 9);
            this.rB_v702.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rB_v702.Name = "rB_v702";
            this.rB_v702.Size = new System.Drawing.Size(84, 21);
            this.rB_v702.TabIndex = 43;
            this.rB_v702.TabStop = true;
            this.rB_v702.Text = "Ver 7.0.2";
            this.rB_v702.UseVisualStyleBackColor = true;
            this.rB_v702.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
            // 
            // cmdSendTo
            // 
            this.cmdSendTo.Location = new System.Drawing.Point(523, 231);
            this.cmdSendTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSendTo.Name = "cmdSendTo";
            this.cmdSendTo.Size = new System.Drawing.Size(219, 26);
            this.cmdSendTo.TabIndex = 53;
            this.cmdSendTo.Text = "Send Updated to 250";
            this.cmdSendTo.UseVisualStyleBackColor = true;
            this.cmdSendTo.Click += new System.EventHandler(this.cmdSendTo_Click);
            // 
            // txt_SpecialName
            // 
            this.txt_SpecialName.Location = new System.Drawing.Point(591, 38);
            this.txt_SpecialName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_SpecialName.Name = "txt_SpecialName";
            this.txt_SpecialName.Size = new System.Drawing.Size(151, 23);
            this.txt_SpecialName.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Special Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Build No.";
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(326, 38);
            this.txtVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(103, 23);
            this.txtVer.TabIndex = 50;
            // 
            // v71
            // 
            this.v71.AutoSize = true;
            this.v71.Location = new System.Drawing.Point(222, 9);
            this.v71.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.v71.Name = "v71";
            this.v71.Size = new System.Drawing.Size(84, 21);
            this.v71.TabIndex = 42;
            this.v71.TabStop = true;
            this.v71.Text = "Ver 7.0.1";
            this.v71.UseVisualStyleBackColor = true;
            this.v71.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
            // 
            // v76
            // 
            this.v76.AutoSize = true;
            this.v76.Location = new System.Drawing.Point(440, 9);
            this.v76.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.v76.Name = "v76";
            this.v76.Size = new System.Drawing.Size(84, 21);
            this.v76.TabIndex = 49;
            this.v76.TabStop = true;
            this.v76.Text = "Ver 7.0.6";
            this.v76.UseVisualStyleBackColor = true;
            this.v76.CheckedChanged += new System.EventHandler(this.version_CheckedChanged);
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(241, 164);
            this.txtFormName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFormName.Multiline = true;
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(212, 55);
            this.txtFormName.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 82;
            this.label8.Text = "Change Form Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 26);
            this.button1.TabIndex = 83;
            this.button1.Text = "Auto Update Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Publishing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 410);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Publishing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Publishing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton v76;
        private System.Windows.Forms.Button cmdPublished2Zip;
        private System.Windows.Forms.RadioButton v75;
        private System.Windows.Forms.RadioButton rB_v704;
        private System.Windows.Forms.RadioButton rB_v703;
        private System.Windows.Forms.RadioButton rB_v702;
        private System.Windows.Forms.Button cmdSendTo;
        private System.Windows.Forms.TextBox txt_SpecialName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button cmdSourceSendto;
        private System.Windows.Forms.Button btn_publish;
        private System.Windows.Forms.Button btn_rebuild;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_DownloadRequestXls;
        private System.Windows.Forms.RadioButton v71;
        private System.Windows.Forms.Label lbl_trackno;
        private System.Windows.Forms.TextBox txt_TrackNo;
        private System.Windows.Forms.Label lbl_programmer;
        private System.Windows.Forms.ComboBox cbo_Programmer;
        private System.Windows.Forms.RadioButton rB_v802;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFormName;
    }
}