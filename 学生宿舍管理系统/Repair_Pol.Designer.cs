namespace 学生宿舍管理系统
{
    partial class Repair_Pol
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
            this.Repair_Pol_BtnPol = new System.Windows.Forms.Button();
            this.Repair_Pol_AllDate = new System.Windows.Forms.DataGridView();
            this.Repair_Pol_DorID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Repair_Pol_AllDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "宿舍号：";
            // 
            // Repair_Pol_BtnPol
            // 
            this.Repair_Pol_BtnPol.AutoSize = true;
            this.Repair_Pol_BtnPol.Location = new System.Drawing.Point(205, 587);
            this.Repair_Pol_BtnPol.Name = "Repair_Pol_BtnPol";
            this.Repair_Pol_BtnPol.Size = new System.Drawing.Size(110, 25);
            this.Repair_Pol_BtnPol.TabIndex = 2;
            this.Repair_Pol_BtnPol.Text = "查询";
            this.Repair_Pol_BtnPol.UseVisualStyleBackColor = true;
            this.Repair_Pol_BtnPol.Click += new System.EventHandler(this.Repair_Pol_BtnPol_Click);
            // 
            // Repair_Pol_AllDate
            // 
            this.Repair_Pol_AllDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Repair_Pol_AllDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Repair_Pol_AllDate.Location = new System.Drawing.Point(25, 79);
            this.Repair_Pol_AllDate.Name = "Repair_Pol_AllDate";
            this.Repair_Pol_AllDate.RowTemplate.Height = 27;
            this.Repair_Pol_AllDate.Size = new System.Drawing.Size(805, 476);
            this.Repair_Pol_AllDate.TabIndex = 3;
            // 
            // Repair_Pol_DorID
            // 
            this.Repair_Pol_DorID.Location = new System.Drawing.Point(178, 32);
            this.Repair_Pol_DorID.Name = "Repair_Pol_DorID";
            this.Repair_Pol_DorID.Size = new System.Drawing.Size(153, 25);
            this.Repair_Pol_DorID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "宿舍号为空则查询所有记录";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(492, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Repair_Pol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 635);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Repair_Pol_DorID);
            this.Controls.Add(this.Repair_Pol_AllDate);
            this.Controls.Add(this.Repair_Pol_BtnPol);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Repair_Pol";
            this.Text = "维修查询";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Repair_Pol_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Repair_Pol_AllDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Repair_Pol_BtnPol;
        private System.Windows.Forms.DataGridView Repair_Pol_AllDate;
        private System.Windows.Forms.TextBox Repair_Pol_DorID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}