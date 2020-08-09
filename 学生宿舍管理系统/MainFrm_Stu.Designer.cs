namespace 学生宿舍管理系统
{
    partial class MainFrm_Stu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm_Stu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生宿舍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_MainFrm_Std_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.出入管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_MainFrm_in_out = new System.Windows.Forms.ToolStripMenuItem();
            this.维修管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_MainFrm_Repair_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.水电费查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Std_MainFrm_User_Psw = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.增删用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水电费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维修登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出入登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生宿舍管理ToolStripMenuItem,
            this.出入管理ToolStripMenuItem,
            this.维修管理ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.用户管理ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生宿舍管理ToolStripMenuItem
            // 
            this.学生宿舍管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加学生信息ToolStripMenuItem,
            this.删除学生信息ToolStripMenuItem,
            this.修改学生信息ToolStripMenuItem,
            this.Std_MainFrm_Std_Pol});
            this.学生宿舍管理ToolStripMenuItem.Name = "学生宿舍管理ToolStripMenuItem";
            this.学生宿舍管理ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.学生宿舍管理ToolStripMenuItem.Text = "学生宿舍管理";
            // 
            // Std_MainFrm_Std_Pol
            // 
            this.Std_MainFrm_Std_Pol.Name = "Std_MainFrm_Std_Pol";
            this.Std_MainFrm_Std_Pol.Size = new System.Drawing.Size(216, 26);
            this.Std_MainFrm_Std_Pol.Text = "查询学生信息";
            this.Std_MainFrm_Std_Pol.Click += new System.EventHandler(this.Std_MainFrm_Std_Pol_Click);
            // 
            // 出入管理ToolStripMenuItem
            // 
            this.出入管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.出入登记ToolStripMenuItem,
            this.Std_MainFrm_in_out});
            this.出入管理ToolStripMenuItem.Name = "出入管理ToolStripMenuItem";
            this.出入管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.出入管理ToolStripMenuItem.Text = "出入管理";
            // 
            // Std_MainFrm_in_out
            // 
            this.Std_MainFrm_in_out.Name = "Std_MainFrm_in_out";
            this.Std_MainFrm_in_out.Size = new System.Drawing.Size(144, 26);
            this.Std_MainFrm_in_out.Text = "出入查询";
            this.Std_MainFrm_in_out.Click += new System.EventHandler(this.Std_MainFrm_in_out_Click);
            // 
            // 维修管理ToolStripMenuItem
            // 
            this.维修管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.维修登记ToolStripMenuItem,
            this.Std_MainFrm_Repair_Pol});
            this.维修管理ToolStripMenuItem.Name = "维修管理ToolStripMenuItem";
            this.维修管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.维修管理ToolStripMenuItem.Text = "维修管理";
            // 
            // Std_MainFrm_Repair_Pol
            // 
            this.Std_MainFrm_Repair_Pol.Name = "Std_MainFrm_Repair_Pol";
            this.Std_MainFrm_Repair_Pol.Size = new System.Drawing.Size(144, 26);
            this.Std_MainFrm_Repair_Pol.Text = "维修查询";
            this.Std_MainFrm_Repair_Pol.Click += new System.EventHandler(this.Std_MainFrm_Repair_Pol_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水电费ToolStripMenuItem,
            this.水电费查询ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.toolStripMenuItem1.Text = "水电费管理";
            // 
            // 水电费查询ToolStripMenuItem
            // 
            this.水电费查询ToolStripMenuItem.Name = "水电费查询ToolStripMenuItem";
            this.水电费查询ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.水电费查询ToolStripMenuItem.Text = "水电费查询";
            this.水电费查询ToolStripMenuItem.Click += new System.EventHandler(this.水电费查询ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增删用户ToolStripMenuItem,
            this.Std_MainFrm_User_Psw});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // Std_MainFrm_User_Psw
            // 
            this.Std_MainFrm_User_Psw.Name = "Std_MainFrm_User_Psw";
            this.Std_MainFrm_User_Psw.Size = new System.Drawing.Size(144, 26);
            this.Std_MainFrm_User_Psw.Text = "修改密码";
            this.Std_MainFrm_User_Psw.Click += new System.EventHandler(this.Std_MainFrm_User_Psw_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 410);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // 增删用户ToolStripMenuItem
            // 
            this.增删用户ToolStripMenuItem.Name = "增删用户ToolStripMenuItem";
            this.增删用户ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.增删用户ToolStripMenuItem.Text = "增删用户";
            this.增删用户ToolStripMenuItem.Click += new System.EventHandler(this.增删用户ToolStripMenuItem_Click);
            // 
            // 水电费ToolStripMenuItem
            // 
            this.水电费ToolStripMenuItem.Name = "水电费ToolStripMenuItem";
            this.水电费ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.水电费ToolStripMenuItem.Text = "水电费缴纳";
            this.水电费ToolStripMenuItem.Click += new System.EventHandler(this.水电费ToolStripMenuItem_Click);
            // 
            // 维修登记ToolStripMenuItem
            // 
            this.维修登记ToolStripMenuItem.Name = "维修登记ToolStripMenuItem";
            this.维修登记ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.维修登记ToolStripMenuItem.Text = "维修登记";
            this.维修登记ToolStripMenuItem.Click += new System.EventHandler(this.维修登记ToolStripMenuItem_Click);
            // 
            // 出入登记ToolStripMenuItem
            // 
            this.出入登记ToolStripMenuItem.Name = "出入登记ToolStripMenuItem";
            this.出入登记ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.出入登记ToolStripMenuItem.Text = "出入登记";
            this.出入登记ToolStripMenuItem.Click += new System.EventHandler(this.出入登记ToolStripMenuItem_Click);
            // 
            // 修改学生信息ToolStripMenuItem
            // 
            this.修改学生信息ToolStripMenuItem.Name = "修改学生信息ToolStripMenuItem";
            this.修改学生信息ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.修改学生信息ToolStripMenuItem.Text = "修改学生信息";
            this.修改学生信息ToolStripMenuItem.Click += new System.EventHandler(this.修改学生信息ToolStripMenuItem_Click);
            // 
            // 删除学生信息ToolStripMenuItem
            // 
            this.删除学生信息ToolStripMenuItem.Name = "删除学生信息ToolStripMenuItem";
            this.删除学生信息ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.删除学生信息ToolStripMenuItem.Text = "删除学生信息";
            this.删除学生信息ToolStripMenuItem.Click += new System.EventHandler(this.删除学生信息ToolStripMenuItem_Click);
            // 
            // 添加学生信息ToolStripMenuItem
            // 
            this.添加学生信息ToolStripMenuItem.Name = "添加学生信息ToolStripMenuItem";
            this.添加学生信息ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.添加学生信息ToolStripMenuItem.Text = "添加学生信息";
            this.添加学生信息ToolStripMenuItem.Click += new System.EventHandler(this.添加学生信息ToolStripMenuItem_Click);
            // 
            // MainFrm_Stu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm_Stu";
            this.Text = "学生宿舍管理系统（学生登录）";
            this.Load += new System.EventHandler(this.MainFrm_Stu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 出入管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维修管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Std_MainFrm_Std_Pol;
        private System.Windows.Forms.ToolStripMenuItem Std_MainFrm_in_out;
        private System.Windows.Forms.ToolStripMenuItem Std_MainFrm_Repair_Pol;
        private System.Windows.Forms.ToolStripMenuItem Std_MainFrm_User_Psw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 学生宿舍管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 水电费查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出入登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维修登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水电费ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增删用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生信息ToolStripMenuItem;
    }
}