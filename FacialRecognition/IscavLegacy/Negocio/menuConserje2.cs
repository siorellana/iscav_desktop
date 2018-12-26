using System;
using System.Windows.Forms;

namespace FacialRecognition
{
    public partial class menuConserje : Form
    {
        public menuConserje()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            //make it starting form

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //link it to training module
            modEnroll f = new modEnroll();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //now create form for recognition
            modDeteccion r = new modDeteccion();
            r.Show();
            this.Hide();
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuLogin login = new menuLogin();

            login.Show();


            this.Hide();

        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
           

            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
