namespace WindowsApplication1proj
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rp3 = new System.Windows.Forms.RadioButton();
            this.rp4 = new System.Windows.Forms.RadioButton();
            this.rp1 = new System.Windows.Forms.RadioButton();
            this.rp2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rp3);
            this.groupBox1.Controls.Add(this.rp4);
            this.groupBox1.Controls.Add(this.rp1);
            this.groupBox1.Controls.Add(this.rp2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(322, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(120, 135);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "انتخاب حالت";
            // 
            // rp3
            // 
            this.rp3.AutoSize = true;
            this.rp3.ForeColor = System.Drawing.Color.Black;
            this.rp3.Location = new System.Drawing.Point(5, 75);
            this.rp3.Name = "rp3";
            this.rp3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rp3.Size = new System.Drawing.Size(106, 17);
            this.rp3.TabIndex = 7;
            this.rp3.TabStop = true;
            this.rp3.Text = "كوچكتر مساوي";
            this.rp3.UseVisualStyleBackColor = true;
            this.rp3.CheckedChanged += new System.EventHandler(this.rp3_CheckedChanged);
            // 
            // rp4
            // 
            this.rp4.AutoSize = true;
            this.rp4.ForeColor = System.Drawing.Color.Black;
            this.rp4.Location = new System.Drawing.Point(69, 97);
            this.rp4.Name = "rp4";
            this.rp4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rp4.Size = new System.Drawing.Size(42, 17);
            this.rp4.TabIndex = 6;
            this.rp4.TabStop = true;
            this.rp4.Text = "بين";
            this.rp4.UseVisualStyleBackColor = true;
            this.rp4.CheckedChanged += new System.EventHandler(this.rp4_CheckedChanged);
            // 
            // rp1
            // 
            this.rp1.AutoSize = true;
            this.rp1.ForeColor = System.Drawing.Color.Black;
            this.rp1.Location = new System.Drawing.Point(62, 30);
            this.rp1.Name = "rp1";
            this.rp1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rp1.Size = new System.Drawing.Size(49, 17);
            this.rp1.TabIndex = 9;
            this.rp1.TabStop = true;
            this.rp1.Text = "برابر";
            this.rp1.UseVisualStyleBackColor = true;
            this.rp1.CheckedChanged += new System.EventHandler(this.rp1_CheckedChanged);
            // 
            // rp2
            // 
            this.rp2.AutoSize = true;
            this.rp2.ForeColor = System.Drawing.Color.Black;
            this.rp2.Location = new System.Drawing.Point(11, 52);
            this.rp2.Name = "rp2";
            this.rp2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rp2.Size = new System.Drawing.Size(100, 17);
            this.rp2.TabIndex = 8;
            this.rp2.TabStop = true;
            this.rp2.Text = "بزرگتر مساوي";
            this.rp2.UseVisualStyleBackColor = true;
            this.rp2.CheckedChanged += new System.EventHandler(this.rp2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(376, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "تا";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(322, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 21);
            this.textBox2.TabIndex = 15;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 21);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(243, 229);
            this.dataGridView1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "code";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "کدکتاب";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "onvan";
            this.Column2.HeaderText = "عنوان";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "codem";
            this.Column3.HeaderText = "کدموضوع";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "codenasher";
            this.Column4.HeaderText = "کد ناشر";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nevisande";
            this.Column5.HeaderText = "نویسنده";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "tedad";
            this.Column6.HeaderText = "تعداد";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "arzesh";
            this.Column7.HeaderText = "ارزش";
            this.Column7.Name = "Column7";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsApplication1proj.Properties.Resources.ser;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(366, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(443, 238);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 277);
            this.MinimumSize = new System.Drawing.Size(459, 277);
            this.Name = "Form7";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو ";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rp3;
        private System.Windows.Forms.RadioButton rp4;
        private System.Windows.Forms.RadioButton rp1;
        private System.Windows.Forms.RadioButton rp2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}