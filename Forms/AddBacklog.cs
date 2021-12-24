using Management.DataBaseHelper;
using Management.ProjectHelper;
using System;
using System.Windows.Forms;
namespace Management.Forms
{
    public partial class AddBacklog : Form
    {
        public AddBacklog()
        {
            InitializeComponent();
        }

        private void dtBorrow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string uid;
        private bool check()
        {
            if (this.rtbname.Text == "")
            {
                MessageBox.Show("请输入待办名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.rtbname.Focus();
                return false;
            }
            else if (this.cnttype.Text=="") {
                MessageBox.Show("请输入计时类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cnttype.Focus();
                return false;
            }
            else if (this.rtbtime.Text == "")
            {
                MessageBox.Show("请输入待办时长！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.rtbtime.Focus();
                return false;
            }
            else if (this.bcltype.Text == "")
            {
                MessageBox.Show("请输入待办类型！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.bcltype.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public delegate void RefreshTomato();
        public event RefreshTomato refresh;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string tdname = rtbname.Text.Trim();
                string tdtype = cnttype.Text.Trim();
                string uid = "1";
                string tdlenth = rtbtime.Text.Trim().Substring(0, 2);
                string tdtime = DateTime.Now.ToString();
                DBUtil db = new DBUtil();
                string sql = string.Format(@"INSERT INTO tomato(tdname,tdtype,tdlenth,tdtime,uid)
                    VALUES ('{0}','{1}',{2},'{3}','{4}');", tdname, tdtype, tdlenth, tdtime, uid);
                db.SqlQuery(sql);
                refresh();
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbname.Clear();
            cnttype.Clear();
            bcltype.Clear();
            rtbtime.Clear();
        }

        private void bcltype_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbtime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rtbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cnttype_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
