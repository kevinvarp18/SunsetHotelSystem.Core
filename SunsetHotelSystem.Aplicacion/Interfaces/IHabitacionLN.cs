using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IHabitacionLN {
        Respuesta<List<SP_ConsultarDisponibilidad_Result>> lfConsultarHabitacionesDisponibles(int tipoHabitacion);
        Respuesta<TSH_Habitacion> lfObtenerHabitacion(int idHabitacion);
    }//Fin de la clase IHabitacionLN.
}//Fin del namespace.
