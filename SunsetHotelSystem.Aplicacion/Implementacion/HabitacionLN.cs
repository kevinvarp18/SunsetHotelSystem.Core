using SunsetHotelSystem.Aplicacion.Interfaces;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Aplicacion.Implementacion {
    public class HabitacionLN : IHabitacionLN {
        #region
        private readonly IRepositorioHabitacion DominioHabitacion;
        #endregion

        public HabitacionLN(IRepositorioHabitacion repositorio) {
            DominioHabitacion = repositorio;
        }//Fin del constructor.

        public Respuesta<List<TSH_Habitacion>> lfObtener() {
            Respuesta<List<TSH_Habitacion>> respuesta = new Respuesta<List<TSH_Habitacion>>();

            try {
                respuesta.valorRetorno = DominioHabitacion.obtenerHabitaciones();
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtener.

        public Respuesta<TSH_Habitacion> lfObtener(int id) {
            Respuesta<TSH_Habitacion> respuesta = new Respuesta<TSH_Habitacion>();

            try {
                respuesta.valorRetorno = DominioHabitacion.obtenerHabitacionID(new TSH_Habitacion { TN_Numero_Habitacion_TSH_Habitacion = id });
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtener.

        public Respuesta<TSH_Habitacion> lfInsertar(TSH_Habitacion user) {
            Respuesta<TSH_Habitacion> respuesta = new Respuesta<TSH_Habitacion>();

            try {
                respuesta.valorRetorno = DominioHabitacion.insertarHabitacion(user);
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfInsertar.

        public Respuesta<TSH_Habitacion> lfActualizar(TSH_Habitacion user) {
            Respuesta<TSH_Habitacion> respuesta = new Respuesta<TSH_Habitacion>();

            try {
                respuesta.valorRetorno = DominioHabitacion.actualizarHabitacion(user);
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
            }
            return respuesta;
        }//Fin del método lfActualizar.

        public Respuesta<bool> lfEliminar(int id) {
            Respuesta<bool> respuesta = new Respuesta<bool>();
            try {
                respuesta.valorRetorno = DominioHabitacion.eliminarHabitacion(new TSH_Habitacion { TN_Numero_Habitacion_TSH_Habitacion = id });
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = false;
                respuesta.strOrigen = ex.ToString();
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfEliminar.
    }//Fin de la clase HabitacionLN.
}//Fin del namespace.
