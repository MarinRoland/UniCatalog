using GestionareStudenti;
using NoteStudenti;

namespace alegere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gestionare_Click(object sender, EventArgs e)
        {
            Form gest = new gestionare();
            gest.Show();
            this.Hide();
        }

        private void note_Click(object sender, EventArgs e)
        {
            Form note = new note();
            note.Show();
            this.Hide();
        }
    }
}