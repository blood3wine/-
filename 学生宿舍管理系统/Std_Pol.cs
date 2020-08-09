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
    public partial class Std_Pol : Form
    {
        public SqlConnection Std_Pol_DataConn = null;//声明一个数据库连接
        public Std_Pol()
        {
            InitializeComponent();
        }

        private void Std_Pol_BtnCancel_Click(object sender, EventArgs e)
        {
            if (flag.number == 0)
                MainFrm.P_MainFrm.Show();
            else { MainFrm_Stu.S_MainFrm.Show();   }
            this.Close();
        }
        

        private void Std_Pol_BtnPol_Click(object sender, EventArgs e)
        {
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接
            DataConn.Open();//打开连接

            String DataSql;
            if (Std_Pol_DepID.Text != "" && Std_Pol_DorID.Text == "" && Std_Pol_Sno.Text == "")
                DataSql = "select * from student where dep_ID = '" + Std_Pol_DepID.Text + "'";
            else if (Std_Pol_DepID.Text != "" && Std_Pol_DorID.Text != "" && Std_Pol_Sno.Text == "")
                DataSql = "select * from student where dep_ID = '" + Std_Pol_DepID.Text + "'and dor_ID = '" + Std_Pol_DorID.Text + "'";
            else if (Std_Pol_DepID.Text != "" && Std_Pol_DorID.Text != "" && Std_Pol_Sno.Text != "")
                DataSql = "select * from student where dep_ID = '" + Std_Pol_DepID.Text + "'and dor_ID = '" + Std_Pol_DorID.Text + "' and sno = '" + Std_Pol_Sno.Text + "'";//SQL语句
            else if (Std_Pol_DepID.Text == "" && Std_Pol_DorID.Text != "" && Std_Pol_Sno.Text == "")
                DataSql = "select * from student where dor_ID = '" + Std_Pol_DorID.Text + "'";
            else if (Std_Pol_DepID.Text == "" && Std_Pol_DorID.Text != "" && Std_Pol_Sno.Text != "")
                DataSql = "select * from student where dor_ID = '" + Std_Pol_DorID.Text + "' and sno = '" + Std_Pol_Sno.Text + "'";
            else if (Std_Pol_DepID.Text == "" && Std_Pol_DorID.Text == "" && Std_Pol_Sno.Text != "")
                DataSql = "select * from student where sno = '" + Std_Pol_Sno.Text + "'";
            else if (Std_Pol_DepID.Text != "" && Std_Pol_DorID.Text == "" && Std_Pol_Sno.Text != "")
                DataSql = "select * from student where dep_ID = '" + Std_Pol_DepID.Text + "' and sno = '" + Std_Pol_Sno.Text + "'";
            else
                DataSql = "select * from student";

            SqlCommand DataComm = new SqlCommand(DataSql, DataConn);
            SqlDataAdapter sda = new SqlDataAdapter(DataComm);//数据适配器
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");//适配器匹配数据
            Std_Pol_StdDate.DataSource = ds;//把dataGridView的数据源设置为ds
            Std_Pol_StdDate.DataMember = "student";

            Std_Pol_StdDate.Columns[0].HeaderText = "系号";
            Std_Pol_StdDate.Columns[1].HeaderText = "班级";
            Std_Pol_StdDate.Columns[2].HeaderText = "学号";
            Std_Pol_StdDate.Columns[3].HeaderText = "姓名";
            Std_Pol_StdDate.Columns[4].HeaderText = "性别";
            Std_Pol_StdDate.Columns[5].HeaderText = "年龄";
            Std_Pol_StdDate.Columns[6].HeaderText = "电话";
            Std_Pol_StdDate.Columns[7].HeaderText = "门牌号";
            Std_Pol_StdDate.Columns[8].HeaderText = "入住日期";
            for (int i = 0; i < Std_Pol_StdDate.Rows.Count; i++)
            {
                Std_Pol_StdDate.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接
            DataConn.Open();//打开连接
            String DataSql;
            if (textBox1.Text=="") DataSql= "select * from  Doemitory ";
            //  String DataSql = "exec C1 '"+ textBox1.Text+"'";
            else DataSql = "select * from  Doemitory where dor_ID='" + textBox1.Text + "'";
            SqlCommand DataComm = new SqlCommand(DataSql, DataConn);
            SqlDataAdapter sda = new SqlDataAdapter(DataComm);//数据适配器
            DataSet ds = new DataSet();
            sda.Fill(ds, "Doemitory");//适配器匹配数据
            Std_Pol_StdDate.DataSource = ds;//把dataGridView的数据源设置为ds
            Std_Pol_StdDate.DataMember = "Doemitory";
            
            Std_Pol_StdDate.Columns[0].HeaderText = "宿舍号";
            Std_Pol_StdDate.Columns[1].HeaderText = "已住人数";
            Std_Pol_StdDate.Columns[2].HeaderText = "宿舍剩余空位";
            for (int i = 0; i < Std_Pol_StdDate.Rows.Count; i++)
            {
                Std_Pol_StdDate.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接
            DataConn.Open();//打开连接

            String DataSql = "exec C1 '" + textBox2.Text + "'";
            SqlCommand DataComm = new SqlCommand(DataSql, DataConn);
            SqlDataAdapter sda = new SqlDataAdapter(DataComm);//数据适配器
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");//适配器匹配数据
            Std_Pol_StdDate.DataSource = ds;//把dataGridView的数据源设置为ds
            Std_Pol_StdDate.DataMember = "student";

            Std_Pol_StdDate.Columns[0].HeaderText = "宿舍号";
            for (int i = 0; i < Std_Pol_StdDate.Rows.Count; i++)
            {
                Std_Pol_StdDate.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
    }
}
