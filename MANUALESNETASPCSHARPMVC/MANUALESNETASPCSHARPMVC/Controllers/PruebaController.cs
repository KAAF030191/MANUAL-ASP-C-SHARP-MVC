using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MANUALESNETASPCSHARPMVC.Models;

namespace MANUALESNETASPCSHARPMVC.Controllers
{
    public class PruebaController : Controller
    {
        private DbContextTUsuario db = new DbContextTUsuario();

        // GET: /Prueba/
        public ActionResult Index()
        {
            return View(db.tUsuario.ToList());
        }

        // GET: /Prueba/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TUsuario tusuario = db.tUsuario.Find(id);
            if (tusuario == null)
            {
                return HttpNotFound();
            }
            return View(tusuario);
        }

        // GET: /Prueba/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Prueba/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="codigoUsuario,nombre,apellidoPaterno,apellidoMaterno,correoElectronico,contrasenia,fechaNacimiento,sexo")] TUsuario tusuario)
        {
            if (ModelState.IsValid)
            {
                db.tUsuario.Add(tusuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tusuario);
        }

        // GET: /Prueba/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TUsuario tusuario = db.tUsuario.Find(id);
            if (tusuario == null)
            {
                return HttpNotFound();
            }
            return View(tusuario);
        }

        // POST: /Prueba/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="codigoUsuario,nombre,apellidoPaterno,apellidoMaterno,correoElectronico,contrasenia,fechaNacimiento,sexo")] TUsuario tusuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tusuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tusuario);
        }

        // GET: /Prueba/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TUsuario tusuario = db.tUsuario.Find(id);
            if (tusuario == null)
            {
                return HttpNotFound();
            }
            return View(tusuario);
        }

        // POST: /Prueba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TUsuario tusuario = db.tUsuario.Find(id);
            db.tUsuario.Remove(tusuario);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
