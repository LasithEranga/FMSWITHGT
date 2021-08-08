
namespace Fine_Management_System.MainWindowItems
{
    partial class Users
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
            this.usersPanel = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.driversLine = new System.Windows.Forms.Panel();
            this.officersLine = new System.Windows.Forms.Panel();
            this.addNewBtn = new System.Windows.Forms.Panel();
            this.allUsersLine = new System.Windows.Forms.Panel();
            this.labelDrivers = new System.Windows.Forms.Label();
            this.labelOfficers = new System.Windows.Forms.Label();
            this.labelAllusrs = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.usrsSearchIcon = new System.Windows.Forms.PictureBox();
            this.usrsSearchInput = new System.Windows.Forms.TextBox();
            this.labelUsrs = new System.Windows.Forms.Label();
            this.table = new Fine_Management_System.UsersItems.UserTable();
            this.usersPanel.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usrsSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // usersPanel
            // 
            this.usersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.usersPanel.Controls.Add(this.table);
            this.usersPanel.Controls.Add(this.panel22);
            this.usersPanel.Location = new System.Drawing.Point(0, 0);
            this.usersPanel.Margin = new System.Windows.Forms.Padding(4);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(930, 627);
            this.usersPanel.TabIndex = 12;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.panel22.Controls.Add(this.driversLine);
            this.panel22.Controls.Add(this.officersLine);
            this.panel22.Controls.Add(this.addNewBtn);
            this.panel22.Controls.Add(this.allUsersLine);
            this.panel22.Controls.Add(this.labelDrivers);
            this.panel22.Controls.Add(this.labelOfficers);
            this.panel22.Controls.Add(this.labelAllusrs);
            this.panel22.Controls.Add(this.panel21);
            this.panel22.Controls.Add(this.labelUsrs);
            this.panel22.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel22.Location = new System.Drawing.Point(12, 7);
            this.panel22.Margin = new System.Windows.Forms.Padding(4);
            this.panel22.Name = "panel22";
            this.panel22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel22.Size = new System.Drawing.Size(909, 128);
            this.panel22.TabIndex = 2;
            this.panel22.Paint += new System.Windows.Forms.PaintEventHandler(this.panel22_Paint);
            // 
            // driversLine
            // 
            this.driversLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(143)))));
            this.driversLine.Location = new System.Drawing.Point(410, 122);
            this.driversLine.Margin = new System.Windows.Forms.Padding(4);
            this.driversLine.Name = "driversLine";
            this.driversLine.Size = new System.Drawing.Size(100, 5);
            this.driversLine.TabIndex = 4;
            // 
            // officersLine
            // 
            this.officersLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(143)))));
            this.officersLine.Location = new System.Drawing.Point(223, 123);
            this.officersLine.Margin = new System.Windows.Forms.Padding(4);
            this.officersLine.Name = "officersLine";
            this.officersLine.Size = new System.Drawing.Size(100, 5);
            this.officersLine.TabIndex = 4;
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackgroundImage = global::Fine_Management_System.Properties.Resources.ADD_NEW;
            this.addNewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addNewBtn.Location = new System.Drawing.Point(758, 85);
            this.addNewBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(145, 38);
            this.addNewBtn.TabIndex = 3;
            this.addNewBtn.Click += new System.EventHandler(this.addUsrBtnClick);
            this.addNewBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.addNewBtn_Paint);
            // 
            // allUsersLine
            // 
            this.allUsersLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(143)))));
            this.allUsersLine.Location = new System.Drawing.Point(72, 122);
            this.allUsersLine.Margin = new System.Windows.Forms.Padding(4);
            this.allUsersLine.Name = "allUsersLine";
            this.allUsersLine.Size = new System.Drawing.Size(100, 5);
            this.allUsersLine.TabIndex = 3;
            // 
            // labelDrivers
            // 
            this.labelDrivers.AutoSize = true;
            this.labelDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrivers.ForeColor = System.Drawing.Color.White;
            this.labelDrivers.Location = new System.Drawing.Point(417, 99);
            this.labelDrivers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrivers.Name = "labelDrivers";
            this.labelDrivers.Size = new System.Drawing.Size(83, 20);
            this.labelDrivers.TabIndex = 4;
            this.labelDrivers.Text = "DRIVERS";
            this.labelDrivers.Click += new System.EventHandler(this.labelDrivers_Click);
            // 
            // labelOfficers
            // 
            this.labelOfficers.AutoSize = true;
            this.labelOfficers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfficers.ForeColor = System.Drawing.Color.White;
            this.labelOfficers.Location = new System.Drawing.Point(231, 99);
            this.labelOfficers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOfficers.Name = "labelOfficers";
            this.labelOfficers.Size = new System.Drawing.Size(91, 20);
            this.labelOfficers.TabIndex = 3;
            this.labelOfficers.Text = "OFFICERS";
            this.labelOfficers.Click += new System.EventHandler(this.labelOfficers_Click);
            // 
            // labelAllusrs
            // 
            this.labelAllusrs.AutoSize = true;
            this.labelAllusrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllusrs.ForeColor = System.Drawing.Color.White;
            this.labelAllusrs.Location = new System.Drawing.Point(72, 99);
            this.labelAllusrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAllusrs.Name = "labelAllusrs";
            this.labelAllusrs.Size = new System.Drawing.Size(99, 20);
            this.labelAllusrs.TabIndex = 2;
            this.labelAllusrs.Text = "ALL USERS";
            this.labelAllusrs.Click += new System.EventHandler(this.labelAllusrs_Click);
            // 
            // panel21
            // 
            this.panel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel21.Controls.Add(this.usrsSearchIcon);
            this.panel21.Controls.Add(this.usrsSearchInput);
            this.panel21.Location = new System.Drawing.Point(155, 27);
            this.panel21.Margin = new System.Windows.Forms.Padding(4);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(185, 33);
            this.panel21.TabIndex = 1;
            // 
            // usrsSearchIcon
            // 
            this.usrsSearchIcon.Image = global::Fine_Management_System.Properties.Resources.search1;
            this.usrsSearchIcon.Location = new System.Drawing.Point(5, 7);
            this.usrsSearchIcon.Name = "usrsSearchIcon";
            this.usrsSearchIcon.Size = new System.Drawing.Size(20, 19);
            this.usrsSearchIcon.TabIndex = 5;
            this.usrsSearchIcon.TabStop = false;
            // 
            // usrsSearchInput
            // 
            this.usrsSearchInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.usrsSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usrsSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrsSearchInput.ForeColor = System.Drawing.SystemColors.Control;
            this.usrsSearchInput.Location = new System.Drawing.Point(32, 7);
            this.usrsSearchInput.Margin = new System.Windows.Forms.Padding(4);
            this.usrsSearchInput.Name = "usrsSearchInput";
            this.usrsSearchInput.Size = new System.Drawing.Size(149, 19);
            this.usrsSearchInput.TabIndex = 2;
            this.usrsSearchInput.Text = "Search Here";
            this.usrsSearchInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.usrsSearchInput.Enter += new System.EventHandler(this.Search_Focus);
            // 
            // labelUsrs
            // 
            this.labelUsrs.AutoSize = true;
            this.labelUsrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsrs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsrs.Location = new System.Drawing.Point(39, 27);
            this.labelUsrs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsrs.Name = "labelUsrs";
            this.labelUsrs.Size = new System.Drawing.Size(108, 31);
            this.labelUsrs.TabIndex = 0;
            this.labelUsrs.Text = "USERS";
            // 
            // table
            // 
            this.table.Location = new System.Drawing.Point(12, 152);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(909, 412);
            this.table.TabIndex = 4;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usersPanel);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(930, 627);
            this.usersPanel.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usrsSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel usersPanel;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel addNewBtn;
        private System.Windows.Forms.Panel allUsersLine;
        private System.Windows.Forms.Label labelDrivers;
        private System.Windows.Forms.Label labelOfficers;
        private System.Windows.Forms.Label labelAllusrs;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.PictureBox usrsSearchIcon;
        private System.Windows.Forms.TextBox usrsSearchInput;
        private System.Windows.Forms.Label labelUsrs;
        private UsersItems.UserTable table;
        private System.Windows.Forms.Panel driversLine;
        private System.Windows.Forms.Panel officersLine;
    }
}
