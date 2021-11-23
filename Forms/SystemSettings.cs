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
            rgbValue = "26, 179, 148";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(26, 179, 148);
            change(c);
        }

        private void btnColor3_Click(object sender, EventArgs e)
        {
            rgbValue = "248, 172, 89";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(248, 172, 89);
            change(c);
        }

        private void SystemSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            rgbValue = "0, 71, 160";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(0, 71, 160);
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
            rgbValue = "35, 198, 200";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(35, 198, 200);
            change(c);
        }

        private void btnColor6_Click(object sender, EventArgs e)
        {
            rgbValue = "198, 47, 47";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(198, 47, 47);
            change(c);
        }

        private void btnColor5_Click(object sender, EventArgs e)
        {
            rgbValue = "116, 40, 148";
            UpdateDefaultColor(rgbValue);
            Color c = Color.FromArgb(116, 40, 148);
            change(c);
        }
    }
}
