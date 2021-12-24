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
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            string sql = string.Format(@"select * from user_view");
            Search(sql);
        }
        private void Search(string sql) {
            DBUtil db = new DBUtil();
            DataSet ds1 = db.SqlSet(sql);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.Font = new Font("宋体", 25);
            dataGridView1.ForeColor = Color.FromArgb(248, 172, 89); 
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccount.Clear();
            txtPassWord.Clear();
            txtid.Clear();
            txtUsername.Clear();
            txtTel.Clear();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassWord.Text;
            string username = txtUsername.Text;
            string telephone = txtTel.Text;
            int auth = this.cmbAuthority.SelectedIndex + 1;
            string sql = string.Format(@"insert into userinfo(account,password,username,telephone,authority,theme)values('{0}','{1}','{2}','{3}',{4},'248, 172, 89')", account, password, username, telephone, auth);
            DBUtil db = new DBUtil();
            db.SqlQuery(sql);
            MessageBox.Show("添加成功");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string account = txtAccount.Text;
            string password = txtPassWord.Text;
            string username = txtUsername.Text;
            string telephone = txtTel.Text;
            string uid = txtid.Text;
            int auth = this.cmbAuthority.SelectedIndex + 1;
            string sql = string.Format(@"update userinfo set account='{0}',password='{1}',username='{2}',telephone='{3}',authority={4},theme='248, 172, 89' where uid={5}", account, password, username, telephone, auth,uid);
            DBUtil db = new DBUtil();
            db.SqlQuery(sql);
            MessageBox.Show("修改成功");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtid.Text;
            string sql = string.Format(@"delete from userinfo where uid={0}", uid);
            DBUtil db = new DBUtil();
            db.SqlQuery(sql);
            MessageBox.Show("删除成功");
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"select * from user_view");
            Search(sql);
        }
    }
}
