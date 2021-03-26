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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Regex reg = new Regex("^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");

            bool userValidate = reg.IsMatch(textBox1.Text);
            bool passwordValidate = reg.IsMatch(textBox2.Text);

            if (userValidate==false || passwordValidate==false)
            {

                MessageBox.Show("The Login Name or The Password is false.");
            }
            
            //TODO removed causing errors
            /*Login x = new Login();
           if( x.Valid(textBox1.Text, Password.Text)) {
                this.Hide();
                
                MainForm log = new MainForm();
                log.Show();
            }
            else
            {
                
                MessageBox.Show("Validation error");
                textBox1.Text = "";
                Password.Text = "";
            }*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
           
                if (textBox1.Text == "Login Name")
                {
                    textBox1.Text = "";
                    textBox1.ForeColor = Color.White;
                }
            }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Login Name";
                textBox1.ForeColor = Color.FromArgb(102, 102, 102);
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.FromArgb(102, 102, 102);

            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
        }     
    }
    }

