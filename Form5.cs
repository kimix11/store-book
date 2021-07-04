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
    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=storebook.mdb");
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            t4.Text = dataGridView1.SelectedRows[0].Cells["codem"].Value.ToString();
            t5.Text = dataGridView1.SelectedRows[0].Cells["mozoo"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from mozoo where mozoo like '" + textBox7.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void th_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into mozoo(codem,mozoo) values(@p1,@p2)", con);
            cmd.Parameters.AddWithValue("@p1", t4.Text);
            cmd.Parameters.AddWithValue("@p2", t5.Text);
            try { cmd.ExecuteNonQuery(); }
            catch { MessageBox.Show(".کد کتاب تکراری است", "خطا"); t4.Clear(); t5.Clear(); }
            OleDbDataAdapter da = new OleDbDataAdapter("select * from mozoo", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (Form1.frm3.kToolStripMenuItem.Checked == true)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                textBox1.Enabled = false;
                t4.Enabled = false;
                t5.Enabled = false;
                

            }
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from mozoo", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                DialogResult x = MessageBox.Show("کاربر گرامی،آيابرای حذف رکوردمطمئن هستيد؟با توجه به اینکه با حذف آن تمام کتابهای مربوط به این موضوع حذف میشوند ", "حذف ركورد", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(" delete from mozoo where mozoo=@p1 ", con);
                    cmd.Parameters.AddWithValue("@p1", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    OleDbDataAdapter da = new OleDbDataAdapter("select * from mozoo", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
               
                textBox1.Clear();
            }
            
        }

        private void t4_TextChanged(object sender, EventArgs e)
        {

        }

        private void t4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)'a' && e.KeyChar <= (char)'z')
                e.KeyChar = (char)0;
        }

        private void t5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)'0' && e.KeyChar <= (char)'9')
                e.KeyChar = (char)0;

        }
    }
}