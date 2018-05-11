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
    [RoutePrefix("api/TSH_Pagina")]
    public class TSH_PaginaController : ApiController {
        [Route("{idPagina}")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<TSH_Pagina>))]
        public IHttpActionResult obtenerPaginaHome(int idPagina) {
            Respuesta<TSH_Pagina> respuesta = new Respuesta<TSH_Pagina>();
            var paginaLN = FabricaIoC.Container.Resolver<PaginaLN>();
            return Json(paginaLN.lfObtenerPorID(idPagina), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerPaginaHome.

        [Route("")]
        [HttpPut]
        [ResponseType(typeof(Respuesta<TSH_Pagina>))]
        public IHttpActionResult actualizarPaginaHome([FromBody]TSH_Pagina pagina) {
            PaginaLN paginaLN = FabricaIoC.Container.Resolver<PaginaLN>();
            return Json(paginaLN.lfActualizar(pagina), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método actualizarPaginaHome
    }//Fin de la clase TSH_Pag_HomeController
}//Fin del namespace.