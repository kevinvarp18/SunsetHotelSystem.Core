using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioHabitacion {
        List<SP_ConsultarDisponibilidad_Result> consultarHabitacionesDisponibles(int tipoHabitacion);
        TSH_Habitacion obtenerHabitacion(int idHabitacion);
    }//Fin de la interfaz IRepositorioHabitacion.
}//Fin del namespace.