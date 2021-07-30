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

namespace Fine_Management_System
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            FillCharts();
            setYearlyCases();
            setDailyCases();
            setIncome();


        }

        private void a(object sender, PaintEventArgs e)
        {

        }
        private void FillCharts()
        {//fils chart with dummy data values
            for (int i = 0; i < 10; i++)
            {
                chartWeekly.Series["Series1"].Points.AddXY(i, i * 100);
            }
            for (int i = 0; i < 10; i++)
            {
                chartThisMonth.Series["Series1"].Points.AddXY(i, i * i + 50);

            }

            for (int i = 0; i < 10; i++)
            {
                chartMonthlyCases.Series["Series1"].Points.AddXY(i, i * i + 50);
            }

            chartThisWeek.Series["Series1"].Points.AddXY("Mon", "22");
            chartThisWeek.Series["Series1"].Points.AddXY("Tue", "56");
            chartThisWeek.Series["Series1"].Points.AddXY("Wed", "45");
            chartThisWeek.Series["Series1"].Points.AddXY("Thur", "78");
            chartThisWeek.Series["Series1"].Points.AddXY("Fri", "12");
            chartThisWeek.Series["Series1"].Points.AddXY("Sat", "58");
            chartThisWeek.Series["Series1"].Points.AddXY("Sun", "95");

        }

        private void chartThisWeek_Click(object sender, EventArgs e)
        {

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void setYearlyCases() {
            string query = "SELECT COUNT(Ref_No) As count FROM fine_receipt WHERE date >= '2021-01-01' ";
            MySqlDataReader dr = DBConnection.db.Read(query);
            try { dr.Read();
                labelTodayIncome.Text = "Rs:" + dr.GetString("sum") + ".00";
            }
            catch (Exception nl)
            {

            }
            labelTotalCases.Text = dr.GetString("count")+" Cases";

        }

        private void setDailyCases()
        {
            string query = "SELECT COUNT(Ref_No) As count FROM fine_receipt WHERE date >= '2021-01-01' ";
            MySqlDataReader dr = DBConnection.db.Read(query);
            try { dr.Read();
                labelTodayIncome.Text = "Rs:" + dr.GetString("sum") + ".00";
            }
            catch (Exception nl)
            {

            }
            labelDailyCases.Text = dr.GetString("count") + " Cases";
        }
        private void setIncome()
        {
            string query = "SELECT SUM(amount) AS sum FROM payment WHERE date = CURRENT_DATE";
            MySqlDataReader dr = DBConnection.db.Read(query);
            try { dr.Read();
                labelTodayIncome.Text = "Rs:" + dr.GetString("sum") + ".00";
            }
            catch (Exception nl)
            {

            }
            
        }
    }

}
