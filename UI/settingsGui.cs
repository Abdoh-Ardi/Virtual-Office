using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
