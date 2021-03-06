
namespace Fine_Management_System.MainWindowItems
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.Label();
            this.menuStripPanel = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBtn = new System.Windows.Forms.Panel();
            this.labelChartsTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartCalenderIcon1 = new System.Windows.Forms.Panel();
            this.dtpicker1 = new System.Windows.Forms.DateTimePicker();
            this.chartCalenderIcon2 = new System.Windows.Forms.Panel();
            this.dtpicker2 = new System.Windows.Forms.DateTimePicker();
            this.chartToLabel = new System.Windows.Forms.Label();
            this.chartFromLabel = new System.Windows.Forms.Label();
            this.chartBackground = new System.Windows.Forms.Panel();
            this.statLegendLabel = new System.Windows.Forms.Label();
            this.casesLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartPanelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.yaxis = new System.Windows.Forms.Label();
            this.xaxis = new System.Windows.Forms.Label();
            this.chartPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStripPanel.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.chartBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPanelChart)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPanel
            // 
            this.chartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.chartPanel.Controls.Add(this.panel5);
            this.chartPanel.Controls.Add(this.chartBackground);
            this.chartPanel.Location = new System.Drawing.Point(0, 0);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(927, 624);
            this.chartPanel.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.loading);
            this.panel5.Controls.Add(this.menuStripPanel);
            this.panel5.Controls.Add(this.goBtn);
            this.panel5.Controls.Add(this.labelChartsTitle);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(28, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(864, 77);
            this.panel5.TabIndex = 17;
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loading.Location = new System.Drawing.Point(645, 46);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(0, 13);
            this.loading.TabIndex = 18;
            // 
            // menuStripPanel
            // 
            this.menuStripPanel.BackColor = System.Drawing.Color.Black;
            this.menuStripPanel.Controls.Add(this.menuStrip2);
            this.menuStripPanel.Location = new System.Drawing.Point(141, 3);
            this.menuStripPanel.Name = "menuStripPanel";
            this.menuStripPanel.Size = new System.Drawing.Size(327, 25);
            this.menuStripPanel.TabIndex = 17;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.chartTypeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(327, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.yearToolStripMenuItem});
            this.sortByToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.sortByToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sortByToolStripMenuItem.Text = "&View By";
            this.sortByToolStripMenuItem.DropDownClosed += new System.EventHandler(this.ViewByDropdownCLosed);
            this.sortByToolStripMenuItem.Click += new System.EventHandler(this.ViewClick);
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dayToolStripMenuItem.Text = "&Day";
            this.dayToolStripMenuItem.Click += new System.EventHandler(this.dayToolStripMenuItem_Click);
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthToolStripMenuItem.Text = "&Month";
            this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItem_Click);
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yearToolStripMenuItem.Text = "&Year";
            this.yearToolStripMenuItem.Click += new System.EventHandler(this.yearToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueToolStripMenuItem,
            this.noCasesToolStripMenuItem});
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "&Category";
            this.categoryToolStripMenuItem.DropDownClosed += new System.EventHandler(this.CatDropdownClosed);
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.CatClick);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revenueToolStripMenuItem.Text = "&Revenue";
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // noCasesToolStripMenuItem
            // 
            this.noCasesToolStripMenuItem.Name = "noCasesToolStripMenuItem";
            this.noCasesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noCasesToolStripMenuItem.Text = "&No_Cases";
            this.noCasesToolStripMenuItem.Click += new System.EventHandler(this.NoCasesToolStripMenuItem_Click);
            // 
            // chartTypeToolStripMenuItem
            // 
            this.chartTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineChartToolStripMenuItem,
            this.barGraphToolStripMenuItem});
            this.chartTypeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.chartTypeToolStripMenuItem.Name = "chartTypeToolStripMenuItem";
            this.chartTypeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.chartTypeToolStripMenuItem.Text = "&Chart Type";
            this.chartTypeToolStripMenuItem.DropDownClosed += new System.EventHandler(this.DropDownClosed);
            this.chartTypeToolStripMenuItem.Click += new System.EventHandler(this.chartTypeToolStripMenuItem_Click);
            // 
            // lineChartToolStripMenuItem
            // 
            this.lineChartToolStripMenuItem.Name = "lineChartToolStripMenuItem";
            this.lineChartToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lineChartToolStripMenuItem.Text = "&Line Chart";
            this.lineChartToolStripMenuItem.Click += new System.EventHandler(this.lineChartToolStripMenuItem_Click);
            // 
            // barGraphToolStripMenuItem
            // 
            this.barGraphToolStripMenuItem.Name = "barGraphToolStripMenuItem";
            this.barGraphToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.barGraphToolStripMenuItem.Text = "&Bar Graph";
            this.barGraphToolStripMenuItem.Click += new System.EventHandler(this.barGraphToolStripMenuItem_Click);
            // 
            // goBtn
            // 
            this.goBtn.BackgroundImage = global::Fine_Management_System.Properties.Resources.Group_31;
            this.goBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goBtn.Location = new System.Drawing.Point(733, 35);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(128, 39);
            this.goBtn.TabIndex = 7;
            this.goBtn.Click += new System.EventHandler(this.GoBtnClick);
            this.goBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.goBtn_Paint);
            this.goBtn.MouseHover += new System.EventHandler(this.go_tip);
            // 
            // labelChartsTitle
            // 
            this.labelChartsTitle.AutoSize = true;
            this.labelChartsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartsTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelChartsTitle.Location = new System.Drawing.Point(3, 3);
            this.labelChartsTitle.Name = "labelChartsTitle";
            this.labelChartsTitle.Size = new System.Drawing.Size(132, 25);
            this.labelChartsTitle.TabIndex = 13;
            this.labelChartsTitle.Text = "STATISTICS";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chartCalenderIcon1);
            this.panel3.Controls.Add(this.dtpicker1);
            this.panel3.Controls.Add(this.chartCalenderIcon2);
            this.panel3.Controls.Add(this.dtpicker2);
            this.panel3.Controls.Add(this.chartToLabel);
            this.panel3.Controls.Add(this.chartFromLabel);
            this.panel3.Location = new System.Drawing.Point(3, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 40);
            this.panel3.TabIndex = 16;
            // 
            // chartCalenderIcon1
            // 
            this.chartCalenderIcon1.BackgroundImage = global::Fine_Management_System.Properties.Resources.calander;
            this.chartCalenderIcon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartCalenderIcon1.Location = new System.Drawing.Point(180, 3);
            this.chartCalenderIcon1.Name = "chartCalenderIcon1";
            this.chartCalenderIcon1.Size = new System.Drawing.Size(26, 26);
            this.chartCalenderIcon1.TabIndex = 10;
            // 
            // dtpicker1
            // 
            this.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker1.Location = new System.Drawing.Point(80, 8);
            this.dtpicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpicker1.Name = "dtpicker1";
            this.dtpicker1.Size = new System.Drawing.Size(76, 20);
            this.dtpicker1.TabIndex = 2;
            // 
            // chartCalenderIcon2
            // 
            this.chartCalenderIcon2.BackgroundImage = global::Fine_Management_System.Properties.Resources.calander;
            this.chartCalenderIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartCalenderIcon2.Location = new System.Drawing.Point(405, 3);
            this.chartCalenderIcon2.Name = "chartCalenderIcon2";
            this.chartCalenderIcon2.Size = new System.Drawing.Size(26, 26);
            this.chartCalenderIcon2.TabIndex = 11;
            // 
            // dtpicker2
            // 
            this.dtpicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker2.Location = new System.Drawing.Point(309, 7);
            this.dtpicker2.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpicker2.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpicker2.Name = "dtpicker2";
            this.dtpicker2.Size = new System.Drawing.Size(76, 20);
            this.dtpicker2.TabIndex = 4;
            // 
            // chartToLabel
            // 
            this.chartToLabel.AutoSize = true;
            this.chartToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartToLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chartToLabel.Location = new System.Drawing.Point(262, 6);
            this.chartToLabel.Name = "chartToLabel";
            this.chartToLabel.Size = new System.Drawing.Size(37, 20);
            this.chartToLabel.TabIndex = 1;
            this.chartToLabel.Text = "TO:";
            // 
            // chartFromLabel
            // 
            this.chartFromLabel.AutoSize = true;
            this.chartFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartFromLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chartFromLabel.Location = new System.Drawing.Point(7, 9);
            this.chartFromLabel.Name = "chartFromLabel";
            this.chartFromLabel.Size = new System.Drawing.Size(65, 20);
            this.chartFromLabel.TabIndex = 0;
            this.chartFromLabel.Text = "FROM:";
            // 
            // chartBackground
            // 
            this.chartBackground.BackgroundImage = global::Fine_Management_System.Properties.Resources.chartBack;
            this.chartBackground.Controls.Add(this.xaxis);
            this.chartBackground.Controls.Add(this.yaxis);
            this.chartBackground.Controls.Add(this.statLegendLabel);
            this.chartBackground.Controls.Add(this.casesLabel);
            this.chartBackground.Controls.Add(this.panel2);
            this.chartBackground.Controls.Add(this.chartPanelChart);
            this.chartBackground.Location = new System.Drawing.Point(28, 103);
            this.chartBackground.Name = "chartBackground";
            this.chartBackground.Size = new System.Drawing.Size(864, 469);
            this.chartBackground.TabIndex = 12;
            // 
            // statLegendLabel
            // 
            this.statLegendLabel.AutoSize = true;
            this.statLegendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLegendLabel.ForeColor = System.Drawing.Color.White;
            this.statLegendLabel.Location = new System.Drawing.Point(411, 18);
            this.statLegendLabel.Name = "statLegendLabel";
            this.statLegendLabel.Size = new System.Drawing.Size(73, 20);
            this.statLegendLabel.TabIndex = 14;
            this.statLegendLabel.Text = "Revenue";
            // 
            // casesLabel
            // 
            this.casesLabel.AutoSize = true;
            this.casesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.casesLabel.Location = new System.Drawing.Point(782, 18);
            this.casesLabel.Name = "casesLabel";
            this.casesLabel.Size = new System.Drawing.Size(43, 13);
            this.casesLabel.TabIndex = 10;
            this.casesLabel.Text = "Amount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(240)))));
            this.panel2.Location = new System.Drawing.Point(737, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 5);
            this.panel2.TabIndex = 9;
            // 
            // chartPanelChart
            // 
            this.chartPanelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.chartPanelChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartPanelChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chartPanelChart.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartPanelChart.BackSecondaryColor = System.Drawing.Color.White;
            this.chartPanelChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            chartArea2.BorderColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.chartPanelChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            legend2.Enabled = false;
            legend2.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend2.Name = "Legend1";
            this.chartPanelChart.Legends.Add(legend2);
            this.chartPanelChart.Location = new System.Drawing.Point(10, 37);
            this.chartPanelChart.Name = "chartPanelChart";
            this.chartPanelChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartPanelChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(218)))), ((int)(((byte)(72)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Lime;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series1";
            this.chartPanelChart.Series.Add(series2);
            this.chartPanelChart.Size = new System.Drawing.Size(807, 383);
            this.chartPanelChart.TabIndex = 8;
            this.chartPanelChart.Text = "chartNew";
            // 
            // yaxis
            // 
            this.yaxis.AutoSize = true;
            this.yaxis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yaxis.Location = new System.Drawing.Point(26, 21);
            this.yaxis.Name = "yaxis";
            this.yaxis.Size = new System.Drawing.Size(62, 13);
            this.yaxis.TabIndex = 15;
            this.yaxis.Text = "Amount(Rs)";
            // 
            // xaxis
            // 
            this.xaxis.AutoSize = true;
            this.xaxis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xaxis.Location = new System.Drawing.Point(389, 423);
            this.xaxis.Name = "xaxis";
            this.xaxis.Size = new System.Drawing.Size(30, 13);
            this.xaxis.TabIndex = 16;
            this.xaxis.Text = "Date";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartPanel);
            this.Name = "Statistics";
            this.Size = new System.Drawing.Size(930, 627);
            this.chartPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.menuStripPanel.ResumeLayout(false);
            this.menuStripPanel.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.chartBackground.ResumeLayout(false);
            this.chartBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPanelChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel menuStripPanel;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barGraphToolStripMenuItem;
        private System.Windows.Forms.Panel goBtn;
        private System.Windows.Forms.Label labelChartsTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel chartCalenderIcon1;
        private System.Windows.Forms.DateTimePicker dtpicker1;
        private System.Windows.Forms.Panel chartCalenderIcon2;
        private System.Windows.Forms.DateTimePicker dtpicker2;
        private System.Windows.Forms.Label chartToLabel;
        private System.Windows.Forms.Label chartFromLabel;
        private System.Windows.Forms.Panel chartBackground;
        private System.Windows.Forms.Label statLegendLabel;
        private System.Windows.Forms.Label casesLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPanelChart;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Label xaxis;
        private System.Windows.Forms.Label yaxis;
    }
}
