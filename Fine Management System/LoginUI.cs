using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fine_Management_System
{

    public partial class LoginForm : Form
    {
        private bool pass = true;
        LoginForm form;
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
            MainWindow logged = new MainWindow();

            if (pass)
            {
                //after verification of the the password 
                //textFields will be cleared!
                usrName.Clear();
                password.Clear();
            }
            logged.Show();
        }


        private void closeBtn_Click(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
