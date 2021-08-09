using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fine_Management_System.ReportItems
{
    public partial class FineReceipt : UserControl
    {
        bool DBConnectionHealth = true;
        public FineReceipt()
        {
            InitializeComponent();
            try
            {
                showReceipt.Hide();
                buttonBack.Hide();
                string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
                MySqlDataAdapter sqlda = new MySqlDataAdapter("Select * from fine_receipt", connStr);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                table.DataSource = dtbl;
                
            }
            catch (MySqlException) {
                MainWindow.DBConnectionHelath = false;
            }

            
        }

        public void FineReceiptWithQuery(string query)
        {
            try
            {
                string connStr = "server=mysql-42457-0.cloudclusters.net;user=admin;database=fmsdb;port=19451;password=jaOuzvbF;";
                MySqlDataAdapter sqlda = new MySqlDataAdapter(query, connStr);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                table.DataSource = dtbl;
            }
            catch (MySqlException)
            {
                MainWindow.DBConnectionHelath = false;
            }


        }


        public bool getState() {
            return DBConnectionHealth;
        }

        public void Save() {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Output.pdf";
            bool fileError = false;
            if (table.Rows.Count > 0)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException)
                        {
                            fileError = true;
                            new Aletrs.DataSaved("Cannot access the disk!").Show();
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn column in table.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in table.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if(cell.Value != null)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());

                                    }
                                    
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            new Aletrs.DataSaved("Data Exported Successfully !").Show();
                        }
                        catch (Exception)
                        {
                            new Aletrs.DataSaved("Something went wrong!").Show();
                        }
                    }
                }
            }
            else
            {
                new Aletrs.DataSaved("No Record To Export !").Show();
            }
        }

        private void row_selected(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = table.CurrentRow.Index;
            DataGridViewRow selectedRow = table.Rows[rowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Ref_No"].Value);
            table.Hide();
            buttonBack.Show();
            showReceipt.setData(cellValue);
            showReceipt.SetBounds(0, 0, 895, 481);
            showReceipt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Show();
            buttonBack.Hide();
            showReceipt.Hide();
        }

        public int GetRowNum(String searchValue) {
            int rowIndex = -1;
            foreach (DataGridViewRow row in table.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    break;
                    
                }
            }
            return rowIndex;
        }


        public void SelectRow(int row)
        {
            table.Rows[row].Selected = true;
        }
        public void UnselectAll()
        {
            table.ClearSelection();
        }

        public string GetMax() {
            try
            {
                var MaxID = table.RowCount;
                return MaxID.ToString();
            }
            catch (Exception)
            {
                return "0";
            }

            
        }

        public void SetById()
        {

            int rowindex = table.CurrentRow.Index;
            DataGridViewRow selectedRow = table.Rows[rowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Ref_No"].Value);
            table.Hide();
            buttonBack.Show();
            showReceipt.setData(cellValue);
            showReceipt.SetBounds(0, 0, 895, 481);
            showReceipt.Show();

        }

        public string[] GetList() {
            string[] array= new string[table.Rows.Count];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                array[i] = table.Rows[i].Cells[0].Value.ToString().Trim();
            }
            return array;
        }

        public void Select(string key)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                 if(table.Rows[i].Cells[0].Value.ToString().Trim() == key)
                {
                    SelectRow(i);
                    break;
                }
            }
            


        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
