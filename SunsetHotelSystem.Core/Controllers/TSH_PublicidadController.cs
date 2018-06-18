using Newtonsoft.Json;
using SunsetHotelSystem.Aplicacion.Implementacion;
using SunsetHotelSystem.Dominio.Entidades;
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
    [RoutePrefix("api/TSH_Publicidad")]
    public class TSH_PublicidadController : ApiController {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<TSH_Publicidad>))]
        public IHttpActionResult obtenerPublicidad() {
            Respuesta<TSH_Publicidad> respuesta = new Respuesta<TSH_Publicidad>();
            var publicidadLN = FabricaIoC.Container.Resolver<PublicidadLN>();
            return Json(publicidadLN.lfObtener(), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerPublicidad.

        [Route("")]
        [HttpPost]
        [ResponseType(typeof(Respuesta<TSH_Publicidad>))]
        public IHttpActionResult insertarPublicidad([FromBody]TSH_Publicidad publicidad) {
            PublicidadLN publicidadLN = FabricaIoC.Container.Resolver<PublicidadLN>();
            return Json(publicidadLN.lfInsertar(publicidad), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método insertarPublicidad.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<TSH_Publicidad>))]
        public IHttpActionResult actualizarPublicidad([FromBody]TSH_Publicidad publicidad) {
            PublicidadLN publicidadLN = FabricaIoC.Container.Resolver<PublicidadLN>();
            return Json(publicidadLN.lfActualizar(publicidad), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método actualizarPublicidad.
    }//Fin de la clase TSH_PublicidadController.
}//Fin del namespace.