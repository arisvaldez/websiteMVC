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

        // GET: Crud
        public ActionResult Index()
        {
           var model = new BookModel().GetAll();
            return View(model);
        }

        // GET: Crud/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Datos = new BookModel().Get(id);
            return View();
        }

        // GET: Crud/Detalle/5
        public ActionResult Detalle(int id)
        {
            var model = new BookModel().Get(id);
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
                new BookModel().Insert(model);

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.Erros = e.Message;
                return View();
            }
        }

        // GET: Crud/Edit/5
        public ActionResult Edit(int id)
        {
           var model =  new BookModel().Get(id);
            return View(model);
        }

        // POST: Crud/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, BookModel model)
        {
            try
            {
                // TODO: Add update logic here
                model.Id = id;
                new BookModel().Edit(model);
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
