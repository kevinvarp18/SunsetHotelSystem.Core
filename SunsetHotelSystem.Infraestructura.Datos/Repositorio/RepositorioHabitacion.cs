using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.IRepositorio;
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

        public TSH_Habitacion obtenerPorID(int numeroHabitacion) {
            TSH_Habitacion habitacionTemp = new TSH_Habitacion();
            try {
                habitacionTemp = (from listaHabitaciones in SS_Contexto.TSH_Habitacion where listaHabitaciones.TN_Numero_Habitacion_TSH_Habitacion == numeroHabitacion select listaHabitaciones).Single<TSH_Habitacion>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return habitacionTemp;
        }//Fin del método obtenerPorID.

        public void actualizar(TSH_Habitacion habitacion) {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try {
                var entity = SS_Contexto.TSH_Habitacion.Find(habitacion.TN_Numero_Habitacion_TSH_Habitacion);
                SS_Contexto.Entry(entity).CurrentValues.SetValues(new { TN_Borrado_TSH_Habitacion = habitacion.TN_Borrado_TSH_Habitacion });
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            } catch (Exception ex) {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }//Fin del método actualizar.
    }//Fin de la clase RepositorioHabitacion.
}//Fin del namespace.
