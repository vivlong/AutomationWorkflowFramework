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
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFormName = new System.Windows.Forms.TextBox();
            this.lbl_programmer = new System.Windows.Forms.Label();
            this.cbo_Programmer = new System.Windows.Forms.ComboBox();
            this.lbl_trackno = new System.Windows.Forms.Label();
            this.txt_TrackNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 252);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 26);
            this.button1.TabIndex = 90;
            this.button1.Text = "Auto Update Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 19);
            this.label8.TabIndex = 89;
            this.label8.Text = "Change Form Name";
            // 
            // txtFormName
            // 
            this.txtFormName.Location = new System.Drawing.Point(299, 223);
            this.txtFormName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFormName.Multiline = true;
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Size = new System.Drawing.Size(212, 55);
            this.txtFormName.TabIndex = 88;
            // 
            // lbl_programmer
            // 
            this.lbl_programmer.AutoSize = true;
            this.lbl_programmer.Location = new System.Drawing.Point(539, 180);
            this.lbl_programmer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_programmer.Name = "lbl_programmer";
            this.lbl_programmer.Size = new System.Drawing.Size(100, 19);
            this.lbl_programmer.TabIndex = 87;
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
            this.cbo_Programmer.Location = new System.Drawing.Point(680, 176);
            this.cbo_Programmer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Programmer.Name = "cbo_Programmer";
            this.cbo_Programmer.Size = new System.Drawing.Size(120, 27);
            this.cbo_Programmer.TabIndex = 86;
            this.cbo_Programmer.ValueMember = "Name";
            // 
            // lbl_trackno
            // 
            this.lbl_trackno.AutoSize = true;
            this.lbl_trackno.Location = new System.Drawing.Point(72, 176);
            this.lbl_trackno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trackno.Name = "lbl_trackno";
            this.lbl_trackno.Size = new System.Drawing.Size(174, 19);
            this.lbl_trackno.TabIndex = 85;
            this.lbl_trackno.Text = "需求编号 : （; 或 空格区分）";
            // 
            // txt_TrackNo
            // 
            this.txt_TrackNo.Location = new System.Drawing.Point(299, 176);
            this.txt_TrackNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TrackNo.Multiline = true;
            this.txt_TrackNo.Name = "txt_TrackNo";
            this.txt_TrackNo.Size = new System.Drawing.Size(212, 27);
            this.txt_TrackNo.TabIndex = 84;
            // 
            // Frm_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.lbl_programmer);
            this.Controls.Add(this.cbo_Programmer);
            this.Controls.Add(this.lbl_trackno);
            this.Controls.Add(this.txt_TrackNo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Publishing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFormName;
        private System.Windows.Forms.Label lbl_programmer;
        private System.Windows.Forms.ComboBox cbo_Programmer;
        private System.Windows.Forms.Label lbl_trackno;
        private System.Windows.Forms.TextBox txt_TrackNo;

    }
}