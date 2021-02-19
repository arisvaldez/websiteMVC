using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website.Models;
using Dapper;

namespace website.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logear(FormCollection data)
        {

            var cn = DBConection.ConectionMySQL.GetConnection();
            string query = "SELECT * FROM User WHERE user=@user AND pwd=@Password";
            var result = cn.Query<UserModel>(query, new { user = data["user"], Password = data["Password"] }).ToList();

            if (result.Count != 1)
            {
                ViewBag.Errors = "Usuario o Contraseña Invalidos";
                return View("Index");
            }
            else
            {
                Session["user"] = result[0].User;
                return RedirectPermanent("/Home");
            }
        }


        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            return View("Index");
        }
    }
}