using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IHomeLN {
        Respuesta<TSH_Pag_Home> lfObtenerPorID(int idPagina);
    }//Fin de la interfaz IHomeLN.
}//Fin del namespace.
