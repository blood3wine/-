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
    public partial class MainFrm_Stu : Form
    {
        public static MainFrm_Stu S_MainFrm = null;
        public static string C_name;
        public static string C_type;
        public SqlConnection DataConn = null;//声明一个数据库连接
        public MainFrm_Stu(string uname,string utype)
        {
            C_name = uname;
            C_type = utype;
            S_MainFrm = this;
            InitializeComponent();
        }

        private void Std_MainFrm_Std_Pol_Click(object sender, EventArgs e)
        {
            Std_Pol studentuser_stuPol = new Std_Pol();
            studentuser_stuPol.Show();
            this.Hide();
        }

        private void Std_MainFrm_in_out_Click(object sender, EventArgs e)
        {
            in_out_select studenteuser_latePol = new in_out_select();
            studenteuser_latePol.Show();
            this.Hide();
        }

        private void Std_MainFrm_Repair_Pol_Click(object sender, EventArgs e)
        {
            Repair_Pol studentuser_repPol = new Repair_Pol();
            studentuser_repPol.Show();
            this.Hide();
        }

        private void Std_MainFrm_User_Psw_Click(object sender, EventArgs e)
        {
            User_ChangePsw studentuser_changePSW = new User_ChangePsw(C_name, C_type);
            studentuser_changePSW.Show();
            this.Hide();
        }

        
        private void MainFrm_Stu_Load(object sender, EventArgs e)
        {
           
            
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 出入登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 维修登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 增删用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();//打开主窗体
            this.Visible = false;//登录窗体隐藏
        }

        private void 水电费ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("学生无此权限！", "操作被禁止", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void 水电费查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            money_select  studentuser_money_select = new money_select();
            studentuser_money_select.Show();
            // this.Visible = false;
            this.Hide();
        }
    }
}
