using Management.DataBaseHelper;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Management.Forms
{
    public partial class SystemSettings : Form
    {
        public SystemSettings()
        {
            InitializeComponent();
        }
        private string rgbValue;
        public delegate void ChangeMainForm(Color c);
        public event ChangeMainForm change;

        private void btnColor4_Click(object sender, EventArgs e)
        {
            rgbValue = "102, 193, 140";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(102, 193, 140);
            change(c);
        }

        private void btnColor3_Click(object sender, EventArgs e)
        {
            rgbValue = "248,223,112";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(248, 223, 112);
            change(c);
        }

        private void SystemSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            rgbValue = "143,178,201";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(143, 178, 201);
            change(c);
        }
        private void UpdateDefaultColor(string color)
        {
            string sql = string.Format("UPDATE userinfo set theme = '{0}'", color);
            DBUtil db = new DBUtil();
            db.SqlQuery(sql);
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            rgbValue = "147,213,220";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(147, 213, 220);
            change(c);
        }

        private void btnColor6_Click(object sender, EventArgs e)
        {
            rgbValue = "246,173,143";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(246, 173, 143);
            change(c);
        }

        private void btnColor5_Click(object sender, EventArgs e)
        {
            rgbValue = "242,230,206";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(242, 230, 206);
            change(c);
        }
        /*
                菠萝紫  128,118,163
                星蓝 147,181,207
                麦秆黄 248,223,112
                淡藏花红 246,173,143
                清水蓝 147,213,220
                荔肉白 242,230,206
         */
    }
}
