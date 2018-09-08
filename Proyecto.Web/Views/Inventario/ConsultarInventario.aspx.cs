using System;
using System.Data;

namespace Proyecto.Web.Views.Inventario
{
    public partial class ConsultarInventario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Controllers.ConsultarInventarioController obConsultarInventarioController =
                        new Controllers.ConsultarInventarioController();
                    DataSet dsConsulta = obConsultarInventarioController.getConsultaInventarioController();

                    if (dsConsulta.Tables[0].Rows.Count > 0) gvwDatos.DataSource = dsConsulta;
                    else gvwDatos.DataSource = null;

                    gvwDatos.DataBind();
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
                }
            }
        }

        protected void gvwDatos_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            try
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);
                if (e.CommandName.Equals("Editar"))
                {
                    
                } else if (e.CommandName.Equals("Eliminar"))
                {

                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Mesaje", "<Script> swal('ERROR!', '" + ex.Message + "!', 'error')</Script>");
            }
        }
    }
}