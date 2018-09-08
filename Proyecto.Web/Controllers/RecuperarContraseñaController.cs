using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Proyecto.Web.Controllers
{
    public class RecuperarContraseñaController
    {
        public DataSet getRecuperarContraseñaController(Logica.Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                Logica.BL.clsRecuperarContraseña obclsRecuperarContraseña = new Logica.BL.clsRecuperarContraseña();
                return obclsRecuperarContraseña.getConsultarContraseña(obclsUsuarios);

            }
            catch (Exception ex) { throw ex; }
        }
        public void SendCorreoController(Logica.Models.clsCorreo obclsCorreo)
        {
            try
            {
                Logica.BL.clsGeneral obclsGeneral = new Logica.BL.clsGeneral();
                obclsGeneral.SendCorreo(obclsCorreo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}