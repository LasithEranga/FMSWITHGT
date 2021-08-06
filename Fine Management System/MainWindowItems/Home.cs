using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            MainWindow.DBConnectionHelath = true;
            WeeklyChart();
            MonthlyChart();
            SetCasesByDate();
            PieChart();
            SetThisMonthChart();
            setYearlyCases();
            setDailyCases();
            setIncome();
            
        }

        private void WeeklyChart() {
            if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
            {
                
                try
                {
                    for (int i = 7; i > 0; i--)
                    {
                        string count = "0";
                        MySqlDataReader dr = null;
                        dr = DBConnection.db.Read("SELECT COUNT(Ref_No) AS count FROM fine_receipt WHERE YEARWEEK(Date) = YEARWEEK(NOW() - INTERVAL " + i + " WEEK);SELECT DAY(NOW() - INTERVAL " + i + " WEEK + INTERVAL 7 Day) as ed, DAY(NOW() - INTERVAL " + i + " WEEK) as st");
                        while (dr.Read())
                        {
                            count = dr.GetString("count");
                        }

                        if (dr.NextResult())
                        {
                            while (dr.Read())
                            {
                                chartWeekly.Series["Series1"].Points.AddXY(dr.GetString("st") + "-" + dr.GetString("ed"), count);
                            }
                        }
                    }
                }
                catch (MySqlException)
                {
                    MainWindow.DBConnectionHelath = false;
                }
             }
        } 


        private void MonthlyChart()
        {
                if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
                {
                try
                {
                    MySqlDataReader dr = null;
                    dr = DBConnection.db.Read("SELECT MONTHNAME(Date) AS Month, COUNT(Ref_No) as count FROM fine_receipt WHERE Date >= CURDATE() - INTERVAL 1 YEAR GROUP BY MONTH(Date); ");
                    while (dr.Read())
                    {
                        chartMonthlyCases.Series["Series1"].Points.AddXY(dr.GetString("Month"), dr.GetString("count"));
                    }
                }
                catch (MySqlException)
                {
                    MainWindow.DBConnectionHelath = false;
                }
            }
        }


        private void PieChart()
        {
            if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
            {
            try
            {
                MySqlDataReader weekData = null;
                weekData = DBConnection.db.Read("SELECT COUNT(Ref_No) as count, DAYNAME(Date) as date FROM fine_receipt WHERE Date >= DATE(NOW()) - INTERVAL 7 DAY GROUP BY DAY(Date)");
                while (weekData.Read())
                {
                    chartThisWeek.Series["Series1"].Points.AddXY(weekData.GetString("Date").Substring(0, 3), weekData.GetString("count"));

                }
            }
            catch (MySqlException)
                {
                    MainWindow.DBConnectionHelath = false;

                }

            }

        }



        private void setYearlyCases() {
            string query = "SELECT COUNT(Ref_No) As count FROM fine_receipt WHERE Date >= CURDATE() - INTERVAL 1 YEAR ";
            MySqlDataReader dr = null;
            
                if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
                {
                    try
                    {
                        dr = DBConnection.db.Read(query);
                        dr.Read();
                        labelTotalCases.Text = dr.GetString("count") + " Cases";
                    }
                    catch (MySqlException)
                    {
                        MainWindow.DBConnectionHelath = false;
                }
                } 
        }

        private void setDailyCases()
        {
            string query = "SELECT COUNT(Ref_No) As count FROM fine_receipt WHERE date = CURRENT_DATE";
            MySqlDataReader dr = null;
            
                if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
                {
                    try
                    {
                        dr = DBConnection.db.Read(query);
                        dr.Read();
                        labelDailyCases.Text = dr.GetString("count") + " Cases";
                    }
                    catch(MySqlException)
                    {
                         MainWindow.DBConnectionHelath = false;
                }
            }
        }


        private void setIncome()
        {
            string query = "SELECT SUM(amount) AS sum FROM payment WHERE date = CURRENT_DATE";
            MySqlDataReader dr = null;
            
                if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
                {
                    try
                    {
                        dr = DBConnection.db.Read(query);
                        dr.Read();
                        labelTodayIncome.Text = "Rs:" + dr.GetString("sum") + ".00";
                    }
                    catch (MySqlException)
                    {

                        MainWindow.DBConnectionHelath = false;
                }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        labelTodayIncome.Text = "Rs: 0.00";
                    }
                } 

        }

        private void SetThisMonthChart() {
            string query = "SELECT SUM(amount) as sum, DAY(date) as date FROM payment WHERE date >= DATE(NOW())-INTERVAL 30 Day Group by DATE(date)";
            MySqlDataReader dr = null;
            try
            {
                if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
                {
                    dr = DBConnection.db.Read(query);
                    while (dr.Read())
                    {
                        chartThisMonth.Series["Series1"].Points.AddXY(dr.GetString("date"), dr.GetInt32("sum") / 1000);
                    }
                } 
                
            }
            catch (MySqlException) {
                MainWindow.DBConnectionHelath = false;
            }
            
        }

        private void chartThisWeek_Click(object sender, EventArgs e)
        {

        }

        private void SetCasesByDate() {
            try
            {
                if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
                {
                    Label[] dates = { date1, date2, date3, date4, date5 };
                    Label[] values = { value1, value2, value3, value4, value5 };
                    MySqlDataReader dr = null;
                    for (int i = 0; i < 5; i++)
                    {
                        string query = "SELECT DATE_FORMAT((DATE(NOW()) - INTERVAL " + i + " Day),'%Y-%m-%d') as date ,COUNT(Ref_No) count FROM fine_receipt WHERE Date = DATE(NOW()) - INTERVAL " + i + " Day;";
                        dr = DBConnection.db.Read(query);
                        while (dr.Read())
                        {
                            dates[i].Text = dr.GetString("date");
                            values[i].Text = dr.GetString("count");
                        }
                        
                    }

                }
            }
            catch (MySqlException)
            {
            }

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


