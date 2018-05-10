﻿using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioReserva {
        TSH_Reserva insertar(TSH_Reserva reserva);
    }//Fin de la interfaz IRepositorioReserva.
}//Fin del namespace.