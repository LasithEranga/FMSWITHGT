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
    public partial class InputError : Form
    {
        
        public InputError()
        {
            InitializeComponent();
        }
        public InputError(String title, String msg)
        {
            InitializeComponent();
            Title.Text = title;
            this.msg.Text = msg;

        }


        private void closeBtnClick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
