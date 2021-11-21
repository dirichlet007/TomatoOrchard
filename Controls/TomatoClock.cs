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
  
    public partial class TomatoClock : UserControl
    {  
        public string Caccount;
        public TomatoClock()
        {
            InitializeComponent();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            AddBacklog fs = new AddBacklog();
            fs.rfhTmtClk += txtdisplay;
            fs.ShowDialog();           
        }
        class Tmtinfo
        {
            public string tmtname;
            public string tmttype;
        }
        private void TomatoClock_Load(object sender, EventArgs e)
        {
           txtdisplay();        
        }
        
        public void txtdisplay()
        {
                List<Tmtinfo> bls = new List<Tmtinfo>();         
                DBUtil db=new DBUtil();
                string sql = string.Format(@"select tdname,tdtype,tdlenth from tomato ");
                DataSet ds= db.SqlSet(sql);
                try
                {
                DataTable myTable = ds.Tables[0];
                foreach (DataRow myRow in myTable.Rows)
                {
                    
                       //遍历表中的每个单元格
                        Tmtinfo u = new Tmtinfo();
                        u.tmtname = myRow[0].ToString();
                        u.tmttype = myRow[1].ToString();
                        bls.Add(u);
                    
                }              
                int len = bls.Count();
                label2.Text = bls[len - 1].tmtname;
                label3.Text = bls[len - 2].tmtname;
                label4.Text = bls[len - 3].tmtname;
                label5.Text = bls[len - 4].tmtname;
                label6.Text = bls[len - 1].tmttype;
                label7.Text = bls[len - 2].tmttype;
                label8.Text = bls[len - 3].tmttype;
                label9.Text = bls[len - 4].tmttype;
            }

               
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
            //for循环写法；
            //int i = 1;
            //foreach (Tmtinfo unit in bls)
            //{
            //    string labelunit = string.Format(@"labe{}.Text", i);
            //    labelunit= unit.tmtname + "    " + unit.tmttype;
            //    if (i == 5)
            //    break;               
            //    i += 1;
            //}





        }           
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
   
        }

        private void button4_Click(object sender, EventArgs e)
        {
   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TimeCounter fs = new TimeCounter(); 
            fs.Taccount = Caccount;
            fs.tdname = label2.Text.ToString();
            fs.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TimeCounter fs = new TimeCounter();
            fs.Taccount = Caccount;
            fs.tdname = label3.Text.ToString();
            fs.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            TimeCounter fs = new TimeCounter();
            fs.Taccount = Caccount;
            fs.tdname = label4.Text.ToString();
            fs.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            TimeCounter fs = new TimeCounter();
            fs.Taccount = Caccount;
            fs.tdname = label5.Text.ToString();
            fs.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
         
        }

        private void tomatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tomatoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.managementDataSet);

        }
    }
}
