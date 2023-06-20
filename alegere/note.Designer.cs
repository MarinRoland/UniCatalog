namespace NoteStudenti
{
    partial class note
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
            Clear = new Button();
            Update = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            coloana = new TextBox();
            textBox3 = new TextBox();
            Student = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Clear
            // 
            Clear.BackColor = Color.DarkSlateBlue;
            Clear.FlatAppearance.BorderColor = Color.LightSkyBlue;
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("OCR A Extended", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = Color.White;
            Clear.Location = new Point(29, 675);
            Clear.Margin = new Padding(4);
            Clear.Name = "Clear";
            Clear.Size = new Size(368, 121);
            Clear.TabIndex = 52;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.DarkSlateBlue;
            Update.FlatAppearance.BorderColor = Color.LightSkyBlue;
            Update.FlatStyle = FlatStyle.Flat;
            Update.Font = new Font("OCR A Extended", 30F, FontStyle.Bold, GraphicsUnit.Point);
            Update.ForeColor = Color.White;
            Update.Location = new Point(29, 546);
            Update.Margin = new Padding(4);
            Update.Name = "Update";
            Update.Size = new Size(368, 121);
            Update.TabIndex = 51;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DeepSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 10);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1730, 429);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(215, 443);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 31);
            label1.TabIndex = 27;
            label1.Text = "Nota";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1685, 738);
            button1.Name = "button1";
            button1.Size = new Size(68, 62);
            button1.TabIndex = 53;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 27F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(215, 477);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 62);
            textBox1.TabIndex = 54;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // coloana
            // 
            coloana.Location = new Point(63, 12);
            coloana.Name = "coloana";
            coloana.Size = new Size(100, 23);
            coloana.TabIndex = 55;
            coloana.TextChanged += coloana_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(63, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 56;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Student
            // 
            Student.BackColor = SystemColors.ButtonHighlight;
            Student.Font = new Font("Segoe UI", 27F, FontStyle.Regular, GraphicsUnit.Point);
            Student.Location = new Point(29, 477);
            Student.Multiline = true;
            Student.Name = "Student";
            Student.ReadOnly = true;
            Student.Size = new Size(180, 62);
            Student.TabIndex = 57;
            Student.TextAlign = HorizontalAlignment.Center;
            Student.TextChanged += Student_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 443);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 31);
            label2.TabIndex = 58;
            label2.Text = "Student";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1765, 812);
            Controls.Add(label2);
            Controls.Add(Student);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Clear);
            Controls.Add(Update);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(coloana);
            Controls.Add(textBox3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Clear;
        private Button Update;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox coloana;
        private TextBox textBox3;
        private TextBox Student;
        private Label label2;
    }
}