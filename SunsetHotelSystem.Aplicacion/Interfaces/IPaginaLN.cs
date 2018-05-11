using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IPaginaLN {
        Respuesta<TSH_Pagina> lfObtenerPorID(int idPagina);
        Respuesta<TSH_Pagina> lfActualizar(TSH_Pagina pagina);
    }//Fin de la interfaz IHomeLN.
}//Fin del namespace.
