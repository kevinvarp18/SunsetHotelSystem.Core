using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioCaracteristicaHabitacion {
        List<TSH_Caracteristica_habitacion> obtener();
    }//Fin de la interfaz IRepositorioCaracteristicaHabitacion.
}//Fin del namespace.
