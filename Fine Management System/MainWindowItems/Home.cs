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
    }
}
