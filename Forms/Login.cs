using Management.DataBaseHelper;
using Management.Forms;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        DBUtil db = new DBUtil();

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadOut();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
        private bool Check()
        {
            if (txtName.Text.Trim().Equals("") || txtName.Text == null)
            {
                MessageBox.Show("请输入用户名！\t", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;

            }
            else if (txtPassword.Text.Trim().Equals("") || txtPassword.Text == null)
            {
                MessageBox.Show("请输入密码！\t", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string account = txtName.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (Check())
            {
                button1.Text = "正在登录...";

                string sql = string.Format(@"select count(*) from userinfo where account='{0}'and password ='{1}'", account, password);
                string sql2 = string.Format(@"select username,authority,theme,uid from userinfo where account='{0}'and password ='{1}'", account, password);
                if (db.SqlCheck(sql))
                {

                    DataSet ds = db.SqlSet(sql2);
                    label1.Text = ds.Tables[0].Rows[0][0].ToString();
                    DashBoard fs = new DashBoard();
                    fs.username = ds.Tables[0].Rows[0][0].ToString();
                    fs.authority = ds.Tables[0].Rows[0][1].ToString();
                    fs.theme = ds.Tables[0].Rows[0][2].ToString();
                    fs.uid = ds.Tables[0].Rows[0][3].ToString();
                    fs.Show();
                    button1.Text = "登录";

                }
                else
                {
                    MessageBox.Show("密码或账号错误,请重新输入");
                }
            }
        }
        public void show()
        {
            DashBoard dbd = new DashBoard();
            dbd.Show();
            button1.Text = "登录";
        }
        public void warning()
        {
            MessageBox.Show("密码错误！\t", "错误警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            button1.Text = "登录";

        }
        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://wpa.qq.com/msgrd?v=3&uin=1508022928&site=qq&menu=yes");
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {

            if (Check())
            {
                if (this.cb.Checked) //如果选中了则执行记录账号和密码操作
                {
                    WriteIn();
                }
                else
                {
                    ClearConfig();
                }

            }
        }
        //写入文档
        private void WriteIn()
        {
            string File = Application.StartupPath;
            MessageBox.Show(File);
            string path = File.Substring(0, File.Length - 9) + "\\id_pwd\\PasswordConfig.txt";
            //找到储存登录密码的文件路径
            string content = this.txtName.Text.Trim() + "," + this.txtPassword.Text.Trim() + ",1";
            //储存信息
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(content);  //写入文档
            sw.Close();
            fs.Close();
        }

        //读取文档
        private void ReadOut()
        {
            //先将内容读取出来
            string File = Application.StartupPath;
            string path = File.Substring(0, File.Length - 9) + "id_pwd\\PasswordConfig.txt";
            //找到储存登录密码的文件路径
            FileStream fs = new FileStream(path, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            string content = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            //对内容进行分割处理
            if (content != "")
            {
                string[] pwd_id = content.Split(',');
                this.txtName.Text = pwd_id[0];  //将内容写进文本框中
                this.txtPassword.Text = pwd_id[1];
                if (pwd_id[2] == "1")
                {
                    this.cb.Checked = true;
                }
            }
        }

        //清空文档
        private void ClearConfig()
        {
            string File = Application.StartupPath;
            string path = File.Substring(0, File.Length - 9) + "id_pwd\\PasswordConfig.txt";
            //找到储存登录密码的文件路径
            string content = "";
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(content);  //写入文档
            sw.Close();
            fs.Close();
        }


    }
}
