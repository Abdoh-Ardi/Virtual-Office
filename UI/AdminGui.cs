using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Virtual_Office.UI;

namespace Virtual_Office
{
    public partial class AdminGui : Form
    {
        
        public AdminGui()
        {
            //TODO adminGUI list not displaying correctly
            //TODO desktop show desktops returning null
            //listBox1.DataSource=VirtualOffice.ShowDesktops();
            InitializeComponent(); // you need to add a listView named listView1 with the designer
            listView1.View =View.Details;//
            
            listView1.FullRowSelect = true;
            listView1.Visible = true;

            //listView1.Location = new System.Drawing.Point(12, 12);
            listView1.Name = "ListView1";
            //listView1.Size = new System.Drawing.Size(245, 200);
            //listView1.BackColor = System.Drawing.Color.Orange;
            listView1.ForeColor = System.Drawing.Color.White;

            ListViewExtender extender = new ListViewExtender(listView1);
            // extend 2nd column
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(1);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.FixedWidth = true;
            



            extender.AddColumn(buttonAction);
            //var list = VirtualOffice.ShowDesktops();
            var list = new List<string>();
            list.Add("HELLO WORLD");
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = listView1.Items.Add( list[i]);
                
                item.SubItems.Add("button " + i);
                
            }




        }

        
        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            //TODO interface
            MessageBox.Show(this, @"you clicked " + e.SubItem.Text);
        }

        public VirtualOffice VirtualOffice { get; internal set; }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            settingsGui sett = new settingsGui();
            sett.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Hide();
            activityGui activity = new activityGui();
            activity.Show();
        }
    }
}
