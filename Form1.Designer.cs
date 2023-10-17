namespace DapperDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label1 = new Label();
            textBox8 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 274);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1112, 414);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(28, 60);
            button1.Name = "button1";
            button1.Size = new Size(130, 50);
            button1.TabIndex = 1;
            button1.Text = "GetAll";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(234, 60);
            button2.Name = "button2";
            button2.Size = new Size(130, 50);
            button2.TabIndex = 2;
            button2.Text = "GetById";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(474, 60);
            button3.Name = "button3";
            button3.Size = new Size(130, 50);
            button3.TabIndex = 3;
            button3.Text = "Insert";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(719, 60);
            button4.Name = "button4";
            button4.Size = new Size(130, 50);
            button4.TabIndex = 4;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(927, 60);
            button5.Name = "button5";
            button5.Size = new Size(130, 50);
            button5.TabIndex = 5;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(128, 128, 255);
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(239, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 30);
            textBox1.TabIndex = 7;
            textBox1.Text = "Id";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(128, 128, 255);
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(474, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 30);
            textBox2.TabIndex = 8;
            textBox2.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(128, 128, 255);
            textBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(474, 186);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 30);
            textBox3.TabIndex = 9;
            textBox3.Text = "Age";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(128, 128, 255);
            textBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(719, 139);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(130, 30);
            textBox4.TabIndex = 10;
            textBox4.Text = "Id";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(128, 128, 255);
            textBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(927, 139);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(130, 30);
            textBox5.TabIndex = 11;
            textBox5.Text = "Id";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(128, 128, 255);
            textBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(927, 186);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(130, 30);
            textBox6.TabIndex = 12;
            textBox6.Text = "Name";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(128, 128, 255);
            textBox7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox7.Location = new Point(927, 229);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(130, 30);
            textBox7.TabIndex = 13;
            textBox7.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 226);
            label1.Name = "label1";
            label1.Size = new Size(301, 28);
            label1.TabIndex = 14;
            label1.Text = "Your data will be shown there!";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(128, 128, 255);
            textBox8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.Location = new Point(474, 231);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(130, 30);
            textBox8.TabIndex = 15;
            textBox8.Text = "Address";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1168, 716);
            Controls.Add(textBox8);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label1;
        private TextBox textBox8;
    }
}