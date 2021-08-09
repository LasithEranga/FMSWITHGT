using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fine_Management_System.Validations
{
    class Validate
    {
        public static bool Validate_Email(string emailAddress)
        {
            if (emailAddress.Length > 0)
            {
                try
                {
                    var email = new MailAddress(emailAddress);
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

        public static bool Validate_NIC(string nicNo)
        {
            int len = nicNo.Length;
            if (len == 10)
            {
                //pattern1
                Regex rgx = new Regex(@"^\d{9}[vxVX]{1}$");
                if (rgx.IsMatch(nicNo))
                {
                    return true;
                }
                else
                {
                    new Error_messages.InputError("Invalid ID", "Please check ID Number").Show();
                    return false;
                }

            }

            else if (len == 12)
            {
                //pattern 2
                Regex rgx = new Regex(@"^\d{12}$");
                if (rgx.IsMatch(nicNo))
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

        public static bool ValidateLicense(string license)
        {
            if (license.Length > 0)
            {
                Regex reg = new Regex(@"^B\d{7}$");
                if (reg.IsMatch(license))
                {
                    return true;
                }
                else
                {
                    new Error_messages.InputError("Invalid License No", "Please check license Number").Show();
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool ValidateVehicleNo(string label)
        {
            if (label.Length > 0 && label.Length < 9)
            {
                Regex reg = new Regex(@"^[a-zA-Z0-9\s]+$");
                if (reg.IsMatch(label))
                {
                   
                    return true;
                }
                else
                {
                    new Error_messages.InputError("Invalid vehicle No", "Please check vehicle Number").Show();
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool ValidateText(string text, string txtbox)
        {
            if (text.Length > 0)
            {

                Regex rgx = new Regex(@"^[a-zA-Z\s,]+$");
                if (rgx.IsMatch(text))
                {
                    return true;
                }
                else
                {
                    new Error_messages.InputError("Invalid " + txtbox, "Please check " + txtbox).Show();
                    return false;
                }
            }
            else
            {
                new Error_messages.InputError(txtbox + " Field is Empty", "Please fill the " + txtbox + " field").Show();
                return false;
            }

        }
        public static bool ValidateAddress(string address)
        {
            if (address.Length > 0)
            {

                Regex rgx = new Regex(@"^[a-zA-Z0-9\/\s,]+$");
                if (rgx.IsMatch(address))
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
        public static bool ValidatePhoneNo(string phoneNo)
        {
            Regex rgx = new Regex(@"^\d{10}$");
            if (rgx.IsMatch(phoneNo))
            {
                return true;
            }
            else
            {
                new Error_messages.InputError("Invalid Phone Number", "Please check the phone no").Show();
                return false;
            }
        }

        public static bool ValidatePoliceId(string id)
        {
            Regex rgx = new Regex(@"^\d{5}$");
            if (rgx.IsMatch(id))
            {
                return true;
            }
            else
            {
                new Error_messages.InputError("Invalid ID number", "Please check the police ID no").Show();
                return false;
            }
        }
    }
}
