using Bai_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai_7.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result(Operation operation)
        {
            ViewBag.Result = "";
            switch (operation.opt)
            {
                case "+":
                    ViewBag.Result = (operation.a + operation.b).ToString();
                    break;
                case "-":
                    ViewBag.Result = (operation.a - operation.b).ToString();
                    break;
                case "*":
                    ViewBag.Result = (operation.a * operation.b).ToString();
                    break;
                case "/":
                    ViewBag.Result = (operation.a / operation.b).ToString();
                    break;
                default:
                    ViewBag.Result = "";
                    break;
            }
            return View("Index");
        }
    }
}