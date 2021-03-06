﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SunsetHotelSystem.Dominio.Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SunsetHotelSystem_DBEntities : DbContext
    {
        public SunsetHotelSystem_DBEntities()
            : base("name=SunsetHotelSystem_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TSH_Administrador> TSH_Administrador { get; set; }
        public virtual DbSet<TSH_Caracteristica_habitacion> TSH_Caracteristica_habitacion { get; set; }
        public virtual DbSet<TSH_Cliente> TSH_Cliente { get; set; }
        public virtual DbSet<TSH_Habitacion> TSH_Habitacion { get; set; }
        public virtual DbSet<TSH_Pag_Facilidades> TSH_Pag_Facilidades { get; set; }
        public virtual DbSet<TSH_Pag_Home> TSH_Pag_Home { get; set; }
        public virtual DbSet<TSH_Pagina> TSH_Pagina { get; set; }
        public virtual DbSet<TSH_Publicidad> TSH_Publicidad { get; set; }
        public virtual DbSet<TSH_Reserva> TSH_Reserva { get; set; }
        public virtual DbSet<TSH_SobreN_Galeria> TSH_SobreN_Galeria { get; set; }
        public virtual DbSet<TSH_Tipo_Habitacion> TSH_Tipo_Habitacion { get; set; }
    
        public virtual ObjectResult<SP_ConsultarDisponibilidad_Result> SP_ConsultarDisponibilidad(Nullable<int> idTipoHabitacion)
        {
            var idTipoHabitacionParameter = idTipoHabitacion.HasValue ?
                new ObjectParameter("idTipoHabitacion", idTipoHabitacion) :
                new ObjectParameter("idTipoHabitacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ConsultarDisponibilidad_Result>("SP_ConsultarDisponibilidad", idTipoHabitacionParameter);
        }
    
        public virtual ObjectResult<sp_realizarReserva_Result> sp_realizarReserva(string cedula, string nombre, string apellidos, string correo, string tarjeta, Nullable<System.Guid> idReserva, Nullable<int> numero, Nullable<System.DateTime> fechaLlegada, Nullable<System.DateTime> fechaSalida)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("apellidos", apellidos) :
                new ObjectParameter("apellidos", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var tarjetaParameter = tarjeta != null ?
                new ObjectParameter("tarjeta", tarjeta) :
                new ObjectParameter("tarjeta", typeof(string));
    
            var idReservaParameter = idReserva.HasValue ?
                new ObjectParameter("idReserva", idReserva) :
                new ObjectParameter("idReserva", typeof(System.Guid));
    
            var numeroParameter = numero.HasValue ?
                new ObjectParameter("numero", numero) :
                new ObjectParameter("numero", typeof(int));
    
            var fechaLlegadaParameter = fechaLlegada.HasValue ?
                new ObjectParameter("fechaLlegada", fechaLlegada) :
                new ObjectParameter("fechaLlegada", typeof(System.DateTime));
    
            var fechaSalidaParameter = fechaSalida.HasValue ?
                new ObjectParameter("fechaSalida", fechaSalida) :
                new ObjectParameter("fechaSalida", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_realizarReserva_Result>("sp_realizarReserva", cedulaParameter, nombreParameter, apellidosParameter, correoParameter, tarjetaParameter, idReservaParameter, numeroParameter, fechaLlegadaParameter, fechaSalidaParameter);
        }
    }
}
