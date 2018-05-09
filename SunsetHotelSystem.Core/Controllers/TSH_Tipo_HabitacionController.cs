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
    [RoutePrefix("api/TSH_Tipo_Habitacion")]
    public class TSH_Tipo_HabitacionController : ApiController {
        [Route("")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<List<TSH_Tipo_Habitacion>>))]
        public IHttpActionResult obtenerTiposHabitacion() {
            Respuesta<List<TSH_Tipo_Habitacion>> respuesta = new Respuesta<List<TSH_Tipo_Habitacion>>();
            var tipoHabitacionLN = FabricaIoC.Container.Resolver<TipoHabitacionLN>();
            return Json(tipoHabitacionLN.lfObtener(), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método HabitacionDisponible.

        [Route("{tipoHabitacion}")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<SP_ConsultarDisponibilidad_Result>))]
        public IHttpActionResult obtenerTipoHabitacion(int tipoHabitacion) {
            Respuesta<SP_ConsultarDisponibilidad_Result> respuesta = new Respuesta<SP_ConsultarDisponibilidad_Result>();
            var habitacionLN = FabricaIoC.Container.Resolver<HabitacionLN>();
            return Json(habitacionLN.lfObtenerHabitacionesDisponibles(tipoHabitacion), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método HabitacionDisponible.
    }
}