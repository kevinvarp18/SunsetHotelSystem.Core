using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Dominio.IRepositorio {
    public interface IRepositorioBase<Entidad> : IDisposable {
        List<Entidad> obtenerTodos();
        Entidad obtenerPorID(int id);
        Entidad insertar(Entidad entidad);
        Entidad actualizar(Entidad entidad);
        Boolean eliminar(Entidad user);
    }//Fin de la clase IRepositorioBase
}//Fin del namespace.
