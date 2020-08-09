using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生宿舍管理系统
{
    public partial class in_out_select : Form
    {
        public in_out_select()
        {
            InitializeComponent();
        }

        private void in_out_BtnCancel_Click(object sender, EventArgs e)
        {
            if (flag.number == 0)
                MainFrm.P_MainFrm.Show();
            else { MainFrm_Stu.S_MainFrm.Show();   }
            this.Close();
        }

        private void in_out_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag.number == 0)
                MainFrm.P_MainFrm.Show();
            else { MainFrm_Stu.S_MainFrm.Show();   }
        }

        private void in_out_BtnPol_Click(object sender, EventArgs e)
        {
           
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接
            DataConn.Open();//打开连接


            string DataSql;
            if (in_out_Sno.Text == "")
                DataSql = "select * from in_out";
            else 
            DataSql = "select * from in_out where sno = '" + in_out_Sno.Text + "'";//SQL语句
            SqlCommand DataComm = new SqlCommand(DataSql, DataConn);

            SqlDataAdapter sda = new SqlDataAdapter(DataComm);//数据适配器
            DataSet ds = new DataSet();
            sda.Fill(ds, "in_out");//适配器匹配数据
            in_out_Date.DataSource = ds;//把dataGridView的数据源设置为ds
            in_out_Date.DataMember = "in_out";
            

            in_out_Date.Columns[0].HeaderText = "姓名";
            in_out_Date.Columns[1].HeaderText = "学号";
            in_out_Date.Columns[2].HeaderText = "性别";
            in_out_Date.Columns[3].HeaderText = "宿舍号";
            in_out_Date.Columns[4].HeaderText = "时间";
            in_out_Date.Columns[5].HeaderText = "原因";
            for (int i = 0; i < in_out_Date.Rows.Count; i++)
            {
                in_out_Date.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
           
        }
        
        
    }
}
