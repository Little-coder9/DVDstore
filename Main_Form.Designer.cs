
namespace Coursework1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.VisitorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.VisitorEntryForm = new System.Windows.Forms.ToolStripMenuItem();
            this.VisitorExitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TicketsList = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewReport = new System.Windows.Forms.ToolStripMenuItem();
            this.getdailyreport = new System.Windows.Forms.ToolStripMenuItem();
            this.getweeklyreport = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Date_display = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisitorMenu,
            this.TicketsList,
            this.ViewReport,
            this.Exit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1301, 36);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // VisitorMenu
            // 
            this.VisitorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisitorEntryForm,
            this.VisitorExitForm});
            this.VisitorMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.VisitorMenu.Name = "VisitorMenu";
            this.VisitorMenu.Size = new System.Drawing.Size(137, 32);
            this.VisitorMenu.Text = "Visitor Menu";
            this.VisitorMenu.Click += new System.EventHandler(this.VisitorMenu_Click);
            // 
            // VisitorEntryForm
            // 
            this.VisitorEntryForm.Name = "VisitorEntryForm";
            this.VisitorEntryForm.Size = new System.Drawing.Size(255, 32);
            this.VisitorEntryForm.Text = "Visitor Entry Form";
            this.VisitorEntryForm.Click += new System.EventHandler(this.VisitorEntryForm_Click);
            // 
            // VisitorExitForm
            // 
            this.VisitorExitForm.Name = "VisitorExitForm";
            this.VisitorExitForm.Size = new System.Drawing.Size(255, 32);
            this.VisitorExitForm.Text = "Visitor Exit Form";
            this.VisitorExitForm.Click += new System.EventHandler(this.VisitorExitForm_Click);
            // 
            // TicketsList
            // 
            this.TicketsList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TicketsList.Name = "TicketsList";
            this.TicketsList.Size = new System.Drawing.Size(85, 32);
            this.TicketsList.Text = "Tickets";
            this.TicketsList.Click += new System.EventHandler(this.TicketsList_Click);
            // 
            // ViewReport
            // 
            this.ViewReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getdailyreport,
            this.getweeklyreport});
            this.ViewReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ViewReport.Name = "ViewReport";
            this.ViewReport.Size = new System.Drawing.Size(169, 32);
            this.ViewReport.Text = "Generate Report";
            this.ViewReport.Visible = false;
            // 
            // getdailyreport
            // 
            this.getdailyreport.Name = "getdailyreport";
            this.getdailyreport.Size = new System.Drawing.Size(225, 32);
            this.getdailyreport.Text = "Daily Report";
            this.getdailyreport.Click += new System.EventHandler(this.getdailyreport_Click);
            // 
            // getweeklyreport
            // 
            this.getweeklyreport.Name = "getweeklyreport";
            this.getweeklyreport.Size = new System.Drawing.Size(225, 32);
            this.getweeklyreport.Text = "Weekly Report";
            this.getweeklyreport.Click += new System.EventHandler(this.getweeklyreport_Click);
            // 
            // Exit
            // 
            this.Exit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOut,
            this.exitToolStripMenuItem});
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(57, 32);
            this.Exit.Text = "Exit";
            // 
            // LogOut
            // 
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(224, 32);
            this.LogOut.Text = "Log Out";
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Date_display
            // 
            this.Date_display.AutoSize = true;
            this.Date_display.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_display.ForeColor = System.Drawing.Color.Blue;
            this.Date_display.Location = new System.Drawing.Point(951, 9);
            this.Date_display.Name = "Date_display";
            this.Date_display.Size = new System.Drawing.Size(133, 25);
            this.Date_display.TabIndex = 1;
            this.Date_display.Text = "Date and time";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 595);
            this.Controls.Add(this.Date_display);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem VisitorMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewReport;
        private System.Windows.Forms.ToolStripMenuItem TicketsList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Date_display;
        private System.Windows.Forms.ToolStripMenuItem VisitorEntryForm;
        private System.Windows.Forms.ToolStripMenuItem VisitorExitForm;
        private System.Windows.Forms.ToolStripMenuItem getdailyreport;
        private System.Windows.Forms.ToolStripMenuItem getweeklyreport;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem LogOut;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

