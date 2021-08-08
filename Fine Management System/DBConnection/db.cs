
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fine_Management_System.DBConnection
{
    class DB
    {
        public static MySqlDataReader Read(string query)
        {
            MySqlDataReader dr = null;
            string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
            MySqlConnection conn = new MySqlConnection(connStr);
            
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                dr = cmd.ExecuteReader();

            }
                
            catch (MySqlException ex)
            {
                throw ex;
               
            }
            catch (Exception)
            {

            }
            return dr;
        }

        public static MySqlConnection Conn()
        {
            string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
            }

            catch (MySqlException ex)
            {
                //throw ex;
                MessageBox.Show(ex.Message);
            }
            return conn;
        }


        public static void Write(string query)
        {
            string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex )
            {
                throw ex;
            }
            catch (Exception)
            {

            }
            conn.Close();
        }

        public static void Delete(string query)
        {
            string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
            }
            conn.Close();
        }

        public static void Update(string query)
        {
            string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            conn.Close();
        }
    }
}
