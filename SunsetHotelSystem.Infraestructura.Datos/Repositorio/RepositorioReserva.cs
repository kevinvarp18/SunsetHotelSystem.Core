using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Infraestructura.Datos.Repositorio {
    public class RepositorioReserva : IRepositorioReserva {

        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioReserva(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public void insertar(TSH_Reserva reserva) {
            try {
                SS_Contexto.sp_realizarReserva(reserva.TSH_Cliente.TC_Nombre_TSH_Cliente, reserva.TSH_Cliente.TC_Apellidos_TSH_Cliente, reserva.TSH_Cliente.TC_Correo_TSH_Cliente, reserva.TSH_Cliente.TC_Tarjeta_TSH_Cliente, reserva.TN_Numero_Reserva_TSH_Reserva, reserva.TN_Num_Habitacion_TSH_Reserva, reserva.TD_Fecha_Ingreso_TSH_Reserva, reserva.TD_Fecha_Salida_TSH_Reserva);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }//Fin del método insertar.

        public List<TSH_Reserva> obtener() {
            List<TSH_Reserva> listaReservas = new List<TSH_Reserva>();
            try {
                listaReservas = (from list in SS_Contexto.TSH_Reserva select list).ToList<TSH_Reserva>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return listaReservas;
        }//Fin del método obtener.

    }//Fin de la clase RepositorioReserva.
}//Fin del namespace.
