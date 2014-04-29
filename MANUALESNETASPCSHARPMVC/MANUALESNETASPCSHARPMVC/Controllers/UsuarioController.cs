using MANUALESNETASPCSHARPMVC.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MANUALESNETASPCSHARPMVC.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/
        /*public ActionResult Registrar(FormCollection values)
        {
            if (Request.HttpMethod == "POST") 
            {
                string nombre = Request.Form["txtNombre"];

                ViewBag.nombreRecuperado = nombre;

                string nombre = values["txtNombre"];

                ViewBag.nombreRecuperado = nombre;

                return View();
            }

            return View();
        }*/

        /*public ActionResult Registrar(EntidadTUsuario entidadTUsuario) 
        {
            if (Request.HttpMethod == "POST")
            {
                ViewBag.nombreRecuperado = entidadTUsuario.txtNombre;

                return View();
            }

            return View();
        }*/

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Registrar() 
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Registrar(FormCollection values) 
        {
            string nombre = values["txtNombre"];

            ViewBag.nombreRecuperado = nombre;

            return View();
        }

        public ActionResult VerPorCodigoUsuario(string parametro1) 
        {
            ViewBag.codigoUsuario = parametro1;

            return View();
        }

        public ActionResult VerPorCodigoUsuarioYNombre(string parametro1, string parametro2)
        {
            ViewBag.codigoUsuario = parametro1;
            ViewBag.nombre = parametro2;

            return View();
        }
	}
}