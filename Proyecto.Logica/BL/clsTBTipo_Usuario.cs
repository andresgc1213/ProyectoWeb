using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.Logica.BL
{
    public class clsTBTipo_Usuario
    {
        public List<Models.clsTBTipoUsuario> getTBTipoUsuario()
        {
            try
            {
                using (Entidades.proyeIntEntities obDatos = new Entidades.proyeIntEntities())
                {
                    List<Models.clsTBTipoUsuario> lstclsTBTipoUsuario = (from q in obDatos.Tipo_Usuario
                                                                        select new Models.clsTBTipoUsuario
                                                                        {
                                                                            IdTpUsu = q.Id_TpUsu,
                                                                            Descripcion = q.Descripcion
                                                                        }).ToList();
                    return lstclsTBTipoUsuario;
                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
