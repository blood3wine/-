namespace 学生宿舍管理系统
{
    partial class in_out_add
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.in_out_add_DorID = new System.Windows.Forms.TextBox();
            this.in_out_add_Sno = new System.Windows.Forms.TextBox();
            this.in_out_add_Sex = new System.Windows.Forms.ComboBox();
            this.in_out_add_Sname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.in_out_add_LateTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.in_out_add_LateReason = new System.Windows.Forms.TextBox();
            this.in_out_add_BtnBook = new System.Windows.Forms.Button();
            this.in_out_add_BtnCancel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.in_out_add_DorID);
            this.groupBox1.Controls.Add(this.in_out_add_Sno);
            this.groupBox1.Controls.Add(this.in_out_add_Sex);
            this.groupBox1.Controls.Add(this.in_out_add_Sname);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(49, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "填写信息：";
            // 
            // in_out_add_DorID
            // 
            this.in_out_add_DorID.Location = new System.Drawing.Point(93, 185);
            this.in_out_add_DorID.Name = "in_out_add_DorID";
            this.in_out_add_DorID.Size = new System.Drawing.Size(154, 25);
            this.in_out_add_DorID.TabIndex = 8;
            // 
            // in_out_add_Sno
            // 
            this.in_out_add_Sno.Location = new System.Drawing.Point(93, 135);
            this.in_out_add_Sno.Name = "in_out_add_Sno";
            this.in_out_add_Sno.Size = new System.Drawing.Size(154, 25);
            this.in_out_add_Sno.TabIndex = 7;
            // 
            // in_out_add_Sex
            // 
            this.in_out_add_Sex.FormattingEnabled = true;
            this.in_out_add_Sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.in_out_add_Sex.Location = new System.Drawing.Point(93, 87);
            this.in_out_add_Sex.Name = "in_out_add_Sex";
            this.in_out_add_Sex.Size = new System.Drawing.Size(154, 23);
            this.in_out_add_Sex.TabIndex = 6;
            // 
            // in_out_add_Sname
            // 
            this.in_out_add_Sname.Location = new System.Drawing.Point(92, 35);
            this.in_out_add_Sname.Name = "in_out_add_Sname";
            this.in_out_add_Sname.Size = new System.Drawing.Size(155, 25);
            this.in_out_add_Sname.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.in_out_add_LateTime);
            this.groupBox2.Location = new System.Drawing.Point(322, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 80);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "系统时间：";
            // 
            // in_out_add_LateTime
            // 
            this.in_out_add_LateTime.CustomFormat = "yyyy-MM-dd ";
            this.in_out_add_LateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.in_out_add_LateTime.Location = new System.Drawing.Point(15, 31);
            this.in_out_add_LateTime.Name = "in_out_add_LateTime";
            this.in_out_add_LateTime.Size = new System.Drawing.Size(255, 25);
            this.in_out_add_LateTime.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "宿舍号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.in_out_add_LateReason);
            this.groupBox3.Location = new System.Drawing.Point(49, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 143);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "原因：";
            // 
            // in_out_add_LateReason
            // 
            this.in_out_add_LateReason.Location = new System.Drawing.Point(34, 42);
            this.in_out_add_LateReason.Multiline = true;
            this.in_out_add_LateReason.Name = "in_out_add_LateReason";
            this.in_out_add_LateReason.Size = new System.Drawing.Size(545, 72);
            this.in_out_add_LateReason.TabIndex = 0;
            // 
            // in_out_add_BtnBook
            // 
            this.in_out_add_BtnBook.AutoSize = true;
            this.in_out_add_BtnBook.Location = new System.Drawing.Point(191, 454);
            this.in_out_add_BtnBook.Name = "in_out_add_BtnBook";
            this.in_out_add_BtnBook.Size = new System.Drawing.Size(85, 25);
            this.in_out_add_BtnBook.TabIndex = 2;
            this.in_out_add_BtnBook.Text = "登记";
            this.in_out_add_BtnBook.UseVisualStyleBackColor = true;
            this.in_out_add_BtnBook.Click += new System.EventHandler(this.in_out_add_BtnBook_Click);
            // 
            // in_out_add_BtnCancel
            // 
            this.in_out_add_BtnCancel.AutoSize = true;
            this.in_out_add_BtnCancel.Location = new System.Drawing.Point(447, 454);
            this.in_out_add_BtnCancel.Name = "in_out_add_BtnCancel";
            this.in_out_add_BtnCancel.Size = new System.Drawing.Size(85, 25);
            this.in_out_add_BtnCancel.TabIndex = 3;
            this.in_out_add_BtnCancel.Text = "返回";
            this.in_out_add_BtnCancel.UseVisualStyleBackColor = true;
            this.in_out_add_BtnCancel.Click += new System.EventHandler(this.in_out_add_BtnCancel_Click);
            // 
            // in_out_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 498);
            this.Controls.Add(this.in_out_add_BtnCancel);
            this.Controls.Add(this.in_out_add_BtnBook);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "in_out_add";
            this.Text = "出入登记";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.in_out_add_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox in_out_add_DorID;
        private System.Windows.Forms.TextBox in_out_add_Sno;
        private System.Windows.Forms.ComboBox in_out_add_Sex;
        private System.Windows.Forms.TextBox in_out_add_Sname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker in_out_add_LateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox in_out_add_LateReason;
        private System.Windows.Forms.Button in_out_add_BtnBook;
        private System.Windows.Forms.Button in_out_add_BtnCancel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}