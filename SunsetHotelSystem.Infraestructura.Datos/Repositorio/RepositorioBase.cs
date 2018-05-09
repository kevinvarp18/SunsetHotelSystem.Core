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
    public class RepositorioBase<Entidad> /*: IRepositorioBase<Entidad> where Entidad : class*/ {

        private readonly SunsetHotel_DBEntities SS_Contexto;

        public RepositorioBase(SunsetHotel_DBEntities contexto) {
            SS_Contexto = contexto;
        }//Fin del constructor.

        //List<Entidad> obtenerTodos() {
        //}
        //Entidad obtenerPorID(int id) {
        //}
        //Entidad insertar(Entidad entidad) {
        //}
        //Entidad actualizar(Entidad entidad) {
        //}
        //Boolean eliminar(Entidad user) {
        //}

    }//Fin de la clase RepositorioBase
}//Fin del namespace.

