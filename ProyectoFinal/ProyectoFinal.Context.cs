﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoFinal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CARRITO_DE_COMPRAEntities : DbContext
    {
        public CARRITO_DE_COMPRAEntities()
            : base("name=CARRITO_DE_COMPRAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CARRITO_DET> CARRITO_DET { get; set; }
        public virtual DbSet<CARRITO_ENC> CARRITO_ENC { get; set; }
        public virtual DbSet<PEDIDO_DET> PEDIDO_DET { get; set; }
        public virtual DbSet<PEDIDO_ENC> PEDIDO_ENC { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}