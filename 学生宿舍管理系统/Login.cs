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
    
    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
        }

        public void login_btnLogin_Click(object sender, EventArgs e)
        {
            string username = login_txtName.Text.Trim();
            string password = login_txtPsw.Text.Trim();
            string usertype = login_UserType.Text;
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection login_conn = new SqlConnection(connString);
            string login_sql = string.Format("select count(*) from Userlogin where username = '{0}' and password = '{1}' and usertype = '{2}' ", username, password,usertype);
            try
            {
                login_conn.Open();
                SqlCommand login_comm = new SqlCommand(login_sql, login_conn);
                int login_flag = (int)login_comm.ExecuteScalar();
                if(login_flag==1)
                {
                    if (login_UserType.Text == "学生登录")
                    {
                        flag.number = 1;
                        MainFrm_Stu mainfrm_stu = new MainFrm_Stu(username,password);
                        mainfrm_stu.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MainFrm mainForm = new MainFrm(username,password);
                        mainForm.Show();//打开主窗体
                        this.Visible = false;//登录窗体隐藏
                    }

                }
                else
                {
                    login_txtPsw.Text = "";//如果账号或者密码错误，则清空密码
                    MessageBox.Show("账号或密码错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                login_conn.Close();//关闭数据库连接
            }
        }

        private void login_btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        
    }
    public class flag
    {
        public static int number = 0;
     }
    

}
