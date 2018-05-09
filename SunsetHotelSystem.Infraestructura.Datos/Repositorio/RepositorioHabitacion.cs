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

        private readonly SunsetHotel_DBEntities SS_Contexto;

        public RepositorioHabitacion(SunsetHotel_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<SP_ConsultarDisponibilidad_Result> consultarHabitacionesDisponibles(int tipoHabitacion) {
            List<SP_ConsultarDisponibilidad_Result> listaHabitaciones = new List<SP_ConsultarDisponibilidad_Result>();
            try {
                listaHabitaciones = SS_Contexto.SP_ConsultarDisponibilidad(tipoHabitacion).ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return listaHabitaciones;
        }//Fin del método obtenerTiposHabitacion.

        public TSH_Habitacion obtenerHabitacion(int idHabitacion) {
            TSH_Habitacion habitacionTemp = new TSH_Habitacion();
            try {
                habitacionTemp = (from listaHabitaciones in SS_Contexto.TSH_Habitacion where listaHabitaciones.TN_Identificador_TSH_Habitacion == idHabitacion select listaHabitaciones).Single<TSH_Habitacion>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return habitacionTemp;
        }//Fin del método lfObtenerHabitacion
    }//Fin de la clase RepositorioHabitacion.
}//Fin del namespace.
