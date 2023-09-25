﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BRodriguezPruebaTecnica2CompletaEntities : DbContext
    {
        public BRodriguezPruebaTecnica2CompletaEntities()
            : base("name=BRodriguezPruebaTecnica2CompletaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artista> Artistas { get; set; }
        public virtual DbSet<Disco> Discoes { get; set; }
        public virtual DbSet<Distribuidora> Distribuidoras { get; set; }
        public virtual DbSet<GeneroMusical> GeneroMusicals { get; set; }
    
        public virtual ObjectResult<ArtistaGetAll_Result> ArtistaGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ArtistaGetAll_Result>("ArtistaGetAll");
        }
    
        public virtual int DiscoAdd(string titulo, Nullable<System.TimeSpan> duracion, Nullable<System.DateTime> anio, Nullable<int> ventas, string disponibilidad, Nullable<int> idArtista, Nullable<int> idGenero, Nullable<int> idDistribuidora)
        {
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var duracionParameter = duracion.HasValue ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(System.TimeSpan));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("Anio", anio) :
                new ObjectParameter("Anio", typeof(System.DateTime));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(int));
    
            var disponibilidadParameter = disponibilidad != null ?
                new ObjectParameter("Disponibilidad", disponibilidad) :
                new ObjectParameter("Disponibilidad", typeof(string));
    
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            var idGeneroParameter = idGenero.HasValue ?
                new ObjectParameter("IdGenero", idGenero) :
                new ObjectParameter("IdGenero", typeof(int));
    
            var idDistribuidoraParameter = idDistribuidora.HasValue ?
                new ObjectParameter("IdDistribuidora", idDistribuidora) :
                new ObjectParameter("IdDistribuidora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoAdd", tituloParameter, duracionParameter, anioParameter, ventasParameter, disponibilidadParameter, idArtistaParameter, idGeneroParameter, idDistribuidoraParameter);
        }
    
        public virtual int DiscoDelete(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoDelete", idDiscoParameter);
        }
    
        public virtual int DiscoUpdate(Nullable<int> idDisco, string titulo, Nullable<System.TimeSpan> duracion, Nullable<System.DateTime> anio, Nullable<int> ventas, string disponibilidad, Nullable<int> idArtista, Nullable<int> idGenero, Nullable<int> idDistribuidora)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            var tituloParameter = titulo != null ?
                new ObjectParameter("Titulo", titulo) :
                new ObjectParameter("Titulo", typeof(string));
    
            var duracionParameter = duracion.HasValue ?
                new ObjectParameter("Duracion", duracion) :
                new ObjectParameter("Duracion", typeof(System.TimeSpan));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("Anio", anio) :
                new ObjectParameter("Anio", typeof(System.DateTime));
    
            var ventasParameter = ventas.HasValue ?
                new ObjectParameter("Ventas", ventas) :
                new ObjectParameter("Ventas", typeof(int));
    
            var disponibilidadParameter = disponibilidad != null ?
                new ObjectParameter("Disponibilidad", disponibilidad) :
                new ObjectParameter("Disponibilidad", typeof(string));
    
            var idArtistaParameter = idArtista.HasValue ?
                new ObjectParameter("IdArtista", idArtista) :
                new ObjectParameter("IdArtista", typeof(int));
    
            var idGeneroParameter = idGenero.HasValue ?
                new ObjectParameter("IdGenero", idGenero) :
                new ObjectParameter("IdGenero", typeof(int));
    
            var idDistribuidoraParameter = idDistribuidora.HasValue ?
                new ObjectParameter("IdDistribuidora", idDistribuidora) :
                new ObjectParameter("IdDistribuidora", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DiscoUpdate", idDiscoParameter, tituloParameter, duracionParameter, anioParameter, ventasParameter, disponibilidadParameter, idArtistaParameter, idGeneroParameter, idDistribuidoraParameter);
        }
    
        public virtual ObjectResult<DistribuidoraGetALL_Result> DistribuidoraGetALL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DistribuidoraGetALL_Result>("DistribuidoraGetALL");
        }
    
        public virtual ObjectResult<GeneroGetALL_Result> GeneroGetALL()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GeneroGetALL_Result>("GeneroGetALL");
        }
    
        public virtual ObjectResult<DiscoGetAll_Result> DiscoGetAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiscoGetAll_Result>("DiscoGetAll");
        }
    
        public virtual ObjectResult<DiscoGetById_Result> DiscoGetById(Nullable<int> idDisco)
        {
            var idDiscoParameter = idDisco.HasValue ?
                new ObjectParameter("IdDisco", idDisco) :
                new ObjectParameter("IdDisco", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DiscoGetById_Result>("DiscoGetById", idDiscoParameter);
        }
    }
}
