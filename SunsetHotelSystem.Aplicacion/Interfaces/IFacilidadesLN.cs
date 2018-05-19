using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IFacilidadesLN {
        Respuesta<List<TSH_Pag_Facilidades>> lfObtener();
    }//Fin de la interfaz IFacilidadesLN.
}//Fin del namespace.
