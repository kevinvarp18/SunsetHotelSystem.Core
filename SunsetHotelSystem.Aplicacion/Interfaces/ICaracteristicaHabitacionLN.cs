using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface ICaracteristicaHabitacionLN {
        Respuesta<List<TSH_Caracteristica_habitacion>> lfObtener();
    }//Fin de la interfaz ICaracteristicaHabitacionLN.
}//Fin del namespace.
