using Management.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management.Controls
{
    public partial class mybutton : UserControl
    {
        public string label1_text;
        public string label2_text;
        public string tdtime;
        public string uid;
        public mybutton()
        {
            //label1.Text = label1_text;
            //label2.Text = label2_text;
            InitializeComponent();
        }

        private void mybutton_Load(object sender, EventArgs e)
        {
            label1.Text = label1_text;
            label2.Text = label2_text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimeCounter fs = new TimeCounter();
            fs.uid = uid;
            fs.Attentiontime = Convert.ToInt32(tdtime)*60;
            fs.tdname = label1_text;
            fs.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
