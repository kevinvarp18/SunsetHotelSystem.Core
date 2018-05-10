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
        }//Fin del método obtenerPorID.

        public TSH_Pag_Home actualizar(TSH_Pag_Home paginaHome) {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try {
                var entity = SS_Contexto.TSH_Pag_Home.Find(paginaHome.TN_Identificador_TSH_Pag_Home);
                SS_Contexto.Entry(entity).CurrentValues.SetValues(paginaHome);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            } catch (Exception ex) {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return paginaHome;
        }//Fin del método actualizar.
    }//Fin de la clase RepositorioHome.
}//Fin del namespace.