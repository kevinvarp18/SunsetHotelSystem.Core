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

        public Respuesta<List<SP_ConsultarDisponibilidad_Result>> lfObtenerHabitacionesDisponibles(int tipoHabitacion) {
            Respuesta<List<SP_ConsultarDisponibilidad_Result>> respuesta = new Respuesta<List<SP_ConsultarDisponibilidad_Result>>();

            try {
                respuesta.valorRetorno = DominioHabitacion.obtenerHabitacionesDisponibles(tipoHabitacion);
                respuesta.resultado = 1;
            } catch (Exception ex)  {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtenerHabitacionesDisponibles.

        public Respuesta<TSH_Habitacion> lfObtenerPorID(int idHabitacion) {
            Respuesta<TSH_Habitacion> respuesta = new Respuesta<TSH_Habitacion>();

            try {
                respuesta.valorRetorno = DominioHabitacion.obtenerPorID(idHabitacion);
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtenerPorID.

        public Respuesta<List<TSH_Habitacion>> lfObtener() {
            Respuesta<List<TSH_Habitacion>> respuesta = new Respuesta<List<TSH_Habitacion>>();

            try {
                respuesta.valorRetorno = DominioHabitacion.obtener();
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtener.

    }//Fin de la clase HabitacionLN.
}//Fin del namespace.
