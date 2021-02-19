using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace website.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = $"Your application description page Hola {Session["user"]} .";
            ViewBag.Recordatorio = "Esto es para que no se te olvide";
            return View();
        }

        public ActionResult Contact()
        {
           
            
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Papaup()
        {
            ViewBag.Resultado = sumar(50, 501);
            ViewBag.Nombre = "Victor Vargas Presidente";
            
            return View();
        }

        public double sumar(double a, double b) 
        {
            return a + b;
        }
    }
}