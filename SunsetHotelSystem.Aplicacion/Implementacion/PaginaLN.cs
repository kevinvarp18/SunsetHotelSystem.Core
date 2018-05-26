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
    public class PaginaLN : IPaginaLN {
        #region
        private readonly IRepositorioPagina DominioHome;
        #endregion

        public PaginaLN(IRepositorioPagina repositorio) {
            DominioHome = repositorio;
        }//Fin del constructor.

        public Respuesta<TSH_Pagina> lfObtenerPorID(int idPagina) {
            Respuesta<TSH_Pagina> respuesta = new Respuesta<TSH_Pagina>();

            try {
                respuesta.valorRetorno = DominioHome.obtenerPorID(idPagina);
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtenerPorID.

        public Respuesta<TSH_Pagina> lfActualizar(TSH_Pagina pagina) {
            Respuesta<TSH_Pagina> respuesta = new Respuesta<TSH_Pagina>();

            try {
                DominioHome.actualizar(pagina);
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfActualizar.
    }//Fin de la clase HomeLN.
}//Fin del namespace.
