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
    }
}