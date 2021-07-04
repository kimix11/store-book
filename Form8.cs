using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsApplication1proj
{
    public partial class Form8 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=storebook.mdb");
        OleDbDataAdapter da;
        DataTable dt;
        int a, b, c,d,m,n; string st;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (Form1.frm3.kToolStripMenuItem.Checked == true)
            {
                button1.Enabled = false;
                th1.Enabled = false;
            }
            th3.Hide();
            con.Open();
            da = new OleDbDataAdapter("select * from fehrestketab", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            label5.DataBindings.Add("text", dt, "code");
            label6.DataBindings.Add("text", dt, "onvan");
            label7.DataBindings.Add("text", dt, "arzesh");
            th.DataBindings.Add("text", dt, "tedad");
            th3.DataBindings.Add("text", dt, "code");
            con.Close();
            System.Globalization.PersianCalendar per = new System.Globalization.PersianCalendar();
            string year = per.GetYear(DateTime.Now).ToString();
            string mon = per.GetMonth(DateTime.Now).ToString();
            string day = per.GetDayOfMonth(DateTime.Now).ToString();
            label8.Text = day + " / " + mon + " / " + year;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("select * from fehrestketab where onvan like '" + textBox2.Text + "%'", con);
             dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            try
            {
                a = int.Parse(th.Text);
                b = int.Parse(th1.Text);
                c = int.Parse(th1.Text);
                d = int.Parse(label7.Text);
                if (b <= a)
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("insert into kharid(code,onvan,tedad1,arzesh,dat) values(@p1,@p2,@p3,@p4,@p5)", con);
                    cmd.Parameters.AddWithValue("@p1", label5.Text);
                    cmd.Parameters.AddWithValue("@p2", label6.Text);
                    cmd.Parameters.AddWithValue("@p3", th1.Text);
                    cmd.Parameters.AddWithValue("@p4", label7.Text);
                    cmd.Parameters.AddWithValue("@p5", label8.Text);
                    cmd.ExecuteNonQuery();
                    DialogResult x = MessageBox.Show("آیا مایل به خرید کتاب هستید؟", "خرید", MessageBoxButtons.YesNo);
                    if (x == DialogResult.Yes)
                    {
                        st = (a - b).ToString();
                        OleDbCommand cmd2 = new OleDbCommand("update fehrestketab set code=@p1,tedad=@p6 where code=" + th3.Text, con);
                        cmd2.Parameters.AddWithValue("@p1", th3.Text);
                        cmd2.Parameters.AddWithValue("@p6", st);
                        cmd2.ExecuteNonQuery();
                        //da = new OleDbDataAdapter("select * from fehrestketab", con);
                        //dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        m = (c * d) - (((c * d) / 100) * 30);
                        MessageBox.Show(d + ":قیمت هر کتاب" + "\n" + c + ":تعداد کتاب درخواستی" + "\n" + (c * d) + ":قیمت کل" + "\n" + m + ":قابل پرداخت با 30٪ تخفیف", "قیمت کل");
                        th1.Clear();
                        th.Focus();
                        con.Close();
                    }
                    else
                    {
                        th1.Clear();
                        th.Focus();
                        con.Close();
                    }

                }
                else
                {
                    MessageBox.Show("به این تعداد کتاب موجود نیست", "خطا");
                }
            }
            catch { MessageBox.Show(".تعداد کتابهای مورد نیاز را در کادر وارد کنید", "خطا"); }
        }

        private void th1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)'a' && e.KeyChar <= (char)'z')
                e.KeyChar = (char)0;
        }

        private void th1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            da = new OleDbDataAdapter("select * from fehrestketab", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            label5.DataBindings.Add("text", dt, "code");
            label6.DataBindings.Add("text", dt, "onvan");
            label7.DataBindings.Add("text", dt, "arzesh");
            th.DataBindings.Add("text", dt, "tedad");
            th3.DataBindings.Add("text", dt, "code");
            con.Close();
            System.Globalization.PersianCalendar per = new System.Globalization.PersianCalendar();
            string year = per.GetYear(DateTime.Now).ToString();
            string mon = per.GetMonth(DateTime.Now).ToString();
            string day = per.GetDayOfMonth(DateTime.Now).ToString();
            label8.Text = day + " / " + mon + " / " + year;
           
        }
    }
}