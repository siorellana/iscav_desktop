using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
   public class Propiedad
    {

        public int Id_propiedad { get; set; }
        public string Direccion { get; set; }
        public string Ubicacion { get; set; }
        public string Estado { get; set; }
        public string Id_propietario { get; set; }
        public string Id_residente { get; set; }
        public int Id_visita { get; set; }
        public int Cobros { get; set; }
        public string Pago { get; set; }
    }
}
