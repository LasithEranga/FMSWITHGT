
namespace Fine_Management_System.MainWindowItems
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.labelSettingsTitle = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Panel();
            this.theme = new System.Windows.Forms.Panel();
            this.notification = new System.Windows.Forms.Panel();
            this.language = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.Panel();
            this.usersPanel = new Fine_Management_System.MainWindowItems.Users();
            this.settingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.settingsPanel.Controls.Add(this.usersPanel);
            this.settingsPanel.Controls.Add(this.labelSettingsTitle);
            this.settingsPanel.Controls.Add(this.help);
            this.settingsPanel.Controls.Add(this.theme);
            this.settingsPanel.Controls.Add(this.notification);
            this.settingsPanel.Controls.Add(this.language);
            this.settingsPanel.Controls.Add(this.user);
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(927, 624);
            this.settingsPanel.TabIndex = 8;
            // 
            // labelSettingsTitle
            // 
            this.labelSettingsTitle.AutoSize = true;
            this.labelSettingsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettingsTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSettingsTitle.Location = new System.Drawing.Point(21, 13);
            this.labelSettingsTitle.Name = "labelSettingsTitle";
            this.labelSettingsTitle.Size = new System.Drawing.Size(116, 25);
            this.labelSettingsTitle.TabIndex = 14;
            this.labelSettingsTitle.Text = "SETTINGS";
            // 
            // help
            // 
            this.help.BackgroundImage = global::Fine_Management_System.Properties.Resources.help;
            this.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help.Location = new System.Drawing.Point(363, 279);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(212, 170);
            this.help.TabIndex = 4;
            // 
            // theme
            // 
            this.theme.BackgroundImage = global::Fine_Management_System.Properties.Resources.theme;
            this.theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.theme.Location = new System.Drawing.Point(55, 279);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(212, 170);
            this.theme.TabIndex = 3;
            // 
            // notification
            // 
            this.notification.BackgroundImage = global::Fine_Management_System.Properties.Resources.notification;
            this.notification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.notification.Location = new System.Drawing.Point(662, 56);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(212, 170);
            this.notification.TabIndex = 2;
            // 
            // language
            // 
            this.language.BackgroundImage = global::Fine_Management_System.Properties.Resources.language;
            this.language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.language.Location = new System.Drawing.Point(363, 56);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(212, 170);
            this.language.TabIndex = 1;
            // 
            // user
            // 
            this.user.BackgroundImage = global::Fine_Management_System.Properties.Resources.user;
            this.user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.user.Location = new System.Drawing.Point(55, 56);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(212, 170);
            this.user.TabIndex = 0;
            this.user.Click += new System.EventHandler(this.userClick);
            // 
            // usersPanel
            // 
            this.usersPanel.Location = new System.Drawing.Point(55, 507);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(311, 79);
            this.usersPanel.TabIndex = 15;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsPanel);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(930, 627);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label labelSettingsTitle;
        private System.Windows.Forms.Panel help;
        private System.Windows.Forms.Panel theme;
        private System.Windows.Forms.Panel notification;
        private System.Windows.Forms.Panel language;
        private System.Windows.Forms.Panel user;
        private Users usersPanel;
    }
}
