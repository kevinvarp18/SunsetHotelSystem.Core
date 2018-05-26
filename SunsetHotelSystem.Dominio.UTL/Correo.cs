using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace SunsetHotelSystem.Dominio.UTL {
    public class Correo {

        private SmtpClient CrearClienteSMTP(string servidorSMTP) {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = servidorSMTP;
            smtp.Port = 25;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("sunsethotelinfo@gmail.com", "sunsethotel1123");
            return smtp;
        }//Fin del método CrearClienteSTMP.

        public string CrearCuepoMensaje(string nombreReserva, string apellidoReserva, int numeroHabitacion, string codigoReserva) {
            string cuerpoMensaje = "<h1>Reciba un cordial saludo </h1><br><h2>" + nombreReserva + " " + apellidoReserva + "</h2><br> <p>De parte de Sunset Hotel, le adjuntamos el número de habitación asignada: " + numeroHabitacion + ".</p><br> <p>Además, tiene que presentar el siguiente código de comprobante para verificar su reservación <p/><br><h3>" + codigoReserva + "</h3>";
            return cuerpoMensaje;
        }//Fin del método CrearCuerpoMensaje.

        private MailMessage CrearCorreo(string correoCliente, string cuerpoCorreo) {
            MailMessage mensajeCorreo = new MailMessage();
            mensajeCorreo.To.Add(new MailAddress(correoCliente));
            mensajeCorreo.From = new MailAddress("sunsethotelinfo@gmail.com");
            mensajeCorreo.Subject = "Reservación Comprobante( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
            mensajeCorreo.Body = cuerpoCorreo;
            mensajeCorreo.IsBodyHtml = true;
            mensajeCorreo.Priority = MailPriority.Normal;
            return mensajeCorreo;
        }//Fin del método CrearMensaje.

        public void enviarCorreo(string correoCliente, string cuerpoMensaje) {
            SmtpClient smtp = CrearClienteSMTP("smtp.gmail.com");
            MailMessage email = CrearCorreo(correoCliente, cuerpoMensaje);
            try {
                smtp.Send(email);
            } catch {
                email.Dispose();
            }//Fin del try-catch.
        }//Fin del método enviarCorreo.        
    }//Fin de la clase Correo.
}//Fin del namespace.
