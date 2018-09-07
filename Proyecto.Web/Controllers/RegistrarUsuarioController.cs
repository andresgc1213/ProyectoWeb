using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Web.Controllers
{
    public class RegistrarUsuarioController
    {
        public string setUsuarioController(Logica.Models.clsUsuarios obclsUsuarioModels)
        {
            try
            {
                Logica.BL.clsInicioUsuario obclsInicioUsuario = new Logica.BL.clsInicioUsuario();
                return obclsInicioUsuario.setUsuario(obclsUsuarioModels);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}