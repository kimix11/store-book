using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.OleDb;
using System.IO;
namespace WindowsApplication1proj
{
    public partial class Form1 : Form
    {
        public int j = 0;
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=storebook.mdb");
        public static Form1 frm1;
        public static Form1 frm3;
        StreamReader sr = new StreamReader("jomle.txt");
        Form f3 = new Form4(); public  int a;
       
       public  int i = 1; Random r = new Random();
        public Form1()
        {
            InitializeComponent();

        }

        private void mozooBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

            //www.ostad98.ir


            //menuStrip2.Hide();
            toolStripTextBox1.Text = "E واردکردن رمزیافشاردادن کلید";
            label7.Hide();
            label7.Width = 12;
            label7.Text = sr.ReadLine();
                    label1.Hide();
            frm1 = this;
            frm3 = this;
            this.ClientSize = new System.Drawing.Size(815, 406);
            toolStripMenuItem27_Click(sender, e);
                MessageBox.Show("کار کنید E تا A لطفا برای استفاده کامل از راهنمای برنامه با کلید های", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

        }
        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem26.Checked == false)
            {
                toolStripMenuItem26.Checked = true;
                menuStrip2.Show();
            }
            else
            {
                toolStripMenuItem26.Checked = false;
                menuStrip2.Hide();
            }
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            timer6.Enabled = true;
            System.Globalization.PersianCalendar per = new System.Globalization.PersianCalendar();
            string day = per.GetDayOfMonth(DateTime.Now).ToString();
            string mon = per.GetMonth(DateTime.Now).ToString();
            string year = per.GetYear(DateTime.Now).ToString();
            label4.Text = year + " / " + mon + " / " + day + "  :   تاریخ ";
            if (toolStripMenuItem27.Checked == false)
            {
                toolStripMenuItem27.Checked = true;
                            }
            else
            {
                toolStripMenuItem27.Checked = false;
                          }
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            Form f2 = new Form3();
            f2.Show();
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
           

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
            this.BackgroundImage = Image.FromFile(@"pic\" + i.ToString() + ".jpg");
            i++;
            if (i == 10) i = 1;
            timer1.Interval = 2000;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                menuStrip1.Enabled = true;
                menuStrip2.Enabled = true;
                this.BackgroundImage =Image.FromFile("bg.jpg");
                this.BackColor = Color.Empty;
                label1.Hide();
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            
        }      
            

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            Random r = new Random();
            int a = r.Next(5);
            switch (a)
            {
                case 1:

                    this.BackColor = Color.SeaGreen;
                    break;
                case 2:

                    this.BackColor = Color.Violet;

                    break;
                case 3:


                    this.BackColor = Color.Blue;
                    break;
                case 4:


                    this.BackColor = Color.Magenta;
                    break;
                case 5:

                    this.BackColor = Color.Magenta;

                    break;


            }
            timer2.Interval = 2000;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Show();
            label1.Text = Form4.frm.st;
            Random r = new Random();
            int s = r.Next(4);

            
            int a = r.Next(5);
            if (label1.Location.X > this.Width) label1.Location = new Point(-1, 120);
            switch (a)
            {
                case 1:
                    label1.Left = label1.Left + 10;
                    
                    label1.ForeColor = Color.Yellow;
                    break;
                case 2:
                    label1.Left = label1.Left + 10;
                   
                    label1.ForeColor = Color.Red;
                    break;
                case 3:
                    label1.Left = label1.Left + 10;
                   
                    label1.ForeColor = Color.Blue;
                    break;
                case 4:
                    label1.Left = label1.Left + 10;
                  
                    label1.ForeColor = Color.Magenta;
                    break;
                case 5:
                    label1.Left = label1.Left + 10;
                    
                    label1.ForeColor = Color.Maroon;
                    break;
            }
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {

            menuStrip1.Enabled = false;
            menuStrip2.Enabled = false;
            if (a == 1)
            {
                timer1.Enabled = true;
               
            }
            else if (a == 2)
            {
                timer2.Enabled = true;
               
            }
            else if (a == 3)
                timer3.Enabled = true;
            else if (a == 0)
            {
                timer1.Enabled = true;
              
            }
              
           
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            Process.Start("Chessboard.exe");
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            label2.Width += 2;
            label3.Left += 2;
            label7.Show();
            label7.Width += 2;
            if (label2.Width >= 500)
            {
                timer4.Enabled = false;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label2.Width -= 2;
            label3.Left -= 2;
            label7.Width -= 2;
            if (label2.Width <= 170)
            {  
                label7.Hide();
                timer5.Enabled = false;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString() + " :  ساعت";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            f3.Visible = true;
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form f=new Form2();
            f.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form f = new Form5();
            f.ShowDialog();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            label7.Text = sr.ReadLine();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void ارزشToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Form f = new Form8();
            f.ShowDialog();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Form f = new Form7();
            f.ShowDialog();
        }

        private void toolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            Form f = new Form8();
            f.ShowDialog();
        }

      

       
        

        private void toolStripTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)13)
            {

                if (toolStripTextBox1.Text == "2010")
                {
                    mToolStripMenuItem.Checked = true;
                    kToolStripMenuItem.Checked = false;


                }
              
                toolStripTextBox1.Clear();
               
            }
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mToolStripMenuItem.Checked == true)
                kToolStripMenuItem.Checked = false;
           
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Clear();
        }

        private void اToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kToolStripMenuItem.Checked = true;
            mToolStripMenuItem.Checked = false;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
            Form f = new Form2();
            f.ShowDialog();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem39_Click(object sender, EventArgs e)
        {
            Form f = new Form8();
            f.ShowDialog();
        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {
            Form f = new Form7();
            f.ShowDialog();
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {
            Form f = new Form5();
            f.ShowDialog();
        }

        private void toolStripMenuItem47_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("آیا مایل به گرفتن نسخه پشتیبان هستید؟", "نسخه پشتیبان", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                int i = 0;
                StreamWriter sw = new StreamWriter("BuyBook.text");
                con.Open();
                OleDbCommand cm = new OleDbCommand("select *from kharid", con);
                OleDbDataReader dr;
                dr = cm.ExecuteReader();
                while (dr.Read() != false)
                {
                    for (i = 0; i < 5; i++)
                        sw.Write(dr[i] + "  ");
                    sw.WriteLine("\t");
                }
                sw.Close();
                con.Close();
                MessageBox.Show("ازفهرست کتابهای خریداری شده نسخه پشتیبان ایجاد شد","نسخه پشتیبان");
               }
            else

               MessageBox.Show("ازفهرست کتابهای خریداری شده نسخه پشتیبان ایجاد نشد", "نسخه پشتیبان");
            
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("آیا مایل به گرفتن نسخه پشتیبان هستید؟", "نسخه پشتیبان", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                int i = 0;
                StreamWriter sw = new StreamWriter("ListBook.text");
                con.Open();
                OleDbCommand cm = new OleDbCommand("select *from fehrestketab", con);
                OleDbDataReader dr;
                dr = cm.ExecuteReader();
                while (dr.Read() != false)
                {
                    for (i = 0; i < 5; i++)
                        sw.Write(dr[i] + "  ");
                    sw.WriteLine("\t");
                }
                sw.Close();
                con.Close();
                MessageBox.Show("ازفهرست کتابها نسخه پشتیبان ایجاد شد", "نسخه پشتیبان");
            }
            else

                MessageBox.Show("ازفهرست کتابها نسخه پشتیبان ایجاد نشد", "نسخه پشتیبان");
            
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void اسلاید1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"/slide/1.swf");
        }

        private void اسلاید2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"/slide/2.swf");
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            try { Process.Start(@"/projpazel/pazel.exe"); }
            catch { MessageBox.Show(".است اجراکنید SourceGame لطفاکد برنامه راکه در پوشه", "خطادراجرای برنامه"); }
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            try { Process.Start(@"/projhobab1/hobab.exe"); }
            catch { MessageBox.Show(".است اجراکنید SourceGame لطفاکد برنامه راکه در پوشه", "خطادراجرای برنامه"); }
            
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void کاراییبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form10();
            f.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Form f11 = new Form11();
            if (e.KeyCode == Keys.A)
            {
                j = 1;
                f11.ShowDialog();
               

            }
            else if (e.KeyCode == Keys.B)
            {
                j = 2;
                f11.ShowDialog();
            }
            else if (e.KeyCode == Keys.C)
            {
                j = 3;
                f11.ShowDialog();
               

            }
            else if (e.KeyCode == Keys.D)
            {
                j = 4;
                f11.ShowDialog();
            }
            else if (e.KeyCode == Keys.E)
            {
                j = 5;
                f11.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (timer5.Enabled == false) label3.Text = ">>";
            if (label2.Width < 450) timer4.Enabled = true;
            else { timer5.Enabled = true; label3.Text = "<<"; }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           //MessageBox.Show("با تشکر از توجه شما عزیزان", "تشکر", MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
