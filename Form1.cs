using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(Username.Text=="AbbVie" & Password.Text == "AbbVie")
            {
                MessageBox.Show("User Login Correct!","Welcome User!");
                Second_Page page = new Second_Page();
                page.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sorry Incorrect User Login!","Warning");
                Password.Text = "";
                Username.Text = "";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
