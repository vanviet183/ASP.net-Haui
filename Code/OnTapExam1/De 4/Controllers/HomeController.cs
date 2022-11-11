using De_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace De_4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cau1()
        {
            return View();
        }

        public ActionResult Tinh()
        {
            return View("Cau1");
        }

        public ActionResult Cau2()
        {
            return View();
        }

        public ActionResult KetQua(GiangVien gv)
        {
            gv.maGV = Request["maGV"].ToString();
            gv.hoTen = Request["hoTen"].ToString();
            gv.soGio = Request["soGio"] == null ? 0 : int.Parse(Request["soGio"]);
            gv.luongGio = Request["soGio"] == null ? 0 : float.Parse(Request["luongGio"]);
            gv.luongThang = 0;

            if(gv.soGio >= 120)
            {
                gv.luongThang = gv.soGio * gv.luongGio * 1.1;
            } else
            {
                gv.luongThang = gv.soGio * gv.luongGio;
            }
            return View(gv);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}