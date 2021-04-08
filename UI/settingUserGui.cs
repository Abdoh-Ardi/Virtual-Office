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
    public partial class settingUserGui : Form
    {
        public settingUserGui()
        {
            InitializeComponent();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            if (textBox14.Text == "Enter New UserName")
            {
                textBox14.Text = "";
                textBox14.ForeColor = Color.White;
            }
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                textBox14.Text = "Enter New UserName";
                textBox14.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            if (textBox12.Text == "Enter New Password")
            {
                textBox12.Text = "";
                textBox12.ForeColor = Color.White;
            }
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textBox12.Text = "Enter New Password";
                textBox12.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");

            bool changeUserNameValidate = reg.IsMatch(textBox14.Text);



            if (changeUserNameValidate == false)
            {

                MessageBox.Show("The User Name is invalid.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");

            bool changePasswordValidate = reg.IsMatch(textBox12.Text);



            if (changePasswordValidate == false)
            {

                MessageBox.Show("The Password is invalid.");
            }
        }
    }
}
