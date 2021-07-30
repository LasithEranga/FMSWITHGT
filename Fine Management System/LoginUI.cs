using System;
using System.Windows.Forms;

namespace Fine_Management_System
{

    public partial class LoginForm : Form
    {
        LoginForm form;
        //tempory username and password for development purposes 
        string md5password = "13926153831969718150168391712481961204215";
        string userName = "Lasith";
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

            //check password with MD5 encryption 
            if (MD5Hashing.Encryption(password.Text) == md5password && userName ==usrName.Text)
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


        private void closeBtn_Click(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void closeBtn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
