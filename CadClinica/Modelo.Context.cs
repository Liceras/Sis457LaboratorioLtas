﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadClinica
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClinicaEntities : DbContext
    {
        public ClinicaEntities()
            : base("name=ClinicaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Citas> Citas { get; set; }
        public virtual DbSet<Dias> Dias { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Horarios> Horarios { get; set; }
        public virtual DbSet<Medico> Medico { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
