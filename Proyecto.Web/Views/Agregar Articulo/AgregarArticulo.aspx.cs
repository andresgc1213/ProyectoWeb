using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.Agregar_Articulo
{
    public partial class AgregarArticulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
         {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtNombre.Text)) stMensaje += "Ingrese Nombre,";
                if (string.IsNullOrEmpty(txtProveedor.Text)) stMensaje += "Ingrese Proveedor,";
                if (string.IsNullOrEmpty(txtCantidad.Text)) stMensaje += "Ingrese Cantidad,";
                if (string.IsNullOrEmpty(txtTipo.Text)) stMensaje += "Ingrese Tipo,";
                if (string.IsNullOrEmpty(txtValor.Text)) stMensaje += "Ingrese Valor,";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                Logica.Models.clsConsultarInventario obclsConsultarInventario = new Logica.Models.clsConsultarInventario
                {
                    stNombre = txtNombre.Text,
                    inCantidad = Convert.ToInt32(txtCantidad.Text),
                    inValor = Convert.ToInt32(txtValor.Text),
                    inProveedor = Convert.ToInt32(txtProveedor.Text),
                    inTipo = Convert.ToInt32(txtTipo.Text)
                };

                Controllers.ConsultarInventarioController obConsultarInventarioController = new Controllers.ConsultarInventarioController();

                if (string.IsNullOrEmpty(lblOpcion.Text)) lblOpcion.Text = "1";

                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('CORRECTO!', '" + 
                obConsultarInventarioController.setAdministrarInventarioCotroller(obclsConsultarInventario,Convert.ToInt32(lblOpcion.Text))
                + "!', 'error')</Script>");

            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}