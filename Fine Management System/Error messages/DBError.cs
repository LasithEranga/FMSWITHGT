using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fine_Management_System.Error_messages
{
    public partial class DBError : Form
    {
        Form form;
        public DBError()
        {
            InitializeComponent();
        }

        public DBError(String title, String msg, Form form)
        {
            InitializeComponent();
            Title.Text = title;
            this.msg.Text = msg;
            this.form = form;
            this.TopMost = true;
            form.WindowState = FormWindowState.Minimized;
        }

        private void DBError_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            form.Dispose();
        }
    }
}
