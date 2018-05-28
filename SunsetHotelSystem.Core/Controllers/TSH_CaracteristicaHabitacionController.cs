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
    [RoutePrefix("api/TSH_Caracteristica_Habitacion")]
    public class TSH_CaracteristicaHabitacionController : ApiController {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<List<TSH_CaracteristicaHabitacionController>>))]
        public IHttpActionResult obtenerCaracteristicasHabitaciones() {
            Respuesta<List<TSH_CaracteristicaHabitacionController>> respuesta = new Respuesta<List<TSH_CaracteristicaHabitacionController>>();
            var caracteristicaHabitacionLN = FabricaIoC.Container.Resolver<CaracteristicaHabitacionLN>();
            return Json(caracteristicaHabitacionLN.lfObtener(), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método obtenerCaracteristicasHabitaciones.
    }//Fin de la clase TSH_CaracteristicaHabitacionController.
}//Fin del namespace.