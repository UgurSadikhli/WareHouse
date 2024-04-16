using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouseUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Dock = DockStyle.Fill;
            panel1.Show();
            panel2.Dock = DockStyle.Fill;
            panel2.Hide();
            panel3.Dock = DockStyle.Fill;
            panel3.Hide();

            timer1.Start();
        }
        string Dont_see = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "resources", "dontsee.png");
        string See = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "resources", "see.png");
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel3.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        bool flaq_Char = false;
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (flaq_Char == false)
            {
                pictureBox15.Image = Image.FromFile(Dont_see);
                maskedTextBox1.UseSystemPasswordChar = true;
                flaq_Char = true;
            }
            else if (flaq_Char == true)
            {
                pictureBox15.Image = Image.FromFile(See);
                maskedTextBox1.UseSystemPasswordChar = false;
                flaq_Char = false;
            }
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sHOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
            listView3.Visible = false;

        }

        private void sHOWToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listView2.Visible = true;
            listView3.Visible = false;
            listView1.Visible = false;

        }

        private void sHOWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
            listView3.Visible = true;
            listView1.Visible = false;
        }

        bool filter_toggle = false;
        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            email_toggle = false;

            if (filter_toggle == false)
            {
                groupBox1.Visible = true;
               
                filter_toggle = true;

            }
            else if (filter_toggle == true)
            {
                groupBox1.Visible = false;
             
                filter_toggle = false;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label41.Text = "";
            label42.Text = "";

            label41.Text = DateTime.Now.ToString("HH:mm");
            label42.Text = DateTime.Now.ToString("dd dddd");
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel5_Client.Visible = true;
            panel5_Order.Visible = false;
            panel5_Settings.Visible = false;
            panel5_Product.Visible = false;
            panel4.Visible = true;
            label13.Text = "CLIENT";
            button1.Visible = true;
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel5_Order.Visible = true;
            panel5_Product.Visible = false;
            panel4.Visible = true;
            panel5_Client.Visible = false;
            panel5_Settings.Visible = false;
            label13.Text = "ORDER";
            button1.Visible = true;
        }

        private void aDDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel5_Product.Visible = true;
            panel5_Order.Visible = false;
            panel4.Visible = true;
            panel5_Client.Visible = false;
            panel5_Settings.Visible = false;
            label13.Text = "PRODUCT";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(label13.Text) 
            {
                case "PRODUCT":

                    return;
                case "CLIENT":

                    return;
                case "ORDER":

                    return;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool settings_toggle = false;

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            if (settings_toggle == false)
            {
                panel5_Product.Visible = false;
                panel5_Order.Visible = false;
                panel4.Visible = true;
                panel5_Client.Visible = false;
                panel5_Settings.Visible = true;
                label13.Text = "SETTINGS";
                button1.Visible = false;

                settings_toggle = true;

            }
            else if (settings_toggle == true)
            {
                panel5_Product.Visible = false;
                panel5_Order.Visible = false;
                panel4.Visible = false;
                panel5_Client.Visible = false;
                panel5_Settings.Visible = true;
                label13.Text = "SETTINGS";
                button1.Visible = false;
                settings_toggle = false;


            }
        }


        bool email_toggle = false;

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            groupBox1.Visible= false;
            listView2.Visible = false;
            listView3.Visible = true;
            listView1.Visible = false;
            groupBox2.Visible = false;
            filter_toggle = false;

            if (email_toggle == false)
            {
                groupBox2.Visible = true;

                email_toggle = true;

            }
            else if (email_toggle == true)
            {
                groupBox2.Visible = false;
                email_toggle = false;


            }
        }
    }
}
