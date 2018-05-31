using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface ITipoHabitacionLN {
        Respuesta<List<TSH_Tipo_Habitacion>> lfObtener();
        Respuesta<TSH_Tipo_Habitacion> lfActualizar(TSH_Tipo_Habitacion tipoHabitacion);
    }//Fin de la interfaz ITipoHabitacionLN.
}//Fin del namespace.
