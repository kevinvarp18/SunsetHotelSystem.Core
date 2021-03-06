﻿using SunsetHotelSystem.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioHabitacion {
        List<SP_ConsultarDisponibilidad_Result> obtenerHabitacionesDisponibles(int tipoHabitacion);
        TSH_Habitacion obtenerPorID(int numeroHabitacion);
        List<TSH_Habitacion> obtener();
        void actualizar(TSH_Habitacion habitacion);
    }//Fin de la interfaz IRepositorioHabitacion.
}//Fin del namespace.