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
    public partial class TomatoStatistics : Form
    {
        public TomatoStatistics()
        {
            InitializeComponent();
        }
        public string uid;
        private void tomatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tomatoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.managementDataSet);

        }

        private void TomatoStatistics_Load(object sender, EventArgs e)
        {
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            string timelenth = "100000";
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.Font = new Font("宋体", 25);
            chartsdisplay(timelenth);

        }
        private void chartsdisplay(string timelenth) {

            DBUtil db = new DBUtil();
            string sql1 = string.Format(@"select  代办名称,代办时长*完成次数 as 总时长 from tmtsta where uid ={0} and DATEDIFF(day,创建时间,getdate())<={1}", uid, timelenth);
            DataSet ds1 = db.SqlSet(sql1);
            dataGridView1.DataSource = ds1.Tables[0];
            chart1.DataSource = ds1.Tables[0];
            chart1.Series["Series1"].XValueMember = "代办名称";
            chart1.Series["Series1"].YValueMembers = "总时长";
            chart1.Series["Series1"].IsValueShownAsLabel = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string timelenth = "7";
            chartsdisplay(timelenth);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string timelenth = "1";
            chartsdisplay(timelenth);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string timelenth = "365";
            chartsdisplay(timelenth);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBUtil db = new DBUtil();
            string sql1 = string.Format(@"select * from tmtsta ");
            DataSet ds1 = db.SqlSet(sql1);
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
