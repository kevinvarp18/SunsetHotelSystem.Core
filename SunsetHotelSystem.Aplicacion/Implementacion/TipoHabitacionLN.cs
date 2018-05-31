using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Aplicacion.Interfaces;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Implementacion {
    public class TipoHabitacionLN : ITipoHabitacionLN {
        #region
        private readonly IRepositorioTipoHabitacion DominioTipoHabitacion;
        #endregion

        public TipoHabitacionLN(IRepositorioTipoHabitacion repositorio) {
            DominioTipoHabitacion = repositorio;
        }//Fin del constructor.

        public Respuesta<List<TSH_Tipo_Habitacion>> lfObtener() {
            Respuesta<List<TSH_Tipo_Habitacion>> respuesta = new Respuesta<List<TSH_Tipo_Habitacion>>();

            try {
                respuesta.valorRetorno = DominioTipoHabitacion.obtener();
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtener.

        public Respuesta<TSH_Tipo_Habitacion> lfActualizar(TSH_Tipo_Habitacion tipoHabitacion) {
            Respuesta<TSH_Tipo_Habitacion> respuesta = new Respuesta<TSH_Tipo_Habitacion>();

            try {
                DominioTipoHabitacion.actualizar(tipoHabitacion);
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfActualizar.

    }//Fin de la clase TipoHabitacionLN.
}//Fin del namespace.
