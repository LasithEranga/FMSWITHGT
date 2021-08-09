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


namespace Fine_Management_System.Popup
{
    public partial class UpdateOfficer : Form
    {
        MySqlDataReader dr = null;
        MySqlConnection conn;
        MySqlCommand cmd;
        private string query = "";

        public UpdateOfficer()
        {
            InitializeComponent();
        }

        public UpdateOfficer(string id)
        {
            InitializeComponent();
            conn = DBConnection.DB.Conn();
            query = "SELECT `police_id`, `fname`, `lname`, `full_name`, `email`, `nic`, `contact_no`, `post`, `address` FROM `traffic_police_officer` WHERE police_id='"+id+"';";
            try
            {
                cmd = new MySqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    policeId.Text = dr.GetString("police_id");
                    fName.Text = dr.GetString("fname");
                    lName.Text = dr.GetString("lname");
                    fullName.Text = dr.GetString("full_name");
                    emailAddress.Text = dr.GetString("email");
                    nicNo.Text = dr.GetString("nic");
                    contactNo.Text = dr.GetString("contact_no");
                    post.Text = dr.GetString("post");
                    address.Text = dr.GetString("address");

                }
                dr.Close();
            }
            catch (Exception)
            {
                dr.Close();
            }
        }



        private void addUsrBtn_Click(object sender, EventArgs e)
        {
            if (Validations.Validate.ValidateText(fName.Text, "first name") && Validations.Validate.ValidateText(lName.Text, "last name") && Validations.Validate.ValidateText(fullName.Text, "full name") && Validations.Validate.ValidatePhoneNo(contactNo.Text) && Validations.Validate.ValidateAddress(address.Text) && Validations.Validate.Validate_Email(emailAddress.Text) && Validations.Validate.Validate_NIC(nicNo.Text) && Validations.Validate.ValidatePoliceId(policeId.Text) && Validations.Validate.ValidateText(post.Text, "police post"))
            {
                query = "UPDATE `traffic_police_officer` SET `fname`='" + fName.Text + "',`lname`='" + lName.Text + "',`full_name`='" + fullName.Text + "',`email`='" + emailAddress.Text + "',`nic`='" + nicNo.Text + "',`contact_no`='" + contactNo.Text + "',`post`='" + post.Text + "',`address`='" + address.Text + "';";
                try
                {
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    new Aletrs.DataSaved("Officer details updated!").Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //new Error_messages.InputError("Database error", "Sorry..we could not update details").Show();

                }
            }
        }
    }
}
