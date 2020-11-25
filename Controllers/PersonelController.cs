using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rehber.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult Add()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }
    }
}