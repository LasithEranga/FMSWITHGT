using System;
using System.Windows.Forms;

namespace Fine_Management_System
{

    public partial class LoginForm : Form
    {
        private bool pass = true;
        LoginForm form;
        string md5password = "13926153831969718150168391712481961204215";
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

            
            if (MD5Hashing.Encryption(password.Text) == md5password)
            {
                MainWindow logged = new MainWindow();
                //after verification of the the password 
                //textFields will be cleared!
                usrName.Clear();
                password.Clear();
                logged.Show();
            }
            
        }


        private void closeBtn_Click(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
