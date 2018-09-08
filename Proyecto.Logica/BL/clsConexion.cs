using System.Configuration;

namespace Proyecto.Logica.BL
{
    public class clsConexion
    {
    /// <summary>
    /// Clase Para conectar a base de datos
    /// </summary>
    /// <returns>Obtiene cadena de conexion (ConnectionStrings)</returns>
        public string getConexion ()
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
