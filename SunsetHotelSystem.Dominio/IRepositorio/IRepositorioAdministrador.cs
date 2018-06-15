using SunsetHotelSystem.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioAdministrador {
        TSH_Administrador obtenerPorID(TSH_Administrador administrador);
    }//Fin de la interfaz IRepositorioAdministrador.
}//Fin del namespace.s
