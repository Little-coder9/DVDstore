
namespace Coursework1
{
    partial class VisitorEntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.VisitorEntryTime = new System.Windows.Forms.Label();
            this.visitorCount = new System.Windows.Forms.TextBox();
            this.countlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.visitorID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.visitorCountGroup = new System.Windows.Forms.NumericUpDown();
            this.visitorCategory = new System.Windows.Forms.ComboBox();
            this.Groupcountlabel = new System.Windows.Forms.Label();
            this.AddVisitor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.VisitorView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCountGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter visitor entry details";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.VisitorEntryTime);
            this.panel1.Controls.Add(this.visitorCount);
            this.panel1.Controls.Add(this.countlabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.visitorID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.visitorCountGroup);
            this.panel1.Controls.Add(this.visitorCategory);
            this.panel1.Controls.Add(this.Groupcountlabel);
            this.panel1.Location = new System.Drawing.Point(3, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 327);
            this.panel1.TabIndex = 1;
            // 
            // VisitorEntryTime
            // 
            this.VisitorEntryTime.AutoSize = true;
            this.VisitorEntryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitorEntryTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.VisitorEntryTime.Location = new System.Drawing.Point(225, 264);
            this.VisitorEntryTime.Name = "VisitorEntryTime";
            this.VisitorEntryTime.Size = new System.Drawing.Size(199, 25);
            this.VisitorEntryTime.TabIndex = 7;
            this.VisitorEntryTime.Text = "Click here to get time!";
            this.VisitorEntryTime.Click += new System.EventHandler(this.VisitorEntryTime_Click);
            // 
            // visitorCount
            // 
            this.visitorCount.Enabled = false;
            this.visitorCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorCount.Location = new System.Drawing.Point(276, 158);
            this.visitorCount.Name = "visitorCount";
            this.visitorCount.Size = new System.Drawing.Size(120, 30);
            this.visitorCount.TabIndex = 6;
            this.visitorCount.Visible = false;
            // 
            // countlabel
            // 
            this.countlabel.AutoSize = true;
            this.countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countlabel.Location = new System.Drawing.Point(29, 155);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(124, 25);
            this.countlabel.TabIndex = 5;
            this.countlabel.Text = "Visitor Count";
            this.countlabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visitor ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Entry time";
            // 
            // visitorID
            // 
            this.visitorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorID.Location = new System.Drawing.Point(276, 38);
            this.visitorID.Name = "visitorID";
            this.visitorID.Size = new System.Drawing.Size(120, 30);
            this.visitorID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Visitor Category";
            // 
            // visitorCountGroup
            // 
            this.visitorCountGroup.Enabled = false;
            this.visitorCountGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorCountGroup.Location = new System.Drawing.Point(276, 204);
            this.visitorCountGroup.Name = "visitorCountGroup";
            this.visitorCountGroup.Size = new System.Drawing.Size(120, 34);
            this.visitorCountGroup.TabIndex = 1;
            this.visitorCountGroup.Visible = false;
            // 
            // visitorCategory
            // 
            this.visitorCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorCategory.FormattingEnabled = true;
            this.visitorCategory.Items.AddRange(new object[] {
            "Child(5-12)",
            "Adult(>12)",
            "Group of 5",
            "Group of 10"});
            this.visitorCategory.Location = new System.Drawing.Point(276, 100);
            this.visitorCategory.Name = "visitorCategory";
            this.visitorCategory.Size = new System.Drawing.Size(121, 33);
            this.visitorCategory.TabIndex = 0;
            this.visitorCategory.SelectedIndexChanged += new System.EventHandler(this.visitorCategory_SelectedIndexChanged);
            // 
            // Groupcountlabel
            // 
            this.Groupcountlabel.AutoSize = true;
            this.Groupcountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupcountlabel.Location = new System.Drawing.Point(29, 210);
            this.Groupcountlabel.Name = "Groupcountlabel";
            this.Groupcountlabel.Size = new System.Drawing.Size(124, 25);
            this.Groupcountlabel.TabIndex = 2;
            this.Groupcountlabel.Text = "Visitor Count";
            this.Groupcountlabel.Visible = false;
            // 
            // AddVisitor
            // 
            this.AddVisitor.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVisitor.Location = new System.Drawing.Point(69, 475);
            this.AddVisitor.Name = "AddVisitor";
            this.AddVisitor.Size = new System.Drawing.Size(253, 64);
            this.AddVisitor.TabIndex = 3;
            this.AddVisitor.Text = "Register visitor";
            this.AddVisitor.UseVisualStyleBackColor = true;
            this.AddVisitor.Click += new System.EventHandler(this.AddVisitor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(819, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "Registered Visitors";
            // 
            // VisitorView
            // 
            this.VisitorView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisitorView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.VisitorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VisitorView.Location = new System.Drawing.Point(476, 96);
            this.VisitorView.Name = "VisitorView";
            this.VisitorView.RowHeadersWidth = 51;
            this.VisitorView.RowTemplate.Height = 24;
            this.VisitorView.Size = new System.Drawing.Size(1008, 615);
            this.VisitorView.TabIndex = 4;
            // 
            // VisitorEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1742, 780);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VisitorView);
            this.Controls.Add(this.AddVisitor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "VisitorEntryForm";
            this.Text = "Visitor Entry Form";
            this.Load += new System.EventHandler(this.VisitorEntryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitorCountGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown visitorID;
        private System.Windows.Forms.Button AddVisitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown visitorCountGroup;
        private System.Windows.Forms.ComboBox visitorCategory;
        private System.Windows.Forms.Label Groupcountlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox visitorCount;
        private System.Windows.Forms.Label countlabel;
        private System.Windows.Forms.DataGridView VisitorView;
        private System.Windows.Forms.Label VisitorEntryTime;
    }
}