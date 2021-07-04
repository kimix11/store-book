using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1proj
{
    public partial class Form4 : Form
    {
        public int a; int c = 0;
        public string st;
        public static Form4 frm;
        public Form4()
        {
            InitializeComponent();
        }

       

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            
            frm = this;
            textBox1.Hide();
            button2.Hide();
            
        }

      

        public  void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                timer1.Enabled = true;
            else timer1.Enabled = false;
              
            
            if (radioButton2.Checked == true)
          
                timer2.Enabled = true;
            else timer2.Enabled=false;

            if (radioButton3.Checked == true)
                timer3.Enabled = true;
            else timer3.Enabled = false;
            

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Show();
            button2.Show();
            textBox1.Focus();
            Form1.frm1.label1.Text = textBox1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            Form1.frm1.label1.Font = new Font(fontDialog1.Font.Name, fontDialog1.Font.Size, fontDialog1.Font.Style);
            button1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)  Form1.frm1.a = 1; 
            else if (radioButton2.Checked == true)  Form1.frm1.a = 2; 
            else if (radioButton3.Checked == true) Form1.frm1.a = 3; 
            else { Form1.frm1.a = 0; }
            this.Hide();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            pictureBox3.Hide();
            st = textBox1.Text;
            textBox1.Clear(); 

           
        }

        private void Form4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
               
               Form1.frm1.BackgroundImage = null;
               Form1.frm1.BackColor = Color.Empty;
               Form1.frm1.label1.Hide();
               Form1.frm1. timer1.Enabled = false;
               Form1.frm1.timer2.Enabled = false;
               Form1.frm1.timer3.Enabled = false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            c = Form1.frm1.i;
            pictureBox1.Image = Image.FromFile(@"pic\" +c.ToString()  + ".jpg");
            Form1.frm1.i++;
            if (Form1.frm1.i == 10) Form1.frm1.i = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            pictureBox1.Image = null;
            Random r = new Random();
            int a = r.Next(5);
            switch (a)
            {
                case 1:

                    pictureBox1.BackColor = Color.SeaGreen;
                    break;
                case 2:

                  pictureBox1. BackColor = Color.Violet;

                    break;
                case 3:


                  pictureBox1.BackColor = Color.Blue;
                break;
               

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.Show();
            if (pictureBox3.Location.X > pictureBox1.Width) pictureBox3.Location = new Point(34, 54);
            pictureBox3.Left = pictureBox3.Left + 1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            textBox1.Text = "";
        }

      
           
        

       
    }
}