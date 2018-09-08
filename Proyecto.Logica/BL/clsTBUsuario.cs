using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Logica.BL
{
    public class clsTBUsuario
    {
        public List<Models.clsTBUsuario> getTBUsuario()
        {
            try
            {
                using (Entidades.proyeIntEntities obDatos = new Entidades.proyeIntEntities())
                {
                    List<Models.clsTBUsuario> lstclsTBUsuario = (from q in obDatos.Usuario
                                                                 select new Models.clsTBUsuario
                                                                 {
                                                                     Nombre = q.Nombre,
                                                                     Apellido = q.Apellido,
                                                                     Correo = q.Correo,
                                                                     Contraseña = q.Contraseña,
                                                                     Telefono = q.Telefono,
                                                                     TipoUsuario = new Models.clsTBTipoUsuario
                                                                     {
                                                                         IdTpUsu = q.Id_Usuario
                                                                     }
                                                                 }).ToList();
                    return lstclsTBUsuario;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        public void createUsuario(Models.clsTBUsuario obclsTBUsuario)
        {
            try
            {
                using (Entidades.proyeIntEntities obDatos = new Entidades.proyeIntEntities())
                {
                    obDatos.Usuario.Add(new Entidades.Usuario
                    {
                        Nombre = obclsTBUsuario.Nombre,
                        Apellido = obclsTBUsuario.Apellido,
                        Correo = obclsTBUsuario.Correo,
                        Contraseña = obclsTBUsuario.Contraseña,
                        Telefono = obclsTBUsuario.Telefono,
                        Tipo_Usuario = obclsTBUsuario.TipoUsuario.IdTpUsu
                    });
                    obDatos.SaveChanges();

                }
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
