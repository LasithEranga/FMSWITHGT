
namespace Fine_Management_System
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.navBarPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.PictureBox();
            this.settingsBtn = new System.Windows.Forms.PictureBox();
            this.reportBtn = new System.Windows.Forms.PictureBox();
            this.chartBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.windowPanel = new System.Windows.Forms.Panel();
            this.statisticsPanel = new Fine_Management_System.MainWindowItems.Statistics();
            this.settingsPanel = new Fine_Management_System.MainWindowItems.Settings();
            this.reportPanel = new Fine_Management_System.MainWindowItems.Report();
            this.homePanel = new Fine_Management_System.Home();
            this.usrNameTop = new System.Windows.Forms.Label();
            this.lableSysName = new System.Windows.Forms.Label();
            this.sysIcon = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.usrImage = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.navBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.windowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sysIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarPanel
            // 
            this.navBarPanel.Controls.Add(this.logoutBtn);
            this.navBarPanel.Controls.Add(this.settingsBtn);
            this.navBarPanel.Controls.Add(this.reportBtn);
            this.navBarPanel.Controls.Add(this.chartBtn);
            this.navBarPanel.Controls.Add(this.homeBtn);
            this.navBarPanel.Location = new System.Drawing.Point(3, 60);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.Size = new System.Drawing.Size(61, 626);
            this.navBarPanel.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Image = global::Fine_Management_System.Properties.Resources.logout_new;
            this.logoutBtn.Location = new System.Drawing.Point(9, 567);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.logoutBtn.Size = new System.Drawing.Size(41, 38);
            this.logoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Image = global::Fine_Management_System.Properties.Resources.settings_new;
            this.settingsBtn.Location = new System.Drawing.Point(12, 506);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(2);
            this.settingsBtn.Size = new System.Drawing.Size(36, 35);
            this.settingsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Click += new System.EventHandler(this.SettingsBtnClick);
            // 
            // reportBtn
            // 
            this.reportBtn.Image = global::Fine_Management_System.Properties.Resources.report_new;
            this.reportBtn.Location = new System.Drawing.Point(12, 166);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.reportBtn.Size = new System.Drawing.Size(34, 40);
            this.reportBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportBtn.TabIndex = 4;
            this.reportBtn.TabStop = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtnClick);
            // 
            // chartBtn
            // 
            this.chartBtn.Image = global::Fine_Management_System.Properties.Resources.chart_new;
            this.chartBtn.Location = new System.Drawing.Point(12, 94);
            this.chartBtn.Name = "chartBtn";
            this.chartBtn.Padding = new System.Windows.Forms.Padding(2);
            this.chartBtn.Size = new System.Drawing.Size(37, 37);
            this.chartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chartBtn.TabIndex = 5;
            this.chartBtn.TabStop = false;
            this.chartBtn.Click += new System.EventHandler(this.ChartBtnClick);
            // 
            // homeBtn
            // 
            this.homeBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.ErrorImage")));
            this.homeBtn.Image = global::Fine_Management_System.Properties.Resources.homeBlue;
            this.homeBtn.Location = new System.Drawing.Point(13, 25);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(33, 32);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeBtn.TabIndex = 6;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.HomeBtnClick);
            // 
            // windowPanel
            // 
            this.windowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.windowPanel.Controls.Add(this.statisticsPanel);
            this.windowPanel.Controls.Add(this.settingsPanel);
            this.windowPanel.Controls.Add(this.reportPanel);
            this.windowPanel.Controls.Add(this.homePanel);
            this.windowPanel.Location = new System.Drawing.Point(70, 60);
            this.windowPanel.Name = "windowPanel";
            this.windowPanel.Size = new System.Drawing.Size(930, 627);
            this.windowPanel.TabIndex = 2;
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.Location = new System.Drawing.Point(299, 197);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(266, 183);
            this.statisticsPanel.TabIndex = 16;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(20, 197);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(256, 183);
            this.settingsPanel.TabIndex = 14;
            // 
            // reportPanel
            // 
            this.reportPanel.Location = new System.Drawing.Point(299, 3);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(266, 165);
            this.reportPanel.TabIndex = 13;
            // 
            // homePanel
            // 
            this.homePanel.Location = new System.Drawing.Point(20, 14);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(256, 154);
            this.homePanel.TabIndex = 12;
            // 
            // usrNameTop
            // 
            this.usrNameTop.AutoSize = true;
            this.usrNameTop.BackColor = System.Drawing.Color.Transparent;
            this.usrNameTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrNameTop.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usrNameTop.Location = new System.Drawing.Point(829, 22);
            this.usrNameTop.Name = "usrNameTop";
            this.usrNameTop.Size = new System.Drawing.Size(52, 20);
            this.usrNameTop.TabIndex = 8;
            this.usrNameTop.Text = "Lasith";
            // 
            // lableSysName
            // 
            this.lableSysName.AutoSize = true;
            this.lableSysName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableSysName.ForeColor = System.Drawing.Color.White;
            this.lableSysName.Location = new System.Drawing.Point(72, 21);
            this.lableSysName.Name = "lableSysName";
            this.lableSysName.Size = new System.Drawing.Size(314, 20);
            this.lableSysName.TabIndex = 13;
            this.lableSysName.Text = "FINE PAYMENT MANAGEMENT SYSTEM";
            // 
            // sysIcon
            // 
            this.sysIcon.Image = global::Fine_Management_System.Properties.Resources.logo;
            this.sysIcon.Location = new System.Drawing.Point(3, 4);
            this.sysIcon.Name = "sysIcon";
            this.sysIcon.Size = new System.Drawing.Size(61, 50);
            this.sysIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sysIcon.TabIndex = 14;
            this.sysIcon.TabStop = false;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(935, 24);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(26, 10);
            this.minimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizeBtn.TabIndex = 10;
            this.minimizeBtn.TabStop = false;
            // 
            // usrImage
            // 
            this.usrImage.Image = global::Fine_Management_System.Properties.Resources.officer1;
            this.usrImage.Location = new System.Drawing.Point(795, 19);
            this.usrImage.Name = "usrImage";
            this.usrImage.Size = new System.Drawing.Size(26, 24);
            this.usrImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usrImage.TabIndex = 8;
            this.usrImage.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(975, 19);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 19);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeBtn.TabIndex = 12;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtnClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1010, 697);
            this.ControlBox = false;
            this.Controls.Add(this.sysIcon);
            this.Controls.Add(this.lableSysName);
            this.Controls.Add(this.usrNameTop);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.usrImage);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.windowPanel);
            this.Controls.Add(this.navBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fine Payment Management System";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.navBarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.windowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sysIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.PictureBox usrImage;
        private System.Windows.Forms.Panel navBarPanel;
        private System.Windows.Forms.PictureBox logoutBtn;
        private System.Windows.Forms.PictureBox settingsBtn;
        private System.Windows.Forms.PictureBox reportBtn;
        private System.Windows.Forms.PictureBox chartBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.Panel windowPanel;
        private System.Windows.Forms.Label usrNameTop;
        private System.Windows.Forms.Label lableSysName;
        private System.Windows.Forms.PictureBox sysIcon;
        private Home homePanel;
        private MainWindowItems.Statistics statisticsPanel;
        private MainWindowItems.Settings settingsPanel;
        private MainWindowItems.Report reportPanel;
    }
}