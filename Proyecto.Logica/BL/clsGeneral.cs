using System;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace Proyecto.Logica.BL
{
    public class clsGeneral
    {
        public void SendCorreo(Models.clsCorreo obclsCorreo)
        {
            try
            {
                //Objeto del correo
                System.Net.Mail.MailMessage Correo = new MailMessage();

                Correo.From = new System.Net.Mail.MailAddress(obclsCorreo.stDesdeCorreo);
                Correo.To.Add(obclsCorreo.stParaCorreo);
                Correo.Subject = obclsCorreo.stAsunto;
                Correo.Body = obclsCorreo.stMensaje;

                if (obclsCorreo.inTipo == 0) Correo.IsBodyHtml = false;
                else if (obclsCorreo.inTipo == 1) Correo.IsBodyHtml = true;

                if (obclsCorreo.inPrioridad == 2) Correo.Priority = MailPriority.High;
                else if (obclsCorreo.inPrioridad == 1) Correo.Priority = MailPriority.Low;
                else if (obclsCorreo.inPrioridad == 0) Correo.Priority = MailPriority.Normal;

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(obclsCorreo.stMensaje, Encoding.UTF8,
                    MediaTypeNames.Text.Html);

                LinkedResource Img = new LinkedResource(obclsCorreo.stImagen, MediaTypeNames.Image.Jpeg);
                Img.ContentId = obclsCorreo.stIdImagen;
                htmlView.LinkedResources.Add(Img);
                //Para agregar imagen de encabezado al correo


                //Cliente del servidor del correo
                SmtpClient smtp = new SmtpClient();
                smtp.Host = obclsCorreo.stServidor;

                if (obclsCorreo.blAutenticacion) smtp.Credentials = new System.Net.NetworkCredential(obclsCorreo.stUsuarioCorreo, obclsCorreo.stContraseñaCorreo);
                if (obclsCorreo.stPuerto.Length > 0) smtp.Port = Convert.ToInt32(obclsCorreo.stPuerto);

                smtp.EnableSsl = obclsCorreo.blConexionSegura;
                smtp.Send(Correo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
