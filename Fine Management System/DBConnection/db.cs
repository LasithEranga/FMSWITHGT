
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fine_Management_System.DBConnection
{
    class db
    {
        public static MySqlDataReader Read(string query)
        {
            MySqlDataReader dr = null;
            string connStr = "server=localhost;user=root;database=fmsdb;port=3306;password=;SSL Mode=None;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try{
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                dr = cmd.ExecuteReader();

            }
                
            catch (MySqlException ex)
            {
                throw ex;
            }
            return dr;
        }

        public static void Write(string query)
        {
            string connStr = "server=localhost;user=root;database=fmsdb;port=3306;password=;SSL Mode=None;";
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

        public static void Delete(string query)
        {
            string connStr = "server=localhost;user=root;database=fmsdb;port=3306;password=;SSL Mode=None;";
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
            string connStr = "server=localhost;user=root;database=fmsdb;port=3306;password=;SSL Mode=None;";
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
