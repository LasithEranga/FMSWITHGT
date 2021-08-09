
namespace Fine_Management_System.MainWindowItems
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.fineReceipt1 = new Fine_Management_System.ReportItems.FineReceipt();
            this.gobtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rptSearchIcon = new System.Windows.Forms.Panel();
            this.rptNav = new System.Windows.Forms.Panel();
            this.list = new System.Windows.Forms.ComboBox();
            this.dpIcon2 = new System.Windows.Forms.Panel();
            this.dpIcon1 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rptSearch = new System.Windows.Forms.TextBox();
            this.reportTextBox = new System.Windows.Forms.RichTextBox();
            this.saveAsPdfBtn = new System.Windows.Forms.Panel();
            this.shareBtn = new System.Windows.Forms.Panel();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.reportPanel.SuspendLayout();
            this.rptNav.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.reportPanel.Controls.Add(this.fineReceipt1);
            this.reportPanel.Controls.Add(this.gobtn);
            this.reportPanel.Controls.Add(this.label1);
            this.reportPanel.Controls.Add(this.rptSearchIcon);
            this.reportPanel.Controls.Add(this.rptNav);
            this.reportPanel.Controls.Add(this.dpIcon2);
            this.reportPanel.Controls.Add(this.dpIcon1);
            this.reportPanel.Controls.Add(this.dateTimePicker2);
            this.reportPanel.Controls.Add(this.labelTo);
            this.reportPanel.Controls.Add(this.labelFrom);
            this.reportPanel.Controls.Add(this.dateTimePicker1);
            this.reportPanel.Controls.Add(this.panel11);
            this.reportPanel.Controls.Add(this.reportTextBox);
            this.reportPanel.Controls.Add(this.saveAsPdfBtn);
            this.reportPanel.Controls.Add(this.shareBtn);
            this.reportPanel.Location = new System.Drawing.Point(0, 0);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(927, 624);
            this.reportPanel.TabIndex = 5;
            // 
            // fineReceipt1
            // 
            this.fineReceipt1.Location = new System.Drawing.Point(18, 121);
            this.fineReceipt1.Name = "fineReceipt1";
            this.fineReceipt1.Size = new System.Drawing.Size(895, 481);
            this.fineReceipt1.TabIndex = 16;
            // 
            // gobtn
            // 
            this.gobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(198)))), ((int)(((byte)(143)))));
            this.gobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gobtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobtn.ForeColor = System.Drawing.Color.White;
            this.gobtn.Location = new System.Drawing.Point(585, 67);
            this.gobtn.Name = "gobtn";
            this.gobtn.Size = new System.Drawing.Size(93, 35);
            this.gobtn.TabIndex = 15;
            this.gobtn.Text = "Go";
            this.gobtn.UseVisualStyleBackColor = false;
            this.gobtn.Click += new System.EventHandler(this.GoBtnClick);
            this.gobtn.MouseHover += new System.EventHandler(this.go_tip);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "REPORTS";
            // 
            // rptSearchIcon
            // 
            this.rptSearchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.rptSearchIcon.BackgroundImage = global::Fine_Management_System.Properties.Resources.search1;
            this.rptSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rptSearchIcon.Location = new System.Drawing.Point(623, 2);
            this.rptSearchIcon.Name = "rptSearchIcon";
            this.rptSearchIcon.Size = new System.Drawing.Size(42, 35);
            this.rptSearchIcon.TabIndex = 11;
            // 
            // rptNav
            // 
            this.rptNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.rptNav.Controls.Add(this.list);
            this.rptNav.Location = new System.Drawing.Point(297, 1);
            this.rptNav.Name = "rptNav";
            this.rptNav.Size = new System.Drawing.Size(327, 36);
            this.rptNav.TabIndex = 11;
            // 
            // list
            // 
            this.list.AllowDrop = true;
            this.list.AutoCompleteCustomSource.AddRange(new string[] {
            "Expired"});
            this.list.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.list.BackColor = System.Drawing.SystemColors.InfoText;
            this.list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.list.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.list.FormattingEnabled = true;
            this.list.Items.AddRange(new object[] {
            "Expired",
            "Sued List",
            "Pending",
            "Paid",
            "All Records"});
            this.list.Location = new System.Drawing.Point(192, 6);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(121, 21);
            this.list.TabIndex = 6;
            this.list.SelectedIndexChanged += new System.EventHandler(this.IndexChanged);
            // 
            // dpIcon2
            // 
            this.dpIcon2.BackgroundImage = global::Fine_Management_System.Properties.Resources.calander;
            this.dpIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dpIcon2.Location = new System.Drawing.Point(489, 67);
            this.dpIcon2.Name = "dpIcon2";
            this.dpIcon2.Size = new System.Drawing.Size(26, 26);
            this.dpIcon2.TabIndex = 10;
            // 
            // dpIcon1
            // 
            this.dpIcon1.BackgroundImage = global::Fine_Management_System.Properties.Resources.calander;
            this.dpIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dpIcon1.Location = new System.Drawing.Point(219, 68);
            this.dpIcon1.Name = "dpIcon1";
            this.dpIcon1.Size = new System.Drawing.Size(26, 26);
            this.dpIcon1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(345, 67);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 26);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.White;
            this.labelTo.Location = new System.Drawing.Point(293, 73);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(29, 20);
            this.labelTo.TabIndex = 7;
            this.labelTo.Text = "To";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.ForeColor = System.Drawing.Color.White;
            this.labelFrom.Location = new System.Drawing.Point(17, 73);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(50, 20);
            this.labelFrom.TabIndex = 6;
            this.labelFrom.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.panel11.Controls.Add(this.rptSearch);
            this.panel11.Location = new System.Drawing.Point(662, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(262, 35);
            this.panel11.TabIndex = 4;
            // 
            // rptSearch
            // 
            this.rptSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.rptSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.rptSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(41)))), ((int)(((byte)(44)))));
            this.rptSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rptSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.rptSearch.Location = new System.Drawing.Point(9, 6);
            this.rptSearch.Name = "rptSearch";
            this.rptSearch.Size = new System.Drawing.Size(250, 22);
            this.rptSearch.TabIndex = 0;
            this.rptSearch.Text = "Search Here";
            this.rptSearch.TextChanged += new System.EventHandler(this.rptSearch_TextChanged);
            this.rptSearch.Enter += new System.EventHandler(this.Focus_Search);
            // 
            // reportTextBox
            // 
            this.reportTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(25)))));
            this.reportTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.reportTextBox.Location = new System.Drawing.Point(18, 121);
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.Size = new System.Drawing.Size(895, 481);
            this.reportTextBox.TabIndex = 2;
            this.reportTextBox.Text = "";
            // 
            // saveAsPdfBtn
            // 
            this.saveAsPdfBtn.BackgroundImage = global::Fine_Management_System.Properties.Resources.save_as_pdf_new;
            this.saveAsPdfBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveAsPdfBtn.Location = new System.Drawing.Point(806, 68);
            this.saveAsPdfBtn.Name = "saveAsPdfBtn";
            this.saveAsPdfBtn.Size = new System.Drawing.Size(107, 34);
            this.saveAsPdfBtn.TabIndex = 1;
            this.saveAsPdfBtn.Click += new System.EventHandler(this.SaveAsPdf);
            this.saveAsPdfBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.saveAsPdfBtn_Paint);
            this.saveAsPdfBtn.MouseHover += new System.EventHandler(this.saveas_tip);
            // 
            // shareBtn
            // 
            this.shareBtn.BackgroundImage = global::Fine_Management_System.Properties.Resources.share_new;
            this.shareBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shareBtn.Location = new System.Drawing.Point(697, 68);
            this.shareBtn.Name = "shareBtn";
            this.shareBtn.Size = new System.Drawing.Size(92, 34);
            this.shareBtn.TabIndex = 0;
            this.shareBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShareClicked);
            this.shareBtn.MouseHover += new System.EventHandler(this.share_tip);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportPanel);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(930, 627);
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            this.rptNav.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rptSearchIcon;
        private System.Windows.Forms.Panel rptNav;
        private System.Windows.Forms.Panel dpIcon2;
        private System.Windows.Forms.Panel dpIcon1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox rptSearch;
        private System.Windows.Forms.RichTextBox reportTextBox;
        private System.Windows.Forms.Panel saveAsPdfBtn;
        private System.Windows.Forms.Panel shareBtn;
        private System.Windows.Forms.Button gobtn;
        private ReportItems.FineReceipt fineReceipt1;
        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}
