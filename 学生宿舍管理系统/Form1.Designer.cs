namespace 学生宿舍管理系统
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.in_out_add_BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "宿舍号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 25);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // in_out_add_BtnCancel
            // 
            this.in_out_add_BtnCancel.AutoSize = true;
            this.in_out_add_BtnCancel.Location = new System.Drawing.Point(218, 151);
            this.in_out_add_BtnCancel.Name = "in_out_add_BtnCancel";
            this.in_out_add_BtnCancel.Size = new System.Drawing.Size(85, 39);
            this.in_out_add_BtnCancel.TabIndex = 4;
            this.in_out_add_BtnCancel.Text = "返回";
            this.in_out_add_BtnCancel.UseVisualStyleBackColor = true;
            this.in_out_add_BtnCancel.Click += new System.EventHandler(this.in_out_add_BtnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 260);
            this.Controls.Add(this.in_out_add_BtnCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "新建宿舍";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button in_out_add_BtnCancel;
    }
}