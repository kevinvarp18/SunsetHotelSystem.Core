using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IReservaLN {
        Respuesta<TSH_Reserva> lfInsertarReserva(TSH_Reserva reserva);
    }//Fin de la interfaz IReserva.
}//Fin del namespace.
