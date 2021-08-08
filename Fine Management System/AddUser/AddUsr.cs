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
using System.Net;

namespace Fine_Management_System.AddUser
{
    public partial class AddUsr : Form
    {
        
        public AddUsr()
        {
            InitializeComponent();
            policeId.PromptChar = ' ';
        }

        private void addUsrBtn_Click(object sender, EventArgs e)
        {
            GetPhoneNo();
            if (ValidateText(fName.Text, "first name") && ValidateText(lName.Text, "last name") && ValidateText(fullName.Text, "full name")&& ValidatePhoneNo() && ValidateText(post.Text, "police post") && ValidateAddress() && Validate_Email() && Validate_NIC())
            {
                try
                {
                    string query = "INSERT INTO `traffic_police_officer`(`police_id`, `fname`, `lname`, `full_name`, `email`, `nic`, `contact_no`, `post`, `address`) VALUES (" + policeId.Text + ",'" + fName.Text + "','" + lName.Text + "','" + fullName.Text + "','" + emailAddress.Text + "','" + nicNo.Text + "','" + GetPhoneNo() + "','" + post.Text + "','" + address.Text + "')";
                    DBConnection.DB.Write(query);
                    new Aletrs.DataSaved("User Details Saved!").Show();
                }
                catch (Exception)
                {

                }
                

            }
                try
                {
                    SmtpClient clientDetail = new SmtpClient();
                    clientDetail.Host = "smtp.gmail.com";
                    clientDetail.Port = 587;
                    clientDetail.EnableSsl = true;
                    clientDetail.DeliveryMethod = SmtpDeliveryMethod.Network;
                    clientDetail.UseDefaultCredentials = false;
                    clientDetail.Credentials = new NetworkCredential("finexpayment@gmail.com", "Sinerugroup9");
                    MailMessage mailDetails = new MailMessage();
                    mailDetails.From = new MailAddress("finexpayment@gmail.com");
                    mailDetails.To.Add(emailAddress.Text);
                    mailDetails.Subject = "Account Password";
                    mailDetails.Body = RandomGen.password();

                    clientDetail.Send(mailDetails);
                    MessageBox.Show("Your mail has been sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
            try
            {
                file.Filter = "ImageFiles(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                file.ShowDialog();
                usrImage.Image = new Bitmap(file.FileName);
                uploadBtn.Text = "Change";
            }
            catch (Exception)
            {
                new Error_messages.InputError("Image Not Selected", "Please choose an image").Show();

            }

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


        private bool Validate_Email()
        {
            if (emailAddress.TextLength > 0)
            {
                try
                {
                   var email= new MailAddress(emailAddress.Text);
                    return true;

                }
                catch (FormatException b)
                {
                    new Error_messages.InputError("Invalid Email Address", "Please check Email Address").Show();
                    return false;
                }

            }
            else
            {
                new Error_messages.InputError("Email Address Required", "Please Insert an Email Address").Show();
                return false;
            }
        }

        private bool Validate_NIC()
        {
            int len = nicNo.TextLength;
            if (len == 10)
            {
                //pattern1
                Regex rgx = new Regex(@"^\d{9}[vxVX]{1}$");
                if (rgx.IsMatch(nicNo.Text))
                {
                    return true;
                }
                else
                {
                    new Error_messages.InputError("Invalid ID", "Please check ID Number").Show();
                    return false;
                }

            }

            else if(len == 12)
            {
                //pattern 2
                Regex rgx = new Regex(@"^\d{12}$");
                if (rgx.IsMatch(nicNo.Text))
                {
                    return true;
                }
                else
                {
                    new Error_messages.InputError("Invalid ID", "Please check ID Number").Show();
                    return false;
                }
                
            }
            else
            {
                //empty
                new Error_messages.InputError("Invalid ID", "Please check ID Number").Show();
                return false;
            }
            
       
        }



        private bool ValidateText(string text, string txtbox)
        {
            if (text.Length > 0)
            {
                
                Regex rgx = new Regex(@"^[a-zA-Z0-9\s,]+$");
                if (rgx.IsMatch(text))
                {
                    return true;
                }
                else
                {
                    new Error_messages.InputError("Invalid "+txtbox, "Please check "+txtbox).Show();
                    return false;
                }
            }
            else
            {
                new Error_messages.InputError(txtbox +" Field is Empty", "Please fill the " + txtbox +" field").Show();
                return false;
            }

        }
        private bool ValidateAddress()
        {
            if (address.Text.Length > 0)
            {

                Regex rgx = new Regex(@"^[a-zA-Z0-9\/\s,]+$");
                if (rgx.IsMatch(address.Text))
                {
                    
                    return true;
                }
                else
                {
                    new Error_messages.InputError("Invalid Address", "Please check address").Show();

                    return false;
                }
            }
            else
            {
                new Error_messages.InputError("Empty Address Field", "Please Fill the Address").Show();
                return false;
            }

        }
        private bool ValidatePhoneNo()
        {
            Regex rgx = new Regex(@"^\d{10}$");
            if (rgx.IsMatch(GetPhoneNo()))
            {
                return true;
            }
            else
            {
                new Error_messages.InputError("Invalid Phone Number", "Please check the phone no").Show();
                return false;
            }
        }

        private string GetPhoneNo()
        {
            string phoneNo = "";
            try
            {
                phoneNo = contactNo.Text.Substring(6, 2) + contactNo.Text.Substring(10, 4) + contactNo.Text.Substring(16, 5);
                phoneNo = "0" + phoneNo.Replace(" ", "");
                return phoneNo;
            }
            catch
            {
                return phoneNo;

            }
            
        }

        private void usrImage_Click(object sender, EventArgs e)
        {

        }

        private void AddUsr_Load(object sender, EventArgs e)
        {

        }
        
    }
}
