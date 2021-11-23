using Management.DataBaseHelper;
using System;
using System.Media;
using System.Windows.Forms;
namespace Management.Forms
{
    public partial class TimeCounter : Form
    {
        public string Taccount;
        public TimeCounter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
            playeralarm.Stop();
            this.Dispose();
        }
        SoundPlayer player = new SoundPlayer(@"C:\Users\唐宇峰\Desktop\Management\music\rain.wav");
        private void TimeCounter_Load(object sender, EventArgs e)
        {
            timer1.Start();

            player.Play();
        }
        //public int Attentiontime = 25*60;
        public int Attentiontime = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {

            ToClock();

        }
        public string tdname;
        private void Shake()
        {
            int leftWidth = this.Left; //指定窗体左边值
            int topWidth = this.Top; //指定窗体上边值 
            for (int i = 0; i < 40; i++)
            {
                if (i % 2 == 0)
                {
                    this.Left = this.Left + 10;
                }
                else
                {
                    this.Left = this.Left - 10;
                }
                if (i % 2 == 0)
                {
                    this.Top = this.Top + 10;
                }
                else
                {
                    this.Top = this.Top - 10;
                }
                System.Threading.Thread.Sleep(30);//震动频率 
            }
            this.Left = leftWidth;//重设窗体初此左边值 
            this.Top = topWidth; //重设窗体初此上边值 
        }


        string music = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "\\music\\alarm.wav";
        SoundPlayer playeralarm = new SoundPlayer(@"C:\Users\唐宇峰\Desktop\Management\music\alarm.wav");
        private void ToClock()
        {
            Attentiontime -= 1;
            int left = Attentiontime / 60;
            int right = Attentiontime % 60;
            string minute;
            string second;
            if (left < 10)
            {
                minute = "0" + left;
            }
            else
            {
                minute = "" + left;
            }
            if (right < 10)
            {
                second = "0" + right;
            }
            else
            {
                second = "" + right;
            }

            TimeSet.Text = minute + ":" + second;
            if (Attentiontime == 0)
            {
                TimeSet.Text = "00:00";
                label1.Text = "已完成";

                string sql = string.Format(@"UPDATE tomato SET tdcounter=tdcounter+1 WHERE tdname='{0}' and account={1}", tdname, Taccount);
                DBUtil db = new DBUtil();
                db.SqlQuery(sql);
                Shake();
                player.Stop();
                playeralarm.Play();
                timer1.Stop();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
