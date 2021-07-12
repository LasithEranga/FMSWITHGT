﻿using System;
using System.Threading;
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
                chartWeekly.Series["Series1"].Points.AddXY(i, i * 100);
            }
            for (int i = 0; i < 10; i++)
            {
                chartThisMonth.Series["Series1"].Points.AddXY(i, i * i + 50);
            }
            for (int i = 0; i < 10; i++)
            {
                chartMonthlyCases.Series["Series1"].Points.AddXY(i, i * i + 50);
            }

            chartThisWeek.Series["Series1"].Points.AddXY("Mon", "22");
            chartThisWeek.Series["Series1"].Points.AddXY("Tue", "56");
            chartThisWeek.Series["Series1"].Points.AddXY("Wed", "45");
            chartThisWeek.Series["Series1"].Points.AddXY("Thur", "78");
            chartThisWeek.Series["Series1"].Points.AddXY("Fri", "12");
            chartThisWeek.Series["Series1"].Points.AddXY("Sat", "58");
            chartThisWeek.Series["Series1"].Points.AddXY("Sun", "95");

            homePanel.SetBounds(0, 0, 930, 627);
            homePanel.Show();
            chartPanel.Hide();
            reportPanel.Hide();
            usersPanel.Hide();
            settingsPanel.Hide();

        }
        public MainWindow(LoginForm Form)
        {

            InitializeComponent();
            FillCharts();
            ShowPanel(homePanel);

        }

        private void FillCharts()
        {//fils chart with dummy data values
            for (int i = 0; i < 10; i++)
            {
                chartWeekly.Series["Series1"].Points.AddXY(i, i * 100);
            }
            for (int i = 0; i < 10; i++)
            {
                chartThisMonth.Series["Series1"].Points.AddXY(i, i * i + 50);
                
            }

            for (int i = 0; i < 10; i++)
            {
                chartMonthlyCases.Series["Series1"].Points.AddXY(i, i * i + 50);
            }
           
        }

        private void SwitchPanel()
        {


        }

        private void closeBtnClick(object sender, EventArgs e)
        {
            this.Dispose();
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
            for (int i = 0; i < 10; i++)
            {//fils chart with dummy data values
                chartPanelChart.Series["Series1"].Points.AddXY(i, i * 100);
            }
            ShowPanel(chartPanel);
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

        private void UserIconClick(object sender, MouseEventArgs e)
        {
            ShowPanel(usersPanel);
        }

        private void ShowPanel(Panel panel)
        {
            homePanel.Hide();
            chartPanel.Hide();
            reportPanel.Hide();
            usersPanel.Hide();
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

        private void NewUserBtnClick(object sender, MouseEventArgs e)
        {
            AddUser.AddUsr addNew = new AddUser.AddUsr();
            addNew.Show();
        }

        private void rptPgNo_MouseClick(object sender, MouseEventArgs e)
        {
            if (rptPgNo.Text == "")
            {
                rptPgNo.Select(rptPgNo.Text.Length, 0);
            }

        }

        private void rptSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (rptSearch.Text == "Search Here")
            {
                rptSearch.Clear();
            }
        }

        SaveFileDialog fileSave = new SaveFileDialog();
        
        private void savePdfClick(object sender, MouseEventArgs e)
        {
            fileSave.Filter = "PdfFiles(*.pdf;)|*.pdf";
            if (fileSave.ShowDialog() == DialogResult.OK)
            {
                reportTextBox.SaveFile(fileSave.FileName);
            }
        }
    }
}