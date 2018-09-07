using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.Models
{
    public class clsTBProducto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }
        public int Proveedor { get; set; }
        public int Tipo { get; set; }
    }
}
