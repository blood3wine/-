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
    public partial class money_add : Form
    {
        public money_add()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)  //确认缴费
        {
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接
          

            string DataSql = "update money set wmoney =0 ,emoney=0  where dor_ID = '" + textBox6.Text + "'";//SQL语句
            try
            {
                DataConn.Open();
                SqlCommand Std_Alt_Comm = new SqlCommand(DataSql, DataConn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)Std_Alt_Comm.ExecuteNonQuery();//执行修改语句并返回影响行数
                if (Return_num == 1)//影响行数为1,修改成功
                {
                    MessageBox.Show("缴费成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("缴费失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接


            string DataSql = "update money set wmoney ='" + textBox2.Text + "' , emoney= '" + textBox3.Text + "'  where dor_ID = '" + textBox1.Text + "'";//SQL语句
            try
            {
                DataConn.Open();
                SqlCommand Std_Alt_Comm = new SqlCommand(DataSql, DataConn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)Std_Alt_Comm.ExecuteNonQuery();//执行修改语句并返回影响行数
                if (Return_num == 1)//影响行数为1,修改成功
                {
                    MessageBox.Show("添加费用成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("添加费用失败", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            if (flag.number == 0)
                MainFrm.P_MainFrm.Show();
            else { MainFrm_Stu.S_MainFrm.Show();   }
        }
    }
}
