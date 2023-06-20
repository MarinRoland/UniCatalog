namespace GestionareStudenti
{
    partial class gestionare
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            insert = new Button();
            Student_ID = new TextBox();
            Nume = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Prenume = new TextBox();
            Initiala_Tata = new TextBox();
            label4 = new Label();
            CNP = new TextBox();
            label5 = new Label();
            Specializare = new TextBox();
            label6 = new Label();
            Anul = new TextBox();
            label7 = new Label();
            Medie_admitere = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ciclu_invatamant = new TextBox();
            data_inscriere = new TextBox();
            label10 = new Label();
            Delete = new Button();
            Del_ID = new TextBox();
            Update = new Button();
            Clear = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 496);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DeepSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 13);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1730, 429);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // insert
            // 
            insert.BackColor = Color.DarkSlateBlue;
            insert.FlatAppearance.BorderColor = Color.LightSkyBlue;
            insert.FlatStyle = FlatStyle.Flat;
            insert.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            insert.ForeColor = Color.White;
            insert.Location = new Point(19, 654);
            insert.Margin = new Padding(4);
            insert.Name = "insert";
            insert.Size = new Size(162, 35);
            insert.TabIndex = 2;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_click_Click;
            // 
            // Student_ID
            // 
            Student_ID.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Student_ID.Location = new Point(19, 525);
            Student_ID.Margin = new Padding(4);
            Student_ID.Name = "Student_ID";
            Student_ID.Size = new Size(152, 24);
            Student_ID.TabIndex = 3;
            Student_ID.TextChanged += Student_ID_TextChanged;
            // 
            // Nume
            // 
            Nume.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Nume.Location = new Point(424, 525);
            Nume.Margin = new Padding(4);
            Nume.Name = "Nume";
            Nume.Size = new Size(152, 24);
            Nume.TabIndex = 4;
            Nume.TextChanged += Nume_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(424, 497);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 5;
            label2.Text = "Nume";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(616, 496);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 6;
            label3.Text = "Prenume";
            // 
            // Prenume
            // 
            Prenume.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Prenume.Location = new Point(616, 525);
            Prenume.Margin = new Padding(4);
            Prenume.Name = "Prenume";
            Prenume.Size = new Size(152, 24);
            Prenume.TabIndex = 7;
            Prenume.TextChanged += Prenume_TextChanged;
            // 
            // Initiala_Tata
            // 
            Initiala_Tata.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Initiala_Tata.Location = new Point(803, 525);
            Initiala_Tata.Margin = new Padding(4);
            Initiala_Tata.Name = "Initiala_Tata";
            Initiala_Tata.Size = new Size(65, 24);
            Initiala_Tata.TabIndex = 9;
            Initiala_Tata.TextChanged += Initiala_Tata_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(785, 496);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 8;
            label4.Text = "Initiala Tata";
            // 
            // CNP
            // 
            CNP.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CNP.Location = new Point(19, 602);
            CNP.Margin = new Padding(4);
            CNP.Name = "CNP";
            CNP.Size = new Size(185, 24);
            CNP.TabIndex = 11;
            CNP.TextChanged += CNP_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 573);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 17);
            label5.TabIndex = 10;
            label5.Text = "CNP";
            // 
            // Specializare
            // 
            Specializare.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Specializare.Location = new Point(716, 606);
            Specializare.Margin = new Padding(4);
            Specializare.MaximumSize = new Size(0, 33);
            Specializare.MinimumSize = new Size(152, 33);
            Specializare.Name = "Specializare";
            Specializare.Size = new Size(152, 33);
            Specializare.TabIndex = 21;
            Specializare.TextChanged += Specializare_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(716, 577);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(78, 17);
            label6.TabIndex = 20;
            label6.Text = "Specializare";
            label6.Click += label6_Click;
            // 
            // Anul
            // 
            Anul.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Anul.Location = new Point(616, 602);
            Anul.Margin = new Padding(4);
            Anul.Name = "Anul";
            Anul.Size = new Size(65, 24);
            Anul.TabIndex = 19;
            Anul.TextChanged += Anul_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(616, 573);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 17);
            label7.TabIndex = 18;
            label7.Text = "Anul";
            // 
            // Medie_admitere
            // 
            Medie_admitere.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Medie_admitere.Location = new Point(263, 602);
            Medie_admitere.Margin = new Padding(4);
            Medie_admitere.Name = "Medie_admitere";
            Medie_admitere.Size = new Size(65, 24);
            Medie_admitere.TabIndex = 17;
            Medie_admitere.TextChanged += Medie_admitere_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(227, 573);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 17);
            label8.TabIndex = 16;
            label8.Text = "Medie admitere";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(424, 573);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 17);
            label9.TabIndex = 15;
            label9.Text = "ciclu_invatamant";
            // 
            // ciclu_invatamant
            // 
            ciclu_invatamant.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ciclu_invatamant.Location = new Point(424, 602);
            ciclu_invatamant.Margin = new Padding(4);
            ciclu_invatamant.Name = "ciclu_invatamant";
            ciclu_invatamant.Size = new Size(152, 24);
            ciclu_invatamant.TabIndex = 14;
            ciclu_invatamant.TextChanged += ciclu_invatamant_TextChanged;
            // 
            // data_inscriere
            // 
            data_inscriere.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            data_inscriere.Location = new Point(227, 525);
            data_inscriere.Margin = new Padding(4);
            data_inscriere.Name = "data_inscriere";
            data_inscriere.Size = new Size(152, 24);
            data_inscriere.TabIndex = 13;
            data_inscriere.TextChanged += data_inscriere_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(227, 496);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(91, 17);
            label10.TabIndex = 12;
            label10.Text = "Data inscriere";
            // 
            // Delete
            // 
            Delete.BackColor = SystemColors.ActiveCaptionText;
            Delete.FlatAppearance.BorderColor = Color.LightSkyBlue;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Delete.ForeColor = Color.White;
            Delete.Location = new Point(143, 773);
            Delete.Margin = new Padding(4);
            Delete.Name = "Delete";
            Delete.Size = new Size(116, 33);
            Delete.TabIndex = 22;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Del_ID
            // 
            Del_ID.Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Del_ID.Location = new Point(1, 773);
            Del_ID.Margin = new Padding(4);
            Del_ID.MinimumSize = new Size(120, 33);
            Del_ID.Name = "Del_ID";
            Del_ID.Size = new Size(120, 33);
            Del_ID.TabIndex = 23;
            // 
            // Update
            // 
            Update.BackColor = Color.DarkSlateBlue;
            Update.FlatAppearance.BorderColor = Color.LightSkyBlue;
            Update.FlatStyle = FlatStyle.Flat;
            Update.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Update.ForeColor = Color.White;
            Update.Location = new Point(189, 654);
            Update.Margin = new Padding(4);
            Update.Name = "Update";
            Update.Size = new Size(162, 35);
            Update.TabIndex = 24;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.DarkSlateBlue;
            Clear.FlatAppearance.BorderColor = Color.LightSkyBlue;
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = Color.White;
            Clear.Location = new Point(359, 654);
            Clear.Margin = new Padding(4);
            Clear.Name = "Clear";
            Clear.Size = new Size(162, 35);
            Clear.TabIndex = 25;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1, 741);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(76, 18);
            label11.TabIndex = 26;
            label11.Text = "ID Student";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1765, 812);
            Controls.Add(label11);
            Controls.Add(Clear);
            Controls.Add(Update);
            Controls.Add(Del_ID);
            Controls.Add(Delete);
            Controls.Add(Specializare);
            Controls.Add(label6);
            Controls.Add(Anul);
            Controls.Add(label7);
            Controls.Add(Medie_admitere);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(ciclu_invatamant);
            Controls.Add(data_inscriere);
            Controls.Add(label10);
            Controls.Add(CNP);
            Controls.Add(label5);
            Controls.Add(Initiala_Tata);
            Controls.Add(label4);
            Controls.Add(Prenume);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nume);
            Controls.Add(Student_ID);
            Controls.Add(insert);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("OCR A Extended", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button insert;
        private TextBox Student_ID;
        private TextBox Nume;
        private Label label2;
        private Label label3;
        private TextBox Prenume;
        private TextBox Initiala_Tata;
        private Label label4;
        private TextBox CNP;
        private Label label5;
        private TextBox Specializare;
        private Label label6;
        private TextBox Anul;
        private Label label7;
        private TextBox Medie_admitere;
        private Label label8;
        private Label label9;
        private TextBox ciclu_invatamant;
        private TextBox data_inscriere;
        private Label label10;
        private Button Delete;
        private TextBox Del_ID;
        private Button Update;
        private Button Clear;
        private Label label11;
    }
}