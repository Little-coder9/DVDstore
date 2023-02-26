using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class VisitorExitForm : Form
    {
        string FilePath;
        string filePath = "registered_visitors.csv";
        public VisitorExitForm()
        {
            InitializeComponent();
        }

        private void Searchvisitor_Click(object sender, EventArgs e)
        {
            FileStream Stream = new FileStream("visitors\\visitorCollection", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            GlobalValues.VisitorRecordList = (VisitorCollection)formatter.Deserialize(Stream);
            //s = (Visitor)formatter.Deserialize(Stream);
            Stream.Flush();
            RetriveVisitor();
            Stream.Close();
        }
        private void RetriveVisitor()
        {
            bool found = false;
            int id = (int)VisitorID.Value;
            foreach (Visitor v in GlobalValues.VisitorRecordList.VisitorRecords)
            {
                //MessageBox.Show("Count:"+ GlobalValues.VisitorRecordList.VisitorRecords.Count);
                if (id == v.Visitor_Id && v.Pay_amount == 0)
                {
                    VisitorCategory.Text = v.Visitor_Category;
                    VisitorCount.Text = v.Visitor_Count.ToString();
                    showvisitorentry.Text = v.Entry_Time.ToString();
                    visit_day.Text = v.Entry_Time.ToString("dddddddd");
                    found = true;
                    VisitorExitTime.Enabled = true;
                    visitorstaytime.Enabled = true;
                    pay_amount.Enabled = true;
                    VisitorExitTime.Text = "";
                    visitorstaytime.Text = "";
                    pay_amount.Text = "";
                    VisitorExitTime.ReadOnly = true;
                    visitorstaytime.ReadOnly = true;
                    pay_amount.ReadOnly = true;
                    VisitorCategory.Visible = true;
                    VisitorCount.Visible = true;
                    exitdetailslabel.Visible = true;
                    ExitDetailsPanel.Visible = true;
                    showvisitorentry.Visible = true;
                    visit_day.Visible = true;
                    break;
                }
                else if (id == v.Visitor_Id && v.Pay_amount != 0)
                {
                    VisitorCategory.Text = v.Visitor_Category;
                    VisitorCount.Text = v.Visitor_Count.ToString();
                    showvisitorentry.Text = v.Entry_Time.ToString();
                    visit_day.Text = v.Entry_Time.ToString("dddddddd");
                    VisitorExitTime.Text = v.Exit_Time.ToString();
                    visitorstaytime.Text = v.Stay_time.ToString();
                    pay_amount.Text = v.Pay_amount.ToString();
                    VisitorExitTime.Enabled = false;
                    visitorstaytime.Enabled = false;
                    pay_amount.Enabled = false;
                    VisitorCategory.Visible = true;
                    VisitorCount.Visible = true;
                    exitdetailslabel.Visible = true;
                    ExitDetailsPanel.Visible = true;
                    showvisitorentry.Visible = true;
                    visit_day.Visible = true;
                    found = true;
                    break;
                }

            }
            if (!found)
            {
                MessageBox.Show("Couldn't find any details on the requested ID.", "ID not found!");
            }
        }
        private void VisitorExitTime_Click(object sender, System.EventArgs e)
        {
            VisitorExitTime.Text = DateTime.Now.ToString();
        }

        private void Visitorstaytime_Click(object sender, System.EventArgs e)
        {
            if (VisitorExitTime.Text != "")
            {
                TimeSpan time = Convert.ToDateTime(VisitorExitTime.Text) - Convert.ToDateTime(showvisitorentry.Text);
                visitorstaytime.Text = time.ToString();
            }
            else 
            {
                MessageBox.Show("No exit time found! Please click on the exit field. ");
            }
            
        }

        private void Pay_amount_Click(object sender, System.EventArgs e)
        {
            TimeSpan time = Convert.ToDateTime(VisitorExitTime.Text) - Convert.ToDateTime(showvisitorentry.Text);
            string temp_time = time.TotalMinutes.ToString();

            float timeofstay = float.Parse(temp_time);

            if (visit_day.Text == "Monday" || visit_day.Text == "Tuesday" || visit_day.Text == "Wednesday" || visit_day.Text == "Thursday" || visit_day.Text == "Friday" )
            {
                FilePath = "Weekday_tickets.csv";
            }
            else if (visit_day.Text == "Saturday" || visit_day.Text == "Sunday")
            {
                FilePath = "Weekend_tickets.csv";
            }

            GlobalValues.TicketList = new List<Ticketpricerate>();
            string[] lines = File.ReadAllLines(FilePath);
            foreach (string line in lines)
            {
                string[] st = line.Split(',');

                if (st.Length == 6)
                {
                    Ticketpricerate tpr = new Ticketpricerate();
                    tpr.Ticket_Category = st[0];
                    tpr.Rate_for_1hr = Convert.ToInt32(st[1]);
                    tpr.Rate_for_2hr = Convert.ToInt32(st[2]);
                    tpr.Rate_for_3hr = Convert.ToInt32(st[3]);
                    tpr.Rate_for_4hr = Convert.ToInt32(st[4]);
                    tpr.Rate_for_wholeday = Convert.ToInt32(st[5]);
                    GlobalValues.TicketList.Add(tpr);
                }
            }

            foreach (Ticketpricerate rate in GlobalValues.TicketList)
            {
                if (VisitorCategory.Text == rate.Ticket_Category)
                {
                    if (timeofstay <= 60)
                    {
                        pay_amount.Text = rate.Rate_for_1hr.ToString();
                    }
                    else if (timeofstay > 60 && timeofstay <= 120)
                    {
                        pay_amount.Text = rate.Rate_for_2hr.ToString();
                    }
                    else if (timeofstay > 120 && timeofstay <= 180)
                    {
                        pay_amount.Text = rate.Rate_for_3hr.ToString();
                    }
                    else if (timeofstay > 180 && timeofstay <= 240)
                    {
                        pay_amount.Text = rate.Rate_for_4hr.ToString();
                    }
                    else
                    {
                        pay_amount.Text = rate.Rate_for_wholeday.ToString();
                    }
                }
            }
        }

        private void clearInputs() 
        {
            VisitorID.Value = 0;
            VisitorCategory.Visible = false;
            VisitorCount.Visible = false;
            showvisitorentry.Visible = false;
            visit_day.Visible = false;
            VisitorExitTime.Text = "";
            visitorstaytime.Text = "";
            pay_amount.Text = "";
        }

        private void ClearVisitordetails_Click(object sender, EventArgs e)
        {
            clearInputs();
        }

        private void VisitorExitForm_Load(object sender, EventArgs e)
        {
            GlobalValues.RegisteredVisitorList = new List<Visitor>();
            string[] lines = File.ReadAllLines(filePath);
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
                VisitorExitView.DataSource = GlobalValues.RegisteredVisitorList;
            }
        }

        private void VisitorConfirmExit_Click(object sender, EventArgs e)
        {
            if (VisitorExitTime.Text == "" || visitorstaytime.Text == "" || pay_amount.Text == "")
            {
                MessageBox.Show("Fields cannot be empty!");
            }
            else
            {
                foreach (Visitor v in GlobalValues.RegisteredVisitorList)
                {
                    if ((int)VisitorID.Value == v.Visitor_Id && v.Pay_amount != 0)
                    {
                        MessageBox.Show("The selected visitor has already exited!");
                        break;
                    }
                    else if ((int)VisitorID.Value == v.Visitor_Id)
                    {
                        v.Exit_Time = Convert.ToDateTime(VisitorExitTime.Text);
                        v.Stay_time = TimeSpan.Parse(visitorstaytime.Text);
                        v.Pay_amount = float.Parse(pay_amount.Text);

                        List<string> lines = new List<string>();

                        foreach (Visitor renew in GlobalValues.RegisteredVisitorList)
                        {
                            string line = "\n" + renew.Visitor_Id + "," + renew.Visitor_Category + "," + renew.Visitor_Count + "," + renew.Entry_Time + "," + renew.Exit_Time + "," + renew.Stay_time + "," + renew.Pay_amount ;
                            lines.Add(line);
                        }
                        File.WriteAllLines(filePath, lines);
                        MessageBox.Show("Visitor has been de-registered successfully!", "Visitor deregistration");
                    }
                }
                VisitorExitView.DataSource = null;
                VisitorExitView.DataSource = GlobalValues.RegisteredVisitorList;
                clearInputs();

                VisitorExitTime.Enabled = true;
                visitorstaytime.Enabled = true;
                pay_amount.Enabled = true;
            }
        }

        private void visit_day_Click(object sender, EventArgs e)
        {

        }
    }
}
