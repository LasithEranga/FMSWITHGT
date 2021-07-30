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
    public partial class Users : UserControl
    {
        public Users()
        {
            InitializeComponent();
        }

        private void addUsrBtnClick(object sender, EventArgs e)
        {
            AddUser.AddUsr addNew = new AddUser.AddUsr();
            addNew.Show();
        }

        private void Search_Focus(object sender, EventArgs e)
        {
            if (usrsSearchInput.Text == "Search Here")
            {
                usrsSearchInput.Clear();
            }
        }
    }
}
