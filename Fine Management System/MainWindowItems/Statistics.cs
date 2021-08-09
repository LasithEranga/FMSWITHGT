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
        private string viewBy = "DATE_FORMAT(date,'%d')";
        private string group = " Group by Date(date)";


        public Statistics()
        {
            InitializeComponent();
            loading.Hide();
            dtpicker1.Format = DateTimePickerFormat.Custom;
            dtpicker1.CustomFormat = "yyyy-MM-dd";
            dtpicker2.Format = DateTimePickerFormat.Custom;
            dtpicker2.CustomFormat = "yyyy-MM-dd";
            dtpicker1.Value = DateTime.Today.AddDays(-14);
            loading.Text = "Loading....";

            chartPanelChart.Series[0].Color = Color.FromArgb(137, 207, 240);
            
        }


        private void GoBtnClick(object sender, EventArgs e)
        {
            
            //loading
            
            
            switch (selection)
            {
                case 0:
                    query = "SELECT SUM(amount) as yaxis, "+ viewBy +" as xaxis FROM payment ";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text+"' " + group, "xaxis", "yaxis");
                    break;
                case 1:
                    query = "SELECT COUNT(Ref_No) as yaxis, " + viewBy + " as xaxis FROM fine_receipt ";
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
            yaxis.Text = "No of Cases";
            statLegendLabel.Text = "No of Cases";
            casesLabel.Text = "No of Cases";
            query = "SELECT COUNT(Ref_No) as yaxis, " + viewBy + " as xaxis FROM fine_receipt ";
            FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "' "+group, "xaxis", "yaxis");
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selection = 0;
            yaxis.Text = "Amount(Rs)";
            casesLabel.Text = "Amount";
            statLegendLabel.Text = "Revenue";
            query = "SELECT SUM(amount) as yaxis, " + viewBy + " as xaxis FROM payment ";
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
            xaxis.Text = "Date";
            group = " Group by Date(date)";
            LoadChart();
        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBy = "MONTHNAME(date)";
            xaxis.Text = "Month";
            group = " Group by Month(date)";
            LoadChart();
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBy = "YEAR(date)";
            xaxis.Text = "Year";
            group = " Group by Year(date)";
            LoadChart();
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





        private void ViewClick(object sender, EventArgs e)
        {
            sortByToolStripMenuItem.ForeColor = Color.Black;
        }

        private void ViewByDropdownCLosed(object sender, EventArgs e)
        {
            sortByToolStripMenuItem.ForeColor = Color.White;
        }

        private void CatClick(object sender, EventArgs e)
        {
            categoryToolStripMenuItem.ForeColor = Color.Black;
        }

        private void CatDropdownClosed(object sender, EventArgs e)
        {
            categoryToolStripMenuItem.ForeColor = Color.White;
        }

        private void LoadChart() {

            switch (selection)
            {
                case 0:
                    query = "SELECT SUM(amount) as yaxis, " + viewBy + " as xaxis FROM payment ";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "' " + group, "xaxis", "yaxis");
                    break;
                case 1:
                    query = "SELECT COUNT(Ref_No) as yaxis, " + viewBy + " as xaxis FROM fine_receipt ";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "' " + group, "xaxis", "yaxis");
                    break;
                case 2:
                    query = "SELECT SUM(amount) as yaxis, YEAR(date) as xaxis FROM payment ";
                    FillChart(query + " where date >= '" + dtpicker1.Text + "' OR date < '" + dtpicker2.Text + "' " + group, "xaxis", "yaxis");
                    break;


            }
        }
    }
}
