using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class QuerysController : Controller
    {
        // GET: Querys
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ListarProductos()
        {
            QuerysModel modelo = new QuerysModel();
            var results = modelo.ListarProductos();
            return Json(results);
        }
        [HttpPost]
        public int AgregarACarrito(String codigo)
        {
            QuerysModel modelo = new QuerysModel();
            String cod_usuario = Session["Cod_usuario"].ToString();
            var ar = modelo.AgregarACarrito(codigo, cod_usuario);

            return ar;         
        }
        public JsonResult ListarCarrito()
        {
            QuerysModel modelo = new QuerysModel();
            String cod_usuario = Session["Cod_usuario"].ToString();
            var results = modelo.ListarCarrito(cod_usuario);
            return Json(results);
        }

    }
}