using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsInicioUsuario
    {

        SqlConnection _SqlConnection = null; //Me permite establecer comunicacion con BD
        SqlCommand _SqlCommand = null; //Me permite ejecutar conmandos SQL
        SqlDataAdapter _SqlDataAdapter = null; //Me permite adaptar un conjunto de datos SQL
        string stConexion = string.Empty;//Cadena de conexion

        SqlParameter _SqlParameter = null;

        public clsInicioUsuario()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }
        /// <summary>
        /// Validar usuario
        /// </summary>
        /// <param name="obclsUsuarios">Objeto usuario</param>
        /// <returns>confirmacion de consulta</returns>
        public bool getValidarUsuario(Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultaUsuario", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@cUsuario", obclsUsuarios.stUsuario));
                _SqlCommand.Parameters.Add(new SqlParameter("@cContraseña", obclsUsuarios.stContraseña));

                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                if (dsConsulta.Tables[0].Rows.Count > 0) return true;
                else return false;
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlConnection.Close(); }
        }

        /// <summary>
        /// ADministrar registro usuario
        /// </summary>
        /// <returns>Mensaje de proceso</returns>
        public string setUsuario(Models.clsUsuarios ob)
        {
            try
            {
                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spRegistrarUsuario", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@cNombre", ob.stNombre));
                _SqlCommand.Parameters.Add(new SqlParameter("@cApellido", ob.stApellido));
                _SqlCommand.Parameters.Add(new SqlParameter("@cCorreo", ob.stUsuario));
                _SqlCommand.Parameters.Add(new SqlParameter("@cContraseña", ob.stContraseña));
                _SqlCommand.Parameters.Add(new SqlParameter("@cTelefono", ob.inTelefono));
                _SqlCommand.Parameters.Add(new SqlParameter("@cTipoUsuario", "1"));

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
