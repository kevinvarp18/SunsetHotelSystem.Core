using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

namespace SunsetHotelSystem.Infraestructura.Datos.Repositorio {
    public class RepositorioTipoHabitacion : IRepositorioTipoHabitacion {

        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioTipoHabitacion(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<TSH_Tipo_Habitacion> obtener() {
            List<TSH_Tipo_Habitacion> listaTiposHabitacion = new List<TSH_Tipo_Habitacion>();
            try{
                listaTiposHabitacion = (from list in SS_Contexto.TSH_Tipo_Habitacion select list).ToList<TSH_Tipo_Habitacion>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return listaTiposHabitacion;
        }//Fin del método obtener.

        public void actualizar(TSH_Tipo_Habitacion tipoHabitacion) {
            DbContextTransaction dbTransaccion = SS_Contexto.Database.BeginTransaction();

            try {
                var entity = SS_Contexto.TSH_Tipo_Habitacion.Find(tipoHabitacion.TN_Identificador_TSH_Tipo_Habitacion);
                if (tipoHabitacion.TI_Imagen_TSH_Tipo_Habitacion != null)
                    SS_Contexto.Entry(entity).CurrentValues.SetValues(tipoHabitacion);
                else
                    SS_Contexto.Entry(entity).CurrentValues.SetValues(new { TN_Tarifa_TSH_Tipo_Habitacion = tipoHabitacion.TN_Tarifa_TSH_Tipo_Habitacion, TC_Descripcion_TSH_Tipo_Habitacion = tipoHabitacion.TC_Descripcion_TSH_Tipo_Habitacion });

                SS_Contexto.SaveChanges();
                dbTransaccion.Commit();
            } catch (Exception ex) {
                dbTransaccion.Rollback();
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
        }//Fin del método actualizar.

    }//Fin de la clase RepositorioTipoHabitacion.
}//Fin del namespace.
