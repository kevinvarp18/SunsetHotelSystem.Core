using Newtonsoft.Json;
using SunsetHotelSystem.Aplicacion.Implementación;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;
using SunsetHotelSystem.Infraestructura.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace SunsetHotelSystem.Core.Controllers {
    [RoutePrefix("api/Prueba")]
    public class PruebaController : ApiController {
        // GET: api/Prueba
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<List<TSH_Tipo_Habitacion>>))]
        public IHttpActionResult GetTipoHabitacion() {
            Respuesta<List<TSH_Tipo_Habitacion>> respuesta = new Respuesta<List<TSH_Tipo_Habitacion>>();
            var tipoHabitacionLN = FabricaIoC.Container.Resolver<TipoHabitacionLN>();
            return Json(tipoHabitacionLN.lfObtener(), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método ObtenerTiposHabitacion.

        // GET: api/Prueba/5
        public string Get(int id) {
            return "value";
        }

        // POST: api/Prueba
        public void Post([FromBody]string value) {
        }

        // PUT: api/Prueba/5
        public void Put(int id, [FromBody]string value) {
        }

        // DELETE: api/Prueba/5
        public void Delete(int id) {
        }
    }
}
