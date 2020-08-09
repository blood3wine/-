namespace 学生宿舍管理系统
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.MainFrm_Std = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Std_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Std_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Std_Alt = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Std_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Late = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_in_out_add = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_in_out = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Repair = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Repair_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_Repair_Pol = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.电费缴纳管理员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电费查询学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_User = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_User_AddDel = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFrm_User_Psw = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.添加宿舍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip4
            // 
            this.menuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_Std,
            this.MainFrm_Late,
            this.MainFrm_Repair,
            this.toolStripMenuItem1,
            this.MainFrm_User,
            this.退出系统ToolStripMenuItem});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(782, 28);
            this.menuStrip4.TabIndex = 3;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // MainFrm_Std
            // 
            this.MainFrm_Std.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_Std_Add,
            this.MainFrm_Std_Del,
            this.MainFrm_Std_Alt,
            this.MainFrm_Std_Pol,
            this.添加宿舍ToolStripMenuItem});
            this.MainFrm_Std.Name = "MainFrm_Std";
            this.MainFrm_Std.Size = new System.Drawing.Size(111, 24);
            this.MainFrm_Std.Text = "学生宿舍管理";
            // 
            // MainFrm_Std_Add
            // 
            this.MainFrm_Std_Add.Name = "MainFrm_Std_Add";
            this.MainFrm_Std_Add.Size = new System.Drawing.Size(216, 26);
            this.MainFrm_Std_Add.Text = "添加学生信息";
            this.MainFrm_Std_Add.Click += new System.EventHandler(this.MainFrm_Std_Add_Click);
            // 
            // MainFrm_Std_Del
            // 
            this.MainFrm_Std_Del.Name = "MainFrm_Std_Del";
            this.MainFrm_Std_Del.Size = new System.Drawing.Size(216, 26);
            this.MainFrm_Std_Del.Text = "删除学生信息";
            this.MainFrm_Std_Del.Click += new System.EventHandler(this.MainFrm_Std_Del_Click);
            // 
            // MainFrm_Std_Alt
            // 
            this.MainFrm_Std_Alt.Name = "MainFrm_Std_Alt";
            this.MainFrm_Std_Alt.Size = new System.Drawing.Size(216, 26);
            this.MainFrm_Std_Alt.Text = "修改学生信息";
            this.MainFrm_Std_Alt.Click += new System.EventHandler(this.MainFrm_Std_Alt_Click);
            // 
            // MainFrm_Std_Pol
            // 
            this.MainFrm_Std_Pol.Name = "MainFrm_Std_Pol";
            this.MainFrm_Std_Pol.Size = new System.Drawing.Size(216, 26);
            this.MainFrm_Std_Pol.Text = "查询学生信息";
            this.MainFrm_Std_Pol.Click += new System.EventHandler(this.MainFrm_Std_Pol_Click);
            // 
            // MainFrm_Late
            // 
            this.MainFrm_Late.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_in_out_add,
            this.MainFrm_in_out});
            this.MainFrm_Late.Name = "MainFrm_Late";
            this.MainFrm_Late.Size = new System.Drawing.Size(81, 24);
            this.MainFrm_Late.Text = "出入管理";
            // 
            // MainFrm_in_out_add
            // 
            this.MainFrm_in_out_add.Name = "MainFrm_in_out_add";
            this.MainFrm_in_out_add.Size = new System.Drawing.Size(144, 26);
            this.MainFrm_in_out_add.Text = "出入登记";
            this.MainFrm_in_out_add.Click += new System.EventHandler(this.MainFrm_in_out_add_Click);
            // 
            // MainFrm_in_out
            // 
            this.MainFrm_in_out.Name = "MainFrm_in_out";
            this.MainFrm_in_out.Size = new System.Drawing.Size(144, 26);
            this.MainFrm_in_out.Text = "出入查询";
            this.MainFrm_in_out.Click += new System.EventHandler(this.MainFrm_in_out_Click);
            // 
            // MainFrm_Repair
            // 
            this.MainFrm_Repair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_Repair_Book,
            this.MainFrm_Repair_Pol});
            this.MainFrm_Repair.Name = "MainFrm_Repair";
            this.MainFrm_Repair.Size = new System.Drawing.Size(81, 24);
            this.MainFrm_Repair.Text = "维修管理";
            // 
            // MainFrm_Repair_Book
            // 
            this.MainFrm_Repair_Book.Name = "MainFrm_Repair_Book";
            this.MainFrm_Repair_Book.Size = new System.Drawing.Size(144, 26);
            this.MainFrm_Repair_Book.Text = "维修登记";
            this.MainFrm_Repair_Book.Click += new System.EventHandler(this.MainFrm_Repair_Book_Click);
            // 
            // MainFrm_Repair_Pol
            // 
            this.MainFrm_Repair_Pol.Name = "MainFrm_Repair_Pol";
            this.MainFrm_Repair_Pol.Size = new System.Drawing.Size(144, 26);
            this.MainFrm_Repair_Pol.Text = "维修查询";
            this.MainFrm_Repair_Pol.Click += new System.EventHandler(this.MainFrm_Repair_Pol_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.电费缴纳管理员ToolStripMenuItem,
            this.电费查询学生ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.toolStripMenuItem1.Text = "水电费管理";
            // 
            // 电费缴纳管理员ToolStripMenuItem
            // 
            this.电费缴纳管理员ToolStripMenuItem.Name = "电费缴纳管理员ToolStripMenuItem";
            this.电费缴纳管理员ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.电费缴纳管理员ToolStripMenuItem.Text = "水电费缴纳";
            this.电费缴纳管理员ToolStripMenuItem.Click += new System.EventHandler(this.电费缴纳管理员ToolStripMenuItem_Click);
            // 
            // 电费查询学生ToolStripMenuItem
            // 
            this.电费查询学生ToolStripMenuItem.Name = "电费查询学生ToolStripMenuItem";
            this.电费查询学生ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.电费查询学生ToolStripMenuItem.Text = "水电费查询";
            this.电费查询学生ToolStripMenuItem.Click += new System.EventHandler(this.电费查询学生ToolStripMenuItem_Click);
            // 
            // MainFrm_User
            // 
            this.MainFrm_User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainFrm_User_AddDel,
            this.MainFrm_User_Psw});
            this.MainFrm_User.Name = "MainFrm_User";
            this.MainFrm_User.Size = new System.Drawing.Size(81, 24);
            this.MainFrm_User.Text = "用户管理";
            // 
            // MainFrm_User_AddDel
            // 
            this.MainFrm_User_AddDel.Name = "MainFrm_User_AddDel";
            this.MainFrm_User_AddDel.Size = new System.Drawing.Size(144, 26);
            this.MainFrm_User_AddDel.Text = "增删用户";
            this.MainFrm_User_AddDel.Click += new System.EventHandler(this.MainFrm_User_AddDel_Click);
            // 
            // MainFrm_User_Psw
            // 
            this.MainFrm_User_Psw.Name = "MainFrm_User_Psw";
            this.MainFrm_User_Psw.Size = new System.Drawing.Size(144, 26);
            this.MainFrm_User_Psw.Text = "修改密码";
            this.MainFrm_User_Psw.Click += new System.EventHandler(this.MainFrm_User_Psw_Click);
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
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 410);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // 添加宿舍ToolStripMenuItem
            // 
            this.添加宿舍ToolStripMenuItem.Name = "添加宿舍ToolStripMenuItem";
            this.添加宿舍ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.添加宿舍ToolStripMenuItem.Text = "添加宿舍";
            this.添加宿舍ToolStripMenuItem.Click += new System.EventHandler(this.添加宿舍ToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.menuStrip4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainFrm";
            this.Text = "学生宿舍管理系统（管理员登录）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Late;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Repair;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_User;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std_Add;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std_Del;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std_Alt;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Std_Pol;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_in_out_add;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_in_out;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Repair_Book;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_Repair_Pol;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_User_AddDel;
        private System.Windows.Forms.ToolStripMenuItem MainFrm_User_Psw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 电费缴纳管理员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电费查询学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加宿舍ToolStripMenuItem;
    }
}