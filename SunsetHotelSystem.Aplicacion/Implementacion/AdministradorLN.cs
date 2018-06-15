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
    public class AdministradorLN : IAdministradorLN {
        #region
        private readonly IRepositorioAdministrador DominioAdministrador;
        #endregion

        public AdministradorLN(IRepositorioAdministrador repositorio) {
            DominioAdministrador = repositorio;
        }//Fin del constructor.

        public Respuesta<TSH_Administrador> lfObtenerPorID(TSH_Administrador administrador) {
            Respuesta<TSH_Administrador> respuesta = new Respuesta<TSH_Administrador>();

            try {
                respuesta.valorRetorno = DominioAdministrador.obtenerPorID(administrador);
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtenerPorID.
    }//Fin de la clase AdministradorLN.
}//Fin del namespace.
