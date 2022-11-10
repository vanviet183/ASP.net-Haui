using OnTapExam1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnTapExam1.Controllers
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

        public ActionResult CalculateHang()
        {
            return View("Cau1");
        }

        public ActionResult Cau2()
        {
            return View();
        }

        public ActionResult KetQua(Hang hang)
        {
            return View(hang);
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