using Newtonsoft.Json;
using System.Web.Services;

namespace Proyecto.Ws.Servicios
{
    /// <summary>
    /// Descripción breve de wsServicios
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsServicios : System.Web.Services.WebService
    {

        [WebMethod]
        public string getUsuariosWS()
        {
            Logica.BL.clsTBUsuario obclsTBUsuario = new Logica.BL.clsTBUsuario();
            return JsonConvert.SerializeObject(obclsTBUsuario.getTBUsuario());
        }

        [WebMethod]
        public void createUsuarioWS(string stclsTBUsuario)
        {
            Logica.BL.clsTBUsuario obclsTBUsuario = new Logica.BL.clsTBUsuario();
            Logica.Models.clsTBUsuario obclsTBUsuarioModel = JsonConvert.DeserializeObject<Logica.Models.clsTBUsuario>(stclsTBUsuario);
            obclsTBUsuario.createUsuario(obclsTBUsuarioModel);
        }
    }
}
