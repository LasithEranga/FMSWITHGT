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
            backBtn.Hide();
        }

        private void userClick(object sender, EventArgs e)
        {
            backBtn.Show();
            usersPanel.SetBounds(0, 0, 930, 627);
            usersPanel.Show();

        }

        private void BackBtnClick(object sender, EventArgs e)
        {
            usersPanel.Hide();
            settingsPanel.Show();
            backBtn.Hide();
        }

        private void user_tip(object sender, EventArgs e)
        {
            toolTip2.Show("Users", user);
        }

        private void language_tip(object sender, EventArgs e)
        {
            toolTip2.Show("Language", language);
        }

        private void notification_tip(object sender, EventArgs e)
        {
            toolTip2.Show("Notification", notification);
        }

        private void help_tip(object sender, EventArgs e)
        {
            toolTip2.Show("Help", help);
        }
    }
}
