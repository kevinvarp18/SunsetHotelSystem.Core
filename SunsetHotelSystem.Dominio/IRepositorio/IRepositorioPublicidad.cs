using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioPublicidad {
        List<TSH_Publicidad> obtener();
        void actualizar(TSH_Publicidad publicidad);
        void insertar(TSH_Publicidad publicidad);
    }//Fin de la interfaz IRepositorioPublicidad.
}//Fin del namespace.
