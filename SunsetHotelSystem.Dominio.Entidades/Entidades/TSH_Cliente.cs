//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SunsetHotelSystem.Dominio.Entidades.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSH_Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TSH_Cliente()
        {
            this.TSH_Reserva = new HashSet<TSH_Reserva>();
        }
    
        public int TN_Identificador_TSH_Cliente { get; set; }
        public string TC_Nombre_TSH_Cliente { get; set; }
        public string TC_Apellidos_TSH_Cliente { get; set; }
        public string TC_correo_TSH_Cliente { get; set; }
        public string TC_Tarjeta_TSH_Cliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TSH_Reserva> TSH_Reserva { get; set; }
    }
}
