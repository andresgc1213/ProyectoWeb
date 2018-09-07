using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.Registrar_Usuario
{
    public partial class RegistrarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('Bienvenido!', 'Completa los campos para registrarte!', 'info')</Script>");
        }

        protected void btnRegistrarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtNombre.Text)) stMensaje += "Ingrese Nombre,";
                if (string.IsNullOrEmpty(txtApellido.Text)) stMensaje += "Ingrese Apellido,";
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese Correo,";
                if (string.IsNullOrEmpty(txtContraseña.Text)) stMensaje += "Ingrese Contraseña,";
                if (string.IsNullOrEmpty(txtConfirmarContraseña.Text)) stMensaje += "Confirme la contraseña,";
                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }

        }
    }
}