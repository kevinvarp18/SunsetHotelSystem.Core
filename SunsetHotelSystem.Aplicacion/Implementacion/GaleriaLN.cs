using SunsetHotelSystem.Aplicacion.Interfaces;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.UTL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Aplicacion.Implementacion {
    public class GaleriaLN {
        #region
        private readonly IRepositorioGaleria DominioGaleria;
        #endregion

        public GaleriaLN(IRepositorioGaleria repositorio) {
            DominioGaleria = repositorio;
        }//Fin del constructor.

        public Respuesta<List<TSH_SobreN_Galeria>> lfObtener() {
            Respuesta<List<TSH_SobreN_Galeria>> respuesta = new Respuesta<List<TSH_SobreN_Galeria>>();

            try {
                respuesta.valorRetorno = DominioGaleria.obtener();
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtener.
    }//Fin de la clase GaleriaLN.
}//Fin del namespace.
