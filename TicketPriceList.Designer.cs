
namespace Coursework1
{
    partial class TicketPriceList
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
            this.Ticket_day_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateTicketPrice = new System.Windows.Forms.Button();
            this.TicketRateView = new System.Windows.Forms.DataGridView();
            this.weekenddiscountnotice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketRateView)).BeginInit();
            this.SuspendLayout();
            // 
            // Ticket_day_type
            // 
            this.Ticket_day_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticket_day_type.FormattingEnabled = true;
            this.Ticket_day_type.Items.AddRange(new object[] {
            "Pricelist of tickets during weekdays",
            "Pricelist of tickets during holidays"});
            this.Ticket_day_type.Location = new System.Drawing.Point(345, 10);
            this.Ticket_day_type.Name = "Ticket_day_type";
            this.Ticket_day_type.Size = new System.Drawing.Size(398, 33);
            this.Ticket_day_type.TabIndex = 0;
            this.Ticket_day_type.SelectedIndexChanged += new System.EventHandler(this.Ticket_day_type_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select ticket pricelist type";
            // 
            // UpdateTicketPrice
            // 
            this.UpdateTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTicketPrice.Location = new System.Drawing.Point(406, 457);
            this.UpdateTicketPrice.Name = "UpdateTicketPrice";
            this.UpdateTicketPrice.Size = new System.Drawing.Size(171, 55);
            this.UpdateTicketPrice.TabIndex = 2;
            this.UpdateTicketPrice.Text = "save changes";
            this.UpdateTicketPrice.UseVisualStyleBackColor = true;
            this.UpdateTicketPrice.Visible = false;
            this.UpdateTicketPrice.Click += new System.EventHandler(this.UpdateTicketPrice_Click);
            // 
            // TicketRateView
            // 
            this.TicketRateView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.TicketRateView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketRateView.Location = new System.Drawing.Point(95, 124);
            this.TicketRateView.Name = "TicketRateView";
            this.TicketRateView.RowHeadersWidth = 51;
            this.TicketRateView.RowTemplate.Height = 24;
            this.TicketRateView.Size = new System.Drawing.Size(871, 292);
            this.TicketRateView.TabIndex = 3;
            this.TicketRateView.Visible = false;
            this.TicketRateView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketRateView_CellContentClick);
            // 
            // weekenddiscountnotice
            // 
            this.weekenddiscountnotice.AutoSize = true;
            this.weekenddiscountnotice.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekenddiscountnotice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.weekenddiscountnotice.Location = new System.Drawing.Point(178, 67);
            this.weekenddiscountnotice.Name = "weekenddiscountnotice";
            this.weekenddiscountnotice.Size = new System.Drawing.Size(702, 36);
            this.weekenddiscountnotice.TabIndex = 4;
            this.weekenddiscountnotice.Text = "!!Yoohooo!! Discounted price on weekends";
            this.weekenddiscountnotice.Visible = false;
            // 
            // TicketPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1102, 639);
            this.Controls.Add(this.weekenddiscountnotice);
            this.Controls.Add(this.TicketRateView);
            this.Controls.Add(this.UpdateTicketPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ticket_day_type);
            this.Name = "TicketPriceList";
            this.Text = "TicketPriceList";
            this.Load += new System.EventHandler(this.TicketPriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketRateView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Ticket_day_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateTicketPrice;
        private System.Windows.Forms.DataGridView TicketRateView;
        private System.Windows.Forms.Label weekenddiscountnotice;
    }
}