using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_Office
{
    public partial class Front : Form
    {
        public Front()
        {
            Text = "Virtual Office";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

                    }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Enter Server URL"))
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals ("")|| textBox1.Text.Equals("*Incorrect Format*"))
            {
                textBox1.Text = "Enter Server URL";
                textBox1.ForeColor = Color.FromArgb(102, 102, 102);

            }
        }
        /// <summary>
        /// Continue button checks if address matches the format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text.Trim();
            //string ValidIpAddressRegex = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
            Match ipadd = Regex.Match(textBox1.Text, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");

            //string ValidHostnameRegex = @"^(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])$";
            Match hName = Regex.Match(textBox1.Text, @"^(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])$");
            
            if (ipadd.Success||hName.Success)
            {
                Hide();//hide this form
                Signin signinForm = new Signin();
                signinForm.server = textBox1.Text;
                signinForm.Location = Location;
                signinForm.Text = "Virtual Office";//set form name to virtual office
                signinForm.Show();
            }
            else
            {
                textBox1.Text = "*Incorrect Format*";
            }






        }
    }
}
