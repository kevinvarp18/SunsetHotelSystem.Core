using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Aplicacion.Interfaces;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Implementacion {
    public class PublicidadLN : IPublicidadLN {
        #region
        private readonly IRepositorioPublicidad DominioPublicidad;
        #endregion

        public PublicidadLN(IRepositorioPublicidad repositorio) {
            DominioPublicidad = repositorio;
        }//Fin del constructor.

        public Respuesta<List<TSH_Publicidad>> lfObtener() {
            Respuesta<List<TSH_Publicidad>> respuesta = new Respuesta<List<TSH_Publicidad>>();

            try {
                respuesta.valorRetorno = DominioPublicidad.obtener();
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtener.

        public Respuesta<TSH_Publicidad> lfInsertar(TSH_Publicidad publicidad) {
            Respuesta<TSH_Publicidad> respuesta = new Respuesta<TSH_Publicidad>();

            try {
                DominioPublicidad.insertar(publicidad);
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfInsertar.

        public Respuesta<TSH_Publicidad> lfActualizar(TSH_Publicidad publicidad) {
            Respuesta<TSH_Publicidad> respuesta = new Respuesta<TSH_Publicidad>();

            try {
                DominioPublicidad.actualizar(publicidad);
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfActualizar.
    }//Fin de la clase PublicidadLN.
}//Fin del namespace.
