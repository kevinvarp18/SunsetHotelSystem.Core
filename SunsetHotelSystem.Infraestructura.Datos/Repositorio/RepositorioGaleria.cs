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
    public class RepositorioGaleria : IRepositorioGaleria {
        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioGaleria(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public List<TSH_SobreN_Galeria> obtener() {
            List<TSH_SobreN_Galeria> listaGaleria = new List<TSH_SobreN_Galeria>();
            try {
                listaGaleria = (from list in SS_Contexto.TSH_SobreN_Galeria select list).ToList<TSH_SobreN_Galeria>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return listaGaleria;
        }//Fin del método obtener.
    }//Fin de la clase RepositorioGaleria.
}//Fin del namespace.
