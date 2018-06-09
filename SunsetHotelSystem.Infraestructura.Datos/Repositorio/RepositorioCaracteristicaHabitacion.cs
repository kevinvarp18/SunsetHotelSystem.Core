using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades;
using System.Data.Entity.Core.Objects;
using System;

namespace SunsetHotelSystem.Infraestructura.Datos.Repositorio {
    public class RepositorioCaracteristicaHabitacion: IRepositorioCaracteristicaHabitacion {

        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioCaracteristicaHabitacion(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<TSH_Caracteristica_habitacion> obtener() {
            List<TSH_Caracteristica_habitacion> listaCaracteristicasHabitacion = new List<TSH_Caracteristica_habitacion>();
            try {
                listaCaracteristicasHabitacion = (from list in SS_Contexto.TSH_Caracteristica_habitacion select list).ToList<TSH_Caracteristica_habitacion>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return listaCaracteristicasHabitacion;
        }//Fin del método obtener.
    }//Fin de la clase RepositorioCaracteristicaHabitacion.
}//Fin del namespace.