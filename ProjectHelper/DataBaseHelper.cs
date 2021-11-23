using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Management.DataBaseHelper
{
    class DBUtil
    {
        string connectString = "Data Source=DIRICHLET;Initial Catalog=Management;Integrated Security=True";

        public SqlConnection conn;
        public void SqlQuery(string sql)
        {
            conn = new SqlConnection(connectString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }



        }
        /* public DataSet SqlSet(string sql,string tablename)
         {
             conn = new SqlConnection(connectString);
             conn.Open();                    
             SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, conn);
             DataSet myDataSet = new DataSet();      // 创建DataSet
             myDataAdapter.Fill(myDataSet,tablename);               
             conn.Close(); 
             return myDataSet;
         }*/
        public DataSet SqlSet(string sql)
        {
            //创建 SQLConnection 的实例
            SqlConnection conn = null;
            conn = new SqlConnection(connectString);
            //打开数据库连接
            conn.Open();
            //创建 SQLDataAdapter 类的对象
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //创建DataSet类的对象
            DataSet ds = new DataSet();
            //使用SQLDataAdapter对象sda将查询结果填充到Dataset对象ds中
            sda.Fill(ds);
            conn.Close();
            return ds;
        }
        public bool SqlCheck(string sql)
        {
            bool tag = false;
            conn = new SqlConnection(connectString);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result1 = Convert.ToInt32(cmd.ExecuteScalar());
                if (result1 > 0)
                {
                    tag = true;
                }
                return tag;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {

                conn.Close();

            }
        }
    }
}


