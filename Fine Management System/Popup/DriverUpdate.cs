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
    public partial class DriverUpdate : Form
    {
        MySqlDataReader dr = null;
        MySqlConnection conn;
        MySqlCommand cmd;
        private string query = "";

        public DriverUpdate()
        {
            InitializeComponent();
        }

        public DriverUpdate(string id)
        {
            InitializeComponent();
            conn = DBConnection.DB.Conn();
            query = "SELECT `nic`, `fname`, `lname`, `full_name`, `email`, `contact_no`, `address`, `license_no`, `vehicle_no` FROM `driver` WHERE nic='" + id + "';";
            try
            {
                cmd = new MySqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nicNo.Text = dr.GetString("nic");
                    fName.Text = dr.GetString("fname");
                    lName.Text = dr.GetString("lname");
                    fullName.Text = dr.GetString("full_name");
                    emailAddress.Text = dr.GetString("email");
                    contactNo.Text = dr.GetString("contact_no");
                    vehicleNo.Text = dr.GetString("vehicle_no");
                    address.Text = dr.GetString("address");
                    license.Text = dr.GetString("license_no");

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
            if (Validations.Validate.ValidateText(fName.Text, "first name") && Validations.Validate.ValidateText(lName.Text, "last name") && Validations.Validate.ValidateText(fullName.Text, "full name") && Validations.Validate.ValidatePhoneNo(contactNo.Text) && Validations.Validate.ValidateAddress(address.Text) && Validations.Validate.Validate_Email(emailAddress.Text) && Validations.Validate.Validate_NIC(nicNo.Text) && Validations.Validate.ValidateLicense(license.Text) && Validations.Validate.ValidateVehicleNo(vehicleNo.Text))
            {
                query = "UPDATE `driver` SET `fname`='"+fName.Text+"',`lname`='"+lName.Text+"',`full_name`='"+fullName.Text+"',`email`='"+emailAddress.Text+"',`contact_no`='"+contactNo.Text+"',`address`='"+address.Text+"',`license_no`='"+license.Text+"',`vehicle_no`='"+vehicleNo.Text+"' WHERE nic = '"+nicNo.Text+"';";
                try
                {
                    cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    new Aletrs.DataSaved("Driver details updated!").Show();
                }
                catch (Exception)
                {
                    new Error_messages.InputError("Database error", "Sorry..we could not update details").Show();

                }
            }
        }
    }
}
