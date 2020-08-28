using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Services.Protocols;

namespace ProyectoFinal.Models
{
    public class QuerysModel
    {
        CARRITO_DE_COMPRAEntities1 BD = new CARRITO_DE_COMPRAEntities1();
        public List<PRODUCTO> ListarProductos()
        {
            var result = BD.Database.SqlQuery<PRODUCTO>("EXEC LISTAR_PRODUCTOS");

            return result.ToList();
        }
        public List<LISTARCARRITO_Result> ListarCarrito(String usuario)
        {

            var result = BD.Database.SqlQuery<LISTARCARRITO_Result>("EXEC LISTARCARRITO @COD_USUARIO ="+usuario);

            return result.ToList();

        }
        public int AgregarACarrito(String cod_producto, String cod_usuario)
        {
            System.Data.Entity.Core.Objects.ObjectParameter AffectedRows = new System.Data.Entity.Core.Objects.ObjectParameter("AR", typeof(Int32));
            using (var context = new CARRITO_DE_COMPRAEntities1())
            {
                context.AGREGARACARRITO(cod_usuario, cod_producto, AffectedRows);
            }

            int ar = Convert.ToInt32(AffectedRows.Value);

            return ar;
        }

    }
}