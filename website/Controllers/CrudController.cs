using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{   
    public class CrudController : Controller
    {
        List<Libro> libros;

        public CrudController()
        {
            libros = new List<Libro>()
            {
                new Libro()
                {
                    Id = 1,
                    Titulo = "La Gran Controversias",
                    FechaPublicacion = "1880"
                },

                new Libro()
                {
                    Id = 2,
                    Titulo = "La Gran Batalla",
                    FechaPublicacion = "1910"
                },
                
                new Libro()
                {
                    Id = 3,
                    Titulo = "La Batalla Final",
                    FechaPublicacion = "1980"
                }
            };
        }

        // GET: Crud
        public ActionResult Index()
        {
            ViewBag.Datos = libros;
            return View();
        }

        // GET: Crud/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Datos = libros[id-1];
            return View();
        }

        // GET: Crud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crud/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                ViewBag.Datos = collection;
                return View();
               // return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Crud/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Crud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Crud/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Crud/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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

    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string FechaPublicacion { get; set; }
    }
}
