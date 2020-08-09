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
    public partial class in_out_add : Form
    {
        public in_out_add()
        {
            InitializeComponent();
        }

        private void in_out_add_BtnCancel_Click(object sender, EventArgs e)
        {
            MainFrm.P_MainFrm.Show();
            this.Close();
        }

        private void in_out_add_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrm.P_MainFrm.Show();
        }

        private void in_out_add_BtnBook_Click(object sender, EventArgs e)
        {
            string in_out_add_connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection in_out_add_conn = new SqlConnection(in_out_add_connString);

            string in_out_add_sql = "insert into in_out(sname,sno,sex,dor_ID,time,remark) values('"+in_out_add_Sname.Text+"','"+in_out_add_Sno.Text+"','"+in_out_add_Sex.Text+"','"+in_out_add_DorID.Text+"','"+in_out_add_LateTime.Text+"','"+in_out_add_LateReason.Text+"')";
            try
            {
                in_out_add_conn.Open();
                SqlCommand in_out_add_Comm = new SqlCommand(in_out_add_sql, in_out_add_conn);
                //Std_Add_Comm.ExecuteNonQuery();//执行语句
                int Return_num = (int)in_out_add_Comm.ExecuteNonQuery();//执行插入语句并返回影响行数
                if (Return_num == 1)//影响行数为1,插入成功
                {
                    MessageBox.Show("出入登记信息添加成功！", "添加成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("出入登记信息添加失败", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                in_out_add_conn.Close();
            }
        }
    }
}
