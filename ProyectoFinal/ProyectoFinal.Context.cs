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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
        public virtual DbSet<PRODUCTOSXUSUARIO> PRODUCTOSXUSUARIO { get; set; }
    
        public virtual int AGREGARACARRITO(string uSUARIO, string pRODUCTO, ObjectParameter aR)
        {
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var pRODUCTOParameter = pRODUCTO != null ?
                new ObjectParameter("PRODUCTO", pRODUCTO) :
                new ObjectParameter("PRODUCTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGARACARRITO", uSUARIOParameter, pRODUCTOParameter, aR);
        }
    
        public virtual ObjectResult<LISTAR_PRODUCTOS_Result> LISTAR_PRODUCTOS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LISTAR_PRODUCTOS_Result>("LISTAR_PRODUCTOS");
        }
    
        public virtual ObjectResult<LISTARCARRITO_Result> LISTARCARRITO(string cOD_USUARIO)
        {
            var cOD_USUARIOParameter = cOD_USUARIO != null ?
                new ObjectParameter("COD_USUARIO", cOD_USUARIO) :
                new ObjectParameter("COD_USUARIO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LISTARCARRITO_Result>("LISTARCARRITO", cOD_USUARIOParameter);
        }
    
        public virtual int AGREGARACARRITO1(string uSUARIO, string pRODUCTO, ObjectParameter aR)
        {
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var pRODUCTOParameter = pRODUCTO != null ?
                new ObjectParameter("PRODUCTO", pRODUCTO) :
                new ObjectParameter("PRODUCTO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AGREGARACARRITO1", uSUARIOParameter, pRODUCTOParameter, aR);
        }
    }
}
