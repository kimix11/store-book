using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1proj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            label4.Hide();
            label3.Hide();
            label5.Hide();
            timer1.Enabled = true;
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label3.Location.Y <= pictureBox2.Location.Y) label3.Show();
            if (label4.Location.Y <= pictureBox2.Location.Y) label4.Show();
            if (label5.Location.Y <= pictureBox2.Location.Y) label5.Show();
            label3.Top -= 1;
            label4.Top -= 1;
            label5.Top -= 1;
           if (label3.Location.Y <= pictureBox1.Location.Y) label3.Location=new Point (20,pictureBox2.Location.Y);
           if (label4.Location.Y <= pictureBox1.Location.Y) label4.Location = new Point(77, pictureBox2.Location.Y);
           if (label5.Location.Y <= pictureBox1.Location.Y) label5.Location = new Point(45, pictureBox2.Location.Y);
            
        }
    }
}