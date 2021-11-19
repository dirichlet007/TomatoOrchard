using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace Management.DataBase
{
    class DataBaseHelper
    {

        private String connetStr = "server=127.0.0.1;port=3306;user=root;password=tyf241119=; database=management;";
        private MySqlConnection connection;
        public MySqlConnection Connection
        {        
            get
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(connetStr);
                }
                return connection;
            }
        }
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)
            {
                Connection.Close();
                Connection.Open();
            }
        }
        public void CloseConnection()
        {
                if (Connection.State == ConnectionState.Open || Connection.State == ConnectionState.Broken)
                {
                    Connection.Close();
                }
            
        }
        public void Sqlinsert(string sql)
        {
            DataBaseHelper db = new DataBaseHelper();
            MySqlConnection con = db.Connection;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }

        }



    
        public void Sqlcheck(string sql,Action func1,Action func2)
        {
            DataBaseHelper db = new DataBaseHelper();
            MySqlConnection con = db.Connection;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand(sql, con);
                int result1 = Convert.ToInt32(cmd1.ExecuteScalar());
                if (result1 > 0)
                {
                    func1();
                }
                else
                {
                    func2();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}

