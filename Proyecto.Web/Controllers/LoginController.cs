using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Web.Controllers
{
    public class LoginController
    {/// <summary>
    /// Valida el usuario
    /// </summary>
    /// <param name="obclsUsuarios"> Objeto usuario</param>
    /// <returns>Confirmacion de usuario</returns>
        public bool getValidarUsuarioController(Logica.Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                Logica.BL.clsInicioUsuario obclsInicioUsuario = new Logica.BL.clsInicioUsuario();
                return obclsInicioUsuario.getValidarUsuario(obclsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }

    }
}