﻿namespace 学生宿舍管理系统
{
    partial class login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_btnLogin = new System.Windows.Forms.Button();
            this.login_btnCancel = new System.Windows.Forms.Button();
            this.login_txtName = new System.Windows.Forms.TextBox();
            this.login_txtPsw = new System.Windows.Forms.TextBox();
            this.login_UserType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(224, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生宿舍管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(250, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(250, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(250, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "类  型：";
            // 
            // login_btnLogin
            // 
            this.login_btnLogin.AutoSize = true;
            this.login_btnLogin.Location = new System.Drawing.Point(254, 317);
            this.login_btnLogin.Name = "login_btnLogin";
            this.login_btnLogin.Size = new System.Drawing.Size(85, 25);
            this.login_btnLogin.TabIndex = 4;
            this.login_btnLogin.Text = "登录";
            this.login_btnLogin.UseVisualStyleBackColor = true;
            this.login_btnLogin.Click += new System.EventHandler(this.login_btnLogin_Click);
            // 
            // login_btnCancel
            // 
            this.login_btnCancel.AutoSize = true;
            this.login_btnCancel.Location = new System.Drawing.Point(421, 317);
            this.login_btnCancel.Name = "login_btnCancel";
            this.login_btnCancel.Size = new System.Drawing.Size(85, 25);
            this.login_btnCancel.TabIndex = 5;
            this.login_btnCancel.Text = "返回";
            this.login_btnCancel.UseVisualStyleBackColor = true;
            this.login_btnCancel.Click += new System.EventHandler(this.login_btnCancel_Click);
            // 
            // login_txtName
            // 
            this.login_txtName.Location = new System.Drawing.Point(359, 125);
            this.login_txtName.Name = "login_txtName";
            this.login_txtName.Size = new System.Drawing.Size(162, 25);
            this.login_txtName.TabIndex = 6;
            // 
            // login_txtPsw
            // 
            this.login_txtPsw.Location = new System.Drawing.Point(359, 188);
            this.login_txtPsw.Name = "login_txtPsw";
            this.login_txtPsw.PasswordChar = '*';
            this.login_txtPsw.Size = new System.Drawing.Size(162, 25);
            this.login_txtPsw.TabIndex = 7;
            // 
            // login_UserType
            // 
            this.login_UserType.FormattingEnabled = true;
            this.login_UserType.Items.AddRange(new object[] {
            "学生登录",
            "宿管登录"});
            this.login_UserType.Location = new System.Drawing.Point(359, 249);
            this.login_UserType.Name = "login_UserType";
            this.login_UserType.Size = new System.Drawing.Size(162, 23);
            this.login_UserType.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 410);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.login_btnLogin);
            this.Controls.Add(this.login_btnCancel);
            this.Controls.Add(this.login_UserType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login_txtPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_btnLogin;
        private System.Windows.Forms.Button login_btnCancel;
        private System.Windows.Forms.TextBox login_txtName;
        private System.Windows.Forms.TextBox login_txtPsw;
        private System.Windows.Forms.ComboBox login_UserType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

