using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Management.DataBaseHelper;
namespace Management.Forms
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tomatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tomatoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.managementDataSet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tomatoTableAdapter.FillBy(this.managementDataSet.tomato);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DBUtil db= new DBUtil();
            DataSet ds= db.SqlSet("select * from tomato");
            dataGridView1.DataSource = ds;
            dataGridView1.DataBind();*/
        }
    }
}
