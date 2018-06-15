using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IAdministradorLN {
        Respuesta<TSH_Administrador> lfObtenerPorID(TSH_Administrador administrador);
    }//Fin de la interfaz IAdministradorLN.
}//Fin del namespace.
