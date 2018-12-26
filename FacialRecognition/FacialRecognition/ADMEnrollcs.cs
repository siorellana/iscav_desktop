using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
<<<<<<< HEAD
using FacialRecognition;
=======
>>>>>>> e74c1d05333b30f10652cf8b35a6f4b05167b7dc
using Iscav1;

namespace FacialRecognition
{
    public partial class ADMEnrollcs : Form
    {
        public ADMEnrollcs()
        {
            InitializeComponent();
        }

        //AGREGAR EL SIGUIENTE USING
        //using System.Security.Cryptography;

        //string login_pass = textBox3.Text;
        //MD5 md5 = MD5.Create();
        //byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
        //byte[] hash = md5.ComputeHash(inputBytes);
        //login_pass = BitConverter.ToString(hash).Replace("-", "");
        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (txtcontraseña.Text == txtconcontraseña.Text)
                {
                    // Objetos de conexión y comando
                    System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                    // Estableciento propiedades
                    cmd.Connection = conn;
                    cmd.CommandText = "INSERT INTO tbusers VALUES (@NOMBRE,@CONTRASEÑA, @TIPOUSER)";

                    // Creando los parámetros necesarios
                    
                    cmd.Parameters.Add("@NOMBRE", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@CONTRASEÑA", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@TIPOUSER", System.Data.SqlDbType.NVarChar);


                    string login_pass = txtcontraseña.Text;
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                    byte[] hash = md5.ComputeHash(inputBytes);
                    login_pass = BitConverter.ToString(hash).Replace("-", "");

                    txtcontraseña.Text = login_pass;
                    // Asignando los valores a los atributos
                    cmd.Parameters["@NOMBRE"].Value = txtnombre.Text;
                   cmd.Parameters["@CONTRASEÑA"].Value = txtcontraseña.Text;
                    cmd.Parameters["@TIPOUSER"].Value = cbotipo.Text;



                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se agrego nuevo User.");
                    conn.Close();
                }
               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



           





            //lblFaceID.Text = null;
            //boxDepto.Text = null;
            //boxNombre.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtcontraseña.Text == txtconcontraseña.Text)
                {
                    // Objetos de conexión y comando
                    System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                    // Estableciento propiedades
                    cmd.Connection = conn;
                    cmd.CommandText = "update tbusers set NOMBRE=@NOMBRE, CONTRASEÑA=@CONTRASEÑA, TIPOUSER=@TIPOUSER where NOMBRE=@NOMBRE";

                    // Creando los parámetros necesarios

                    cmd.Parameters.Add("@NOMBRE", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@CONTRASEÑA", System.Data.SqlDbType.NVarChar);
                    cmd.Parameters.Add("@TIPOUSER", System.Data.SqlDbType.NVarChar);


                    string login_pass = txtcontraseña.Text;
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                    byte[] hash = md5.ComputeHash(inputBytes);
                    login_pass = BitConverter.ToString(hash).Replace("-", "");

                    txtcontraseña.Text = login_pass;
                    // Asignando los valores a los atributos
                    cmd.Parameters["@NOMBRE"].Value = txtnombre.Text;
                    cmd.Parameters["@CONTRASEÑA"].Value = txtcontraseña.Text;
                    cmd.Parameters["@TIPOUSER"].Value = cbotipo.Text;



                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se Modifico  Usuario.");
                    conn.Close();
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text == "" || txtcontraseña.Text == "" )
                {
                    MessageBox.Show("Ingrese usuario y contraseña para eliminar");

                }
                else
                {
                  
                        // Objetos de conexión y comando
                        System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection((@"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True"));
                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


                        // Estableciento propiedades
                        cmd.Connection = conn;
                        cmd.CommandText = "DELETE from tbusers where NOMBRE =@NOMBRE and CONTRASEÑA =@CONTRASEÑA";


                        // Creando los parámetros necesarios
                        cmd.Parameters.Add("@NOMBRE", System.Data.SqlDbType.VarChar);
                        cmd.Parameters.Add("@CONTRASEÑA", System.Data.SqlDbType.VarChar);

                    string login_pass = txtcontraseña.Text;
                    MD5 md5 = MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                    byte[] hash = md5.ComputeHash(inputBytes);
                    login_pass = BitConverter.ToString(hash).Replace("-", "");

                    txtcontraseña.Text = login_pass;


                    cmd.Parameters["@NOMBRE"].Value = txtnombre.Text;
                    cmd.Parameters["@CONTRASEÑA"].Value =txtcontraseña.Text;


                    conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    MessageBox.Show("Se Elimino a usuario " + txtnombre.Text);


                    }



                

            }
            catch (Exception EX)
            {
                MessageBox.Show("No se logro eliminar Persona" + EX);
               
            }

        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "NOMBRE")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = System.Drawing.Color.DarkBlue;
            }

        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "NOMBRE";
                txtnombre.ForeColor = System.Drawing.Color.DimGray;

            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {
                
                txtcontraseña.Text = "";
                txtcontraseña.PasswordChar = '*';

                txtcontraseña.ForeColor = System.Drawing.Color.DarkBlue;
            }
        }

        private void txtconcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtconcontraseña.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtconcontraseña.Text = "";
                txtconcontraseña.PasswordChar = '*';
                txtconcontraseña.ForeColor = System.Drawing.Color.DarkBlue;
            }
        
    }

        private void txtconcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtconcontraseña.Text == "" || txtconcontraseña.Text == "*")
            {

                txtconcontraseña.Text = "CONFIRMAR CONTRASEÑA";
                txtconcontraseña.ForeColor = System.Drawing.Color.DimGray;

            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtconcontraseña.Text == "" || txtconcontraseña.Text == "*")
            {
                txtconcontraseña.Text = "CONTRASEÑA";
                txtconcontraseña.ForeColor = System.Drawing.Color.DimGray;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            SelectMenu adm = new SelectMenu();

            adm.Show();
            
=======
            SelectMenu login = new SelectMenu();
            login.Show();
>>>>>>> e74c1d05333b30f10652cf8b35a6f4b05167b7dc
            this.Hide();
        }
    }
}
