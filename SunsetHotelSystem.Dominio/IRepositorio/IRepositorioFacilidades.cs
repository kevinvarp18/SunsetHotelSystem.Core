using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioFacilidades {
        List<TSH_Pag_Facilidades> obtener();
        void actualizar(TSH_Pag_Facilidades facilidad);
        void insertar(TSH_Pag_Facilidades facilidad);
    }//Fin de la interfaz IFacilidades.
}//Fin del namespace.
