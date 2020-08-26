using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class QuerysModel
    {
        CARRITO_DE_COMPRAEntities BD = new CARRITO_DE_COMPRAEntities();
        public List<PRODUCTO> ListarProductos()
        {
            var result = BD.Database.SqlQuery<PRODUCTO>("EXEC LISTAR_PRODUCTOS");

            return result.ToList();
        }

    }
}