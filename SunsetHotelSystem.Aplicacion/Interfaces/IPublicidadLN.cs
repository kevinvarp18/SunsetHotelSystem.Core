using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IPublicidadLN {
        Respuesta<List<TSH_Publicidad>> lfObtener();
        Respuesta<TSH_Publicidad> lfActualizar(TSH_Publicidad publicidad);
        Respuesta<TSH_Publicidad> lfInsertar(TSH_Publicidad publicidad);
    }//Fin de la interfaz IPublicidadLN.
}//Fin del namespace.
