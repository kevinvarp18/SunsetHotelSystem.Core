using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioGaleria {
        List<TSH_SobreN_Galeria> obtener();
    }//Fin de la interfaz IRepositorioGaleria.
}//Fin del namespace.
