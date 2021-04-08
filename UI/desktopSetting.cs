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

namespace Virtual_Office.UI
{
    public partial class desktopSetting : Form
    {
        public desktopSetting()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            if (textBox14.Text == "Login Name")
            {
                textBox14.Text = "";
                textBox14.ForeColor = Color.White;
            }
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                textBox14.Text = "Login Name";
                textBox14.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }


        private void textBox13_Enter(object sender, EventArgs e)
        {
            if (textBox13.Text == "Login Password")
            {
                textBox13.Text = "";
                textBox13.ForeColor = Color.White;
            }
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            if (textBox13.Text == "")
            {
                textBox13.Text = "Login Password";
                textBox13.ForeColor = Color.FromArgb(102, 102, 102);
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

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_Enter(object sender, EventArgs e)
        {
            if (textBox16.Text == "Desktop Address")
            {
                textBox16.Text = "";
                textBox16.ForeColor = Color.White;
            }
        }

        private void textBox16_Leave(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "Desktop Address";
                textBox16.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == "Desktop Address")
            {
                textBox12.Text = "";
                textBox12.ForeColor = Color.White;
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textBox12.Text = "Desktop Address";
                textBox12.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");

            bool loginNameValidate= reg.IsMatch(textBox14.Text);
            bool loginPasswordValidate = reg.IsMatch(textBox13.Text);


            if (loginNameValidate == false || loginPasswordValidate == false)
            {

                MessageBox.Show("The Login Name or The Password is invalid.");
            }
        }
    }
}
