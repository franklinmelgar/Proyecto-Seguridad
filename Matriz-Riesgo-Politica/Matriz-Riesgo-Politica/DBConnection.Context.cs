﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Matriz_Riesgo_Politica
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Gestion_RiesgosEntities : DbContext
    {
        public Gestion_RiesgosEntities()
            : base("name=Gestion_RiesgosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activo> Activos { get; set; }
        public virtual DbSet<categoriasAmenaza> categoriasAmenazas { get; set; }
        public virtual DbSet<impactoRiesgo> impactoRiesgoes { get; set; }
        public virtual DbSet<posibilidadRiesgo> posibilidadRiesgoes { get; set; }
        public virtual DbSet<seccionPoliticaAmenaza> seccionPoliticaAmenazas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<cabeceraAnalisisRiesgo> cabeceraAnalisisRiesgoes { get; set; }
        public virtual DbSet<enunciadoPoliticaAmenaza> enunciadoPoliticaAmenazas { get; set; }
        public virtual DbSet<AccionRiesgo> AccionRiesgoes { get; set; }
        public virtual DbSet<configuracionRiesgo> configuracionRiesgoes { get; set; }
        public virtual DbSet<detalleAnalisisRiesgo> detalleAnalisisRiesgoes { get; set; }
    }
}
