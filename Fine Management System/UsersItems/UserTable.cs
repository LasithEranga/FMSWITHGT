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
                string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
                MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT `nic` as NIC, `fname` as First_Name, `lname` as Last_Name, `full_name` as Full_Name, `email` as Email, `contact_no` as Contact_No, `address` as Address, `license_no` as License_No, `vehicle_no` as vehicle_No FROM `driver`", connStr);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                MySqlDataAdapter sqlda1 = new MySqlDataAdapter("SELECT `police_id` as Police_ID, `fname` as Fisrt_Name, `lname` as Last_Name, `full_name` as Full_Name, `email` as Email, `nic` as NIC, `contact_no` as Contact_No, `post` as Post, `address` as Address FROM `traffic_police_officer` WHERE 1", connStr);
                DataTable dtbl1 = new DataTable();
                sqlda1.Fill(dtbl1);
                dtbl.Merge(dtbl1);
                table.DataSource = dtbl;
            }
            catch (Exception)
            {
                new Error_messages.InputError("Database Error", "Cannot connet to database");
            }
            
        }

        public void UserTableWithFilter(string query)
        {
            try
            {
                string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
                MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT `nic` as NIC, `fname` as First_Name, `lname` as Last_Name, `full_name` as Full_Name, `email` as Email, `contact_no` as Contact_No, `address` as Address, `license_no` as License_No, `vehicle_no` as vehicle_No FROM `driver`", connStr);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                MySqlDataAdapter sqlda1 = new MySqlDataAdapter(query, connStr);
                DataTable dtbl1 = new DataTable();
                sqlda1.Fill(dtbl1);
                dtbl.Merge(dtbl1);

                table.DataSource = dtbl;
            }
            catch (Exception)
            {
                new Error_messages.InputError("Database Error", "Cannot connet to database");
            }

        }

        public void UserTableDriver()
        {
            string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT `nic` as NIC, `fname` as First_Name, `lname` as Last_Name, `full_name` as Full_Name, `email` as Email, `contact_no` as Contact_No, `address` as Address, `license_no` as License_No, `vehicle_no` as vehicle_No FROM `driver`", connStr);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            table.DataSource = dtbl;
        }

        public void UserTableOfficer()
        {
            string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT `police_id` as Police_ID, `fname` as Fisrt_Name, `lname` as Last_Name, `full_name` as Full_Name, `email` as Email, `nic` as NIC, `contact_no` as Contact_No, `post` as Post, `address` as Address FROM `traffic_police_officer` WHERE 1", connStr);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            table.DataSource = dtbl;
        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Clecked!");
        }

        private void RowHeaderClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch (MainWindowItems.Users.GetActive())
            {
                case 1:
                    {//officers
                        int rowindex = table.CurrentRow.Index;
                        DataGridViewRow selectedRow = table.Rows[rowindex];
                        string cellValue = Convert.ToString(selectedRow.Cells["Police_ID"].Value);
                        new Popup.UpdateOfficer(cellValue).Show();
                        break;
                    }
                case 2:
                    {//driver
                        int rowindex = table.CurrentRow.Index;
                        DataGridViewRow selectedRow = table.Rows[rowindex];
                        string cellValue = Convert.ToString(selectedRow.Cells["NIC"].Value);
                        new Popup.DriverUpdate(cellValue).Show();
                        break;
                    }
            }
        }
    }
}
