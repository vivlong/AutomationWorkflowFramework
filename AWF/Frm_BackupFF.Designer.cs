namespace AWF
{
    partial class Frm_BackupFF
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Backup_Folders_Start = new System.Windows.Forms.Button();
            this.txt_Backup_Folder_path = new System.Windows.Forms.TextBox();
            this.btn_Backup_Folders_Select = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.cmdSourceSendto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.cmdSourceSendto);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 421);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Backup_Folders_Start);
            this.groupBox2.Controls.Add(this.txt_Backup_Folder_path);
            this.groupBox2.Controls.Add(this.btn_Backup_Folders_Select);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 112);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup Folders";
            // 
            // btn_Backup_Folders_Start
            // 
            this.btn_Backup_Folders_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Backup_Folders_Start.Location = new System.Drawing.Point(383, 83);
            this.btn_Backup_Folders_Start.Name = "btn_Backup_Folders_Start";
            this.btn_Backup_Folders_Start.Size = new System.Drawing.Size(128, 23);
            this.btn_Backup_Folders_Start.TabIndex = 2;
            this.btn_Backup_Folders_Start.Text = "Start";
            this.btn_Backup_Folders_Start.UseVisualStyleBackColor = true;
            this.btn_Backup_Folders_Start.Click += new System.EventHandler(this.btn_Backup_Folders_Start_Click);
            // 
            // txt_Backup_Folder_path
            // 
            this.txt_Backup_Folder_path.Location = new System.Drawing.Point(6, 20);
            this.txt_Backup_Folder_path.Name = "txt_Backup_Folder_path";
            this.txt_Backup_Folder_path.ReadOnly = true;
            this.txt_Backup_Folder_path.Size = new System.Drawing.Size(505, 22);
            this.txt_Backup_Folder_path.TabIndex = 1;
            // 
            // btn_Backup_Folders_Select
            // 
            this.btn_Backup_Folders_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Backup_Folders_Select.Location = new System.Drawing.Point(6, 83);
            this.btn_Backup_Folders_Select.Name = "btn_Backup_Folders_Select";
            this.btn_Backup_Folders_Select.Size = new System.Drawing.Size(128, 23);
            this.btn_Backup_Folders_Select.TabIndex = 0;
            this.btn_Backup_Folders_Select.Text = "Pls select folder";
            this.btn_Backup_Folders_Select.UseVisualStyleBackColor = true;
            this.btn_Backup_Folders_Select.Click += new System.EventHandler(this.btn_Backup_Folders_Select_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 14);
            this.label6.TabIndex = 73;
            this.label6.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 72;
            this.label7.Text = "From ";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(430, 195);
            this.txtTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(79, 22);
            this.txtTo.TabIndex = 71;
            this.txtTo.Text = "131218";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(308, 195);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(79, 22);
            this.txtFrom.TabIndex = 70;
            this.txtFrom.Text = "131218";
            // 
            // cmdSourceSendto
            // 
            this.cmdSourceSendto.Location = new System.Drawing.Point(31, 195);
            this.cmdSourceSendto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSourceSendto.Name = "cmdSourceSendto";
            this.cmdSourceSendto.Size = new System.Drawing.Size(172, 31);
            this.cmdSourceSendto.TabIndex = 69;
            this.cmdSourceSendto.Text = " Backup/Send Source to 250";
            this.cmdSourceSendto.UseVisualStyleBackColor = true;
            this.cmdSourceSendto.Click += new System.EventHandler(this.cmdSourceSendto_Click);
            // 
            // FrmBackupFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 421);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmBackupFF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BackupFF";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Backup_Folders_Start;
        private System.Windows.Forms.TextBox txt_Backup_Folder_path;
        private System.Windows.Forms.Button btn_Backup_Folders_Select;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button cmdSourceSendto;
    }
}