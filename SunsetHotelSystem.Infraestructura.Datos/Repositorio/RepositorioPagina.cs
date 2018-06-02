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
    public class RepositorioPagina : IRepositorioPagina {
        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioPagina(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public TSH_Pagina obtenerPorID(int idPagina) {
            TSH_Pagina paginaTemp = new TSH_Pagina();
            try {
                paginaTemp = (from listaPaginas in SS_Contexto.TSH_Pagina where listaPaginas.TN_Identificador_TSH_Pagina == idPagina select listaPaginas).Single<TSH_Pagina>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return paginaTemp;
        }//Fin del método obtenerPorID.

        public void actualizar(TSH_Pagina pagina) {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try {
                var entity = SS_Contexto.TSH_Pagina.Find(pagina.TN_Identificador_TSH_Pagina);
                SS_Contexto.Entry(entity).CurrentValues.SetValues(pagina);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            } catch (Exception ex) {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            actualizarSubPagina(pagina);
        }//Fin del método actualizar.

        public void actualizarSubPagina(TSH_Pagina pagina) {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try {
                if (pagina.TN_Identificador_TSH_Pagina == 5 && pagina.TSH_Pag_Home.TI_Imagen_TSH_Pag_Home != null) {
                    var entity = SS_Contexto.TSH_Pag_Home.Find(pagina.TN_Identificador_TSH_Pagina);
                    SS_Contexto.Entry(entity).CurrentValues.SetValues(pagina.TSH_Pag_Home);
                }//Fin del if.

                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            } catch (Exception ex) {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }//Fin del método actualizarSubPagina.
    }//Fin de la clase RepositorioHome.
}//Fin del namespace.