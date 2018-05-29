using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioHabitacion {
        List<SP_ConsultarDisponibilidad_Result> obtenerHabitacionesDisponibles(int tipoHabitacion);
        TSH_Habitacion obtenerPorID(int idHabitacion);
        List<TSH_Habitacion> obtener();
    }//Fin de la interfaz IRepositorioHabitacion.
}//Fin del namespace.