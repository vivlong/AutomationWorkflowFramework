namespace AWF
{
    partial class Frm_SQLTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SQLTool));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.cmdAddDatabase = new System.Windows.Forms.Button();
            this.cboDatabseList = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmd_SaveNode = new System.Windows.Forms.Button();
            this.cmdSQL = new System.Windows.Forms.Button();
            this.cmdFindText = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Button3);
            this.panel1.Controls.Add(this.Button2);
            this.panel1.Controls.Add(this.cmdAddDatabase);
            this.panel1.Controls.Add(this.cboDatabseList);
            this.panel1.Controls.Add(this.Label4);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.txtServer);
            this.panel1.Controls.Add(this.Label5);
            this.panel1.Controls.Add(this.RichTextBox1);
            this.panel1.Controls.Add(this.TextBox1);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.cmd_SaveNode);
            this.panel1.Controls.Add(this.cmdSQL);
            this.panel1.Controls.Add(this.cmdFindText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 280);
            this.panel1.TabIndex = 0;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(284, 12);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(146, 24);
            this.Button3.TabIndex = 45;
            this.Button3.Text = "Insert Text to MultiLine";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(174, 12);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(95, 24);
            this.Button2.TabIndex = 44;
            this.Button2.Text = "Back Up";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Visible = false;
            // 
            // cmdAddDatabase
            // 
            this.cmdAddDatabase.Location = new System.Drawing.Point(12, 74);
            this.cmdAddDatabase.Name = "cmdAddDatabase";
            this.cmdAddDatabase.Size = new System.Drawing.Size(153, 24);
            this.cmdAddDatabase.TabIndex = 43;
            this.cmdAddDatabase.Text = "Add Database";
            this.cmdAddDatabase.UseVisualStyleBackColor = true;
            this.cmdAddDatabase.Click += new System.EventHandler(this.cmdAddDatabase_Click);
            // 
            // cboDatabseList
            // 
            this.cboDatabseList.FormattingEnabled = true;
            this.cboDatabseList.Location = new System.Drawing.Point(245, 74);
            this.cboDatabseList.Name = "cboDatabseList";
            this.cboDatabseList.Size = new System.Drawing.Size(123, 22);
            this.cboDatabseList.TabIndex = 39;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(224, 47);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 14);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "User ID";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(361, 47);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 14);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Password";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(171, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 14);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "Database";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(436, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(115, 22);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.Text = "p@ssw0rd$";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(284, 44);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(71, 22);
            this.txtUserID.TabIndex = 37;
            this.txtUserID.Text = "sa";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(93, 44);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(125, 22);
            this.txtServer.TabIndex = 36;
            this.txtServer.Text = "192.168.0.230";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(9, 47);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(70, 14);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "sql Server";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox1.Location = new System.Drawing.Point(11, 136);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBox1.Size = new System.Drawing.Size(540, 132);
            this.RichTextBox1.TabIndex = 34;
            this.RichTextBox1.Text = "";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(93, 106);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(176, 22);
            this.TextBox1.TabIndex = 33;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 109);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 14);
            this.Label1.TabIndex = 32;
            this.Label1.Text = "Node Name";
            // 
            // cmd_SaveNode
            // 
            this.cmd_SaveNode.Location = new System.Drawing.Point(284, 105);
            this.cmd_SaveNode.Name = "cmd_SaveNode";
            this.cmd_SaveNode.Size = new System.Drawing.Size(84, 24);
            this.cmd_SaveNode.TabIndex = 31;
            this.cmd_SaveNode.Text = "save Node Script";
            this.cmd_SaveNode.UseVisualStyleBackColor = true;
            this.cmd_SaveNode.Click += new System.EventHandler(this.cmd_SaveNode_Click);
            // 
            // cmdSQL
            // 
            this.cmdSQL.Location = new System.Drawing.Point(93, 12);
            this.cmdSQL.Name = "cmdSQL";
            this.cmdSQL.Size = new System.Drawing.Size(75, 24);
            this.cmdSQL.TabIndex = 30;
            this.cmdSQL.Text = "SQL";
            this.cmdSQL.UseVisualStyleBackColor = true;
            // 
            // cmdFindText
            // 
            this.cmdFindText.Location = new System.Drawing.Point(12, 12);
            this.cmdFindText.Name = "cmdFindText";
            this.cmdFindText.Size = new System.Drawing.Size(75, 24);
            this.cmdFindText.TabIndex = 29;
            this.cmdFindText.Text = resources.GetString("cmdFindText.Text");
            this.cmdFindText.UseVisualStyleBackColor = true;
            // 
            // Frm_SQLTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 280);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_SQLTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SearchFieldForText";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button cmdAddDatabase;
        internal System.Windows.Forms.ComboBox cboDatabseList;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUserID;
        internal System.Windows.Forms.TextBox txtServer;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button cmd_SaveNode;
        internal System.Windows.Forms.Button cmdSQL;
        internal System.Windows.Forms.Button cmdFindText;
    }
}