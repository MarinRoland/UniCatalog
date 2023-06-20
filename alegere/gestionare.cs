using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionareStudenti
{
    public partial class gestionare : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Licenta;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ad;
        //ID variable used in Updating and Deleting Record 
        int ID = 0;
        public gestionare()
        {
            InitializeComponent();
            Display_Data();
        }
        private void Display_Data()
        {
            string query = "select * from Student";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, cnn);
            cnn.Open();
            // create data adapter
            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            cnn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void insert_click_Click(object sender, EventArgs e)
        {
            if (Student_ID.Text != "")
            {
                cmd = new SqlCommand("insert into Student(Student_ID,Nume,Prenume,Initiala_Tata,CNP,data_inscriere,ciclu_invatamant,Medie_admitere,Anul,Specializarea) values(@id,@nume,@prenume,@initiala,@cnp,@data,@ciclu,@medie,@anul,@specializare)", cnn);
                cnn.Open();
                cmd.Parameters.AddWithValue("@id", Student_ID.Text);
                cmd.Parameters.AddWithValue("@nume", Nume.Text);
                cmd.Parameters.AddWithValue("@prenume", Prenume.Text);
                cmd.Parameters.AddWithValue("@initiala", Initiala_Tata.Text);
                cmd.Parameters.AddWithValue("@cnp", CNP.Text);
                cmd.Parameters.AddWithValue("@data", data_inscriere.Text);
                cmd.Parameters.AddWithValue("@ciclu", ciclu_invatamant.Text);
                cmd.Parameters.AddWithValue("@medie", Medie_admitere.Text);
                cmd.Parameters.AddWithValue("@anul", Anul.Text);
                cmd.Parameters.AddWithValue("@specializare", Specializare.Text);

                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Record Inserted Successfully");
                Display_Data();
                Clear_Textboxes();
                ID++;
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        private void Clear_Textboxes()
        {
            Student_ID.Text = "";
            Nume.Text = "";
            Prenume.Text = "";
            Initiala_Tata.Text = "";
            CNP.Text = "";
            data_inscriere.Text = "";
            ciclu_invatamant.Text = "";
            Medie_admitere.Text = "";
            Anul.Text = "";
            Specializare.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete Student where Student_ID=@val", cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@val", Del_ID.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Record Deleted Successfully!");
            Display_Data();
            Clear_Textboxes();
            ID = ((DataTable)dataGridView1.DataSource).Rows.Count;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (Student_ID.Text != "" && Nume.Text != "")
            {
                cmd = new SqlCommand("update Student set Nume=@nume,Prenume=@prenume,Initiala_Tata=@initiala,CNP=@cnp,data_inscriere=@data,ciclu_invatamant=@ciclu,Medie_admitere=@medie,Anul=@anul,Specializarea=@specializare  where Student_ID=@id", cnn);
                cnn.Open();
                cmd.Parameters.AddWithValue("@id", Student_ID.Text);
                cmd.Parameters.AddWithValue("@nume", Nume.Text);
                cmd.Parameters.AddWithValue("@prenume", Prenume.Text);
                cmd.Parameters.AddWithValue("@initiala", Initiala_Tata.Text);
                cmd.Parameters.AddWithValue("@cnp", CNP.Text);
                cmd.Parameters.AddWithValue("@data", data_inscriere.Text);
                cmd.Parameters.AddWithValue("@ciclu", ciclu_invatamant.Text);
                cmd.Parameters.AddWithValue("@medie", Medie_admitere.Text);
                cmd.Parameters.AddWithValue("@anul", Anul.Text);
                cmd.Parameters.AddWithValue("@specializare", Specializare.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                cnn.Close();
                Display_Data();
                Clear_Textboxes();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int i;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            Student_ID.Text = row.Cells[0].Value.ToString();
            Nume.Text = row.Cells[1].Value.ToString();
            Prenume.Text = row.Cells[2].Value.ToString();
            Initiala_Tata.Text = row.Cells[3].Value.ToString();
            CNP.Text = row.Cells[4].Value.ToString();
            data_inscriere.Text = row.Cells[5].Value.ToString();
            ciclu_invatamant.Text = row.Cells[6].Value.ToString();
            Medie_admitere.Text = row.Cells[7].Value.ToString();
            Anul.Text = row.Cells[8].Value.ToString();
            Specializare.Text = row.Cells[9].Value.ToString();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Clear_Textboxes();
        }

        private void Specializare_TextChanged(object sender, EventArgs e)
        {

        }

        private void Initiala_Tata_TextChanged(object sender, EventArgs e)
        {
        }

        private void Anul_TextChanged(object sender, EventArgs e)
        {
        }

        private void Prenume_TextChanged(object sender, EventArgs e)
        {
        }

        private void ciclu_invatamant_TextChanged(object sender, EventArgs e)
        {
        }

        private void Nume_TextChanged(object sender, EventArgs e)
        {
        }

        private void Medie_admitere_TextChanged(object sender, EventArgs e)
        {
        }

        private void data_inscriere_TextChanged(object sender, EventArgs e)
        {
        }

        private void CNP_TextChanged(object sender, EventArgs e)
        {
        }

        private void Student_ID_TextChanged(object sender, EventArgs e)
        {
        }
    }
}