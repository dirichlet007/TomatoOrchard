using Management.DataBaseHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management.Forms
{
    public partial class BillsStatistics : Form
    {
        public BillsStatistics()
        {
            InitializeComponent();
        }
        public string uid;

        private void BillsStatistics_Load(object sender, EventArgs e)
        {
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            string timelenth = "100000";
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.Font = new Font("宋体", 25);
            chartsdisplay(timelenth);

        }
        private void chartsdisplay(string timelenth)
        {

            DBUtil db = new DBUtil();
            string sql1 = string.Format(@"select 消费类型,sum(消费金额)as 消费总额 from billsta where  uid={0} and  DATEDIFF(day,创建时间,getdate())<= {1} group by 消费类型 ", uid, timelenth);
            DataSet ds1 = db.SqlSet(sql1);
            dataGridView1.DataSource = ds1.Tables[0];
            chart1.DataSource = ds1.Tables[0];
            chart1.Series["Series1"].XValueMember = "消费类型";
            chart1.Series["Series1"].YValueMembers = "消费总额";
            chart1.Series["Series1"].IsValueShownAsLabel = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string timelenth = "1";
            chartsdisplay(timelenth);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBUtil db = new DBUtil();
            string sql1 = string.Format(@"select * from billsta ");
            DataSet ds1 = db.SqlSet(sql1);
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string timelenth = "7";
            chartsdisplay(timelenth);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string timelenth = "365";
            chartsdisplay(timelenth);
        }
    }
}
