using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using System.Data.Entity.Core.Objects;

namespace SunsetHotelSystem.Infraestructura.Datos.Repositorio {
    public class RepositorioFacilidades : IRepositorioFacilidades {
        private readonly SunsetHotel_DBEntities SS_Contexto;

        public RepositorioFacilidades(SunsetHotel_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<TSH_Pag_Facilidades> obtener() {
            List<TSH_Pag_Facilidades> listaFacilidades = new List<TSH_Pag_Facilidades>();
            try {
                listaFacilidades = (from list in SS_Contexto.TSH_Pag_Facilidades select list).ToList<TSH_Pag_Facilidades>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return listaFacilidades;
        }//Fin del método obtenerTiposHabitacion.
    }//Fin de la clase RepositorioFacilidades.
}//Fin del namespace.
