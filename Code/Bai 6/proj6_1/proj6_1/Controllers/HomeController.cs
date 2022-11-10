﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace proj6_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult GioiThieu()
        {
            ViewBag.Message = "Đây là trang Giới Thiệu.";

            return View();
        }

        public ActionResult TuyenSinh()
        {
            ViewBag.Message = "Đây là trang Tuyển Sinh.";

            return View();
        }

        public ActionResult DaoTao()
        {
            ViewBag.Message = "Đây là trang Đào Tạo";

            return View();
        }
    }
}