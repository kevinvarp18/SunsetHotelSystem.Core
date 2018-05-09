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
    public class RepositorioHome : IRepositorioHome {
        private readonly SunsetHotel_DBEntities SS_Contexto;

        public RepositorioHome(SunsetHotel_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public TSH_Pag_Home obtenerPorID(int idPagina) {
            TSH_Pag_Home paginaTemp = new TSH_Pag_Home();
            try {
                paginaTemp = (from listaPaginas in SS_Contexto.TSH_Pag_Home where listaPaginas.TN_Identificador_TSH_Pag_Home == idPagina select listaPaginas).Single<TSH_Pag_Home>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return paginaTemp;
        }//Fin del método lfObtenerHabitacion
    }//Fin de la clase RepositorioHome.
}//Fin del namespace.