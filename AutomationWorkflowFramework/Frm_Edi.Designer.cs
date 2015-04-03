namespace AWF
{
    partial class Frm_Edi
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
            this.gBox_EDI = new System.Windows.Forms.GroupBox();
            this.btn_EDI_Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gBox_EDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.gBox_EDI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 136);
            this.panel1.TabIndex = 0;
            // 
            // gBox_EDI
            // 
            this.gBox_EDI.Controls.Add(this.btn_EDI_Start);
            this.gBox_EDI.Controls.Add(this.textBox1);
            this.gBox_EDI.Controls.Add(this.button2);
            this.gBox_EDI.Location = new System.Drawing.Point(16, 14);
            this.gBox_EDI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gBox_EDI.Name = "gBox_EDI";
            this.gBox_EDI.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gBox_EDI.Size = new System.Drawing.Size(509, 101);
            this.gBox_EDI.TabIndex = 2;
            this.gBox_EDI.TabStop = false;
            this.gBox_EDI.Text = "EDI Folder";
            // 
            // btn_EDI_Start
            // 
            this.btn_EDI_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EDI_Start.Location = new System.Drawing.Point(319, 65);
            this.btn_EDI_Start.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_EDI_Start.Name = "btn_EDI_Start";
            this.btn_EDI_Start.Size = new System.Drawing.Size(171, 27);
            this.btn_EDI_Start.TabIndex = 2;
            this.btn_EDI_Start.Text = "Start";
            this.btn_EDI_Start.UseVisualStyleBackColor = true;
            this.btn_EDI_Start.Click += new System.EventHandler(this.btn_EDI_Start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(481, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "D:\\Other";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 65);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Pls select folder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Frm_EDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 136);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_EDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EDI";
            this.panel1.ResumeLayout(false);
            this.gBox_EDI.ResumeLayout(false);
            this.gBox_EDI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gBox_EDI;
        private System.Windows.Forms.Button btn_EDI_Start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}