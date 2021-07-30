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
        public Statistics()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {//fils chart with dummy data values
                chartPanelChart.Series["Series1"].Points.AddXY(i, i * 100);
            }
        }

        private void a(object sender, PaintEventArgs e)
        {

        }
    }
}
