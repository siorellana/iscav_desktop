using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class MetodosDatos
    {



       public static SqlCommand CrearComando()
       {
           string _cadenaConexion = Configuracion.CadenaConexion;
           SqlConnection _connection = new SqlConnection();
           _connection.ConnectionString = _cadenaConexion;
           SqlCommand _comando = new SqlCommand();
           _comando = _connection.CreateCommand();
           _comando.CommandType = CommandType.Text;
           return _comando;
       }

        public static int EjecutarComandoInsertEdificio(SqlCommand comandoInsProp)
        {
            try
            {
                comandoInsProp.Connection.Open();
                return comandoInsProp.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {

                comandoInsProp.Connection.Dispose();
                comandoInsProp.Connection.Close();
            }

        }


        public static SqlCommand CrearComandoProcInsertPropiedad()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand comandoInsProp = new SqlCommand("insPropiedad", _connection);
            comandoInsProp.CommandType = CommandType.StoredProcedure;
            return comandoInsProp;
        }



        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable _tabla = new DataTable();

            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);

            }
            catch (Exception ex)
            { throw ex; }
            finally
            { comando.Connection.Close(); }
            return _tabla;

        }

        public static int EjecutarComandoModificarPropiedad(SqlCommand comandoModH)
        {
            try
            {
                comandoModH.Connection.Open();
                return comandoModH.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoModH.Connection.Dispose();
                comandoModH.Connection.Close();
            }
        }

        public static SqlCommand CrearComandoProcModPropiedad()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoModH = new SqlCommand("modPropiedad", _connection);
            _comandoModH.CommandType = CommandType.StoredProcedure;
            return _comandoModH;
        }



        public static SqlCommand CrearComandoProcInsertPropietario()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("insPropietario", _connection);
            _comando.CommandType =
                CommandType.StoredProcedure;
            return _comando;
        }



        public static SqlCommand CrearComandoProcInsertEnrola()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoInsE = new SqlCommand("insEnrola", _connection);
            _comandoInsE.CommandType = CommandType.StoredProcedure;
            return _comandoInsE;
        }

        public static SqlCommand CrearComandoValidaUser()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoValidaU = new SqlCommand("validaUser", _connection);
            _comandoValidaU.CommandType = CommandType.StoredProcedure;
            return _comandoValidaU;
        }

        public static int EjecutarComandoValidaUser(SqlCommand comandoValidaU)
        {
            try
            {
                comandoValidaU.Connection.Open();
                return comandoValidaU.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {

                comandoValidaU.Connection.Dispose();
                comandoValidaU.Connection.Close();
            }

        }






        public static int EjecutarComandoInsertEnrola(SqlCommand comandoInsE)
        {
            try
            {
                comandoInsE.Connection.Open();
                return comandoInsE.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {

                comandoInsE.Connection.Dispose();
                comandoInsE.Connection.Close();
            }

        }


        public static int EjecutarComandoInsertPropietario(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {

                comando.Connection.Dispose();
                comando.Connection.Close();
            }

        }

        public static int EjecutarComandoModificarPropietario(SqlCommand comandoMod)
        {
            try
            {
                comandoMod.Connection.Open();
                return comandoMod.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoMod.Connection.Dispose();
                comandoMod.Connection.Close();
            }
        }

        public static SqlCommand CrearComandoProcModPropietario()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoMod = new SqlCommand("modPropietario", _connection);
            _comandoMod.CommandType = CommandType.StoredProcedure;
            return _comandoMod;
        }

        public static SqlCommand CrearComandoProcDeletepropietario()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoDel = new SqlCommand("delPropietario", _connection);
            _comandoDel.CommandType = CommandType.StoredProcedure;
            return _comandoDel;
        }


        public static SqlCommand CrearComandoProcInsResidente()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoR = new SqlCommand("insResidente", _connection);
            _comandoR.CommandType = CommandType.StoredProcedure;
            return _comandoR;
        }

        public static int EjecutarComandoInsertResidente(SqlCommand comandoR)
        {
            try
            {
                comandoR.Connection.Open();
                return comandoR.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {

                comandoR.Connection.Dispose();
                comandoR.Connection.Close();
            }

        }





        public static SqlCommand CrearComandoProcModResidente()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoModR = new SqlCommand("modResidente", _connection);
            _comandoModR.CommandType = CommandType.StoredProcedure;
            return _comandoModR;
        }

        public static int EjecutarComandoModificarResidente(SqlCommand comandoModR)
        {
            try
            {
                comandoModR.Connection.Open();
                return comandoModR.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoModR.Connection.Dispose();
                comandoModR.Connection.Close();
            }
        }

        public static SqlCommand CrearComandoProcDeleteResidente()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoDelR = new SqlCommand("delResidente", _connection);
            _comandoDelR.CommandType = CommandType.StoredProcedure;
            return _comandoDelR;
        }





        public static SqlCommand CrearComandoProcInsertVisita()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoHab = new SqlCommand("insVisita", _connection);
            _comandoHab.CommandType = CommandType.StoredProcedure;
            return _comandoHab;
        }

        public static int EjecutarComandoInsertVisita(SqlCommand comandoHab)
        {
            try
            {
                comandoHab.Connection.Open();
                return comandoHab.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {

                comandoHab.Connection.Dispose();
                comandoHab.Connection.Close();
            }

        }


        public static SqlCommand CrearComandoProcModVisita()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoModVisita = new SqlCommand("modVisita", _connection);
            _comandoModVisita.CommandType = CommandType.StoredProcedure;
            return _comandoModVisita;
        }

        public static int EjecutarComandoModificarVisita(SqlCommand comandoModHab)
        {
            try
            {
                comandoModHab.Connection.Open();
                return comandoModHab.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comandoModHab.Connection.Dispose();
                comandoModHab.Connection.Close();
            }
        }

        public static SqlCommand CrearComandoProcDeleteVisita()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _connection = new SqlConnection(_cadenaConexion);
            SqlCommand _comandoDelHab = new SqlCommand("delVisita", _connection);
            _comandoDelHab.CommandType = CommandType.StoredProcedure;
            return _comandoDelHab;
        }






    }
}
