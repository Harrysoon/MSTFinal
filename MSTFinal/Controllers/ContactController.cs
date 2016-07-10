using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSTFinal.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public ActionResult ContactForm()
        {
            return View();
        }
    }
}