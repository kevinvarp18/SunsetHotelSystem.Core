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
    public class CaracteristicaHabitacionLN : ICaracteristicaHabitacionLN {
        #region
        private readonly IRepositorioCaracteristicaHabitacion DominioCaracteristicaHabitacion;
        #endregion

        public CaracteristicaHabitacionLN(IRepositorioCaracteristicaHabitacion repositorio) {
            DominioCaracteristicaHabitacion = repositorio;
        }//Fin del constructor.

        public Respuesta<List<TSH_Caracteristica_habitacion>> lfObtener() {
            Respuesta<List<TSH_Caracteristica_habitacion>> respuesta = new Respuesta<List<TSH_Caracteristica_habitacion>>();
            try {
                respuesta.valorRetorno = DominioCaracteristicaHabitacion.obtener();
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtener.
    }//Fin de la clase CaracteristicaHabitacionLN.
}//Fin del namespace.
