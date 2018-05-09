using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioTipoHabitacion {
        List<TSH_Tipo_Habitacion> obtener();
    }//Fin de la interfaz IRepositorioTipoHabitacion.
}//Fin del namespace.
