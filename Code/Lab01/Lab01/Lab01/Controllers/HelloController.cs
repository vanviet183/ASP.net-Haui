using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public String Index()
        {
            return "Day la phuong thuc mac dinh";
        }

        public ActionResult Show()
        {
            return View();
        }

    }
}