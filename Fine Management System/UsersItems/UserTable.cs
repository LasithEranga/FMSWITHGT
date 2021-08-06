using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fine_Management_System.UsersItems
{
    public partial class UserTable : UserControl
    {
        public UserTable()
        {
            InitializeComponent();
        }

        public void UserTableAllUser()
        {
            try
            {
                string connStr = "server=localhost;user=root;database=fmsdb;port=3306;password=;SSL Mode=None;";
                MySqlDataAdapter sqlda = new MySqlDataAdapter("Select * from driver WHERE 1", connStr);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                MySqlDataAdapter sqlda1 = new MySqlDataAdapter("Select * from traffic_police_officer WHERE 1", connStr);
                DataTable dtbl1 = new DataTable();
                sqlda1.Fill(dtbl1);
                dtbl.Merge(dtbl1);

                table.DataSource = dtbl;
            }
            catch (Exception)
            {
                new Error_messages.InputError("DB", "sdjkbf");
            }
            
        }

        public void UserTableDriver()
        {
            string connStr = "server=localhost;user=root;database=fmsdb;port=3306;password=;SSL Mode=None;";
            MySqlDataAdapter sqlda = new MySqlDataAdapter("Select * from driver WHERE 1", connStr);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            table.DataSource = dtbl;
        }

        public void UserTableOfficer()
        {
            string connStr = "server=localhost;user=root;database=fmsdb;port=3306;password=;SSL Mode=None;";
            MySqlDataAdapter sqlda = new MySqlDataAdapter("Select * from traffic_police_officer", connStr);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            table.DataSource = dtbl;
        }
    }
}
