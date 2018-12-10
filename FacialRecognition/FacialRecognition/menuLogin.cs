using Iscav1;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Diagnostics;


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


        public void Autentif(string pusuario, string pcontrasena)
        {



            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select NOMBRE,CONTRASEÑA, TIPOUSER from tbusers where NOMBRE =@user AND CONTRASEÑA =@pass", conn);

            cmd.Parameters.AddWithValue("user", pusuario);
            cmd.Parameters.AddWithValue("pass", pcontrasena);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {


                if (dt.Rows[0][2].ToString() == "Administrador")
                {
                    MessageBox.Show(" Bienvenido Administrador");
                    SelectMenu sm = new SelectMenu();
                    menuLogin menul = new menuLogin();
                    sm.Show();
                    this.Hide();

                }
                else if (dt.Rows[0][2].ToString() == "Conserje")
                {
                    MessageBox.Show(" Bienvenido Conserje");
                    SelectMenuCon menuc = new SelectMenuCon();
                    menuLogin menul = new menuLogin();
                    menuc.Show();
                    this.Hide();

                }
                if (dt.Rows[0][2].ToString() == "Residente")
                {
                    MessageBox.Show(" Bienvenido Conserje");
                    SelectMenuCon menuc = new SelectMenuCon();
                    menuLogin menul = new menuLogin();
                    menuc.Show();
                    this.Hide();

                }
                else if (dt.Rows[0][2].ToString() == "Visita")
                {
                    MessageBox.Show(" Bienvenido Conserje");
                    SelectMenuCon menuc = new SelectMenuCon();
                    menuLogin menul = new menuLogin();
                    menuc.Show();
                    this.Hide();
                }





            }


       

        }

        private void btningresar_Click(object sender, EventArgs e)
        {


            string login_pass = txtpass.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
            byte[] hash = md5.ComputeHash(inputBytes);
            login_pass = BitConverter.ToString(hash).Replace("-", "");

            txtpass.Text = login_pass;

            Autentif(txtuser.Text, txtpass.Text);




            //if (txtuser.Text.Equals("admin") && txtpass.Text.Equals("admin1"))
            //{
            //    MessageBox.Show(" Bienvenido Administrador");
            //    SelectMenu sm = new SelectMenu();
            //    menuLogin menul = new menuLogin();
            //    sm.Show();
            //    this.Hide();

            //}
            //else
            //{
            //    if (txtuser.Text.Equals("conserje") && txtpass.Text.Equals("conserje1"))
            //    {
            //        MessageBox.Show(" Bienvenido Conserje");
            //        SelectMenuCon menuc = new SelectMenuCon();
            //        menuLogin menul = new menuLogin();
            //        menuc.Show();
            //        this.Hide();

            //    }
            //    else
            //    {
            //        MessageBox.Show("Revise sus credenciales e intenete nuevamente");

            //    }

            //}




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

                if (txtpass.Text == "CONTRASEÑA")
                {
                    txtpass.Text = "";
                    txtpass.ForeColor = System.Drawing.Color.DarkBlue;
                    //Error de Williams
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://iscav-web.com/");
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
