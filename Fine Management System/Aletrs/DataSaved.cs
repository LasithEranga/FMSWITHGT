using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fine_Management_System.Aletrs
{
    public partial class DataSaved : Form
    {
        public DataSaved()
        {
            InitializeComponent();
        }
        public DataSaved(string title)
        {
            InitializeComponent();
            this.Title.Text = title;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
