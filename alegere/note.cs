using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteStudenti
{
    public partial class note : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=localhost;Initial Catalog=Licenta;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter ad;
        int ID = 0;
        public note()
        {
            InitializeComponent();
            Display_Data();
        }
        private void Display_Data()
        {
            string query = "select * from Note_Studenti";
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int i, j;


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            j = e.ColumnIndex;
            DataGridViewRow row = dataGridView1.Rows[i];
            textBox1.Text = row.Cells[j].Value.ToString();


            string col = e.ColumnIndex.ToString();
            coloana.Text = col;

            Student.Text = row.Cells[0].Value.ToString();
        }


        private void Update_Click(object sender, EventArgs e)
        {
            string opt = coloana.Text;
            string valoare = textBox1.Text;
            switch (opt)
            {
                case "3":
                    {
                        cmd = new SqlCommand("update Note_Studenti set TS1=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "4":
                    {
                        cmd = new SqlCommand("update Note_Studenti set TS2=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "5":
                    {
                        cmd = new SqlCommand("update Note_Studenti set SAE=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "6":
                    {
                        cmd = new SqlCommand("update Note_Studenti set CEL=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "7":
                    {
                        cmd = new SqlCommand("update Note_Studenti set ROBO=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "8":
                    {
                        cmd = new SqlCommand("update Note_Studenti set POO=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "9":
                    {
                        cmd = new SqlCommand("update Note_Studenti set ASCN=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "10":
                    {
                        cmd = new SqlCommand("update Note_Studenti set PA=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "11":
                    {
                        cmd = new SqlCommand("update Note_Studenti set MN=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "12":
                    {
                        cmd = new SqlCommand("update Note_Studenti set MT=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "13":
                    {
                        cmd = new SqlCommand("update Note_Studenti set SPORT=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "14":
                    {
                        cmd = new SqlCommand("update Note_Studenti set SPRT=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "15":
                    {
                        cmd = new SqlCommand("update Note_Studenti set ENG3=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "16":
                    {
                        cmd = new SqlCommand("update Note_Studenti set ENG4=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "17":
                    {
                        cmd = new SqlCommand("update Note_Studenti set PS=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                case "18":
                    {
                        cmd = new SqlCommand("update Note_Studenti set ED=@valoare where Student=@student", cnn);
                        cnn.Open();
                        cmd.Parameters.AddWithValue("@valoare", textBox1.Text);
                        cmd.Parameters.AddWithValue("@student", Student.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully");
                        cnn.Close();
                        Display_Data();
                    }
                    break;
                default:
                    break;

            }
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Student.Clear();
            textBox1.Clear();
            coloana.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SQL query
            string query = "INSERT INTO Note_Studenti (Student, Nume, Prenume) " +
               "SELECT Student_ID, Nume, Prenume " +
               "FROM Student " +
               "WHERE Specializarea='AIA' AND Anul='2' ";

            // Execute the query
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=Licenta;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void coloana_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_TextChanged(object sender, EventArgs e)
        {

        }
    }
}