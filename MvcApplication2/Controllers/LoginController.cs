using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
             return View();
        }
        [HttpPost]
        public ActionResult Authorise(CauHinh user)
        {
            using (khovatEntities db = new khovatEntities())
            {
                db.Database.Connection.Open();
                //var a = db.CauHinhs.ToList();
                var userdetail = db.CauHinhs.Where(x => x.nvUser == user.nvUser && x.nvPass == user.nvPass).FirstOrDefault();
                db.Database.Connection.Close();
                if (userdetail == null)
                {
                    user.LoginErrorMgs = "User và pass không có!";
                    return View("index", user);
                }
                else
                {
                    Session["MaCauHinh"] = user.MaCauHinh;
                    Session["nvUser"] = user.nvUser;
                    return RedirectToAction("Index", "Home");
                }
            }
           // return View();
        }

        public ActionResult Logout()
        {
            //int nvUser = (int)Session["MaCauHinh"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

    }
}
