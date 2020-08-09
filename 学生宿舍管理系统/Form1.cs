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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接


            string DataSql = "insert into Doemitory values('"+ textBox1 .Text+ "',0,4)";
            try
            {
                DataConn.Open();
                SqlCommand Std_Alt_Comm = new SqlCommand(DataSql, DataConn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)Std_Alt_Comm.ExecuteNonQuery();//执行修改语句并返回影响行数
                if (Return_num == 1)//影响行数为1,修改成功
                {
                    MessageBox.Show("添加宿舍成功，已初始化人数！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("添加宿舍失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void in_out_add_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }
    }
}
