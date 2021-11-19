using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management.ProjectHelper
{
    class FormHelper
    {
        public void closeFrm(Panel panelmain)     //关闭panel中的窗体--panelmain是panel的名称
        {
            foreach (Control item in panelmain.Controls)
            {
                if (item is Form)
                {
                    Form form = (Form)item;
                    form.Close();
                    panelmain.Controls.Remove(form);
                }
            }
        }
        public void openFrm(Form frm,Panel panelmain)    //在panel中打开窗体
        {
            frm.TopLevel = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Parent = panelmain;
            frm.Show();
        }

        public void AddControlsToPanel(Control c,Panel panelmain)
        {

            c.Dock = DockStyle.Fill;
            panelmain.Controls.Clear();
            panelmain.Controls.Add(c);

        }
    }
}
