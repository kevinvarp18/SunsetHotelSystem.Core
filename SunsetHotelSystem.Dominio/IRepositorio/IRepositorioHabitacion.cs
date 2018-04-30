using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioHabitacion {
        List<TSH_Habitacion> obtenerHabitaciones();
        TSH_Habitacion obtenerHabitacionID(TSH_Habitacion habitacion);
        TSH_Habitacion insertarHabitacion(TSH_Habitacion habitacion);
        TSH_Habitacion actualizarHabitacion(TSH_Habitacion habitacion);
        bool eliminarHabitacion(TSH_Habitacion habitacion);
    }//Fin de la interfaz IRepositorioHabitacion.
}//Fin del namespace.