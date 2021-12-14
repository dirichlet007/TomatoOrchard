using Management.ProjectHelper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Management.Forms
{

    public partial class DashBoard : Form
    {
        public string username;
        public string authority;
        public string theme;
        public string uid;
        FormHelper fmhpr = new FormHelper();
        int PanelWidth;
        bool isCollapsed;
        public DashBoard()
        {
            InitializeComponent();
            PanelWidth = panelLeft.Width;

        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(theme.Split(',')[0]);
            int num2 = Convert.ToInt32(theme.Split(',')[1]);
            int num3 = Convert.ToInt32(theme.Split(',')[2]);

            timer5.Start();
            Color c = Color.FromArgb(num1, num2, num3);
            labeltitle.Text = "欢迎！" + username;
            if (authority == "1")
            { label4.Text = "权限:  超级管理员"; }
            else if (authority == "2")
            { label4.Text = "权限:  普通管理员"; }
            else if (authority == "3")
            {
                label4.Text = "权限:  用户";
            }
            ChangeColor(c);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 16;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer2.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 16;
                if (panelLeft.Width <= 64)
                {
                    timer2.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
             Main fs = new Main();
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);
        }
        public void ChangeColor(Color c)
        {
            this.toppanel.BackColor = c;
            this.btnclose.BackColor = c;
            this.panelLeft.BackColor = c;
            this.labeltitle.BackColor = c;
            this.btnMain.BackColor = c;
            this.btnTomato.BackColor = c;
            this.btnTomatoStatistic.BackColor = c;
            this.btnBills.BackColor = c;
            this.btnBillsStatistic.BackColor = c;
            this.btnSystemSet.BackColor = c;
            this.btnManager.BackColor = c;
            this.btn.BackColor = c;
            this.btnfold.BackColor = c;
            this.label1.ForeColor = c;
            this.label4.BackColor = c;
        }


        private void btnbookmanage_Click(object sender, EventArgs e)
        {
            Tomato fs = new Tomato();
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);

        }
        private void btnsystemset_Click(object sender, EventArgs e)
        {
            SystemSettings fs = new SystemSettings();
            fs.change += new SystemSettings.ChangeMainForm(ChangeColor);

            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);

        }


        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnreader_Click(object sender, EventArgs e)
        {
            TomatoStatistics fs = new TomatoStatistics();
            fs.uid = uid;
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);
        }

        private void btnqueryinfo_Click(object sender, EventArgs e)
        {
            BillsStatistics fs = new BillsStatistics();
            fs.uid = uid;
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);

        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            Bills fs = new Bills();
            fs.uid = uid;
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            UserManager fs = new UserManager();
            fmhpr.closeFrm(panelmain);
            fmhpr.openFrm(fs, panelmain);
        }
    }
}
