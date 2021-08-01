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
            WeeklyChart();
            MonthlyChart();


        }

        private void a(object sender, PaintEventArgs e)
        {

        }

        private void WeeklyChart() {

            
            for (int i=7; i>0; i--)
            {
                string count = "0"; ;
                MySqlDataReader dr = null;
                dr = DBConnection.db.Read("SELECT COUNT(Ref_No) AS count FROM fine_receipt WHERE YEARWEEK(Date) = YEARWEEK(NOW() - INTERVAL " + i + " WEEK);SELECT DAY(NOW() - INTERVAL "+ i + " WEEK + INTERVAL 7 Day) as ed, DAY(NOW() - INTERVAL " + i + " WEEK) as st");
                try
                {
                    while (dr.Read())
                    {
                        count = dr.GetString("count");
                    }

                    if (dr.NextResult())
                    {
                        while (dr.Read())
                        {
                            chartWeekly.Series["Series1"].Points.AddXY(dr.GetString("st") + "-" + dr.GetString("ed") , count);
                        }
                    }
                }
                catch (Exception error) {
                    MessageBox.Show(error.Message);
                }

            }


        }


        private void MonthlyChart()
        {
                MySqlDataReader dr = null;
                dr = DBConnection.db.Read("SELECT MONTH(Date) AS Month, COUNT(Ref_No) as count FROM fine_receipt WHERE Date >= CURDATE() - INTERVAL 1 YEAR GROUP BY MONTH(Date); ");
                try
                {
                    while (dr.Read())
                    {
                        chartMonthlyCases.Series["Series1"].Points.AddXY(dr.GetString("Month"), dr.GetString("count"));
                    }
                }
                catch (Exception)
                {

                }

        }

        private void FillCharts()
        {//fils chart with dummy data values
            for (int i = 0; i < 10; i++)
            {
                chartThisMonth.Series["Series1"].Points.AddXY(i, i * i + 50);

            }

            MySqlDataReader weekData = DBConnection.db.Read("SELECT COUNT(Ref_No) as count, DAYNAME(Date) as date FROM fine_receipt WHERE Date >= DATE(NOW()) - INTERVAL 7 DAY GROUP BY DAY(Date)");
            while (weekData.Read())
            {
                chartThisWeek.Series["Series1"].Points.AddXY(weekData.GetString("Date").Substring(0,3), weekData.GetString("count"));
            }

        }


        private void setYearlyCases() {
            string query = "SELECT COUNT(Ref_No) As count FROM fine_receipt WHERE Date >= CURDATE() - INTERVAL 1 YEAR ";
            MySqlDataReader dr = DBConnection.db.Read(query);
            try { dr.Read();
                labelTotalCases.Text = dr.GetString("count") + " Cases";
            }
            catch (Exception)
            {

            }

        }

        private void setDailyCases()
        {
            string query = "SELECT COUNT(Ref_No) As count FROM fine_receipt WHERE date = CURRENT_DATE";
            MySqlDataReader dr = DBConnection.db.Read(query);
            try { dr.Read();
                labelDailyCases.Text = dr.GetString("count") + " Cases";
            }
            catch (Exception)
            {

            }
            
        }
        private void setIncome()
        {
            string query = "SELECT SUM(amount) AS sum FROM payment WHERE date = CURRENT_DATE";
            MySqlDataReader dr = DBConnection.db.Read(query);
            try { dr.Read();
                labelTodayIncome.Text = "Rs:" + dr.GetString("sum") + ".00";
            }
            catch (Exception)
            {
                labelTodayIncome.Text = "Rs: 0.00";
            }
            
        }


    }

}
