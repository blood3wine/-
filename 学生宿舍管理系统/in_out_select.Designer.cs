namespace 学生宿舍管理系统
{
    partial class in_out_select
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
            this.in_out_BtnPol = new System.Windows.Forms.Button();
            this.in_out_BtnCancel = new System.Windows.Forms.Button();
            this.in_out_Date = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.in_out_Sno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.in_out_Date)).BeginInit();
            this.SuspendLayout();
            // 
            // in_out_BtnPol
            // 
            this.in_out_BtnPol.AutoSize = true;
            this.in_out_BtnPol.Location = new System.Drawing.Point(147, 447);
            this.in_out_BtnPol.Name = "in_out_BtnPol";
            this.in_out_BtnPol.Size = new System.Drawing.Size(85, 25);
            this.in_out_BtnPol.TabIndex = 3;
            this.in_out_BtnPol.Text = "查询";
            this.in_out_BtnPol.UseVisualStyleBackColor = true;
            this.in_out_BtnPol.Click += new System.EventHandler(this.in_out_BtnPol_Click);
            // 
            // in_out_BtnCancel
            // 
            this.in_out_BtnCancel.AutoSize = true;
            this.in_out_BtnCancel.Location = new System.Drawing.Point(456, 447);
            this.in_out_BtnCancel.Name = "in_out_BtnCancel";
            this.in_out_BtnCancel.Size = new System.Drawing.Size(85, 25);
            this.in_out_BtnCancel.TabIndex = 4;
            this.in_out_BtnCancel.Text = "返回";
            this.in_out_BtnCancel.UseVisualStyleBackColor = true;
            this.in_out_BtnCancel.Click += new System.EventHandler(this.in_out_BtnCancel_Click);
            // 
            // in_out_Date
            // 
            this.in_out_Date.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.in_out_Date.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.in_out_Date.Location = new System.Drawing.Point(12, 91);
            this.in_out_Date.Name = "in_out_Date";
            this.in_out_Date.RowTemplate.Height = 27;
            this.in_out_Date.Size = new System.Drawing.Size(693, 335);
            this.in_out_Date.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "请输入学号：";
            // 
            // in_out_Sno
            // 
            this.in_out_Sno.Location = new System.Drawing.Point(218, 30);
            this.in_out_Sno.Name = "in_out_Sno";
            this.in_out_Sno.Size = new System.Drawing.Size(173, 25);
            this.in_out_Sno.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "学号为空则查询所有记录";
            // 
            // in_out_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.in_out_Sno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.in_out_Date);
            this.Controls.Add(this.in_out_BtnCancel);
            this.Controls.Add(this.in_out_BtnPol);
            this.Name = "in_out_select";
            this.Text = "出入登记查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.in_out_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.in_out_Date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button in_out_BtnPol;
        private System.Windows.Forms.Button in_out_BtnCancel;
        private System.Windows.Forms.DataGridView in_out_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox in_out_Sno;
        private System.Windows.Forms.Label label2;
    }
}