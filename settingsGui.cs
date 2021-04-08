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
    public partial class settingsGui : Form
    {
        public settingsGui()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "User Name")
            {
                textBox10.Text = "";
                textBox10.ForeColor = Color.White;
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "User Name";
                textBox10.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "User Password")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.White;
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "User Password";
                textBox9.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "First Name")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.White;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Last Name";
                textBox5.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Last Name")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.White;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Last Name";
                textBox6.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "User Name")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.White;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "User Name";
                textBox7.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

       
       

        

       

        

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "User Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "User Name";
                textBox1.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            if (textBox11.Text == "Desktop Name")
            {
                textBox11.Text = "";
                textBox11.ForeColor = Color.White;
            }
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                textBox11.Text = "Desktop Name";
                textBox11.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void button4_Click(object sender, EventArgs e) { 
        Regex reg = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");

        bool userNameValidate = reg.IsMatch(textBox10.Text);
        bool passwordValidate= reg.IsMatch(textBox9.Text);


            if (userNameValidate == false || userNameValidate == false)
            {

                MessageBox.Show("The User Name or The Password is invalid.");
            }
}

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");

            bool assignUserNameValidate = reg.IsMatch(textBox1.Text);
            


            if (assignUserNameValidate == false )
            {

                MessageBox.Show("The User Name is invalid.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
