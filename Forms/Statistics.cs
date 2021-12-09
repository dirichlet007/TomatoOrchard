using System;
using System.Windows.Forms;

namespace Management.Forms
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void tomatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tomatoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.managementDataSet);

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“managementDataSet.tomato”中。您可以根据需要移动或删除它。
            this.tomatoTableAdapter.Fill(this.managementDataSet.tomato);

        }
    }
}
