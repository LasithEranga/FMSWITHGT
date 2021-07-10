using System;
using System.Windows.Forms;

namespace Fine_Management_System
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, i * 100);
            }
            for (int i = 0; i < 10; i++)
            {
                chart4.Series["Series1"].Points.AddXY(i, i * i + 50);
            }
            homePanel.SetBounds(0,0, 930, 627);
            homePanel.Show();
            chartPanel.Hide();
            reportPanel.Hide();
            usersPanel.Hide();
            settingsPanel.Hide();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this, true);
        }

        private void HomeBtnClick(object sender, EventArgs e)
        {
            homePanel.SetBounds(0, 0, 930, 627);
            homePanel.Show();
            chartPanel.Hide();
            reportPanel.Hide();
            usersPanel.Hide();
            settingsPanel.Hide();
            homeBtn.Image = Properties.Resources.homeBlue;
        }

        private void ChartBtnClick(object sender, EventArgs e)
        {
            chartPanel.SetBounds(0, 0, 930, 627);
            homePanel.Hide();
            chartPanel.Show();
            reportPanel.Hide();
            usersPanel.Hide();
            settingsPanel.Hide();

        }

        private void SettingsBtnClick(object sender, EventArgs e)
        {
            settingsPanel.SetBounds(0, 0, 930, 627);
            homePanel.Hide();
            chartPanel.Hide();
            reportPanel.Hide();
            usersPanel.Hide();
            settingsPanel.Show();

        }

        private void reportBtnClick(object sender, EventArgs e)
        {
            reportPanel.SetBounds(0, 0, 930, 627);
            homePanel.Hide();
            chartPanel.Hide();
            reportPanel.Show();
            usersPanel.Hide();
            settingsPanel.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
