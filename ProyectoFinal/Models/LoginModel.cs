using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class LoginModel
    {


        public List<USUARIO> ConsultarUsuario(string USUARIO, string CONTRASENA){

            using (var contextoBD = new CARRITO_DE_COMPRAEntities()){
                List<USUARIO> Usuario = new List<USUARIO>();

                Usuario = (from x in contextoBD.USUARIO
                                 where x.CORREO == USUARIO
                                 && x.CONTRASENA == CONTRASENA
                           select x).ToList();

                return Usuario;
            }
        }

    }
}