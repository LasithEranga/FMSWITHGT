using System;
using System.Threading;
using System.Windows.Forms;

namespace Fine_Management_System
{
    public partial class MainWindow : Form
    {
        public static object DBConnectionHelath { get; internal set; }

        public MainWindow()
        {
            InitializeComponent();
            ShowPanel(homePanel);
            if (!(Convert.ToBoolean(DBConnectionHelath)))
            {
                new Error_messages.DBError("Database Error", "Cannot establish the database connectivity",this).Show();
                
            }
        }

        private void closeBtnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this, true);
        }

        private void HomeBtnClick(object sender, EventArgs e)
        {

            ShowPanel(homePanel);
            GrayAll();
            homeBtn.Image = Properties.Resources.homeBlue;
        }

        private void ChartBtnClick(object sender, EventArgs e)
        {
            
            ShowPanel(statisticsPanel);
            GrayAll();
            chartBtn.Image = Properties.Resources.chart_blue;

        }

        private void SettingsBtnClick(object sender, EventArgs e)
        {

            ShowPanel(settingsPanel);
            GrayAll();
            settingsBtn.Image = Properties.Resources.settings_blue;

        }

        private void reportBtnClick(object sender, EventArgs e)
        {
            ShowPanel(reportPanel);
            GrayAll();
            reportBtn.Image = Properties.Resources.report_blue;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ShowPanel(UserControl panel)
        {
            homePanel.Hide();
            statisticsPanel.Hide();
            reportPanel.Hide();
            settingsPanel.Hide();
            panel.SetBounds(0, 0, 930, 627);
            panel.Show();

        }
        private void GrayAll()
        {
            homeBtn.Image = Properties.Resources.home_new;
            chartBtn.Image = Properties.Resources.chart_new;
            settingsBtn.Image = Properties.Resources.settings_new;
            reportBtn.Image = Properties.Resources.report_new;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Tooltip_hover(object sender, EventArgs e)
        {
            toolTip1.Show("Home", homeBtn);
        }

        private void chart_tip(object sender, EventArgs e)
        {
            toolTip1.Show("Statistics", chartBtn);
        }

        private void report_tip(object sender, EventArgs e)
        {
            toolTip1.Show("Report", reportBtn);
        }

        private void setting_tip(object sender, EventArgs e)
        {
            toolTip1.Show("Settings", settingsBtn);
        }

        private void logout_tip(object sender, EventArgs e)
        {
            toolTip1.Show("Logout", logoutBtn);
        }
    }
}