using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades.Entidades;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioFacilidades {
        List<TSH_Pag_Facilidades> obtener();
    }//Fin de la interfaz IFacilidades.
}//Fin del namespace.
