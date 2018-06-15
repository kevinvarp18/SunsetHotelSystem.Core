using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunsetHotelSystem.Infraestructura.Datos.Repositorio {
    public class RepositorioAdministrador : IRepositorioAdministrador {
        private readonly SunsetHotelSystem_DBEntities SS_Contexto;

        public RepositorioAdministrador(SunsetHotelSystem_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        public TSH_Administrador obtenerPorID(TSH_Administrador administrador) {
            TSH_Administrador administradorTemp = new TSH_Administrador();
            try {
                administradorTemp = (from listaAdministradores in SS_Contexto.TSH_Administrador where (listaAdministradores.TC_Correo_TSH_Administrador.Equals(administrador.TC_Correo_TSH_Administrador) && listaAdministradores.TC_contrasenia_TSH_Administrador.Equals(administrador.TC_contrasenia_TSH_Administrador)) select listaAdministradores).Single<TSH_Administrador>();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }//Fin del try-catch.
            return administradorTemp;
        }//Fin del método obtenerPorID.
    }//Fin de la clase RepositorioAdministrador.
}//Fin del namespace.
