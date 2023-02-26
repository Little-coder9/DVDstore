
namespace Coursework1
{
    partial class DailyReport
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
            this.DateofReport = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ChildCount = new System.Windows.Forms.Label();
            this.AdultCount = new System.Windows.Forms.Label();
            this.Groupof5_Count = new System.Windows.Forms.Label();
            this.Groupof10_Count = new System.Windows.Forms.Label();
            this.ChildTotalIncome = new System.Windows.Forms.Label();
            this.AdultTotalIncome = new System.Windows.Forms.Label();
            this.Go5TotalIncome = new System.Windows.Forms.Label();
            this.Go10TotalIncome = new System.Windows.Forms.Label();
            this.see_report = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dailycount = new System.Windows.Forms.Label();
            this.dailyincome = new System.Windows.Forms.Label();
            this.DailyReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReportChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DateofReport
            // 
            this.DateofReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateofReport.Location = new System.Drawing.Point(265, 36);
            this.DateofReport.Name = "DateofReport";
            this.DateofReport.Size = new System.Drawing.Size(242, 34);
            this.DateofReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Generate Report of :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Visitor Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Income";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Child(5-12)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adult>12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Group of 5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Group of 10";
            // 
            // ChildCount
            // 
            this.ChildCount.AutoSize = true;
            this.ChildCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildCount.Location = new System.Drawing.Point(254, 204);
            this.ChildCount.Name = "ChildCount";
            this.ChildCount.Size = new System.Drawing.Size(64, 25);
            this.ChildCount.TabIndex = 9;
            this.ChildCount.Text = "label9";
            this.ChildCount.Visible = false;
            // 
            // AdultCount
            // 
            this.AdultCount.AutoSize = true;
            this.AdultCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdultCount.Location = new System.Drawing.Point(254, 254);
            this.AdultCount.Name = "AdultCount";
            this.AdultCount.Size = new System.Drawing.Size(75, 25);
            this.AdultCount.TabIndex = 10;
            this.AdultCount.Text = "label10";
            this.AdultCount.Visible = false;
            // 
            // Groupof5_Count
            // 
            this.Groupof5_Count.AutoSize = true;
            this.Groupof5_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupof5_Count.Location = new System.Drawing.Point(254, 310);
            this.Groupof5_Count.Name = "Groupof5_Count";
            this.Groupof5_Count.Size = new System.Drawing.Size(75, 25);
            this.Groupof5_Count.TabIndex = 11;
            this.Groupof5_Count.Text = "label11";
            this.Groupof5_Count.Visible = false;
            // 
            // Groupof10_Count
            // 
            this.Groupof10_Count.AutoSize = true;
            this.Groupof10_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupof10_Count.Location = new System.Drawing.Point(254, 360);
            this.Groupof10_Count.Name = "Groupof10_Count";
            this.Groupof10_Count.Size = new System.Drawing.Size(75, 25);
            this.Groupof10_Count.TabIndex = 12;
            this.Groupof10_Count.Text = "label12";
            this.Groupof10_Count.Visible = false;
            // 
            // ChildTotalIncome
            // 
            this.ChildTotalIncome.AutoSize = true;
            this.ChildTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChildTotalIncome.Location = new System.Drawing.Point(425, 204);
            this.ChildTotalIncome.Name = "ChildTotalIncome";
            this.ChildTotalIncome.Size = new System.Drawing.Size(75, 25);
            this.ChildTotalIncome.TabIndex = 13;
            this.ChildTotalIncome.Text = "label13";
            this.ChildTotalIncome.Visible = false;
            // 
            // AdultTotalIncome
            // 
            this.AdultTotalIncome.AutoSize = true;
            this.AdultTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdultTotalIncome.Location = new System.Drawing.Point(425, 254);
            this.AdultTotalIncome.Name = "AdultTotalIncome";
            this.AdultTotalIncome.Size = new System.Drawing.Size(75, 25);
            this.AdultTotalIncome.TabIndex = 14;
            this.AdultTotalIncome.Text = "label14";
            this.AdultTotalIncome.Visible = false;
            // 
            // Go5TotalIncome
            // 
            this.Go5TotalIncome.AutoSize = true;
            this.Go5TotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go5TotalIncome.Location = new System.Drawing.Point(425, 310);
            this.Go5TotalIncome.Name = "Go5TotalIncome";
            this.Go5TotalIncome.Size = new System.Drawing.Size(75, 25);
            this.Go5TotalIncome.TabIndex = 15;
            this.Go5TotalIncome.Text = "label15";
            this.Go5TotalIncome.Visible = false;
            // 
            // Go10TotalIncome
            // 
            this.Go10TotalIncome.AutoSize = true;
            this.Go10TotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go10TotalIncome.Location = new System.Drawing.Point(425, 360);
            this.Go10TotalIncome.Name = "Go10TotalIncome";
            this.Go10TotalIncome.Size = new System.Drawing.Size(75, 25);
            this.Go10TotalIncome.TabIndex = 16;
            this.Go10TotalIncome.Text = "label16";
            this.Go10TotalIncome.Visible = false;
            // 
            // see_report
            // 
            this.see_report.Location = new System.Drawing.Point(183, 489);
            this.see_report.Name = "see_report";
            this.see_report.Size = new System.Drawing.Size(135, 54);
            this.see_report.TabIndex = 17;
            this.see_report.Text = "Get report";
            this.see_report.UseVisualStyleBackColor = true;
            this.see_report.Click += new System.EventHandler(this.see_report_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total";
            // 
            // dailycount
            // 
            this.dailycount.AutoSize = true;
            this.dailycount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailycount.Location = new System.Drawing.Point(254, 416);
            this.dailycount.Name = "dailycount";
            this.dailycount.Size = new System.Drawing.Size(82, 25);
            this.dailycount.TabIndex = 20;
            this.dailycount.Text = "label10";
            this.dailycount.Visible = false;
            // 
            // dailyincome
            // 
            this.dailyincome.AutoSize = true;
            this.dailyincome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyincome.Location = new System.Drawing.Point(425, 416);
            this.dailyincome.Name = "dailyincome";
            this.dailyincome.Size = new System.Drawing.Size(82, 25);
            this.dailyincome.TabIndex = 21;
            this.dailyincome.Text = "label11";
            this.dailyincome.Visible = false;
            // 
            // DailyReportChart
            // 
            chartArea3.Name = "ChartArea1";
            this.DailyReportChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.DailyReportChart.Legends.Add(legend3);
            this.DailyReportChart.Location = new System.Drawing.Point(526, 96);
            this.DailyReportChart.Name = "DailyReportChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Count";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Income";
            this.DailyReportChart.Series.Add(series5);
            this.DailyReportChart.Series.Add(series6);
            this.DailyReportChart.Size = new System.Drawing.Size(765, 536);
            this.DailyReportChart.TabIndex = 22;
            this.DailyReportChart.Text = "chart1";
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 670);
            this.Controls.Add(this.DailyReportChart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dailyincome);
            this.Controls.Add(this.dailycount);
            this.Controls.Add(this.ChildTotalIncome);
            this.Controls.Add(this.ChildCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.see_report);
            this.Controls.Add(this.Go10TotalIncome);
            this.Controls.Add(this.Go5TotalIncome);
            this.Controls.Add(this.AdultTotalIncome);
            this.Controls.Add(this.Groupof10_Count);
            this.Controls.Add(this.Groupof5_Count);
            this.Controls.Add(this.AdultCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateofReport);
            this.Name = "DailyReport";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.DailyReportChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateofReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ChildCount;
        private System.Windows.Forms.Label AdultCount;
        private System.Windows.Forms.Label Groupof5_Count;
        private System.Windows.Forms.Label Groupof10_Count;
        private System.Windows.Forms.Label ChildTotalIncome;
        private System.Windows.Forms.Label AdultTotalIncome;
        private System.Windows.Forms.Label Go5TotalIncome;
        private System.Windows.Forms.Label Go10TotalIncome;
        private System.Windows.Forms.Button see_report;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dailycount;
        private System.Windows.Forms.Label dailyincome;
        private System.Windows.Forms.DataVisualization.Charting.Chart DailyReportChart;
    }
}