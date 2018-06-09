using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IFacilidadesLN {
        Respuesta<List<TSH_Pag_Facilidades>> lfObtener();
        Respuesta<TSH_Pag_Facilidades> lfActualizar(TSH_Pag_Facilidades facilidad);
        Respuesta<TSH_Pag_Facilidades> lfInsertar(TSH_Pag_Facilidades facilidad);
    }//Fin de la interfaz IFacilidadesLN.
}//Fin del namespace.
