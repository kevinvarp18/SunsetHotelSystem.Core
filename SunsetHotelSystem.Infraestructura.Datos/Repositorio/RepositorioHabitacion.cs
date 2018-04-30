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

        private readonly Sunset_HotelDBEntities SS_Contexto;

        public RepositorioHabitacion(Sunset_HotelDBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public TSH_Habitacion insertarHabitacion(TSH_Habitacion habitacion) {
            DbContextTransaction transaccionBD = SS_Contexto.Database.BeginTransaction();

            try {
                SS_Contexto.TSH_Habitacion.Add(habitacion);
                SS_Contexto.SaveChanges();
                transaccionBD.Commit();
            } catch (Exception ex) {
                transaccionBD.Rollback();
                throw new Exception(ex.ToString());
            }
            return habitacion;
        }

        public bool eliminarHabitacion(TSH_Habitacion habitacion) {
            DbContextTransaction transaccionBD = SS_Contexto.Database.BeginTransaction();

            try {
                SS_Contexto.TSH_Habitacion.Attach(habitacion);
                SS_Contexto.TSH_Habitacion.Remove(habitacion);
                SS_Contexto.SaveChanges();
                transaccionBD.Commit();
            } catch (Exception ex) {
                transaccionBD.Rollback();
                throw new Exception(ex.ToString());
            }
            return true;
        }
        public List<TSH_Habitacion> obtenerHabitaciones() {
            List<TSH_Habitacion> userList = new List<TSH_Habitacion>();
            try {
                userList = (from list in SS_Contexto.TSH_Habitacion select list).ToList<TSH_Habitacion>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return userList;
        }

        public TSH_Habitacion obtenerHabitacionID(TSH_Habitacion habitacion) {
            TSH_Habitacion habitacionTemp = new TSH_Habitacion();
            try {
                habitacionTemp = (from listaHabitaciones in SS_Contexto.TSH_Habitacion where listaHabitaciones.TN_Numero_Habitacion_TSH_Habitacion == habitacion.TN_Numero_Habitacion_TSH_Habitacion select listaHabitaciones).Single<TSH_Habitacion>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return habitacionTemp;
        }

        public TSH_Habitacion actualizarHabitacion(TSH_Habitacion habitacion) {
            DbContextTransaction transaccionBD = SS_Contexto.Database.BeginTransaction();

            try {
                var entity = SS_Contexto.TSH_Habitacion.Find(habitacion.TN_Numero_Habitacion_TSH_Habitacion);
                SS_Contexto.Entry(entity).CurrentValues.SetValues(habitacion);
                SS_Contexto.SaveChanges();
                transaccionBD.Commit();
            } catch (Exception ex) {
                transaccionBD.Rollback();
                throw new Exception(ex.ToString());
            }
            return habitacion;
        }
    }//Fin de la clase RepositorioHabitacion.
}//Fin del namespace.
