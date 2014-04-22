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
        public ActionResult Registrar(FormCollection values)
        {
            if (Request.HttpMethod == "POST") 
            {
                /*string nombre = Request.Form["txtNombre"];

                ViewBag.nombreRecuperado = nombre;*/

                string nombre = values["txtNombre"];

                ViewBag.nombreRecuperado = nombre;

                return View();
            }

            return View();
        }
	}
}