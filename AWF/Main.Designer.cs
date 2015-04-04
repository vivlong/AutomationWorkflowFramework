namespace AWF
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel_banner = new System.Windows.Forms.Panel();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.btn_Menu10 = new System.Windows.Forms.Button();
            this.btn_Menu9 = new System.Windows.Forms.Button();
            this.btn_Menu8 = new System.Windows.Forms.Button();
            this.btn_Menu7 = new System.Windows.Forms.Button();
            this.btn_Menu6 = new System.Windows.Forms.Button();
            this.btn_Menu5 = new System.Windows.Forms.Button();
            this.btn_Menu4 = new System.Windows.Forms.Button();
            this.btn_Menu3 = new System.Windows.Forms.Button();
            this.btn_Menu2 = new System.Windows.Forms.Button();
            this.btn_Menu1 = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panel_Form = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_banner.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AllowMerge = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "IP Address";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel3.Text = "Datetime";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_banner);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_Form);
            this.splitContainer1.Size = new System.Drawing.Size(896, 531);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel_banner
            // 
            this.panel_banner.BackColor = System.Drawing.Color.Transparent;
            this.panel_banner.BackgroundImage = global::AWF.Properties.Resources.devFreight2;
            this.panel_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_banner.Controls.Add(this.panel_Menu);
            this.panel_banner.Controls.Add(this.lbl_Title);
            this.panel_banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_banner.Location = new System.Drawing.Point(0, 0);
            this.panel_banner.Name = "panel_banner";
            this.panel_banner.Size = new System.Drawing.Size(896, 88);
            this.panel_banner.TabIndex = 3;
            // 
            // panel_Menu
            // 
            this.panel_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.panel_Menu.Controls.Add(this.btn_Menu10);
            this.panel_Menu.Controls.Add(this.btn_Menu9);
            this.panel_Menu.Controls.Add(this.btn_Menu8);
            this.panel_Menu.Controls.Add(this.btn_Menu7);
            this.panel_Menu.Controls.Add(this.btn_Menu6);
            this.panel_Menu.Controls.Add(this.btn_Menu5);
            this.panel_Menu.Controls.Add(this.btn_Menu4);
            this.panel_Menu.Controls.Add(this.btn_Menu3);
            this.panel_Menu.Controls.Add(this.btn_Menu2);
            this.panel_Menu.Controls.Add(this.btn_Menu1);
            this.panel_Menu.Location = new System.Drawing.Point(346, 4);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(550, 77);
            this.panel_Menu.TabIndex = 23;
            // 
            // btn_Menu10
            // 
            this.btn_Menu10.BackColor = System.Drawing.Color.Black;
            this.btn_Menu10.CausesValidation = false;
            this.btn_Menu10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu10.FlatAppearance.BorderSize = 0;
            this.btn_Menu10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu10.ForeColor = System.Drawing.Color.White;
            this.btn_Menu10.Location = new System.Drawing.Point(455, 6);
            this.btn_Menu10.Name = "btn_Menu10";
            this.btn_Menu10.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu10.TabIndex = 19;
            this.btn_Menu10.Text = "配置";
            this.btn_Menu10.UseVisualStyleBackColor = false;
            // 
            // btn_Menu9
            // 
            this.btn_Menu9.BackColor = System.Drawing.Color.White;
            this.btn_Menu9.CausesValidation = false;
            this.btn_Menu9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu9.FlatAppearance.BorderSize = 0;
            this.btn_Menu9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu9.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu9.Location = new System.Drawing.Point(405, 6);
            this.btn_Menu9.Name = "btn_Menu9";
            this.btn_Menu9.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu9.TabIndex = 18;
            this.btn_Menu9.Text = "PC信息";
            this.btn_Menu9.UseVisualStyleBackColor = false;
            // 
            // btn_Menu8
            // 
            this.btn_Menu8.BackColor = System.Drawing.Color.Silver;
            this.btn_Menu8.CausesValidation = false;
            this.btn_Menu8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu8.FlatAppearance.BorderSize = 0;
            this.btn_Menu8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu8.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu8.Location = new System.Drawing.Point(355, 6);
            this.btn_Menu8.Name = "btn_Menu8";
            this.btn_Menu8.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu8.TabIndex = 17;
            this.btn_Menu8.Text = "云存储";
            this.btn_Menu8.UseVisualStyleBackColor = false;
            // 
            // btn_Menu7
            // 
            this.btn_Menu7.BackColor = System.Drawing.Color.Purple;
            this.btn_Menu7.CausesValidation = false;
            this.btn_Menu7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu7.FlatAppearance.BorderSize = 0;
            this.btn_Menu7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu7.ForeColor = System.Drawing.Color.White;
            this.btn_Menu7.Location = new System.Drawing.Point(305, 6);
            this.btn_Menu7.Name = "btn_Menu7";
            this.btn_Menu7.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu7.TabIndex = 16;
            this.btn_Menu7.Text = "测试";
            this.btn_Menu7.UseVisualStyleBackColor = false;
            // 
            // btn_Menu6
            // 
            this.btn_Menu6.BackColor = System.Drawing.Color.Indigo;
            this.btn_Menu6.CausesValidation = false;
            this.btn_Menu6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu6.FlatAppearance.BorderSize = 0;
            this.btn_Menu6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu6.ForeColor = System.Drawing.Color.White;
            this.btn_Menu6.Location = new System.Drawing.Point(255, 6);
            this.btn_Menu6.Name = "btn_Menu6";
            this.btn_Menu6.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu6.TabIndex = 15;
            this.btn_Menu6.Text = "脚本";
            this.btn_Menu6.UseVisualStyleBackColor = false;
            // 
            // btn_Menu5
            // 
            this.btn_Menu5.BackColor = System.Drawing.Color.Blue;
            this.btn_Menu5.CausesValidation = false;
            this.btn_Menu5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu5.FlatAppearance.BorderSize = 0;
            this.btn_Menu5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu5.ForeColor = System.Drawing.Color.White;
            this.btn_Menu5.Location = new System.Drawing.Point(205, 6);
            this.btn_Menu5.Name = "btn_Menu5";
            this.btn_Menu5.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu5.TabIndex = 14;
            this.btn_Menu5.Text = "数据库";
            this.btn_Menu5.UseVisualStyleBackColor = false;
            // 
            // btn_Menu4
            // 
            this.btn_Menu4.BackColor = System.Drawing.Color.Green;
            this.btn_Menu4.CausesValidation = false;
            this.btn_Menu4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu4.FlatAppearance.BorderSize = 0;
            this.btn_Menu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu4.ForeColor = System.Drawing.Color.White;
            this.btn_Menu4.Location = new System.Drawing.Point(153, 6);
            this.btn_Menu4.Name = "btn_Menu4";
            this.btn_Menu4.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu4.TabIndex = 13;
            this.btn_Menu4.Text = "备份";
            this.btn_Menu4.UseVisualStyleBackColor = false;
            // 
            // btn_Menu3
            // 
            this.btn_Menu3.BackColor = System.Drawing.Color.Yellow;
            this.btn_Menu3.CausesValidation = false;
            this.btn_Menu3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu3.FlatAppearance.BorderSize = 0;
            this.btn_Menu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu3.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3.Location = new System.Drawing.Point(104, 6);
            this.btn_Menu3.Name = "btn_Menu3";
            this.btn_Menu3.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu3.TabIndex = 12;
            this.btn_Menu3.Text = "EDI";
            this.btn_Menu3.UseVisualStyleBackColor = false;
            // 
            // btn_Menu2
            // 
            this.btn_Menu2.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Menu2.CausesValidation = false;
            this.btn_Menu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu2.FlatAppearance.BorderSize = 0;
            this.btn_Menu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu2.ForeColor = System.Drawing.Color.White;
            this.btn_Menu2.Location = new System.Drawing.Point(55, 6);
            this.btn_Menu2.Name = "btn_Menu2";
            this.btn_Menu2.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu2.TabIndex = 11;
            this.btn_Menu2.Text = "发布";
            this.btn_Menu2.UseVisualStyleBackColor = false;
            // 
            // btn_Menu1
            // 
            this.btn_Menu1.BackColor = System.Drawing.Color.Red;
            this.btn_Menu1.CausesValidation = false;
            this.btn_Menu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Menu1.FlatAppearance.BorderSize = 0;
            this.btn_Menu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu1.ForeColor = System.Drawing.Color.White;
            this.btn_Menu1.Location = new System.Drawing.Point(5, 6);
            this.btn_Menu1.Name = "btn_Menu1";
            this.btn_Menu1.Size = new System.Drawing.Size(40, 68);
            this.btn_Menu1.TabIndex = 10;
            this.btn_Menu1.Text = "需求";
            this.btn_Menu1.UseVisualStyleBackColor = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(19, 12);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(216, 68);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "「 凡是被不断重复的过程，将其工具化\r\n    绑定到自动化流程之中，依靠工具，\r\n    而不是经验 」    ——      工具文化\r\n    ©2015 " +
    " SysMagic DevOps Team";
            // 
            // panel_Form
            // 
            this.panel_Form.Location = new System.Drawing.Point(0, 0);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(896, 438);
            this.panel_Form.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysMagic Automation Workflow Framework";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_banner.ResumeLayout(false);
            this.panel_banner.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel_banner;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel panel_Form;
        private System.Windows.Forms.Button btn_Menu1;
        private System.Windows.Forms.Button btn_Menu2;
        private System.Windows.Forms.Button btn_Menu3;
        private System.Windows.Forms.Button btn_Menu4;
        private System.Windows.Forms.Button btn_Menu5;
        private System.Windows.Forms.Button btn_Menu6;
        private System.Windows.Forms.Button btn_Menu7;
        private System.Windows.Forms.Button btn_Menu8;
        private System.Windows.Forms.Button btn_Menu9;
        private System.Windows.Forms.Button btn_Menu10;
    }
}

