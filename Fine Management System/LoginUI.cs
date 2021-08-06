using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Fine_Management_System
{

    public partial class LoginForm : Form
    {
        LoginForm form;
        //tempory username and password for development purposes 
        public LoginForm()
        {
            InitializeComponent();
            form = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        {

            try
            {
                //check password with MD5 encryption 
                MySqlDataReader dr = null;
                dr = DBConnection.DB.Read("SELECT user_name FROM user WHERE password = " + MD5Hashing.Encryption(password.Text) + " AND user_name = '" + usrName.Text + "';");
                dr.Read();
                if (dr.GetString("user_name").Equals(usrName.Text))
                {
                    MainWindow logged = new MainWindow();
                    //textFields will be cleared after verification of the the password 
                    usrName.Clear();
                    password.Clear();
                    logged.Show();
                }
                else
                {
                    new Error_messages.InputError("Login Failed", "Username or Password is incorrect").Show();
                }
                
                
            }
            catch (NullReferenceException)
            {
                new Error_messages.InputError("Login Failed", "Username or Password is incorrect").Show();
            }
            catch (MySqlException ex)
            {
                if (ex.Message.Equals("Invalid attempt to access a field before calling Read()"))
                {
                    new Error_messages.InputError("Login Failed", "Username or Password is incorrect").Show();
                    usrName.Clear();
                    password.Clear();
                }
                else
                {
                   
                    new Error_messages.DBError("Database Error", "Cannot establish the database connectivity", this).Show();

                }

            }



        }


        private void closeBtn_Click(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void closeBtn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
