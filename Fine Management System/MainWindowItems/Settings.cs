using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fine_Management_System.MainWindowItems
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
            usersPanel.Hide();
        }

        private void userClick(object sender, EventArgs e)
        {
            usersPanel.SetBounds(0, 0, 930, 627);
            usersPanel.Show();
        }
    }
}
