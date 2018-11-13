using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class AccesoDatos
    {

        public int InsertEdificio(int id_edificio, string direccion, string nombre)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcInsertPropiedad();
            _comando.Parameters.AddWithValue("@id_edificio", id_edificio);
            _comando.Parameters.AddWithValue("@direccion", direccion);
            _comando.Parameters.AddWithValue("@ubicacion", nombre);
         
          

            return MetodosDatos.EjecutarComandoInsertEdificio(_comando);
        }

        public static DataTable ObtenerPropiedad()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM tbedificio";
            return MetodosDatos.EjecutarComandoSelect(_comando);
    
       }

        public static DataTable ObtenerAdmin()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "select * from tbdepto ";
            return MetodosDatos.EjecutarComandoSelect(_comando);

        }


        public int ModificarEdificio(int id_edificio, string direccion, string nombre)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcModPropiedad();
            _comando.Parameters.AddWithValue("@id_edificio", id_edificio);
            _comando.Parameters.AddWithValue("@direccion", direccion);
            _comando.Parameters.AddWithValue("@nombre", nombre);
  

      
            return MetodosDatos.EjecutarComandoModificarPropiedad(_comando);
        }

        public static DataTable EliminarPropiedad(int EliminarPropiedad)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "DELETE FROM tbedificio where id_edificio = " + EliminarPropiedad + "";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        public int InsertPropietario(int Id_propietario, string Nombre, string Apellido,string ApellidoM, int Edad, int Celular, DateTime Fecha_in,string Rut)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcInsertPropietario();

            _comando.Parameters.AddWithValue("@id_propietario", Id_propietario);
            _comando.Parameters.AddWithValue("@nombre", Nombre);
            _comando.Parameters.AddWithValue("@apellido", Apellido);
            _comando.Parameters.AddWithValue("@edad", Edad);
       
            _comando.Parameters.AddWithValue("@celular", Celular);

            _comando.Parameters.AddWithValue("@fecha_in", Fecha_in);
            _comando.Parameters.AddWithValue("@apellidoM", ApellidoM);
            _comando.Parameters.AddWithValue("@rut", Rut);

            return MetodosDatos.EjecutarComandoInsertPropietario(_comando);
        }

        public static DataTable ObtenerPersona()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM tbpersona";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }



        public int ModificarPropietario(int Id_propietario, string Nombre, string Apellido, string ApellidoM, int Edad, int Celular, DateTime Fecha_in, string Rut)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcModPropietario();
            _comando.Parameters.AddWithValue("@id_propietario", Id_propietario);
            _comando.Parameters.AddWithValue("@nombre", Nombre);
            _comando.Parameters.AddWithValue("@apellido", Apellido);
            _comando.Parameters.AddWithValue("@edad", Edad);

            _comando.Parameters.AddWithValue("@celular", Celular);

            _comando.Parameters.AddWithValue("@fecha_in", Fecha_in);
            _comando.Parameters.AddWithValue("@apellidoM", ApellidoM);
            _comando.Parameters.AddWithValue("@rut", Rut);
            return MetodosDatos.EjecutarComandoModificarPropietario(_comando);
        }

        public static DataTable EliminarPropietario(int faceid)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "DELETE FROM tbpersona where faceid = " + faceid + "";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        public int InsertResidente(int Id_residente, string Nombre, string ApellidoP, string ApellidoM, string Direccion, string Correo, int Telefono, int Rut, string Tipo_residente)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcInsResidente();
            _comando.Parameters.AddWithValue("@id_residente", Id_residente);
            _comando.Parameters.AddWithValue("@nombre", Nombre);
            _comando.Parameters.AddWithValue("@apellidoP", ApellidoP);
            _comando.Parameters.AddWithValue("@apellidoM", ApellidoM);
            _comando.Parameters.AddWithValue("@direccion", Direccion);
            _comando.Parameters.AddWithValue("@correo", Correo);
            _comando.Parameters.AddWithValue("@telefono", Telefono);
          
            _comando.Parameters.AddWithValue("@rut", Rut);
            _comando.Parameters.AddWithValue("@tipo_residente", Tipo_residente);



            return MetodosDatos.EjecutarComandoInsertResidente(_comando);
        }

        public int InsertEnrola(string Nombre, string Faceurl)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcInsertEnrola();

            _comando.Parameters.AddWithValue("@nombre", Nombre);
            _comando.Parameters.AddWithValue("@faceurl", Faceurl);
        

            return MetodosDatos.EjecutarComandoInsertEnrola(_comando);
        }

        public int ValidaEnrol()
        {
            SqlCommand _comando = MetodosDatos.CrearComandoValidaUser();

            //_comando.Parameters.AddWithValue("@nombre", Nombre);
            //_comando.Parameters.AddWithValue("@faceurl", Faceurl);


            return MetodosDatos.EjecutarComandoValidaUser(_comando);
        }

        public static DataTable ObtenerResidente()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM tbresidente";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

        public static DataTable ObtenerUrl(string faceurl)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM TBFACE where faceurl =" + faceurl;
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }


        public static DataTable ValidaUser(string user, string pass)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT user,pass FROM tblogin where user = " + user +" AND pass = " + pass +"";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }


        public int ModificarResidente(int Id_residente, string Nombre, string ApellidoP, string ApellidoM, string Direccion, string Correo, int Telefono, int Rut, string Tipo_residente)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcModResidente();
            _comando.Parameters.AddWithValue("@id_residente", Id_residente);
            _comando.Parameters.AddWithValue("@nombre", Nombre);
            _comando.Parameters.AddWithValue("@apellidoP", ApellidoP);
            _comando.Parameters.AddWithValue("@apellidoM", ApellidoM);
            _comando.Parameters.AddWithValue("@direccion", Direccion);
            _comando.Parameters.AddWithValue("@correo", Correo);
            _comando.Parameters.AddWithValue("@telefono", Telefono);

            _comando.Parameters.AddWithValue("@rut", Rut);
            _comando.Parameters.AddWithValue("@tipo_residente", Tipo_residente);
            return MetodosDatos.EjecutarComandoModificarResidente(_comando);
        }


        public static DataTable EliminarResidente(int EliminarResidente)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "DELETE FROM tbresidente where id_residente = " + EliminarResidente + "";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }



        public int InsertVisita(int Id_visita, DateTime Fecha_in, DateTime Fecha_sal,int id_propiedad, int id_residente)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcInsertVisita();

            _comando.Parameters.AddWithValue("@id_visita", Id_visita);
          
            _comando.Parameters.AddWithValue("@fecha_in", Fecha_in);
            _comando.Parameters.AddWithValue("@fecha_sal", Fecha_sal);
            _comando.Parameters.AddWithValue("@id_propiedad", Fecha_in);
            _comando.Parameters.AddWithValue("@id_residente", Fecha_sal);


            return MetodosDatos.EjecutarComandoInsertVisita(_comando);
        }

        public static DataTable ObtenerVisita()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "SELECT * FROM tbvisita";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }



        public int ModificarVisita(int Id_visita, DateTime Fecha_in, DateTime Fecha_sal, int id_propiedad, int id_residente)
        {
            SqlCommand _comando = MetodosDatos.CrearComandoProcModVisita();
            _comando.Parameters.AddWithValue("@id_visita", Id_visita);

            _comando.Parameters.AddWithValue("@fecha_in", Fecha_in);
            _comando.Parameters.AddWithValue("@fecha_sal", Fecha_sal);
            _comando.Parameters.AddWithValue("@id_propiedad", Fecha_in);
            _comando.Parameters.AddWithValue("@id_residente", Fecha_sal);

            return MetodosDatos.EjecutarComandoModificarVisita(_comando);
        }

        public static DataTable EliminarVisita(int EliminarVisita)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "DELETE FROM tbvisita where id_visita = " + EliminarVisita + "";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }









    }

}
