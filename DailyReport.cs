using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class DailyReport : Form
    {
        int child = 0;
        float childamount = 0;

        int adult = 0;
        float adultamount = 0;

        int group0f5 = 0;
        float go5amount = 0;

        int group0f10 = 0;
        float go10amount = 0;

        public DailyReport()
        {
            InitializeComponent();
        }

        private void see_report_Click(object sender, EventArgs e)
        {
            GlobalValues.RegisteredVisitorList = new List<Visitor>();
            string[] lines = File.ReadAllLines("registered_visitors.csv");
            foreach (string line in lines)
            {
                string[] st = line.Split(',');

                if (st.Length == 7)
                {
                    Visitor v = new Visitor();
                    v.Visitor_Id = Convert.ToInt32(st[0]);
                    v.Visitor_Category = st[1];
                    v.Visitor_Count = Convert.ToInt32(st[2]);
                    v.Entry_Time = Convert.ToDateTime(st[3]);
                    v.Exit_Time = Convert.ToDateTime(st[4]);
                    v.Stay_time = TimeSpan.Parse(st[5]);
                    v.Pay_amount = float.Parse(st[6]);

                    GlobalValues.RegisteredVisitorList.Add(v);
                }
            }

            child = 0;
            childamount = 0;

            adult = 0;
            adultamount = 0;

            group0f5 = 0;
            go5amount = 0;

            group0f10 = 0;
            go10amount = 0;

            foreach (Visitor v in GlobalValues.RegisteredVisitorList)
            {
                if (v.Entry_Time.DayOfYear != DateofReport.Value.DayOfYear) continue;
                if (v.Visitor_Category == "Child(5-12)")
                {
                    child += v.Visitor_Count;
                    ChildCount.Text = child.ToString();

                    childamount += v.Pay_amount;
                    ChildTotalIncome.Text = childamount.ToString();
                }
                else if (v.Visitor_Category == "Adult(>12)")
                {
                    adult += v.Visitor_Count;
                    AdultCount.Text = adult.ToString();

                    adultamount += v.Pay_amount;
                    AdultTotalIncome.Text = adultamount.ToString();
                }
                else if (v.Visitor_Category == "Group of 5")
                {
                    group0f5 += v.Visitor_Count;
                    Groupof5_Count.Text = group0f5.ToString();

                    go5amount += v.Pay_amount;
                    Go5TotalIncome.Text = go5amount.ToString();
                }
                else if (v.Visitor_Category == "Group of 10")
                {
                    group0f10 += v.Visitor_Count;
                    Groupof10_Count.Text = group0f10.ToString();

                    go10amount += v.Pay_amount;
                    Go10TotalIncome.Text = go10amount.ToString();
                }

                int count = child + adult + group0f5 + group0f10;
                dailycount.Text = count.ToString();

                float income = childamount + adultamount + go5amount + go10amount;
                dailyincome.Text = income.ToString();


                if (child != 0)
                {
                    ChildCount.Visible = true;
                    ChildTotalIncome.Visible = true;
                }
                if (adult != 0) 
                {
                    AdultCount.Visible = true;
                    AdultTotalIncome.Visible = true;
                }

                if (group0f5 != 0) 
                { 
                    Groupof5_Count.Visible = true;
                    Go5TotalIncome.Visible = true;
                }

                if (group0f10 != 0) 
                {  
                    Groupof10_Count.Visible = true;
                    Go10TotalIncome.Visible = true;
                }

                if (count != 0)
                {
                    dailycount.Visible = true;
                    dailyincome.Visible = true;
                }    
            }
            generateChart();
        }

        private void generateChart()
        {

            DailyReportChart.Series["Count"].Points.AddXY("Child", child);
            DailyReportChart.Series["Count"].Points.AddXY("Adult", adult);
            DailyReportChart.Series["Count"].Points.AddXY("Group of 5", group0f5);
            DailyReportChart.Series["Count"].Points.AddXY("Group of 10", group0f10);

            DailyReportChart.Series["Income"].Points.AddXY("Child", childamount);
            DailyReportChart.Series["Income"].Points.AddXY("Adult", adultamount);
            DailyReportChart.Series["Income"].Points.AddXY("Group of 5", go5amount);
            DailyReportChart.Series["Income"].Points.AddXY("Group of 10", go10amount);
        }

    }
}
