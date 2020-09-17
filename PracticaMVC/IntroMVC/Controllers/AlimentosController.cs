using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class AlimentosController : Controller
    {
        // GET: Alimentos/todos
        public ActionResult Todos()
        {
            return View();
        }

        

        // GET: Alimentos/Alta
        public ActionResult Alta()
        {
            return View();
        }

        // POST: Alimentos/Crear
        [HttpPost]
        public ActionResult Crear(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alimentos/Editar/5
        public ActionResult Editar(int id)
        {
            return View();
        }

        // POST: Alimentos/Editar/5
        [HttpPost]
        public ActionResult Editar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alimentos/Borrar/5
        public ActionResult Borrar(int id)
        {
            return View();
        }

        // POST: Alimentos/Borrar/5
        [HttpPost]
        public ActionResult Borrar(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
