using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using MSTFinal.Models;
using System.Web.Mvc;
using System.Net.Mail;

namespace MSTFinal.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        [HttpPost]
        public ActionResult CreateContactMessage(ContactModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["IsSuccessful"] = false;
                return CurrentUmbracoPage();
            }
            ViewBag.Contact = model;

            var mobileNumber = "";
            if(model.MobileNumber != null)
            {
                mobileNumber = model.MobileNumber;
            }
            else
            {
                mobileNumber = "No Mobile Number";
            }

            MailMessage email = new MailMessage(model.EmailAddress, "harry.fleetwood@gmail.com");
            email.Subject = model.Name + " | MST Fitness Enquiry";
            email.Body = model.Name + "\n\n" + model.EmailAddress + "\n\n" + mobileNumber + "\n\n\n" + model.Message;

            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Send(email);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            TempData["IsSuccessful"] = true;


            return RedirectToCurrentUmbracoPage();
        }
    }
}