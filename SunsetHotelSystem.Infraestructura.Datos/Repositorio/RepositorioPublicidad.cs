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
    public class RepositorioPublicidad : IRepositorioPublicidad {
        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioPublicidad(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<TSH_Publicidad> obtener() {
            List<TSH_Publicidad> listaPublicidad = new List<TSH_Publicidad>();
            try {
                listaPublicidad = (from list in SS_Contexto.TSH_Publicidad select list).ToList<TSH_Publicidad>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return listaPublicidad;
        }//Fin del método obtener.

        public void insertar(TSH_Publicidad publicidad) {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try {
                SS_Contexto.TSH_Publicidad.Add(publicidad);
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            } catch (Exception ex) {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }//Fin del método insertar.

        public void actualizar(TSH_Publicidad publicidad) {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try {
                var entity = SS_Contexto.TSH_Publicidad.Find(publicidad.TN_Identificador_TSH_Publicidad);
                if (publicidad.TI_Imagen_TSH_Publicidad != null)
                    SS_Contexto.Entry(entity).CurrentValues.SetValues(publicidad);
                else
                    SS_Contexto.Entry(entity).CurrentValues.SetValues(new { TC_Direccion_Pagina_TSH_Publicidad = publicidad.TC_Direccion_Pagina_TSH_Publicidad, TN_Borrado_TSH_Publicidad = publicidad.TN_Borrado_TSH_Publicidad });
                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            } catch (Exception ex) {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }//Fin del método actualizar.
    }//Fin de la clase RepositorioPublicidad
}//Fin del namespace.
