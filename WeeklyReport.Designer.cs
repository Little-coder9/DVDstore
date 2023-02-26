
namespace Coursework1
{
    partial class WeeklyReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DateofReport = new System.Windows.Forms.DateTimePicker();
            this.WeeklyReportView = new System.Windows.Forms.DataGridView();
            this.GetWeeklyReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.weeklychart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyReportView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklychart)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1491, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DateofReport
            // 
            this.DateofReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateofReport.Location = new System.Drawing.Point(247, 27);
            this.DateofReport.Name = "DateofReport";
            this.DateofReport.Size = new System.Drawing.Size(233, 32);
            this.DateofReport.TabIndex = 1;
            // 
            // WeeklyReportView
            // 
            this.WeeklyReportView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WeeklyReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeeklyReportView.Location = new System.Drawing.Point(12, 103);
            this.WeeklyReportView.Name = "WeeklyReportView";
            this.WeeklyReportView.RowHeadersWidth = 51;
            this.WeeklyReportView.RowTemplate.Height = 24;
            this.WeeklyReportView.Size = new System.Drawing.Size(629, 453);
            this.WeeklyReportView.TabIndex = 2;
            // 
            // GetWeeklyReport
            // 
            this.GetWeeklyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetWeeklyReport.Location = new System.Drawing.Point(184, 575);
            this.GetWeeklyReport.Name = "GetWeeklyReport";
            this.GetWeeklyReport.Size = new System.Drawing.Size(234, 58);
            this.GetWeeklyReport.TabIndex = 3;
            this.GetWeeklyReport.Text = "Get Weekly Report";
            this.GetWeeklyReport.UseVisualStyleBackColor = true;
            this.GetWeeklyReport.Click += new System.EventHandler(this.GetWeeklyReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Generate report upto:";
            // 
            // weeklychart
            // 
            chartArea3.Name = "ChartArea1";
            this.weeklychart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.weeklychart.Legends.Add(legend3);
            this.weeklychart.Location = new System.Drawing.Point(664, 74);
            this.weeklychart.Name = "weeklychart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Count";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Income";
            this.weeklychart.Series.Add(series5);
            this.weeklychart.Series.Add(series6);
            this.weeklychart.Size = new System.Drawing.Size(815, 538);
            this.weeklychart.TabIndex = 6;
            this.weeklychart.Text = "chart1";
            // 
            // WeeklyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 661);
            this.Controls.Add(this.weeklychart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetWeeklyReport);
            this.Controls.Add(this.WeeklyReportView);
            this.Controls.Add(this.DateofReport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WeeklyReport";
            this.Text = "WeeklyReport";
            this.Load += new System.EventHandler(this.WeeklyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyReportView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklychart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DateTimePicker DateofReport;
        private System.Windows.Forms.DataGridView WeeklyReportView;
        private System.Windows.Forms.Button GetWeeklyReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklychart;
    }
}