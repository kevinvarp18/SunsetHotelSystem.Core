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

        public Respuesta<TSH_Reserva> lfInsertarReserva(TSH_Reserva reserva) {
            Respuesta<TSH_Reserva> respuesta = new Respuesta<TSH_Reserva>();

            try {
                respuesta.valorRetorno = DominioReserva.insertarReserva(reserva);
            }
            catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
            }
            return respuesta;
        }
        #endregion

    }//Fin de la clase ReservaLN.
}//Fin del namespace.
