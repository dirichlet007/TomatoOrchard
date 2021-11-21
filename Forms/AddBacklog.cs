using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management.DataBase;
using System.Data.SqlClient;
using Management.DataBaseHelper;
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

        private bool check()
        {
           if (this.rtbname.Text == "")
            {
                MessageBox.Show("请输入待办名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.rtbname.Focus();
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
        public delegate void rfhpnl();
        public event rfhpnl rfhTmtClk;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string tdname = rtbname.Text.Trim();
                string tdtype = cnttype.Text.Trim();
                string account = "100000";
                //string bcktp = bcltype.Text.Trim();
                string tdlen = rtbtime.Text.Trim().Substring(0,2);
                string tdtime= DateTime.Now.ToString();
                DBUtil db= new DBUtil();
                string sql = string.Format(@"set tnum_insert tomato on INSERT INTO tomato
                    VALUES (null,'{0}','{1}','{2}','{3}','{4}','0' set tnum_insert tomato off);", tdname, tdtype,tdlen,tdtime,account);
                db.SqlQuery(sql);
                rfhTmtClk();
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
    }
}
