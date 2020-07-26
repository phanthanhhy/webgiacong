using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class ChiTietController : Controller
    {
        //
        // GET: /ChiTiet/

        public ActionResult Index()
        {
            //khovatEntities db = new khovatEntities();
            //List<GCX_TienDoGiaCongXuong_ChiTiet> gcx_chiTiet = db.GCX_TienDoGiaCongXuong_ChiTiet.Where(x => x.STT == STT).ToList();
            return View();
        }

        //public ActionResult SaveRecord(GiaCongXuongMutilTable model)
        //{
        //    khovatEntities db = new khovatEntities();
        //    return View();
        //} 

    }
}
