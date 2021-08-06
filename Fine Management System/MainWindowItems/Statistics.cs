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

namespace Fine_Management_System.MainWindowItems
{
    public partial class Statistics : UserControl
    {
        private string query = "SELECT SUM(amount) as yaxis, DATE_FORMAT(date,'%Y-%m-%d') as xaxis FROM payment";
        private int selection = 0;
        public Statistics()
        {
            InitializeComponent();
            FillChart(query +" where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "';", "xaxis", "yaxis");
        }

        private void GoBtnClick(object sender, EventArgs e)
        {
            dtpicker1.Format = DateTimePickerFormat.Custom;
            dtpicker1.CustomFormat = "d-M-yyyy";
            dtpicker2.Format = DateTimePickerFormat.Custom;
            dtpicker2.CustomFormat = "d-M-yyyy";
            switch (selection)
            {
                case 0:
                    query = "SELECT SUM(amount) as yaxis, DATE_FORMAT(date,'%Y-%m-%d') as xaxis FROM payment";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "';", "xaxis", "yaxis");
                    break;
                case 1:
                    query = "SELECT SUM(amount) as yaxis, DATE_FORMAT(date,'%Y-%m-%d') as xaxis FROM payment";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "';", "xaxis", "yaxis");
                    break;
                case 2:
                    query = "SELECT SUM(amount) as yaxis, DATE_FORMAT(date,'%Y-%m-%d') as xaxis FROM payment";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "';", "xaxis", "yaxis");
                    break;


            }


        }

        private void NoCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selection = 1;
            FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "';", "xaxis", "yaxis");
        }

        private void vehicleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selection = 2;
            FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "';", "xaxis", "yaxis");
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selection = 0;
            FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "';", "xaxis", "yaxis");
        }

        private void FillChart(string query, string x, string y)
        {
            MySqlDataReader dr = null;
            try
            {
                if (Convert.ToBoolean(MainWindow.DBConnectionHelath))
                {
                    MessageBox.Show(query);
                    dr = DBConnection.db.Read(query);
                    while (dr.Read())
                    {
                        
                        chartPanelChart.ResetAutoValues();chartPanelChart.Series["Series1"].Points.AddXY(dr.GetString(x), dr.GetString(y));
                    }
                }

            }
            catch (MySqlException)
            {
                MainWindow.DBConnectionHelath = false;
            }
        }

        private void goBtn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
