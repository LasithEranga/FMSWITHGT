
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStripPanel = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelChartsTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.chartDateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.chartToLabel = new System.Windows.Forms.Label();
            this.chartFromLabel = new System.Windows.Forms.Label();
            this.goBtn = new System.Windows.Forms.Panel();
            this.chartCalenderIcon1 = new System.Windows.Forms.Panel();
            this.chartCalenderIcon2 = new System.Windows.Forms.Panel();
            this.chartBackground = new System.Windows.Forms.Panel();
            this.statLegendLabel = new System.Windows.Forms.Label();
            this.casesLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartPanelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.panel5.Controls.Add(this.menuStripPanel);
            this.panel5.Controls.Add(this.goBtn);
            this.panel5.Controls.Add(this.labelChartsTitle);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(28, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(864, 77);
            this.panel5.TabIndex = 17;
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
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sortByToolStripMenuItem.Text = "&Sort by";
            // 
            // dayToolStripMenuItem
            // 
            this.dayToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
            this.dayToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.dayToolStripMenuItem.Text = "&Day";
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.monthToolStripMenuItem.Text = "&Month";
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.yearToolStripMenuItem.Text = "&Year";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueToolStripMenuItem,
            this.noCasesToolStripMenuItem,
            this.vehicleTypeToolStripMenuItem});
            this.categoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "&Category";
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.revenueToolStripMenuItem.Text = "&Revenue";
            // 
            // noCasesToolStripMenuItem
            // 
            this.noCasesToolStripMenuItem.Name = "noCasesToolStripMenuItem";
            this.noCasesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.noCasesToolStripMenuItem.Text = "&No_Cases";
            // 
            // vehicleTypeToolStripMenuItem
            // 
            this.vehicleTypeToolStripMenuItem.Name = "vehicleTypeToolStripMenuItem";
            this.vehicleTypeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.vehicleTypeToolStripMenuItem.Text = "&Vehicle Type";
            // 
            // chartTypeToolStripMenuItem
            // 
            this.chartTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineChartToolStripMenuItem,
            this.barGraphToolStripMenuItem,
            this.pieChartToolStripMenuItem});
            this.chartTypeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.chartTypeToolStripMenuItem.Name = "chartTypeToolStripMenuItem";
            this.chartTypeToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.chartTypeToolStripMenuItem.Text = "&Chart Type";
            // 
            // lineChartToolStripMenuItem
            // 
            this.lineChartToolStripMenuItem.Name = "lineChartToolStripMenuItem";
            this.lineChartToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lineChartToolStripMenuItem.Text = "&Line Chart";
            // 
            // barGraphToolStripMenuItem
            // 
            this.barGraphToolStripMenuItem.Name = "barGraphToolStripMenuItem";
            this.barGraphToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.barGraphToolStripMenuItem.Text = "&Bar Graph";
            // 
            // pieChartToolStripMenuItem
            // 
            this.pieChartToolStripMenuItem.Name = "pieChartToolStripMenuItem";
            this.pieChartToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pieChartToolStripMenuItem.Text = "&Pie Chart";
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
            this.panel3.Controls.Add(this.dateTimePickerFrom);
            this.panel3.Controls.Add(this.chartCalenderIcon2);
            this.panel3.Controls.Add(this.chartDateTimePickerTo);
            this.panel3.Controls.Add(this.chartToLabel);
            this.panel3.Controls.Add(this.chartFromLabel);
            this.panel3.Location = new System.Drawing.Point(3, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 40);
            this.panel3.TabIndex = 16;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(80, 8);
            this.dateTimePickerFrom.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFrom.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(76, 20);
            this.dateTimePickerFrom.TabIndex = 2;
            // 
            // chartDateTimePickerTo
            // 
            this.chartDateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.chartDateTimePickerTo.Location = new System.Drawing.Point(309, 7);
            this.chartDateTimePickerTo.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.chartDateTimePickerTo.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.chartDateTimePickerTo.Name = "chartDateTimePickerTo";
            this.chartDateTimePickerTo.Size = new System.Drawing.Size(76, 20);
            this.chartDateTimePickerTo.TabIndex = 4;
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
            // goBtn
            // 
            this.goBtn.BackgroundImage = global::Fine_Management_System.Properties.Resources.Group_31;
            this.goBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goBtn.Location = new System.Drawing.Point(733, 35);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(128, 39);
            this.goBtn.TabIndex = 7;
            this.goBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.a);
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
            // chartCalenderIcon2
            // 
            this.chartCalenderIcon2.BackgroundImage = global::Fine_Management_System.Properties.Resources.calander;
            this.chartCalenderIcon2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chartCalenderIcon2.Location = new System.Drawing.Point(405, 3);
            this.chartCalenderIcon2.Name = "chartCalenderIcon2";
            this.chartCalenderIcon2.Size = new System.Drawing.Size(26, 26);
            this.chartCalenderIcon2.TabIndex = 11;
            // 
            // chartBackground
            // 
            this.chartBackground.BackgroundImage = global::Fine_Management_System.Properties.Resources.chartBack;
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
            this.panel2.BackColor = System.Drawing.Color.Lime;
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
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartPanelChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(34)))));
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.WhiteSmoke;
            legend1.Name = "Legend1";
            this.chartPanelChart.Legends.Add(legend1);
            this.chartPanelChart.Location = new System.Drawing.Point(10, 37);
            this.chartPanelChart.Name = "chartPanelChart";
            this.chartPanelChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartPanelChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(218)))), ((int)(((byte)(72)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            this.chartPanelChart.Series.Add(series1);
            this.chartPanelChart.Size = new System.Drawing.Size(807, 383);
            this.chartPanelChart.TabIndex = 8;
            this.chartPanelChart.Text = "chartNew";
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
        private System.Windows.Forms.ToolStripMenuItem vehicleTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieChartToolStripMenuItem;
        private System.Windows.Forms.Panel goBtn;
        private System.Windows.Forms.Label labelChartsTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel chartCalenderIcon1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Panel chartCalenderIcon2;
        private System.Windows.Forms.DateTimePicker chartDateTimePickerTo;
        private System.Windows.Forms.Label chartToLabel;
        private System.Windows.Forms.Label chartFromLabel;
        private System.Windows.Forms.Panel chartBackground;
        private System.Windows.Forms.Label statLegendLabel;
        private System.Windows.Forms.Label casesLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPanelChart;
    }
}
