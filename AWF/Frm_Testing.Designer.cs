namespace AWF
{
    partial class Frm_Testing
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
      this.btn_GenPureNum = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txt_length = new System.Windows.Forms.TextBox();
      this.btn_GenPureLetters = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Transparent;
      this.panel1.Controls.Add(this.btn_GenPureNum);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.txt_length);
      this.panel1.Controls.Add(this.btn_GenPureLetters);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(502, 328);
      this.panel1.TabIndex = 0;
      // 
      // btn_GenPureNum
      // 
      this.btn_GenPureNum.Location = new System.Drawing.Point(167, 38);
      this.btn_GenPureNum.Name = "btn_GenPureNum";
      this.btn_GenPureNum.Size = new System.Drawing.Size(138, 23);
      this.btn_GenPureNum.TabIndex = 3;
      this.btn_GenPureNum.Text = "Gen Pure Numbers";
      this.btn_GenPureNum.UseVisualStyleBackColor = true;
      this.btn_GenPureNum.Click += new System.EventHandler(this.btn_GenPureNum_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 14);
      this.label1.TabIndex = 2;
      this.label1.Text = "Length:";
      // 
      // txt_length
      // 
      this.txt_length.Location = new System.Drawing.Point(74, 10);
      this.txt_length.Name = "txt_length";
      this.txt_length.Size = new System.Drawing.Size(87, 22);
      this.txt_length.TabIndex = 1;
      this.txt_length.Text = "255";
      // 
      // btn_GenPureLetters
      // 
      this.btn_GenPureLetters.Location = new System.Drawing.Point(167, 9);
      this.btn_GenPureLetters.Name = "btn_GenPureLetters";
      this.btn_GenPureLetters.Size = new System.Drawing.Size(138, 23);
      this.btn_GenPureLetters.TabIndex = 0;
      this.btn_GenPureLetters.Text = "Gen Pure Letters";
      this.btn_GenPureLetters.UseVisualStyleBackColor = true;
      this.btn_GenPureLetters.Click += new System.EventHandler(this.btn_GenPureLetters_Click);
      // 
      // Frm_Testing
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(502, 328);
      this.Controls.Add(this.panel1);
      this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "Frm_Testing";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Frm_Testing";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_GenPureLetters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.Button btn_GenPureNum;
    }
}