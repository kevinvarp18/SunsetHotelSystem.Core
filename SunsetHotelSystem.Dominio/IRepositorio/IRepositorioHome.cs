using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioHome {
        TSH_Pag_Home obtenerPorID(int idPagina);
    }//Fin de la interfaz IRepositorioHome.
}//Fin del namespace.
