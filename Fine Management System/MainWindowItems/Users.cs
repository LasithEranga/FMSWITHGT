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
            table.UserTableAllUser();
            SwapLines(allUsersLine);
            
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

        private void panel22_Paint(object sender, PaintEventArgs e)
        {


        }
        private void SwapLines(Panel active) {
            driversLine.Hide();
            officersLine.Hide();
            allUsersLine.Hide();
            active.Show();
        }

        private void labelOfficers_Click(object sender, EventArgs e)
        {
            SwapLines(officersLine);
            table.UserTableOfficer();
        }

        private void labelDrivers_Click(object sender, EventArgs e)
        {
            SwapLines(driversLine);
            table.UserTableDriver();
        }

        private void labelAllusrs_Click(object sender, EventArgs e)
        {
            SwapLines(allUsersLine);
            table.UserTableAllUser();
            
        }

        private void addNewBtn_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
