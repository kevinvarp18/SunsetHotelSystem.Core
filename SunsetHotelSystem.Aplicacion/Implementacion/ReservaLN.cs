using SunsetHotelSystem.Aplicacion.Interfaces;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Aplicacion.Implementacion {
    public class ReservaLN : IReservaLN {
        #region
        private readonly IRepositorioReserva DominioReserva;
        #endregion

        public Respuesta<TSH_Reserva> lfInsertar(TSH_Reserva reserva) {
            Respuesta<TSH_Reserva> respuesta = new Respuesta<TSH_Reserva>();

            try {
                respuesta.valorRetorno = DominioReserva.insertar(reserva);
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfInsertar.
    }//Fin de la clase ReservaLN.
}//Fin del namespace.
