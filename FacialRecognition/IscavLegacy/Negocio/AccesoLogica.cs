using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Datos;

namespace FacialRecognition
{
    public class AccesoLogica
    {
        public static DataTable ObtenerPropiedad()
        {
            return AccesoDatos.ObtenerPropiedad();
        }

        public static DataTable ObtenerAdmin()
        {
            return AccesoDatos.ObtenerAdmin();
        }

        //public int ValidaUser()
        //{
        //    return AccesoDatos.ValidaUser("user","pass");
        //}

        public static DataTable ObtenerUrl(string faceurl)
        {
        
            return AccesoDatos.ObtenerUrl(faceurl);
        }




        public int InsertEdificio(int id_edificio, string direccion, string nombre)
        {
            AccesoDatos acceso = new AccesoDatos();
            return InsertEdificio(id_edificio, direccion, nombre);
        }

        public int ModificarEdificio(int id_edificio, string direccion, string nombre)
        {
            AccesoDatos acceso = new AccesoDatos();
            return ModificarEdificio(id_edificio, direccion, nombre);
        }


        /* public static DataTable ObtenerPersona()
         {

            // return AccesoDatos.ObtenerPersona();
         }*/

        public int InsertPropietario(int Id_propietario, string Nombre, string Apellido, string ApellidoM, int Edad, int Celular, DateTime Fecha_in, string Rut)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertPropietario(Id_propietario, Nombre, Apellido, ApellidoM, Edad, Celular, Fecha_in, Rut);
        }

        public int ModificarPropietario(int Id_propietario, string Nombre, string Apellido, string ApellidoM, int Edad, int Celular, DateTime Fecha_in, string Rut)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.ModificarPropietario(Id_propietario, Nombre, Apellido, ApellidoM, Edad, Celular, Fecha_in, Rut);
        }


        public static DataTable ObtenerResidente()
        {
            return AccesoDatos.ObtenerResidente();
        }




        public int InsertResidente(int Id_residente, string Nombre, string ApellidoP, string ApellidoM, string Direccion, string Correo, int Telefono, int Rut, string Tipo_residente)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertResidente(Id_residente, Nombre, ApellidoP, ApellidoM, Direccion, Correo, Telefono, Rut, Tipo_residente);
        }



        public int InsertEnrola(string Nombre, string Faceurl)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.InsertEnrola(Nombre,Faceurl);

        }

        public int ValidaEnrola()
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.ValidaEnrol();

        }






        //public int ModificarResidente(int Id_residente, string Nombre, string ApellidoP, string ApellidoM, string Direccion, string Correo, int Telefono, int Rut, string Tipo_residente)
        //{
        //    AccesoDatos acceso = new AccesoDatos();
        //    return acceso.ModificarResidente(Id_residente, Nombre, ApellidoP, ApellidoM, Direccion, Correo, Telefono, Rut, Tipo_residente)
        //    ;
        //}




        //public static DataTable ObtenerVisita()
        //{
        //    return AccesoDatos.ObtenerVisita();
        //}


        //public int InsertVisita(int Id_visita, DateTime Fecha_in, DateTime Fecha_sal, int id_propiedad, int id_residente)
        //{
        //    AccesoDatos acceso = new AccesoDatos();
        //    return acceso.InsertVisita(Id_visita, Fecha_in, Fecha_sal, id_propiedad, id_residente);
        //}


        //public int ModificarVisita(int Id_visita, DateTime Fecha_in, DateTime Fecha_sal, int id_propiedad, int id_residente)
        //{
        //    AccesoDatos acceso = new AccesoDatos();
        //    return acceso.ModificarVisita(Id_visita, Fecha_in, Fecha_sal, id_propiedad, id_residente);
        //}

        //SqlConnection cn;
        //SqlCommand cmd;
        //SqlDataReader dr;

        //public string InsertarEnrola(string nombre, string faceurl)
        //{
        //    string salida = "se inserto";
        //    try
        //    {
        //        //cmd = new SqlCommand("insert into TBFaces(nombre,faceurl,userid) values('"+nombre+"',' " +faceurl+ "','" +userid+"') ",cn);
        //        //cmd.ExecuteNonQuery();
        //        //MessageBox.Show("Se inserto");

        //        cmd = new SqlCommand("insert into TBFACE(nombre,faceurl) values(@nombre,@faceurl)", cn);
        //        cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
        //        cmd.Parameters.Add("@faceurl", SqlDbType.VarChar);
        //        //cmd.Parameters.Add("@userid",SqlDbType.Int);


        //        cmd.Parameters["@nombre"].Value = nombre;
        //        //System.IO.MemoryStream ms = new System.IO.MemoryStream();
        //        //faceurl.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Bmp);

        //        cmd.Parameters["@faceurl"].Value = faceurl; //ms.GetBuffer();
        //                                                    // cmd.Parameters["@userid"].Value = userid;
        //        cmd.ExecuteNonQuery();
        //        MessageBox.Show("Se inserto");

        //    }
        //    catch (Exception ex)
        //    {

        //        salida = "no se conecto" + ex.ToString();
        //        MessageBox.Show("Fallo" + ex);
        //        cn.Close();

        //    }
        //    return salida;
        //}








    }
    
}
