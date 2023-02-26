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
    public partial class WeeklyReport : Form
    {
        int count = 0;
        float amount = 0;
        readonly String filepath = "registered_visitors.csv";
        public WeeklyReport()
        {
            InitializeComponent();
        }

        private void GetWeeklyReport_Click(object sender, EventArgs e)
        {
            GlobalValues.RegisteredVisitorList = new List<Visitor>();
            string[] lines = File.ReadAllLines(filepath);
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

            for (int i = 0; i < 7; i++)
            {
                count = 0;
                amount = 0;
                DateTime dateT = (Convert.ToDateTime(DateofReport.Text)).Date;
                dateT = dateT.AddDays(-i);
                VisitorReport vr = new VisitorReport();
                foreach (Visitor v in GlobalValues.RegisteredVisitorList)
                {
                    if (v.Entry_Time.DayOfYear == dateT.DayOfYear)
                    {
                        count += v.Visitor_Count;
                        vr.DailyVisitorCountTotal = count;                        
                        amount += v.Pay_amount;
                        vr.DailyIncomeTotal = amount;
                    }
                    vr.Date = dateT;
                }
                GlobalValues.ReportList.Add(vr);

            }
            WeeklyReportView.DataSource = GlobalValues.ReportList;
            foreach (VisitorReport vr in GlobalValues.ReportList) 
            {
                if (vr.DailyIncomeTotal != 0 && vr.DailyVisitorCountTotal != 0)
                {
                    weeklychart.Series["Count"].Points.AddXY(vr.Date.ToString("dddd"), vr.DailyVisitorCountTotal);
                    weeklychart.Series["Income"].Points.AddXY(vr.Date.ToString("dddd"), vr.DailyIncomeTotal);
                }
            }

        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
            
        }
    }
}
    
    

