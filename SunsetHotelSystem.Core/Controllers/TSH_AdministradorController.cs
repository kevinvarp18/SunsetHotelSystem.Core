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
    [RoutePrefix("api/TSH_Administrador")]
    public class TSH_AdministradorController : ApiController {

        [Route("")]
        [HttpPost]
        [ResponseType(typeof(Respuesta<TSH_Administrador>))]
        public IHttpActionResult obtenerAdministradorID(TSH_Administrador administrador) {
            Respuesta<TSH_Administrador> respuesta = new Respuesta<TSH_Administrador>();
            var administradorLN = FabricaIoC.Container.Resolver<AdministradorLN>();
            return Json(administradorLN.lfObtenerPorID(administrador), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerAdministradorID.
    }//Fin de la clase TSH_AdministradorController.
}//Fin del namespace.