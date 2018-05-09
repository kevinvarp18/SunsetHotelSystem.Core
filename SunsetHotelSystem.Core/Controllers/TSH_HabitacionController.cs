﻿using Newtonsoft.Json;
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
    [RoutePrefix("api/TSH_Habitacion")]

    public class TSH_HabitacionController : ApiController {
        [Route("{idHabitacion}")]
        [HttpGet]
        [ResponseType(typeof(Respuesta<TSH_Habitacion>))]
        public IHttpActionResult Reserva(int idHabitacion) {
            Respuesta<TSH_Habitacion> respuesta = new Respuesta<TSH_Habitacion>();
            var habitacionLN = FabricaIoC.Container.Resolver<HabitacionLN>();
            return Json(habitacionLN.lfObtenerPorID(idHabitacion), new JsonSerializerSettings() {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                Formatting = Formatting.Indented
            });
        }//Fin del método HabitacionDisponible.
    }//Fin de la clase.
}//Fin del namespace.