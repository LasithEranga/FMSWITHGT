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
            list.SelectedIndex = 0;
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

        private void IndexChanged(object sender, EventArgs e)
        {
            string query = "";
            switch (list.SelectedIndex)
            {
                /*Expired
                Sued List
                Pending
                Paid
                All Records*/
                case 0:
                    {
                        //Expired
                        query = "SELECT `Ref_No`, `Date`, `Amount`, `vehicle`, `State`, `driver_nic` FROM fine_receipt WHERE Date <= CURDATE() - INTERVAL 2 WEEK AND State = 0";
                        fineReceipt1.FineReceiptWithQuery(query);
                        fineReceipt1.UnselectAll();
                        
                        break;
                    }

                case 1:
                    {
                        //Sued List
                        query = "SELECT `Ref_No`, `Date`, `Amount`, `vehicle`, `State`, `driver_nic` FROM fine_receipt WHERE State = 9 ";
                        fineReceipt1.FineReceiptWithQuery(query);
                        fineReceipt1.UnselectAll();
                        
                        break;
                    }

                case 2:
                    {
                        //Pending
                        query = "SELECT `Ref_No`, `Date`, `Amount`, `vehicle`, `State`, `driver_nic` FROM fine_receipt WHERE Date >= CURDATE() - INTERVAL 2 WEEK AND State = 0";
                        fineReceipt1.FineReceiptWithQuery(query);
                        fineReceipt1.UnselectAll();
                        
                        break;
                    }

                case 3:
                    {
                        //Paid
                        query = "SELECT `Ref_No`, `Date`, `Amount`, `vehicle`, `State`, `driver_nic` FROM fine_receipt WHERE State = 1 ";
                        fineReceipt1.FineReceiptWithQuery(query);
                        fineReceipt1.UnselectAll();
                        break;
                    }
                case 4:
                    {
                        //All Records
                        query = "SELECT `Ref_No`, `Date`, `Amount`, `vehicle`, `State`, `driver_nic` FROM fine_receipt WHERE 1 " ;
                        fineReceipt1.FineReceiptWithQuery(query);
                        fineReceipt1.UnselectAll();
                        break;
                    }
            }
        }

        private void GoBtnClick(object sender, EventArgs e)
        {
            string query = "";
            string dateFilter = "";
            if(list.SelectedIndex == 0 || list.SelectedIndex == 2)
            {
                //report error
            }
            else
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy-MM-dd";
                dateFilter = "date >= '" + dateTimePicker1.Text + "' AND date< '" + dateTimePicker2.Text+"'";

                switch (list.SelectedIndex)
                {
                    /*Expired
                    Sued List
                    Pending
                    Paid
                    All Records*/
                   
                    case 1:
                        {
                            //Sued List
                            query = "SELECT `Ref_No`, `Date`, `Amount`, `vehicle`, `State`, `driver_nic` FROM fine_receipt WHERE State = 9 AND" + dateFilter;
                            fineReceipt1.FineReceiptWithQuery(query);
                            fineReceipt1.UnselectAll();
                            break;
                        }

                    case 3:
                        {
                            //Paid
                            query = "SELECT `Ref_No`, `Date`, `Amount`, `vehicle`, `State`, `driver_nic` FROM fine_receipt WHERE State = 1 AND" + dateFilter;
                            fineReceipt1.FineReceiptWithQuery(query);
                            fineReceipt1.UnselectAll();
                            
                            break;
                        }
                    case 4:
                        {
                            //All Records
                            query = "SELECT `Ref_No`, `Date`, `Amount`, `vehicle`, `State`, `driver_nic` FROM fine_receipt WHERE " + dateFilter;
                            fineReceipt1.FineReceiptWithQuery(query);
                            fineReceipt1.UnselectAll();
                            
                            break;
                        }
                }
            }


        }
    }
}
