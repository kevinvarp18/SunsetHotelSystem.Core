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
    [RoutePrefix("api/TSH_Reserva")]
    public class TSH_ReservaController : ApiController {

        [Route("")]
        [HttpPost]
        [ResponseType(typeof(Respuesta<TSH_Reserva>))]
        public IHttpActionResult agregarReservacion([FromBody]TSH_Reserva reserva) {
            ReservaLN reservaLN = FabricaIoC.Container.Resolver<ReservaLN>();
            return Json(reservaLN.lfInsertar(reserva), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }

        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<List<TSH_Reserva>>))]
        public IHttpActionResult obtenerReservas()
        {
            Respuesta<List<TSH_Reserva>> respuesta = new Respuesta<List<TSH_Reserva>>();
            var reservaLN = FabricaIoC.Container.Resolver<ReservaLN>();
            return Json(reservaLN.lfObtener(), new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método HabitacionDisponible.

    }//Fin de la clase ReservaController.
}//Fin del namespace.