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
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        private void RptInput(object sender, EventArgs e)
        {
            if (rptPgNo.Text == "")
            {
                rptPgNo.Select(rptPgNo.Text.Length, 0);
            }
        }

        private void Focus_Search(object sender, EventArgs e)
        {
            if (rptSearch.Text == "Search Here")
            {
                rptSearch.Clear();
            }
        }

        SaveFileDialog fileSave = new SaveFileDialog();

        private void SaveAsPdf(object sender, EventArgs e)
        {
            fileSave.Filter = "PdfFiles(*.pdf;)|*.pdf";
            if (fileSave.ShowDialog() == DialogResult.OK)
            {
                reportTextBox.SaveFile(fileSave.FileName);
            }
        }
    }
}
