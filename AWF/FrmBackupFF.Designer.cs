namespace AWF
{
    partial class FrmBackupFF
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
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 136);
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
            // Frm_BackupFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 136);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_BackupFF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_BackupFF";
            this.panel1.ResumeLayout(false);
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
    }
}