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
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }
        private bool check()
        {
            if (this.bname.Text == "")
            {
                MessageBox.Show("请输入待办名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.bname.Focus();
                return false;
            }
            else
            {
                return true;
            }



        }
        public string uid;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string bnames = bname.Text.Trim();
                string btypes = btype.Text.Trim();
                string bvalues = bvalue.Text.Trim();
                string btime = DateTime.Now.ToString();
                //string uid ="1";
                DBUtil db = new DBUtil();
                string sql = string.Format(@"INSERT INTO bills(bname,btime,btype,uid,bvalue)
                    VALUES ('{0}','{1}','{2}','{3}','{4}');", bnames,btime,btypes,uid,bvalues);
                db.SqlQuery(sql);
                MessageBox.Show("添加成功");
            }
        }
    }
}
