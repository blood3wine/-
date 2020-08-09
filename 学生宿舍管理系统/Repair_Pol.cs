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
    public partial class Repair_Pol : Form
    {
        public Repair_Pol()
        {
            InitializeComponent();
        }

        private void Repair_Pol_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag.number == 0)
                MainFrm.P_MainFrm.Show();
            else { MainFrm_Stu.S_MainFrm.Show();   }
        }

        private void Repair_Pol_BtnPol_Click(object sender, EventArgs e)
        {
           
            string connString = "server=DESKTOP-V3H7EOU\\MSSQLSERVER02;database=Stu_Doemitory; Trusted_Connection =SSPI";
            SqlConnection DataConn = new SqlConnection(connString);//实例化链接
            DataConn.Open();//打开连接

            string DataSql;
            if (Repair_Pol_DorID.Text=="")
                DataSql = "select * from repair ";
            else
                DataSql = "select * from repair where dor_ID = '" + Repair_Pol_DorID.Text + "'";//SQL语句
            SqlCommand DataComm = new SqlCommand(DataSql, DataConn);

            SqlDataAdapter sda = new SqlDataAdapter(DataComm);//数据适配器
            DataSet ds = new DataSet();
            sda.Fill(ds, "repair");//适配器匹配数据
            Repair_Pol_AllDate.DataSource = ds;//把dataGridView的数据源设置为ds
            Repair_Pol_AllDate.DataMember = "repair";

            Repair_Pol_AllDate.Columns[0].HeaderText = "门牌号";
            Repair_Pol_AllDate.Columns[1].HeaderText = "上报时间";
            Repair_Pol_AllDate.Columns[2].HeaderText = "维修时间";
            Repair_Pol_AllDate.Columns[3].HeaderText = "原因";
            Repair_Pol_AllDate.Columns[4].HeaderText = "维修人员";
            Repair_Pol_AllDate.Columns[5].HeaderText = "维修价格";
            Repair_Pol_AllDate.Columns[6].HeaderText = "维修设备";
            Repair_Pol_AllDate.Columns[7].HeaderText = "维修数量";
            for (int i = 0; i < Repair_Pol_AllDate.Rows.Count; i++)
            {
                Repair_Pol_AllDate.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
            //conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
