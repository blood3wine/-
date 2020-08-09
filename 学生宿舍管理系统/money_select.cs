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
    public partial class money_select : Form
    {
        public money_select()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (flag.number == 0)
                MainFrm.P_MainFrm.Show();
            else { MainFrm_Stu.S_MainFrm.Show();   }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接
            DataConn.Open();//打开连接

            string DataSql;
            if (textBox1.Text == "")
                DataSql = "select * from money ";
            else
                DataSql = "select * from money where dor_ID = '" + textBox1.Text + "'";//SQL语句
            SqlCommand DataComm = new SqlCommand(DataSql, DataConn);

            SqlDataAdapter sda = new SqlDataAdapter(DataComm);//数据适配器
            DataSet ds = new DataSet();
            sda.Fill(ds, "money");//适配器匹配数据
            dataGridView1.DataSource = ds;//把dataGridView的数据源设置为ds
            dataGridView1.DataMember = "money";

            dataGridView1.Columns[0].HeaderText = "门牌号";
            dataGridView1.Columns[1].HeaderText = "应缴水费";
            dataGridView1.Columns[2].HeaderText = "应缴电费";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }
        
    }
}
