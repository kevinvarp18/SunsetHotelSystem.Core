using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Infraestructura.Datos.Repositorio {
    public class RepositorioHabitacion : IRepositorioHabitacion {

        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioHabitacion(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<SP_ConsultarDisponibilidad_Result> obtenerHabitacionesDisponibles(int tipoHabitacion) {
            List<SP_ConsultarDisponibilidad_Result> listaHabitaciones = new List<SP_ConsultarDisponibilidad_Result>();
            try {
                listaHabitaciones = SS_Contexto.SP_ConsultarDisponibilidad(tipoHabitacion).ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return listaHabitaciones;
        }//Fin del método obtenerHabitacionesDisponibles.

        public List<TSH_Habitacion> obtener()  {
            List<TSH_Habitacion> listaHabitaciones = new List<TSH_Habitacion>();
            try {
                listaHabitaciones = (from list in SS_Contexto.TSH_Habitacion select list).ToList<TSH_Habitacion>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return listaHabitaciones;
        }//Fin del método obtener.

        public TSH_Habitacion obtenerPorID(int idHabitacion) {
            TSH_Habitacion habitacionTemp = new TSH_Habitacion();
            try {
                habitacionTemp = (from listaHabitaciones in SS_Contexto.TSH_Habitacion where listaHabitaciones.TN_Identificador_TSH_Habitacion == idHabitacion select listaHabitaciones).Single<TSH_Habitacion>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return habitacionTemp;
        }//Fin del método obtenerPorID.
    }//Fin de la clase RepositorioHabitacion.
}//Fin del namespace.
