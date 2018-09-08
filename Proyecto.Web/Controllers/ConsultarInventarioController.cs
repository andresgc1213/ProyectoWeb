using System;
using System.Data;

namespace Proyecto.Web.Controllers
{
    public class ConsultarInventarioController
    
        //PRUEBA GIT
        /// <summary>
        /// Obtiene registro de consulta inventario
        /// </summary>
        /// <returns>datos de inventario</returns>
        public DataSet getConsultaInventarioController()
        {
            try
            {
                Logica.BL.clsConsultaInventario obclsInicioUsuario = new Logica.BL.clsConsultaInventario();
                return obclsInicioUsuario.getConsultaInventario();
            }
            catch (Exception ex) { throw ex; }
        }
        public string setAdministrarInventarioCotroller(Logica.Models.clsConsultarInventario obclsConsultarInventario,
                int inOpcion)
        {
            try
            {
                Logica.BL.clsConsultaInventario obclsConsultaInventario = new Logica.BL.clsConsultaInventario();
                return obclsConsultaInventario.setAdministrarInventario(obclsConsultarInventario, inOpcion);
            } catch (Exception ex) { throw ex; }
        }
    }
} 