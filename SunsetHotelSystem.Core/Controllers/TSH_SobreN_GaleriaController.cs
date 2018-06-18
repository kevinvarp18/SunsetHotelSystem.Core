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
    [RoutePrefix("api/TSH_SobreN_Galeria")]
    public class TSH_SobreN_GaleriaController : ApiController {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<TSH_SobreN_Galeria>))]
        public IHttpActionResult obtenerGaleria() {
            Respuesta<TSH_SobreN_Galeria> respuesta = new Respuesta<TSH_SobreN_Galeria>();
            var galeriaLN = FabricaIoC.Container.Resolver<GaleriaLN>();
            return Json(galeriaLN.lfObtener(), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerGaleria.
    }//Fin de la clase TSH_SobreN_GaleriaController.
}//Fin del namespace.