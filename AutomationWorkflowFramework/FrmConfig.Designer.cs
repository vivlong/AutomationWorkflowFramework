﻿namespace AWF
{
    partial class FrmConfig
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDBFilePath = new System.Windows.Forms.TextBox();
            this.cmdSaveConfig = new System.Windows.Forms.Button();
            this.txtSkype = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDBFilePath);
            this.panel1.Controls.Add(this.cmdSaveConfig);
            this.panel1.Controls.Add(this.txtSkype);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 189);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 14);
            this.label2.TabIndex = 80;
            this.label2.Text = "The Path of Saved *.Bak Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 79;
            this.label1.Text = "Skype Users";
            // 
            // txtDBFilePath
            // 
            this.txtDBFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDBFilePath.Location = new System.Drawing.Point(220, 97);
            this.txtDBFilePath.Name = "txtDBFilePath";
            this.txtDBFilePath.Size = new System.Drawing.Size(454, 21);
            this.txtDBFilePath.TabIndex = 78;
            // 
            // cmdSaveConfig
            // 
            this.cmdSaveConfig.Location = new System.Drawing.Point(502, 124);
            this.cmdSaveConfig.Name = "cmdSaveConfig";
            this.cmdSaveConfig.Size = new System.Drawing.Size(172, 26);
            this.cmdSaveConfig.TabIndex = 76;
            this.cmdSaveConfig.Text = "Save Config";
            this.cmdSaveConfig.UseVisualStyleBackColor = true;
            this.cmdSaveConfig.Click += new System.EventHandler(this.cmdSaveConfig_Click);
            // 
            // txtSkype
            // 
            this.txtSkype.Location = new System.Drawing.Point(220, 12);
            this.txtSkype.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSkype.Multiline = true;
            this.txtSkype.Name = "txtSkype";
            this.txtSkype.Size = new System.Drawing.Size(454, 69);
            this.txtSkype.TabIndex = 75;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 189);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Testing";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSaveConfig;
        private System.Windows.Forms.TextBox txtSkype;
        private System.Windows.Forms.TextBox txtDBFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}