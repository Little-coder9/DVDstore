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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginMessage.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
            //check username and password
            if (usernametxt.Text == "Admin" && passwordtxt.Text == "Admin")
            {
                //set the user as admin
                GlobalValues.IsAdmin = true;
                MessageBox.Show("Successfully Logged in as Admin.");
                //Close the login form
                Close();
            }
            else
            {
                //if not valid -> show error message
                LoginMessage.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (usernametxt.Text == "Staff" && passwordtxt.Text == "Staff")
            {
                //set the user as staff
                GlobalValues.IsAdmin = false;
                MessageBox.Show("Successfully Logged in as Staff.");
                //Close the login form
                Close();
            }
            else
            {
                //if not valid -> show error message
                LoginMessage.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = true;
        }

        private void Pw_see_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (Pw_see_hide.Checked)
            {
                passwordtxt.UseSystemPasswordChar = false;
            }
            else 
            {
                passwordtxt.UseSystemPasswordChar = true;
            }
        }
    }
}
