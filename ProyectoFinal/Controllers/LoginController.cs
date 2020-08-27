using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class LoginController : Controller {

        // GET: Login
        String autorizado = "No";
        public ActionResult IniciarSesion(){

            return View();
        }
        
        [HttpPost]
        public ActionResult ValidarAcceso(string Usuario,string Contrasena){
            List<USUARIO> Datos = new List<USUARIO>();

            string USER = "";
            string USER_ID = "";

            LoginModel model = new LoginModel();
            if (Usuario != "" || Contrasena != ""){
                Datos = model.ConsultarUsuario(Usuario, Contrasena);
                if (Datos.Count > 0){
                     USER = Datos.First().NOMBRE;
                     USER_ID = Datos.First().COD_USUARIO;
                }
            }

            Session["Usuario"] = USER;
            Session["Cod_usuario"] = USER_ID;

            if (Datos.Count > 0) {
                autorizado = "Si";
                return Json(Datos);
            }else{
                autorizado = "No";
                return Json(Datos);
            }

        }//Fin de ValidarAcceso
        public String Autenticar(String Usuario, String Contrasena)
        {
            ValidarAcceso(Usuario, Contrasena);
            return autorizado;
        }
        public ActionResult CrearUsuario(){
            return View();
        }
    }

}