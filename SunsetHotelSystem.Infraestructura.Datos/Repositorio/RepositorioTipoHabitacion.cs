using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System.Data.Entity.Core.Objects;

namespace SunsetHotelSystem.Infraestructura.Datos.Repositorio {
    public class RepositorioTipoHabitacion : IRepositorioTipoHabitacion {

        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioTipoHabitacion(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<TSH_Tipo_Habitacion> obtener() {
            List<TSH_Tipo_Habitacion> listaTiposHabitacion = new List<TSH_Tipo_Habitacion>();
            try{
                listaTiposHabitacion = (from list in SS_Contexto.TSH_Tipo_Habitacion select list).ToList<TSH_Tipo_Habitacion>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return listaTiposHabitacion;
        }//Fin del método obtenerTiposHabitacion.

    }//Fin de la clase RepositorioTipoHabitacion.
}//Fin del namespace.
