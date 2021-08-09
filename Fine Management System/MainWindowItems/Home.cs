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
        private MySqlConnection conn;
        private MySqlCommand cmd = null;
        private string query;
        public Home()
        {
            InitializeComponent();
            conn = DBConnection.DB.Conn();
            MainWindow.DBConnectionHelath = true;
            WeeklyChart();
            MonthlyChart();
            PieChart();
            setYearlyCases();
            setDailyCases();
            setIncome();
            SetCasesByDate();
            SetThisMonthChart();
            conn.Close();
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 5000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GenGraph();
        }

        private void GenGraph()
        {
            
        }



        private void WeeklyChart() {
            if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
            {
                MySqlDataReader dr = null;
                try
                {
                    for (int i = 7; i > 0; i--)
                    {
                        string count = "0";
                        query = "SELECT COUNT(Ref_No) AS count FROM fine_receipt WHERE YEARWEEK(Date) = YEARWEEK(NOW() - INTERVAL " + i + " WEEK);SELECT DAY(NOW() - INTERVAL " + i + " WEEK + INTERVAL 7 Day) as ed, DAY(NOW() - INTERVAL " + i + " WEEK) as st";
                        cmd = new MySqlCommand(query, conn);
                        dr = cmd.ExecuteReader();
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
                        dr.Close();
                    }
                    
                } 
                catch (MySqlException er)
                {
                    MessageBox.Show(er.Message);
                    //MainWindow.DBConnectionHelath = false;
                }
                catch (Exception)
                {

                }
                finally
                {
                    if(dr != null)
                    {
                        dr.Close();
                    }
                    
                }
            }
        } 


        private void MonthlyChart()
        {
            MySqlDataReader dr = null;
            if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
                {
                try
                {
                    query = "SELECT MONTHNAME(Date) AS Month, COUNT(Ref_No) as count FROM fine_receipt WHERE Date >= CURDATE() - INTERVAL 1 YEAR GROUP BY MONTH(Date)";
                    cmd = new MySqlCommand(query, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        chartMonthlyCases.Series["Series1"].Points.AddXY(dr.GetString("Month"), dr.GetString("count"));
                    }
                    dr.Close();
                }
                catch (MySqlException)
                {
                    MainWindow.DBConnectionHelath = false;
                }
                
                finally
                {
                    dr.Close();
                }
            }
        }


        private void PieChart()
        {
            MySqlDataReader dr = null;
            if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
            {
                
                try
                {
                query = "SELECT COUNT(Ref_No) as count, DAYNAME(Date) as date FROM fine_receipt WHERE Date >= DATE(NOW()) - INTERVAL 7 DAY GROUP BY DAY(Date)";
                cmd = new MySqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    chartThisWeek.Series["Series1"].Points.AddXY(dr.GetString("Date").Substring(0, 3), dr.GetString("count"));

                }
                    dr.Close();
                }
            catch (MySqlException)
                {
                    MainWindow.DBConnectionHelath = false;

                }
                finally
                {
                    dr.Close();
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
                    cmd = new MySqlCommand(query, conn);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                        labelTotalCases.Text = dr.GetString("count") + " Cases";
                        dr.Close();
                    }
                    catch (MySqlException)
                    {
                        MainWindow.DBConnectionHelath = false;

                    }
                    finally
                    {
                        dr.Close();
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
                        cmd = new MySqlCommand(query, conn);
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        labelDailyCases.Text = dr.GetString("count") + " Cases";
                        dr.Close();
                    }
                    catch(MySqlException)
                    {
                         MainWindow.DBConnectionHelath = false;
                    }
                    finally
                    {
                        dr.Close();
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
                        cmd = new MySqlCommand(query, conn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            labelTodayIncome.Text = "Rs:" + dr.GetFloat("sum").ToString();
                        }
                        
                        dr.Close();
                    }
                    catch (MySqlException)
                    {
                        labelTodayIncome.Text = "Rs: 0.00";
                        MainWindow.DBConnectionHelath = false;
                    }
                    catch (Exception)
                    {

                    }
                    finally
                    {
                        dr.Close();
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
                    dr = DBConnection.DB.Read(query);
                    while (dr.Read())
                    {
                        chartThisMonth.Series["Series1"].Points.AddXY(dr.GetString("date"), dr.GetInt32("sum") / 1000);
                    }
                }
                dr.Close();

            }
            catch (MySqlException) {
                MainWindow.DBConnectionHelath = false;
            }
            finally
            {
                dr.Close();
            }

        }

        private void chartThisWeek_Click(object sender, EventArgs e)
        {

        }

        private void SetCasesByDate() {
            MySqlDataReader dr = null;
            try
            {
                if (Convert.ToBoolean(MainWindow.DBConnectionHelath ))
                {
                    Label[] dates = { date1, date2, date3, date4, date5 };
                    Label[] values = { value1, value2, value3, value4, value5 };
                    
                    for (int i = 0; i < 5; i++)
                    {
                        query = "SELECT DATE_FORMAT((DATE(NOW()) - INTERVAL " + i + " Day),'%Y-%m-%d') as date ,COUNT(Ref_No) count FROM fine_receipt WHERE Date = DATE(NOW()) - INTERVAL " + i + " Day;";
                        cmd = new MySqlCommand(query, conn);
                        dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            dates[i].Text = dr.GetString("date");
                            values[i].Text = dr.GetString("count");
                        }
                        dr.Close();
                    }
                    
                }
                
            }
            catch (MySqlException)
            {
            }
            finally
            {
                dr.Close();
            }

        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
    }


