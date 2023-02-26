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
    public partial class VisitorEntryForm : Form
    {

        string filePath = "registered_visitors.csv";


        public VisitorEntryForm()
        {
            InitializeComponent();
        }
        private void visitorCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)visitorCategory.SelectedItem == "Child(5-12)" || (string)visitorCategory.SelectedItem == "Adult(>12)")
            {
                countlabel.Visible = true;
                visitorCount.Visible = true;
                Groupcountlabel.Visible = false;
                visitorCountGroup.Visible = false;
                visitorCount.Text = "1";
            }

            else if ((string)visitorCategory.SelectedItem == "Group of 5")
            {
                Groupcountlabel.Visible = true;
                visitorCountGroup.Visible = true;
                countlabel.Visible = false;
                visitorCount.Visible = false;
                visitorCountGroup.Value = 5;
            }

            else if ((string)visitorCategory.SelectedItem == "Group of 10")
            {
                Groupcountlabel.Visible = true;
                visitorCountGroup.Visible = true;
                countlabel.Visible = false;
                visitorCount.Visible = false;
                visitorCountGroup.Value = 10;
            }
        }
       
        private void VisitorEntryForm_Load(object sender, EventArgs e)
        {            
            GlobalValues.RegisteredVisitorList = new List<Visitor>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] st = line.Split(',');

                if (st.Length == 7)
                {
                    Visitor vis = new Visitor();
                    vis.Visitor_Id = Convert.ToInt32(st[0]);
                    vis.Visitor_Category = st[1];
                    vis.Visitor_Count = Convert.ToInt32(st[2]);
                    vis.Entry_Time = Convert.ToDateTime(st[3]);
                    vis.Exit_Time = Convert.ToDateTime(st[4]);
                    vis.Stay_time = TimeSpan.Parse(st[5]);
                    vis.Pay_amount = float.Parse(st[6]);

                    GlobalValues.RegisteredVisitorList.Add(vis);
                }
                VisitorView.DataSource = GlobalValues.RegisteredVisitorList;
            }
        }

        private void ValidateVisitorDetails() 
        {
            Visitor v = new Visitor();
            bool exists = false;
            foreach (Visitor vis in GlobalValues.RegisteredVisitorList)
            {
                if ((int)visitorID.Value == vis.Visitor_Id)
                {
                    MessageBox.Show("ID already taken!! Please continue registering from " + (GlobalValues.RegisteredVisitorList.Count + (int)1));
                    exists = true;
                    break;
                }
                else if (visitorID.Value < 1)
                {
                    MessageBox.Show("Visitor ID cannot be zero or less!", "Error during registration!!");
                    exists = true;
                    break;
                }
                else if (visitorID.Value != (GlobalValues.RegisteredVisitorList.Count + (int)1)) 
                {
                    MessageBox.Show("!!Please continue registering from " + (GlobalValues.RegisteredVisitorList.Count + (int)1));
                    exists = true;
                    break;
                }
            }

           if(!exists)
           {
                v.Visitor_Id = (int)visitorID.Value;
                ValidateVisitorCategory(v);
           }

        }
        private void ValidateVisitorCategory(Visitor v) 
        {
            if ((string)visitorCategory.SelectedItem == "Child(5-12)" || (string)visitorCategory.SelectedItem == "Adult(>12)")
            {
                v.Visitor_Category = (String)visitorCategory.SelectedItem;
                v.Visitor_Count = Convert.ToInt32(visitorCount.Text);
                ValidateVisitorEntryTime(v);
            }

            else if ((string)visitorCategory.SelectedItem == "Group of 5" || (string)visitorCategory.SelectedItem == "Group of 10")
            {
                v.Visitor_Category = (String)visitorCategory.SelectedItem;
                v.Visitor_Count = (int)visitorCountGroup.Value;
                ValidateVisitorEntryTime(v);
                
            }
            else
            {
                MessageBox.Show("Please select a category!", "Error during registration!!");
            }
        }
        private void ValidateVisitorEntryTime(Visitor v) 
        {
            if (VisitorEntryTime.Text.Equals("Click here to get time!"))
            {
                MessageBox.Show("Entry time field cannot be empty. " +
                    "\n Click on the field to get time automatically.", "Error during registration!!");
            }
            else
            {
                v.Entry_Time = DateTime.Parse(VisitorEntryTime.Text);
                v.Exit_Time = v.Entry_Time;
                //v.Pay_amount = 0;

                GlobalValues.RegisteredVisitorList.Add(v);
                AddVisitorToCsv(v.Visitor_Id, v.Visitor_Category, v.Visitor_Count, v.Entry_Time, v.Exit_Time, v.Stay_time, v.Pay_amount);
                VisitorView.DataSource = null;
                VisitorView.DataSource = GlobalValues.RegisteredVisitorList;
                MessageBox.Show("Visitor registered successfully!" +
                    "\n Ticket Issue Complete. Visitor can now enter.", "Recreation Center");              
            }
        }

        private void AddVisitor_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateVisitorDetails();
                ClearInputs();
                //prepare visitor list object for serialization
                GlobalValues.VisitorRecordList = new VisitorCollection();
                GlobalValues.VisitorRecordList.VisitorRecords = GlobalValues.RegisteredVisitorList;

                //serializing the visitors details
                //FileStream Stream = new FileStream("C:\\Project Files\\visitors"+"\\"+"visitor"+ s.Visitor_Id, FileMode.Create);
                FileStream Stream = new FileStream("visitors\\visitorCollection", FileMode.Create);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(Stream, GlobalValues.VisitorRecordList);
                Stream.Close();

                //GlobalValues.VisitorExitList = GlobalValues.RegisteredVisitorList;
                /*List<string> lines = new List<string>();
                foreach (Visitor visit in GlobalValues.VisitorRecordList.VisitorRecords)
                //foreach (Visitor visit in GlobalValues.VisitorExitList)
                {
                    string line = visit.Visitor_Id + "," + visit.Visitor_Category + "," + visit.Visitor_Count + "," + visit.Entry_Time + "," + visit.Exit_Time+ "," + visit.Stay_time+ "," + visit.Pay_amount + "\n";
                    lines.Add(line);
                }
                File.WriteAllLines("C:\\Project Files\\exit_visitors.csv", lines);*/

            }
            catch (FormatException)
            {
                MessageBox.Show("Unknown error occured during registration. Please try again!!", "!!UNKNOWN ERROR!! ");
            }           
        }
        private void VisitorEntryTime_Click(object sender, System.EventArgs e)
        {
            VisitorEntryTime.Text = DateTime.Now.ToString("hh:mm tt");
            VisitorEntryTime.ForeColor = Color.Black;
        }

        private void AddVisitorToCsv(int id, string category, int count, DateTime entry, DateTime exit, TimeSpan stay, float payment)
        {
            string newSt = "\n" + id + "," + category + "," + count + "," + entry + "," + exit + ","+ stay + "," + payment;
            File.AppendAllText(filePath, newSt);
        }

        private void ClearInputs() 
        {
            visitorID.Value = 0;
            visitorCategory.SelectedIndex = -1;
            countlabel.Visible = false;
            Groupcountlabel.Visible = false;
            visitorCount.Visible = false;
            visitorCountGroup.Visible = false;
            visitorCountGroup.Value = 0;
            VisitorEntryTime.Text = "Click here to get time!";
            VisitorEntryTime.ForeColor = Color.Blue;
        }
    }
}
