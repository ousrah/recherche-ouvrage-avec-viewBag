﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class librairieEntities : DbContext
    {
        public librairieEntities()
            : base("name=librairieEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<CATALOGUE> CATALOGUE { get; set; }
        public virtual DbSet<CLASSIFICATION> CLASSIFICATION { get; set; }
        public virtual DbSet<DEPOT> DEPOT { get; set; }
        public virtual DbSet<ECRIVAIN> ECRIVAIN { get; set; }
        public virtual DbSet<EDITEUR> EDITEUR { get; set; }
        public virtual DbSet<OUVRAGE> OUVRAGE { get; set; }
        public virtual DbSet<STOCKER> STOCKER { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TARIFER> TARIFER { get; set; }
        public virtual DbSet<test> test { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}
