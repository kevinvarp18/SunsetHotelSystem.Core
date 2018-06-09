using SunsetHotelSystem.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioPagina {
        TSH_Pagina obtenerPorID(int idPagina);
        void actualizar(TSH_Pagina pagina);
    }//Fin de la interfaz IRepositorioHome.
}//Fin del namespace.
