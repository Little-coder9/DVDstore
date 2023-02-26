using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowLogin();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date_display.Text = DateTime.Now.ToString();
        }

        Login f1;
        private void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1 = null;
            //enable menu
            
            menuStrip.Enabled = true;
            Exit.Enabled = true;
            if (GlobalValues.IsAdmin == true)
            {
                ViewReport.Visible = true;
            }
           
        }

        private void ShowLogin()
        {
            if (f1 == null)
            {
                f1 = new Login();
                f1.FormClosed += f1_FormClosed;
                f1.MdiParent = this;
                f1.StartPosition = FormStartPosition.CenterScreen;
                f1.Show();
                menuStrip.Enabled = false;
            }
            else
            {
                f1.Activate();
            }
        }

       
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            Date_display.Text = DateTime.Now.ToString();
        }

        private void VisitorMenu_Click(object sender, EventArgs e)
        {
        }

        VisitorEntryForm visitform;

        private void Visitform_FormClosed(object sender, FormClosedEventArgs e)
        {
            visitform = null;         
        }
        private void VisitorEntryForm_Click(object sender, EventArgs e)
        {
            if (visitform == null)
            {
                visitform = new VisitorEntryForm();
                visitform.FormClosed += Visitform_FormClosed;
                visitform.MdiParent = this;
                visitform.StartPosition = FormStartPosition.CenterScreen;
                visitform.Show();
            }
            else
            {
                visitform.Activate();
            }          
        }

        VisitorExitForm exitform;

        private void Exitform_FormClosed(object sender, FormClosedEventArgs e)
        {
            exitform = null;
        }

        private void VisitorExitForm_Click(object sender, EventArgs e)
        {
            if (exitform == null)
            {
                exitform = new VisitorExitForm();
                exitform.FormClosed += Exitform_FormClosed;
                exitform.MdiParent = this;
                exitform.StartPosition = FormStartPosition.CenterScreen;
                exitform.Show();
            }
            else
            {
                exitform.Activate();
            }
        }

        TicketPriceList ticket;
        private void TicketsList_Click(object sender, EventArgs e)
        {
            if (ticket == null)
            {
                ticket = new TicketPriceList();
                ticket.FormClosed += TicketList_FormClosed;
                ticket.MdiParent = this;
                ticket.StartPosition = FormStartPosition.CenterScreen;
                ticket.Show();
            }
            else
            {
                ticket.Activate();
            }
        }

        private void TicketList_FormClosed(object sender, FormClosedEventArgs e)
        {
            ticket = null;
        }

      /*  DailyReport rep;

        private void ViewReport_Click(object sender, EventArgs e)
        {
            if (rep == null)
            {
                rep = new DailyReport();
                rep.FormClosed += Report_FormClosed;
                rep.MdiParent = this;
                rep.StartPosition = FormStartPosition.CenterScreen;
                rep.Show();
            }
            else 
            {
                rep.Activate();
            }
        }*/

        private void DailyReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            rep = null;
        }

        DailyReport rep;
        private void getdailyreport_Click(object sender, EventArgs e)
        {
            if (rep == null)
            {
                rep = new DailyReport();
                rep.FormClosed += DailyReport_FormClosed;
                rep.MdiParent = this;
                rep.StartPosition = FormStartPosition.CenterScreen;
                rep.Show();
            }
            else
            {
                rep.Activate();
            }
        }

        private void WeeklyReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            rep = null;
        }


        WeeklyReport wr;
        private void getweeklyreport_Click(object sender, EventArgs e)
        {
            if (wr == null)
            {
                wr = new WeeklyReport();
                wr.FormClosed += WeeklyReport_FormClosed;
                wr.MdiParent = this;
                wr.StartPosition = FormStartPosition.CenterScreen;
                wr.Show();
            }
            else
            {
                wr.Activate();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ViewReport.Visible = false;

                ShowLogin();
                if (GlobalValues.IsAdmin == false) 
                {
                    ViewReport.Visible = false;
                }
            }
            else 
            {
                
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
