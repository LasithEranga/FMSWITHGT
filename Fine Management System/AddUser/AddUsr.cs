using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Fine_Management_System.AddUser
{
    public partial class AddUsr : Form
    {
        
        public AddUsr()
        {
            InitializeComponent();
        }

        private void addUsrBtn_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            Validate_Email();
            Validate_NIC();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            fName.Clear();
            lName.Clear();
            nicNo.Clear();
            address.Clear();
            contactNo.Clear();
            emailAddress.Clear();
            fullName.Clear();
            post.Clear();
            policeId.Clear();
            dateTimePickerAddUsr.ResetText();
            usrImage.Image = null;
            uploadBtn.Text = "Upload";

        }

        OpenFileDialog file = new OpenFileDialog();
        
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            file.Filter = "ImageFiles(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            file.ShowDialog();
            usrImage.Image = new Bitmap(file.FileName);
            uploadBtn.Text = "Change";
        }

        private void PoliceIDClick(object sender, EventArgs e)
        {
            if (policeId.Text == "")
            {
                policeId.Select(policeId.Text.Length, 0);
            }
            
        }

        private void ContactNoClick(object sender, MouseEventArgs e)
        {

            if (contactNo.Text == "(+94)    -     - ")
            {

                contactNo.Select(policeId.Text.Length, 5);

            }
        }


        private void Validate_Email()
        {
            if (emailAddress.TextLength > 0)
            {
                try
                {
                   var email= new MailAddress(emailAddress.Text);

                }
                catch (FormatException b)
                {
                    MessageBox.Show(b.Message);
                }

            }
            else
            {
                //empty
            }
        }

        private void Validate_NIC()
        {
            int len = nicNo.TextLength;
            if (len == 10)
            {
                //pattern1
                Regex rgx = new Regex(@"^\d{9}[vxVX]{1}$");
                if (rgx.IsMatch(nicNo.Text))
                {
                    MessageBox.Show("correct");
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }

            else if(len == 12)
            {
                //pattern 2
                Regex rgx = new Regex(@"^\d{12}$");
                if (rgx.IsMatch(nicNo.Text))
                {
                    MessageBox.Show("correct");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                
            }
            else
            {
                //empty
                MessageBox.Show("Invalid");
            }
            
       
        }

    }
}
