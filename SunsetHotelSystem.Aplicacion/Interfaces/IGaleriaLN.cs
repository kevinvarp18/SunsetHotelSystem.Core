using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunsetHotelSystem.Dominio.Entidades;
using SunsetHotelSystem.Dominio.UTL;

namespace SunsetHotelSystem.Aplicacion.Interfaces {
    public interface IGaleriaLN {
        Respuesta<List<TSH_SobreN_Galeria>> lfObtener();
    }//Fin de la interfaz IGaleriaLN.
}//Fin del namespace.
