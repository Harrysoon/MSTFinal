using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSTFinal.Models;

namespace MSTFinal.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public ActionResult CreateMessage(ContactModel model)
        {
            return null;
        }
    }
}