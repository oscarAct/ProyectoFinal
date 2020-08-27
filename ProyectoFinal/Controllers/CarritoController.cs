using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class CarritoController : Controller
    {
        // GET: Carrito
        public ActionResult Carrito()
        {
            if (!string.IsNullOrEmpty(Session["Usuario"] as string))
                return View();
            else
                return View("../Home/Index");
        }
    }
}