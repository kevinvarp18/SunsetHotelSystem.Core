﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Aplicacion.Interfaces;
using SunsetHotelSystem.Dominio.IRepositorio;
using SunsetHotelSystem.Dominio.Entidades.Entidades;
using SunsetHotelSystem.Dominio.UTL;


namespace SunsetHotelSystem.Aplicacion.Implementacion {
    public class FacilidadesLN : IFacilidadesLN {
        #region
        private readonly IRepositorioFacilidades DominioFacilidades;
        #endregion

        public FacilidadesLN(IRepositorioFacilidades repositorio) {
            DominioFacilidades = repositorio;
        }//Fin del constructor.

        public Respuesta<List<TSH_Pag_Facilidades>> lfObtener() {
            Respuesta<List<TSH_Pag_Facilidades>> respuesta = new Respuesta<List<TSH_Pag_Facilidades>>();

            try {
                respuesta.valorRetorno = DominioFacilidades.obtener();
                respuesta.resultado = 1;
            } catch (Exception ex) {
                respuesta.bnlIndicadorTransaccion = false;
                respuesta.valorRetorno = null;
                respuesta.strOrigen = ex.ToString();
                respuesta.resultado = 0;
            }//Fin del try-catch.
            return respuesta;
        }//Fin del método lfObtener.
    }//Fin de la clase FacilidadesLN.
}//Fin del namespace.
