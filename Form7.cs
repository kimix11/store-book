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
    public partial class Form7 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=storebook.mdb");
        public Form7()
        {
            InitializeComponent();
        }

        private void rp1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            label1.Enabled = false;
           // dataGridView1 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rp1.Checked == true)
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab where arzesh="+textBox1.Text, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (rp2.Checked == true)
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab where arzesh >=" + textBox1.Text, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (rp3.Checked == true)
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab where arzesh <=" + textBox1.Text, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            if (rp4.Checked == true)
            {
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab where arzesh between " + textBox1.Text + " and " + textBox2.Text, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            textBox1.Clear();
            textBox2.Clear();



        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void rp4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            //dataGridView1 = null;
            textBox2.Enabled = true;
            label1.Enabled = true;
        }

        private void rp3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            label1.Enabled = false;
        }

        private void rp2_CheckedChanged(object sender, EventArgs e)
        {
           // dataGridView1 = null;
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            label1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)'a' && e.KeyChar <= (char)'z')
                e.KeyChar = (char)0;
            if (textBox2.Enabled == true)
            {
                if (e.KeyChar == (char)13) textBox2.Focus();
            }
            else
                if (e.KeyChar == (char)13) button1.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)'a' && e.KeyChar <= (char)'z')
                e.KeyChar = (char)0;
        }
    }
}