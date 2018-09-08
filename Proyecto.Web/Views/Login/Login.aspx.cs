using System;

namespace Proyecto.Web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Bienvenido!','Completa los campos para iniciar sesion','info')</script>");
        }

        protected void btnInicioSesion_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtUsuario.Text)) stMensaje += "Ingrese Email,";
                if (string.IsNullOrEmpty(txtContraseña.Text)) stMensaje += "Ingrese Contraseña,";
                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

//                Defino Objeto con propiedades
                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    stUsuario = txtUsuario.Text,
                    stContraseña = txtContraseña.Text

                };
                    //Instancio Controlador
                Controllers.LoginController obLogingController = new Controllers.LoginController();
                bool blBandera = obLogingController.getValidarUsuarioController(obclsUsuarios);

                if (blBandera)
                {
                    /**if (chkRecordar.Checked)
                    {
                        //Creo el objeto cookie
                        HttpCookie Cookie = new HttpCookie("CookieUsuario", txtUser.Text);
                        //Defino tiempo de vida
                        Cookie.Expires = DateTime.Now.AddDays(2);
                        //Agrego a la colecion de cookies
                        Response.Cookies.Add(Cookie);
                    }
                    else
                    {
                        HttpCookie Cookie = new HttpCookie("CookieUsuario", txtUser.Text);
                        //Cookie expira ayer (Fecha de hoy menos 1 dia)
                        Cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(Cookie);
                    } **/
                    Session["SessionUser"] = txtUsuario.Text;
                    Response.Redirect("../Index/Index.aspx");//Redirecciono
                }
                else
                    throw new Exception("Usuario o password incorrectos");
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}