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
    public partial class Signin : Form
    {
        private VirtualOffice vo;

        internal string server="";
        internal string username="";
        internal string password="";

        public Signin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// provides input validation
        /// and connects
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            Regex reg = new Regex(@"^(?=.{8,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");

            Match userNValidated = reg.Match(textBox1.Text.Trim());
            Match passwordValidated = reg.Match(textBox2.Text.Trim());
            if (!(textBox1.Text.Length >= 8))
            {
                label2.Text = "* Username must be 8+ characters long";
                label2.Visible = true;
            } else if (!userNValidated.Success)
            {

                label2.Text = "* Username format is incorrect";
                label2.Visible = true;
                //textBox3.ReadOnly = true;
                
            }
            else
            {
                username = textBox1.Text.Trim();
                label2.Visible = false;
            }

            if (!passwordValidated.Success)
            {
                label3.Visible = true;
                //textBox3.ReadOnly = true;
                //textBox3.Text = textBox3.Text+"\n*Password format is incorrect";
            }
            else
            {
                password = textBox2.Text.Trim();
                label3.Visible = false;
            }

            //format is correct and ready to sign in
            if (userNValidated.Success && passwordValidated.Success)
            {
                //database user login
                try
                {
                    vo = new VirtualOffice(server, "mydb", "test", "12345a");//
                    vo.Login(username, password);//correct password
                    
                    if (vo.manageLogin.LoginStatus)
                    {
                        if (vo.manageLogin.UserLevel)
                        {
                            AdminGui aGui = new AdminGui();
                            aGui.Location = Location;
                            aGui.VirtualOffice = vo;
                            Hide();
                            aGui.Show();
                            
                        }
                        else
                        {


                        }
                    }
                    else
                    {
                        label2.Text = "Login Failed: Check your information";
                        label2.Visible=true;
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show("Error Occured: "+ exception);    
                }
                

            }

            label2.Visible = false;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

