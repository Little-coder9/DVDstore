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
    public partial class TicketPriceList : Form
    {
        public TicketPriceList()
        {
            InitializeComponent();
        }

       
        private void TicketPriceList_Load(object sender, EventArgs e)
        {
            
        }

        string FilePath;
        private void Ticket_day_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GlobalValues.IsAdmin == true)
            {
                UpdateTicketPrice.Visible = true;
            }
            if ((string)Ticket_day_type.SelectedItem == "Pricelist of tickets during weekdays")
            {
                 FilePath = "Weekday_tickets.csv";                
            }
            else if ((string)Ticket_day_type.SelectedItem == "Pricelist of tickets during holidays")
            {
                weekenddiscountnotice.Visible = true;
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
            TicketRateView.DataSource = GlobalValues.TicketList;
            TicketRateView.Visible = true;
            if (GlobalValues.IsAdmin == true)
            {
                UpdateTicketPrice.Visible = true;
            }

        }

        private void TicketRateView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateTicketPrice_Click(object sender, EventArgs e)
        {
            GlobalValues.UpdatedrateList = new List<Ticketpricerate>();

            for (int i=0; i<TicketRateView.Rows.Count; i++) 
            {
                Ticketpricerate rate = new Ticketpricerate();
                rate.Ticket_Category = TicketRateView.Rows[i].Cells[0].Value.ToString();
                rate.Rate_for_1hr = Convert.ToInt32(TicketRateView.Rows[i].Cells[1].Value);
                rate.Rate_for_2hr = Convert.ToInt32(TicketRateView.Rows[i].Cells[2].Value);
                rate.Rate_for_3hr = Convert.ToInt32(TicketRateView.Rows[i].Cells[3].Value);
                rate.Rate_for_4hr = Convert.ToInt32(TicketRateView.Rows[i].Cells[4].Value);
                rate.Rate_for_wholeday = Convert.ToInt32(TicketRateView.Rows[i].Cells[5].Value);
                GlobalValues.UpdatedrateList.Add(rate);
            }
            //create collection of lines(string)
            List<string> lines = new List<string>();
            foreach (Ticketpricerate r in GlobalValues.UpdatedrateList)
            {
                string line = r.Ticket_Category + "," + r.Rate_for_1hr + "," + r.Rate_for_2hr + "," + r.Rate_for_3hr + "," + r.Rate_for_4hr + "," + r.Rate_for_wholeday;
                lines.Add(line);
            }
            if ((string)Ticket_day_type.SelectedItem == "Pricelist of tickets during weekdays")
            {
                FilePath = "Weekday_tickets.csv";
                File.WriteAllLines(FilePath, lines);
            }
            else if ((string)Ticket_day_type.SelectedItem == "Pricelist of tickets during holidays")
            {
                FilePath = "Weekend_tickets.csv";
                File.WriteAllLines(FilePath, lines);
            }
            MessageBox.Show("Ticket Price Updated!","Ticket Update");
        }
    }
}
