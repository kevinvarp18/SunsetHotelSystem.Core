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
    public class HomeLN : IHomeLN {
        #region
        private readonly IRepositorioHome DominioHome;
        #endregion

        public HomeLN(IRepositorioHome repositorio) {
            DominioHome = repositorio;
        }//Fin del constructor.

        public Respuesta<TSH_Pag_Home> lfObtenerPorID(int idPagina) {
            Respuesta<TSH_Pag_Home> respuesta = new Respuesta<TSH_Pag_Home>();

            try {
                respuesta.valorRetorno = DominioHome.obtenerPorID(idPagina);
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtenerPorID.
    }//Fin de la clase HomeLN.
}//Fin del namespace.
