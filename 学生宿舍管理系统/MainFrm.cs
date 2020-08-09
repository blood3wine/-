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
    public partial class MainFrm : Form
    {
        public static MainFrm P_MainFrm = null;
        public static string C_name;
        public static string C_type;
        public SqlConnection DataConn = null;//声明一个数据库连接
        public MainFrm(string uname,string utype)
        {
            C_name = uname;
            C_type = utype;
            P_MainFrm = this;
            InitializeComponent();
        }

        private void MainFrm_Std_Add_Click(object sender, EventArgs e)
        {
            Std_Add student_infoAdd = new Std_Add();
            student_infoAdd.Show();//显示学生信息添加窗口
                                   //  this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_Std_Del_Click(object sender, EventArgs e)
        {
            Std_Del student_infoDel = new Std_Del();
            student_infoDel.Show();//显示学生信息删除窗口
                                   // this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_Std_Alt_Click(object sender, EventArgs e)
        {
            Std_Alt student_infoAlt = new Std_Alt();
            student_infoAlt.Show();//显示学生信息修改窗口
                                   //  this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_Std_Pol_Click(object sender, EventArgs e)
        {
            Std_Pol student_infoPol = new Std_Pol();
            student_infoPol.Show();//显示学生信息查询窗口
                                   //  this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_in_out_add_Click(object sender, EventArgs e)
        {
            in_out_add student_LateBook = new in_out_add();
            student_LateBook.Show();//显示学生出入录入窗口
                                    // this.Visible = false;//学生宿舍管理系统窗口隐藏
            this.Hide();
        }

        private void MainFrm_in_out_Click(object sender, EventArgs e)
        {
            in_out_select student_LatePol = new in_out_select();
            student_LatePol.Show();
            // this.Visible = false;
            this.Hide();
        }

        private void MainFrm_Repair_Book_Click(object sender, EventArgs e)
        {
            Repair_Book Man_repair_Book = new Repair_Book();
            Man_repair_Book.Show();
            //this.Visible = false;
            this.Hide();
        }

        private void MainFrm_Repair_Pol_Click(object sender, EventArgs e)
        {
            Repair_Pol Man_Repair_Pol = new Repair_Pol();
            Man_Repair_Pol.Show();
            // this.Visible = false;
            this.Hide();
        }

        private void MainFrm_User_AddDel_Click(object sender, EventArgs e)
        {
            User_AddDel User_AddDel_C = new User_AddDel();
            User_AddDel_C.Show();
            // this.Visible = false;
            this.Hide();
        }

        public void MainFrm_User_Psw_Click(object sender, EventArgs e)
        {
            User_ChangePsw User_PswChange = new User_ChangePsw(C_name,C_type);
            User_PswChange.Show();
            // this.Visible = false;
            this.Hide();
        }
        

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();//打开主窗体
            this.Visible = false;//登录窗体隐藏
        }

       

        private void 电费缴纳管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            money_add money_add = new money_add();
            money_add.Show();
            // this.Visible = false;
            this.Hide();
        }

        private void 电费查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            money_select money_select = new money_select();
            money_select.Show();
            // this.Visible = false;
            this.Hide();
        }

        private void 添加宿舍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            // this.Visible = false;
            this.Hide();
        }
    }
}
