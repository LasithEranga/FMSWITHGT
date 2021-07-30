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
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

            table.DataSource = dtbl;
        }
    }
}
