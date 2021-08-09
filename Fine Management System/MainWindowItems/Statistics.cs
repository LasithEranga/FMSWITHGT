﻿using MySql.Data.MySqlClient;
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
        private string viewBy = "DATE_FORMAT(date,'%d')";
        private string group = " Group by Date(date)";


        public Statistics()
        {
            InitializeComponent();
            loading.Hide();
            chartPanelChart.Series[0].Color = Color.FromArgb(137, 207, 240);
            
        }


        private void GoBtnClick(object sender, EventArgs e)
        {
            dtpicker1.Format = DateTimePickerFormat.Custom;
            dtpicker1.CustomFormat = "yyyy-MM-dd";
            dtpicker2.Format = DateTimePickerFormat.Custom;
            dtpicker2.CustomFormat = "yyyy-MM-dd";
            //loading
            loading.Text = "Loading....";
            
            switch (selection)
            {
                case 0:
                    query = "SELECT SUM(amount) as yaxis, "+ viewBy +" as xaxis FROM payment ";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text+"' " + group, "xaxis", "yaxis");
                    break;
                case 1:
                    query = "SELECT SUM(amount) as yaxis, MONTHNAME(date) as xaxis FROM payment ";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "' " + group, "xaxis", "yaxis");
                    break;
                case 2:
                    query = "SELECT SUM(amount) as yaxis, YEAR(date) as xaxis FROM payment ";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "' " + group, "xaxis", "yaxis");
                    break;


            }
            
        }

        private void NoCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selection = 1;
            FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "' "+group, "xaxis", "yaxis");
        }

        private void vehicleTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selection = 2;
            FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "' "+group, "xaxis", "yaxis");
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selection = 0;
            FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "' "+group, "xaxis", "yaxis");
        }

        private void FillChart(string query, string x, string y)
        {
           
            MySqlDataReader dr = null;
            try
            {
                loading.Show();
                if (Convert.ToBoolean(MainWindow.DBConnectionHelath))
                {
                    dr = DBConnection.DB.Read(query);
                    chartPanelChart.Series["Series1"].Points.Clear();
                    while (dr.Read())
                    {
                        chartPanelChart.Series["Series1"].Points.AddXY(dr.GetString(x), dr.GetString(y));
                    }
                    dr.Close();
                }
                loading.Hide();
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
                
            }
        }

        private void goBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBy = "DATE_FORMAT(date,'%d')";
            group = " Group by Date(date)";
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBy = "MONTHNAME(date)";
            group = " Group by Month(date)";
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBy = "YEAR(date)";
            group = " Group by Year(date)";
        }

        private void go_tip(object sender, EventArgs e)
        {
            toolTip4.Show("Go", goBtn);
        }

        private void lineChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartPanelChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void barGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartPanelChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            
        }

        private void chartTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartTypeToolStripMenuItem.ForeColor = Color.Black;
        }

        private void DropDownClosed(object sender, EventArgs e)
        {
            chartTypeToolStripMenuItem.ForeColor = Color.White;
        }

        private void MouseHoverCT(object sender, EventArgs e)
        {
           
        }
    }
}
