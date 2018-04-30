using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IHabitacionLN {
        Respuesta<List<TSH_Habitacion>> lfObtener();
        Respuesta<TSH_Habitacion> lfObtener(int id);
        Respuesta<TSH_Habitacion> lfInsertar(TSH_Habitacion habitacion);
        Respuesta<TSH_Habitacion> lfActualizar(TSH_Habitacion habitacion);
        Respuesta<bool> lfEliminar(int id);
    }//Fin de la clase IHabitacionLN.
}//Fin del namespace.
