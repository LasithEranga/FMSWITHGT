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
        public ShowReceipt()
        {
            InitializeComponent();
            string connStr = "server=localhost;user=root;database=fmsdb;port=3306;password=;SSL Mode=None;";
            MySqlDataAdapter sqlda = new MySqlDataAdapter("Select * from fine_receipt", connStr);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            table.DataSource = dtbl;
        }


        private void ShowReceipt_Load(object sender, EventArgs e)
        {

        }

        public void setData(string id) {
            string connStr = "server=localhost;user=root;database=fmsdb;port=3306;password=;SSL Mode=None;";
            MySqlDataAdapter sqlda = new MySqlDataAdapter("Select * from fine_receipt WHERE Ref_No = " + id, connStr);
            labelRef.Text = "Ref No: 0" +  id;
            SetDriverName(id);
            SetDateAmount(id);
            SetOfficerName(id);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            table.DataSource = dtbl;
        }


        private void SetDriverName(string id) {

            string query = "SELECT * FROM driver WHERE nic = (SELECT driver_nic FROM fine_receipt WHERE Ref_No = " +id + ") ";
            MySqlDataReader dr = DBConnection.db.Read(query);
            try
            {
                dr.Read();
                labelDriverName.Text ="Driver Name: "+ dr.GetString("fname") + " "+ dr.GetString("lname");
            }
            catch (Exception nl)
            {

            }
        }
        private void SetDateAmount(string id)
        {

            string query = "SELECT Date,Amount FROM fine_receipt WHERE Ref_No = " + id;
            MySqlDataReader dr = DBConnection.db.Read(query);
            try
            {
                dr.Read();
                labelDate.Text = "Date : " + dr.GetString("Date");
                labelFineAmount.Text = "Fine Amount: Rs: " + dr.GetString("Amount") + ".00";
            }
            catch (Exception nl)
            {

            }
        }

        private void SetOfficerName(string id)
        {
            string query = "SELECT * FROM traffic_police_officer WHERE police_id = (SELECT officer_id FROM fine_receipt WHERE Ref_No = " + id + ") ";
            MySqlDataReader dr = DBConnection.db.Read(query);
            try
            {
                dr.Read();
                labelPoliceOfficer.Text = "Officer : " + dr.GetString("fname") +" "+ dr.GetString("lname");
            }
            catch (Exception nl)
            {

            }
        }

    }


}
