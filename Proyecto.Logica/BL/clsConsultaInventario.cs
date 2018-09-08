using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsConsultaInventario
    {
        SqlConnection _SqlConnection = null; //Me permite establecer comunicacion con BD
        SqlCommand _SqlCommand = null; //Me permite ejecutar conmandos SQL
        SqlDataAdapter _SqlDataAdapter = null; //Me permite adaptar un conjunto de datos SQL
        string stConexion = string.Empty;//Cadena de conexion

        SqlParameter _SqlParameter = null;

        public clsConsultaInventario()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        public DataSet getConsultaInventario()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarInventario", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;
                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }

        public string setAdministrarInventario(Models.clsConsultarInventario obclsConsultarInventario, int inOpcion)
        {
            try
            {
                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spAdministrarInventario", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;
                
                _SqlCommand.Parameters.Add(new SqlParameter("@cNombre", obclsConsultarInventario.stNombre));
                _SqlCommand.Parameters.Add(new SqlParameter("@nCantidad", obclsConsultarInventario.inCantidad));
                _SqlCommand.Parameters.Add(new SqlParameter("@nValor", obclsConsultarInventario.inValor));
                _SqlCommand.Parameters.Add(new SqlParameter("@nProveedor", obclsConsultarInventario.inProveedor));
                _SqlCommand.Parameters.Add(new SqlParameter("@nTipo", obclsConsultarInventario.inTipo));
                _SqlCommand.Parameters.Add(new SqlParameter("@nOpcion", inOpcion));

                _SqlCommand.ExecuteNonQuery();

                _SqlParameter = new SqlParameter();
                _SqlParameter.ParameterName = "@cMensaje";
                _SqlParameter.Direction = ParameterDirection.Output;
                _SqlParameter.SqlDbType = SqlDbType.VarChar;
                _SqlParameter.Size = 50;

                _SqlCommand.Parameters.Add(_SqlParameter);
                _SqlCommand.ExecuteNonQuery();

                return _SqlParameter.Value.ToString();
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }
    }
}
