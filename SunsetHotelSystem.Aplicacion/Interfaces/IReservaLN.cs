﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IReservaLN {
        Respuesta<TSH_Reserva> lfInsertar(TSH_Reserva reserva);
        Respuesta<List<TSH_Reserva>> lfObtener();

    }//Fin de la interfaz IReserva.
}//Fin del namespace.
