using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TinhToan(double a, double b, string operation = "add")
        {
                //double a = Double.Parse(data["a"]);
                //double b = Double.Parse(data["b"]);
                //String operation = data["operation"];
                switch (operation)
                {
                    case "add":
                        ViewBag.Total = a + b;
                        break;

                    case "sub":
                        ViewBag.Total = a - b;
                        break;

                    case "mul":
                        ViewBag.Total = a * b;
                        break;

                    case "div":
                    if (b == 0)
                        ViewBag.kq = "Khong chia duoc cho 0.";
                    else
                        ViewBag.Total = a / b;
                    break;
                }

            return View("Index");
        }
    }
}