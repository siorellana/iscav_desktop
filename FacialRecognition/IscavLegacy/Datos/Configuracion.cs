using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
   public class Configuracion
    {

        private static string cadenaConexion = @"Data Source=localhost;Initial Catalog=dbprod;Trusted_Connection =True";
        
        // @"Data Source=sharkwilliams\sqlexpress;Initial Catalog=iscavDB;User ID=sa;Password=W1ll1@m$";

        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
