using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioReserva {
        TSH_Reserva insertarReserva(TSH_Reserva reserva);
    }//Fin de la clase IRepositorioReserva.
}//Fin del namespace.
