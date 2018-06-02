using Newtonsoft.Json;
using SunsetHotelSystem.Aplicacion.Implementacion;
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
    [RoutePrefix("api/TSH_Pag_Facilidades")]
    public class TSH_Pag_FacilidadesController : ApiController {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<TSH_Pag_Facilidades>))]
        public IHttpActionResult obtenerFacilidades() {
            Respuesta<TSH_Pag_Facilidades> respuesta = new Respuesta<TSH_Pag_Facilidades>();
            var paginaLN = FabricaIoC.Container.Resolver<FacilidadesLN>();
            return Json(paginaLN.lfObtener(), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerFacilidades.

        [Route("")]
        [HttpPost]
        [ResponseType(typeof(Respuesta<TSH_Pag_Facilidades>))]
        public IHttpActionResult insertarFacilidad([FromBody]TSH_Pag_Facilidades facilidad) {
            FacilidadesLN facilidadLN = FabricaIoC.Container.Resolver<FacilidadesLN>();
            return Json(facilidadLN.lfInsertar(facilidad), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método agregarReserva.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<TSH_Pagina>))]
        public IHttpActionResult actualizarFacilidades([FromBody]TSH_Pag_Facilidades facilidad) {
            FacilidadesLN facilidadesLN = FabricaIoC.Container.Resolver<FacilidadesLN>();
            return Json(facilidadesLN.lfActualizar(facilidad), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método actualizarFacilidades.

    }//Fin de la clase TSH_Pag_FacilidadesController
}//Fin del namespace.