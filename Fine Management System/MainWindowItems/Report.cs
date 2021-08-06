using iTextSharp.text;
using iTextSharp.text.pdf;
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
            fineReceipt1.Save();
        }

        private void saveAsPdfBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void rptSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlDataReader dr = null;
                dr = DBConnection.DB.Read("SELECT Ref_No FROM `fine_receipt` WHERE Ref_No LIKE '" + rptSearch.Text + "%' ");
                AutoCompleteStringCollection Collection = new AutoCompleteStringCollection();
                while (dr.Read())
                {
                    //MessageBox.Show(dr.GetString("Ref_No"));
                    Collection.Add(dr.GetString("Ref_No"));
                }
                rptSearch.AutoCompleteCustomSource = Collection;
            }
            catch (Exception)
            {

            }
           
        }

    }
}
