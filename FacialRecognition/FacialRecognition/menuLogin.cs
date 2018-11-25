using Iscav1;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace FacialRecognition
{

    public partial class menuLogin : Form
    {


        public menuLogin()
        {

            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void menuLogin_Load(object sender, EventArgs e)
        {
           
            FacialRecognition.estacionamiento1.tiempo = -1;
            FacialRecognition.estacionamiento2.tiempo = -1;
            FacialRecognition.estacionamiento3.tiempo = -1;
            FacialRecognition.estacionamiento4.tiempo = -1;
            FacialRecognition.estacionamiento5.tiempo = -1;
            FacialRecognition.estacionamiento6.tiempo = -1;
            FacialRecognition.tiempo.segundos = 60;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals("admin") && txtpass.Text.Equals("admin1"))
            {
                MessageBox.Show(" Bienvenido Administrador");
                SelectMenu sm = new SelectMenu();
                menuLogin menul = new menuLogin();
                sm.Show();
                this.Hide();

            }
            else
            {
                if (txtuser.Text.Equals("conserje") && txtpass.Text.Equals("conserje1"))
                {
                    MessageBox.Show(" Bienvenido Conserje");
                    menuConserje menuc = new menuConserje();
                    menuLogin menul = new menuLogin();
                    menuc.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Revise sus credenciales e intenete nuevamente");

                }

            }




        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = System.Drawing.Color.DimGray;

            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {

            try
            {

                if (txtpass.Text != "")
                {
                    txtpass.Text = "";
                    txtpass.ForeColor = System.Drawing.Color.DarkBlue;

                    txtpass.UseSystemPasswordChar = true;
                }


            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message, "Ingrese contraseña");
            }


        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = System.Drawing.Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    public static class validador
    {
        public static string validarDetec { get; set; }
    }

    public static class numDepto
    {
        public static string nDepto { get; set; }
    }

    public static class numEstacionamiento
    {
        public static string numeroEstacionamiento { get; set; }
    }

    public static class tiempo
    {
        public static int segundos { get; set; }
    }


    public static class estacionamiento1
    {
        public static string status { get; set; }
        public static string nombre { get; set; }
        public static string depto { get; set; }
        public static string patente { get; set; }
        public static string horaInicio { get; set; }
        public static int tiempo { get; set; }

    }

    public static class estacionamiento2
    {
        public static string status { get; set; }
        public static string nombre { get; set; }
        public static string depto { get; set; }
        public static string patente { get; set; }
        public static string horaInicio { get; set; }
        public static int tiempo { get; set; }

    }

    public static class estacionamiento3
    {
        public static string status { get; set; }
        public static string nombre { get; set; }
        public static string depto { get; set; }
        public static string patente { get; set; }
        public static string horaInicio { get; set; }
        public static int tiempo { get; set; }

    }

    public static class estacionamiento4
    {
        public static string status { get; set; }
        public static string nombre { get; set; }

        public static string depto { get; set; }
        public static string patente { get; set; }
        public static string horaInicio { get; set; }
        public static int tiempo { get; set; }

    }

    public static class estacionamiento5
    {
        public static string status { get; set; }
        public static string nombre { get; set; }
        public static string depto { get; set; }
        public static string patente { get; set; }
        public static string horaInicio { get; set; }
        public static int tiempo { get; set; }

    }

    public static class estacionamiento6
    {
        public static string status { get; set; }
        public static string nombre { get; set; }
        public static string depto { get; set; }
        public static string patente { get; set; }
        public static string horaInicio { get; set; }
        public static int tiempo { get; set; }

    }

    public static class estacionamiento7
    {
        public static string status { get; set; }
        public static string nombre { get; set; }

        public static string depto { get; set; }
        public static string patente { get; set; }
        public static string horaInicio { get; set; }
        public static string tiempo { get; set; }

    }

    public static class estacionamiento8
    {
        public static string status { get; set; }
        public static string nombre { get; set; }
        public static string depto { get; set; }
        public static string patente { get; set; }
        public static string horaInicio { get; set; }
        public static string tiempo { get; set; }

    }

}
