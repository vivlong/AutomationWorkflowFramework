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
            this.btn_UpdateRequest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_FormNames = new System.Windows.Forms.TextBox();
            this.lbl_programmer = new System.Windows.Forms.Label();
            this.cbo_Programmer = new System.Windows.Forms.ComboBox();
            this.lbl_trackno = new System.Windows.Forms.Label();
            this.txt_TrackNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_UpdateRequest);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_FormNames);
            this.panel1.Controls.Add(this.lbl_programmer);
            this.panel1.Controls.Add(this.cbo_Programmer);
            this.panel1.Controls.Add(this.lbl_trackno);
            this.panel1.Controls.Add(this.txt_TrackNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 454);
            this.panel1.TabIndex = 91;
            // 
            // btn_UpdateRequest
            // 
            this.btn_UpdateRequest.Location = new System.Drawing.Point(531, 103);
            this.btn_UpdateRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_UpdateRequest.Name = "btn_UpdateRequest";
            this.btn_UpdateRequest.Size = new System.Drawing.Size(219, 26);
            this.btn_UpdateRequest.TabIndex = 97;
            this.btn_UpdateRequest.Text = "Auto Update Request";
            this.btn_UpdateRequest.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 19);
            this.label8.TabIndex = 96;
            this.label8.Text = "Change Form Name";
            // 
            // txt_FormNames
            // 
            this.txt_FormNames.Location = new System.Drawing.Point(249, 74);
            this.txt_FormNames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_FormNames.Multiline = true;
            this.txt_FormNames.Name = "txt_FormNames";
            this.txt_FormNames.Size = new System.Drawing.Size(212, 55);
            this.txt_FormNames.TabIndex = 95;
            // 
            // lbl_programmer
            // 
            this.lbl_programmer.AutoSize = true;
            this.lbl_programmer.Location = new System.Drawing.Point(489, 31);
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
            this.cbo_Programmer.Location = new System.Drawing.Point(630, 27);
            this.cbo_Programmer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Programmer.Name = "cbo_Programmer";
            this.cbo_Programmer.Size = new System.Drawing.Size(120, 27);
            this.cbo_Programmer.TabIndex = 93;
            this.cbo_Programmer.ValueMember = "Name";
            // 
            // lbl_trackno
            // 
            this.lbl_trackno.AutoSize = true;
            this.lbl_trackno.Location = new System.Drawing.Point(22, 27);
            this.lbl_trackno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trackno.Name = "lbl_trackno";
            this.lbl_trackno.Size = new System.Drawing.Size(174, 19);
            this.lbl_trackno.TabIndex = 92;
            this.lbl_trackno.Text = "需求编号 : （; 或 空格区分）";
            // 
            // txt_TrackNo
            // 
            this.txt_TrackNo.Location = new System.Drawing.Point(249, 27);
            this.txt_TrackNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TrackNo.Multiline = true;
            this.txt_TrackNo.Name = "txt_TrackNo";
            this.txt_TrackNo.Size = new System.Drawing.Size(212, 27);
            this.txt_TrackNo.TabIndex = 91;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_UpdateRequest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_FormNames;
        private System.Windows.Forms.Label lbl_programmer;
        private System.Windows.Forms.ComboBox cbo_Programmer;
        private System.Windows.Forms.Label lbl_trackno;
        private System.Windows.Forms.TextBox txt_TrackNo;


    }
}