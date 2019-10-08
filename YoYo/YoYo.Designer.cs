namespace YoYo
{
    partial class YoYo
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.paretoChart = new DevExpress.XtraCharts.ChartControl();
            this.ProductCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.moldsTotalLabel = new System.Windows.Forms.Label();
            this.moldsSuccessLabel = new System.Windows.Forms.Label();
            this.moldsYieldLabel = new System.Windows.Forms.Label();
            this.paintYieldLabel = new System.Windows.Forms.Label();
            this.paintSuccessLabel = new System.Windows.Forms.Label();
            this.paintTotalLabel = new System.Windows.Forms.Label();
            this.assemblyYieldLabel = new System.Windows.Forms.Label();
            this.assemblySuccessLabel = new System.Windows.Forms.Label();
            this.assemblyTotalLabel = new System.Windows.Forms.Label();
            this.packageYieldLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paretoChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // paretoChart
            // 
            xyDiagram1.AxisX.Title.Text = "Types of Failures";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Frequency";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.Name = "Failure Percentage";
            secondaryAxisY1.Title.Text = "Failure Percentage";
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            this.paretoChart.Diagram = xyDiagram1;
            this.paretoChart.Legend.Name = "Default Legend";
            this.paretoChart.Location = new System.Drawing.Point(237, 22);
            this.paretoChart.Name = "paretoChart";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Name = "Failures";
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series1.ValueDataMembersSerializable = "5";
            series2.Name = "Cumulative Percentage";
            series2.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending;
            series2.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            series2.View = lineSeriesView1;
            this.paretoChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.paretoChart.Size = new System.Drawing.Size(729, 504);
            this.paretoChart.TabIndex = 8;
            chartTitle1.Text = "Reasons for Rejection";
            this.paretoChart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // ProductCb
            // 
            this.ProductCb.FormattingEnabled = true;
            this.ProductCb.Items.AddRange(new object[] {
            "All"});
            this.ProductCb.Location = new System.Drawing.Point(88, 46);
            this.ProductCb.Name = "ProductCb";
            this.ProductCb.Size = new System.Drawing.Size(121, 21);
            this.ProductCb.TabIndex = 9;
            this.ProductCb.SelectedIndexChanged += new System.EventHandler(this.ProductCB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Successful: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Yield: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Yield: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Successful: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(94, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Molds";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(94, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Paint";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Assembly";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Yield: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Successful: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Total: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(72, 448);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Package";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 488);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Yield: ";
            // 
            // moldsTotalLabel
            // 
            this.moldsTotalLabel.AutoSize = true;
            this.moldsTotalLabel.Location = new System.Drawing.Point(107, 131);
            this.moldsTotalLabel.Name = "moldsTotalLabel";
            this.moldsTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.moldsTotalLabel.TabIndex = 28;
            this.moldsTotalLabel.Text = "0";
            // 
            // moldsSuccessLabel
            // 
            this.moldsSuccessLabel.AutoSize = true;
            this.moldsSuccessLabel.Location = new System.Drawing.Point(107, 157);
            this.moldsSuccessLabel.Name = "moldsSuccessLabel";
            this.moldsSuccessLabel.Size = new System.Drawing.Size(13, 13);
            this.moldsSuccessLabel.TabIndex = 29;
            this.moldsSuccessLabel.Text = "0";
            // 
            // moldsYieldLabel
            // 
            this.moldsYieldLabel.AutoSize = true;
            this.moldsYieldLabel.Location = new System.Drawing.Point(107, 184);
            this.moldsYieldLabel.Name = "moldsYieldLabel";
            this.moldsYieldLabel.Size = new System.Drawing.Size(13, 13);
            this.moldsYieldLabel.TabIndex = 30;
            this.moldsYieldLabel.Text = "0";
            // 
            // paintYieldLabel
            // 
            this.paintYieldLabel.AutoSize = true;
            this.paintYieldLabel.Location = new System.Drawing.Point(107, 294);
            this.paintYieldLabel.Name = "paintYieldLabel";
            this.paintYieldLabel.Size = new System.Drawing.Size(13, 13);
            this.paintYieldLabel.TabIndex = 33;
            this.paintYieldLabel.Text = "0";
            // 
            // paintSuccessLabel
            // 
            this.paintSuccessLabel.AutoSize = true;
            this.paintSuccessLabel.Location = new System.Drawing.Point(107, 267);
            this.paintSuccessLabel.Name = "paintSuccessLabel";
            this.paintSuccessLabel.Size = new System.Drawing.Size(13, 13);
            this.paintSuccessLabel.TabIndex = 32;
            this.paintSuccessLabel.Text = "0";
            // 
            // paintTotalLabel
            // 
            this.paintTotalLabel.AutoSize = true;
            this.paintTotalLabel.Location = new System.Drawing.Point(107, 241);
            this.paintTotalLabel.Name = "paintTotalLabel";
            this.paintTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.paintTotalLabel.TabIndex = 31;
            this.paintTotalLabel.Text = "0";
            // 
            // assemblyYieldLabel
            // 
            this.assemblyYieldLabel.AutoSize = true;
            this.assemblyYieldLabel.Location = new System.Drawing.Point(107, 410);
            this.assemblyYieldLabel.Name = "assemblyYieldLabel";
            this.assemblyYieldLabel.Size = new System.Drawing.Size(13, 13);
            this.assemblyYieldLabel.TabIndex = 36;
            this.assemblyYieldLabel.Text = "0";
            // 
            // assemblySuccessLabel
            // 
            this.assemblySuccessLabel.AutoSize = true;
            this.assemblySuccessLabel.Location = new System.Drawing.Point(107, 383);
            this.assemblySuccessLabel.Name = "assemblySuccessLabel";
            this.assemblySuccessLabel.Size = new System.Drawing.Size(13, 13);
            this.assemblySuccessLabel.TabIndex = 35;
            this.assemblySuccessLabel.Text = "0";
            // 
            // assemblyTotalLabel
            // 
            this.assemblyTotalLabel.AutoSize = true;
            this.assemblyTotalLabel.Location = new System.Drawing.Point(107, 357);
            this.assemblyTotalLabel.Name = "assemblyTotalLabel";
            this.assemblyTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.assemblyTotalLabel.TabIndex = 34;
            this.assemblyTotalLabel.Text = "0";
            // 
            // packageYieldLabel
            // 
            this.packageYieldLabel.AutoSize = true;
            this.packageYieldLabel.Location = new System.Drawing.Point(107, 488);
            this.packageYieldLabel.Name = "packageYieldLabel";
            this.packageYieldLabel.Size = new System.Drawing.Size(13, 13);
            this.packageYieldLabel.TabIndex = 37;
            this.packageYieldLabel.Text = "0";
            // 
            // YoYo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 538);
            this.Controls.Add(this.packageYieldLabel);
            this.Controls.Add(this.assemblyYieldLabel);
            this.Controls.Add(this.assemblySuccessLabel);
            this.Controls.Add(this.assemblyTotalLabel);
            this.Controls.Add(this.paintYieldLabel);
            this.Controls.Add(this.paintSuccessLabel);
            this.Controls.Add(this.paintTotalLabel);
            this.Controls.Add(this.moldsYieldLabel);
            this.Controls.Add(this.moldsSuccessLabel);
            this.Controls.Add(this.moldsTotalLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductCb);
            this.Controls.Add(this.paretoChart);
            this.Name = "YoYo";
            this.Text = "YoYo";
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paretoChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraCharts.ChartControl paretoChart;
        private System.Windows.Forms.ComboBox ProductCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label moldsTotalLabel;
        private System.Windows.Forms.Label moldsSuccessLabel;
        private System.Windows.Forms.Label moldsYieldLabel;
        private System.Windows.Forms.Label paintYieldLabel;
        private System.Windows.Forms.Label paintSuccessLabel;
        private System.Windows.Forms.Label paintTotalLabel;
        private System.Windows.Forms.Label assemblyYieldLabel;
        private System.Windows.Forms.Label assemblySuccessLabel;
        private System.Windows.Forms.Label assemblyTotalLabel;
        private System.Windows.Forms.Label packageYieldLabel;
    }
}

