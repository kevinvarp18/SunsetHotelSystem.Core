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
    public class RepositorioReserva : IRepositorioReserva {

        private readonly SunsetHotel_DBEntities SS_Contexto;

        public RepositorioReserva(SunsetHotel_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public TSH_Reserva insertarReserva(TSH_Reserva reserva) {
            DbContextTransaction dbTransaction = SS_Contexto.Database.BeginTransaction();

            try {
                SS_Contexto.sp_realizarReserva(reserva.TSH_Cliente.TC_Nombre_TSH_Cliente, reserva.TSH_Cliente.TC_Apellidos_TSH_Cliente, reserva.TSH_Cliente.TC_correo_TSH_Cliente, reserva.TSH_Cliente.TC_Tarjeta_TSH_Cliente, reserva.TN_Num_Habitacion_TSH_Reserva, reserva.TD_Fecha_Ingreso_TSH_Reserva, reserva.TD_Fecha_Salida_TSH_Reserva);
                SS_Contexto.SaveChanges();
                dbTransaction.Commit();
            } catch (Exception ex) {
                dbTransaction.Rollback();
                throw new Exception(ex.ToString());
            }
            return reserva;
        }//Fin del método insertarReserva.

    }//Fin de la clase RepositorioReserva.
}//Fin del namespace.
