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
    [RoutePrefix("api/TSH_Pag_Home")]
    public class TSH_Pag_HomeController : ApiController {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<TSH_Pag_Home>))]
        public IHttpActionResult obtenerPaginaHome() {
            Respuesta<List<TSH_Pag_Home>> respuesta = new Respuesta<List<TSH_Pag_Home>>();
            var homeLN = FabricaIoC.Container.Resolver<HomeLN>();
            return Json(homeLN.lfObtenerPorID(5), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerPaginaHome.
    }//Fin de la clase TSH_Pag_HomeController
}//Fin del namespace.