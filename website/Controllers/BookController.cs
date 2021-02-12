using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;

namespace website.Controllers
{   
    public class BookController : Controller
    {
        List<BookModel> libros;

        public BookController()
        {
            libros = new List<BookModel>()
            {
                new BookModel()
                {
                    Id = 1,
                    Titulo = "La Gran Controversias",
                    FechaPublicacion = "1880"
                },

                new BookModel()
                {
                    Id = 2,
                    Titulo = "La Gran Batalla",
                    FechaPublicacion = "1910"
                },
                
                new BookModel()
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
            var model = new BookModel().GetAll();
            return View(model);
        }

        // GET: Crud/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Datos = libros[id-1];
            return View();
        }

        public ActionResult Detalle(int id)
        {
            var model = libros[id - 1];
            return View(model);
        }

        // GET: Crud/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crud/Create
        [HttpPost]
        public ActionResult Create(BookModel model)
        {
            //FormCollection collection
            try
            {
                // TODO: Add insert logic here
                ViewBag.Datos = model;
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

 
}
