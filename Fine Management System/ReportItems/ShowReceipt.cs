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

namespace Fine_Management_System.ReportItems
{
    public partial class ShowReceipt : UserControl
    {
        private MySqlConnection conn = null;
        private MySqlCommand cmd = null;
        private string query;
       
        public ShowReceipt()
        {
                InitializeComponent();
        }


        public void setData(string id) {
            conn = DBConnection.DB.Conn();
            string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
            MySqlDataAdapter sqlda = new MySqlDataAdapter("Select * from fine_receipt WHERE Ref_No = " + id, connStr);
            labelRef.Text = "Ref No: 0" +  id;
            SetDriverName(id);
            SetDateAmount(id);
            SetOfficerName(id);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            table.DataSource = dtbl;
            conn.Close();
        }


        private void SetDriverName(string id) {

            query = "SELECT * FROM driver WHERE nic = (SELECT driver_nic FROM fine_receipt WHERE Ref_No = " +id + ") ";
            cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            try
            {
                dr.Read();
                labelDriverName.Text ="Driver Name: "+ dr.GetString("fname") + " "+ dr.GetString("lname");
                dr.Close();
            }
            catch (Exception nl)
            {

            }
        }
        private void SetDateAmount(string id)
        {

            query = "SELECT Date,Amount FROM fine_receipt WHERE Ref_No = " + id;
            cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            try
            {
                dr.Read();
                labelDate.Text = "Date : " + dr.GetString("Date");
                labelFineAmount.Text = "Fine Amount: Rs: " + dr.GetString("Amount") + ".00";
                dr.Close();
            }
            catch (Exception nl)
            {

            }
        }

        private void SetOfficerName(string id)
        {
            query = "SELECT * FROM traffic_police_officer WHERE police_id = (SELECT officer_id FROM fine_receipt WHERE Ref_No = " + id + ") ";
            cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            try
            {
                dr.Read();
                labelPoliceOfficer.Text = "Officer : " + dr.GetString("fname") +" "+ dr.GetString("lname");
                dr.Close();
            }
            catch (Exception nl)
            {

            }
        }

        private void labelRef_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
