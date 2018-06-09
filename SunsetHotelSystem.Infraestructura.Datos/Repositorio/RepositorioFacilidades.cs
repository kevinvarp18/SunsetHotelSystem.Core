using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace SunsetHotelSystem.Infraestructura.Datos.Repositorio {
    public class RepositorioFacilidades : IRepositorioFacilidades {
        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioFacilidades(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<TSH_Pag_Facilidades> obtener() {
            List<TSH_Pag_Facilidades> listaFacilidades = new List<TSH_Pag_Facilidades>();
            try {
                listaFacilidades = (from list in SS_Contexto.TSH_Pag_Facilidades select list).ToList<TSH_Pag_Facilidades>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return listaFacilidades;
        }//Fin del método obtener.

        public void insertar(TSH_Pag_Facilidades facilidad) {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try {
                SS_Contexto.TSH_Pag_Facilidades.Add(facilidad);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            } catch (Exception ex) {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }//Fin del método insertar.

        public void actualizar(TSH_Pag_Facilidades facilidad) {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try {
                var entity = SS_Contexto.TSH_Pag_Facilidades.Find(facilidad.TN_IdentificadorNumFac_TSH_Pag_Facilidades);
                if(facilidad.TI_Imagen_TSH_Pag_Facilidades != null)
                    SS_Contexto.Entry(entity).CurrentValues.SetValues(facilidad);
                else
                    SS_Contexto.Entry(entity).CurrentValues.SetValues(new { TC_TituloFacilidad_TSH_Pag_Facilidades = facilidad.TC_TituloFacilidad_TSH_Pag_Facilidades, TC_Descripcion_TSH_Pag_Facilidades = facilidad.TC_Descripcion_TSH_Pag_Facilidades, TN_Borrado_TSH_Pag_Facilidades = facilidad.TN_Borrado_TSH_Pag_Facilidades });
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            } catch (Exception ex) {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }//Fin del método actualizar.
    }//Fin de la clase RepositorioFacilidades.
}//Fin del namespace.
