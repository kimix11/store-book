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
    public partial class Form2 : Form
    {
        OleDbConnection con=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=storebook.mdb");
        
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.frm3.kToolStripMenuItem.Checked == true)
            {
                button5.Enabled = false;
                textBox7.Enabled = false;
                panel3.Enabled = false;

            }
            th.Hide();
            panel2.Enabled = true;
            panel1.Enabled = false;
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            th.DataBindings.Add("text", dt, "code");
            OleDbDataAdapter da1 = new OleDbDataAdapter("select * from mozoo", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "mozoo";
            comboBox1.ValueMember = "codem";
            comboBox1.DataBindings.Add("selectedvalue", dt, "codem");
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "mozoo";
            comboBox2.ValueMember = "codem";
            comboBox2.DataBindings.Add("selectedvalue", dt, "codem");
            OleDbDataAdapter da3 = new OleDbDataAdapter("select * from nasher", con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBox4.DataSource = dt3;
            comboBox4.DisplayMember = "name";
            comboBox4.ValueMember = "codenasher";
            comboBox4.DataBindings.Add("selectedvalue", dt, "codenasher");
            comboBox6.DataSource = dt3;
            comboBox6.DisplayMember = "name";
            comboBox6.ValueMember = "codenasher";
            comboBox6.DataBindings.Add("selectedvalue", dt, "codenasher");
            label18.DataBindings.Add("text", dt, "nevisande");
            label15.DataBindings.Add("text", dt, "code");
            label16.DataBindings.Add("text", dt, "onvan");
            label20.DataBindings.Add("text", dt, "tedad");
            label21.DataBindings.Add("text", dt, "arzesh");
            OleDbDataAdapter da2 = new OleDbDataAdapter("select * from m", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox3.DataSource = dt2;
            comboBox3.DisplayMember = "moshakhasat";
            comboBox3.ValueMember = "code";
            comboBox3.DataBindings.Add("selectedvalue", dt, "code");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into fehrestketab(code,onvan,codem,codenasher,nevisande,tedad,arzesh) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", con);
                cmd.Parameters.AddWithValue("@p1", t4.Text);
                cmd.Parameters.AddWithValue("@p2", t5.Text);
                cmd.Parameters.AddWithValue("@p3", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@p4", comboBox6.SelectedValue);
                cmd.Parameters.AddWithValue("@p5", t6.Text);
                cmd.Parameters.AddWithValue("@p6", t8.Text);
                cmd.Parameters.AddWithValue("@p7", t9.Text);
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand("insert into m(code,moshakhasat) values(@p1,@p2)", con);
                cmd1.Parameters.AddWithValue("@p1", t4.Text);
                cmd1.Parameters.AddWithValue("@p2", comboBox5.Text);
                cmd1.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch { MessageBox.Show(".کد وارد شده تکراری است","خطا"); }
            panel2.Enabled = true;
            panel1.Enabled = false;
            t4.Clear();
            t5.Clear();
            t6.Clear();
            t8.Clear();
            t9.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t4.Focus();
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t4.Focus();
            panel1.Enabled = true;
            panel2.Enabled = false;
            try
            {
                t4.Text = dataGridView1.SelectedRows[0].Cells["code"].Value.ToString();
                t5.Text = dataGridView1.SelectedRows[0].Cells["onvan"].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells["codem"].Value.ToString();
                comboBox6.Text = dataGridView1.SelectedRows[0].Cells["codenasher"].Value.ToString();
                t6.Text = dataGridView1.SelectedRows[0].Cells["nevisande"].Value.ToString();
                t8.Text = dataGridView1.SelectedRows[0].Cells["tedad"].Value.ToString();
                t9.Text = dataGridView1.SelectedRows[0].Cells["arzesh"].Value.ToString();
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                OleDbDataAdapter da2 = new OleDbDataAdapter("select * from m", con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboBox5.DataSource = dt2;
                comboBox5.DisplayMember = "moshakhasat";
                comboBox5.ValueMember = "code";
                comboBox5.DataBindings.Add("selectedvalue", dt, "code");
                con.Close();
          }
           catch { MessageBox.Show(".برای ویرایش یک ردیف راانتخاب کنید", "خطا"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update fehrestketab set code=@p1,onvan=@p2,codem=@p3,codenasher=@p4,nevisande=@p5,tedad=@p6,arzesh=@p7 where code=" + th.Text, con);
            cmd.Parameters.AddWithValue("@p1", t4.Text);
            cmd.Parameters.AddWithValue("@p2", t5.Text);
            cmd.Parameters.AddWithValue("@p3", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@p4", comboBox6.SelectedValue);
            cmd.Parameters.AddWithValue("@p5", t6.Text);
            cmd.Parameters.AddWithValue("@p6", t8.Text);
            cmd.Parameters.AddWithValue("@p7", t9.Text);
            cmd.ExecuteNonQuery();
            OleDbCommand cmd1 = new OleDbCommand("update m set code=@p1,moshakhasat=@p2 where code=" + th.Text, con);
            cmd1.Parameters.AddWithValue("@p1", t4.Text);
            cmd1.Parameters.AddWithValue("@p2", comboBox5.Text);
            cmd1.ExecuteNonQuery();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            t4.Clear();
            t5.Clear();
            t6.Clear();
            t8.Clear();
            t9.Clear();
           
        }

       private void button5_Click(object sender, EventArgs e)
        {
            
            DialogResult x = MessageBox.Show("کاربر گرامی،آيابرای حذف رکوردمطمئن هستيد؟", "حذف ركورد", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(" delete from fehrestketab where onvan=@p1 ", con);
                cmd.Parameters.AddWithValue("@p1", textBox7.Text);
                cmd.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            textBox7.Clear();
        }
           
        private void t4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)'a' && e.KeyChar <= (char)'z')
                e.KeyChar = (char)0;
            if (e.KeyChar == (char)13) t5.Focus();
        }

       private void t8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) t9.Focus();
            if (e.KeyChar >= (char)'a' && e.KeyChar <= (char)'z')
                e.KeyChar = (char)0;
        }

        private void t9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)'a' && e.KeyChar <= (char)'z')
                e.KeyChar = (char)0;
            
        }
        private void t5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) comboBox1.Focus();
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) comboBox6.Focus();
        }
               
        private void t7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= (char)'0' && e.KeyChar <= (char)'9')
                e.KeyChar = (char)0;
            if (e.KeyChar == (char)13) t8.Focus();
        }
            
        private void t6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) t8.Focus();
               if (e.KeyChar >= (char)'0' && e.KeyChar <= (char)'9')
                    e.KeyChar = (char)0;

        }

        private void comboBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) t6.Focus();
        }

        private void comboBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) comboBox6.Focus();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("کاربر گرامی،آيابرای حذف رکوردمطمئن هستيد؟", "حذف ركورد", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(" delete from fehrestketab where onvan=@p1 ", con);
                cmd.Parameters.AddWithValue("@p1", textBox7.Text);
                cmd.ExecuteNonQuery();
                OleDbCommand cmd1 = new OleDbCommand(" delete from m where code="+th.Text, con);
                cmd1.ExecuteNonQuery();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            textBox7.Clear();
        }

         private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from fehrestketab where onvan like '" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            panel2.Enabled = true;
            panel1.Enabled = false;
        }

       
       
    }
}