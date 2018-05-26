using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioReserva {
        void insertar(TSH_Reserva reserva);
        List<TSH_Reserva> obtener();
    }//Fin de la interfaz IRepositorioReserva.
}//Fin del namespace.
