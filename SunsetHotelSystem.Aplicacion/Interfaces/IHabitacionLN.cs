﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IHabitacionLN {
        Respuesta<List<SP_ConsultarDisponibilidad_Result>> lfObtenerHabitacionesDisponibles(int tipoHabitacion);
        Respuesta<TSH_Habitacion> lfObtenerPorID(int idHabitacion);
        Respuesta<List<TSH_Habitacion>> lfObtener();
    }//Fin de la interfaz IHabitacionLN.
}//Fin del namespace.
