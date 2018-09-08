using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Proyecto.Test
{
    [TestClass]
    public class clsTBUsuarios
    {
        [TestMethod]
        public void createUsuarioTest()
        {
            try
            {
                //Arrange
                wsServicios.wsServicios obwsServicios = new wsServicios.wsServicios();

                //Act
                Logica.Models.clsTBUsuario obclsTBUsuario = new Logica.Models.clsTBUsuario
                {
                    Nombre = "Prueba",
                    Apellido = "Test",
                    Correo = "PruebaTs@Gmail.com",
                    Telefono = 1345454,
                    Contraseña = "prueba123",
                    TipoUsuario = new Logica.Models.clsTBTipoUsuario
                    {
                        IdTpUsu = 1
                    }
                };

                string Json = JsonConvert.SerializeObject(obclsTBUsuario);

                //Assert
                obwsServicios.createUsuarioWS(Json);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
