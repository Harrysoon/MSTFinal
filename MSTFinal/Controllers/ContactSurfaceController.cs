﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.Mvc;
using MSTFinal.Models;
using System.Web.Mvc;
using System.Net.Mail;
using System.Threading;

namespace MSTFinal.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        [HttpPost]
        public ActionResult CreateContactMessage(ContactModel model)
        {
            string EncodedResponse = Request.Form["g-Recaptcha-Response"];
            bool IsCaptchaValid = (RecaptchaClass.Validate(EncodedResponse) == "True" ? true : false);

            if (IsCaptchaValid)
            {
                if (!ModelState.IsValid)
                {
                    TempData["IsSuccessful"] = false;
                    return CurrentUmbracoPage();
                }
                ViewBag.Contact = model;

                var mobileNumber = "";
                if (model.MobileNumber != null)
                {
                    mobileNumber = model.MobileNumber;
                }
                else
                {
                    mobileNumber = "No Mobile Number";
                }

                MailMessage email = new MailMessage(model.EmailAddress, "admin@mstfitness.co.uk");
                email.Subject = model.Name + " | MST Fitness Enquiry";
                email.Body = model.Name + "\n\n" + model.EmailAddress + "\n\n" + mobileNumber + "\n\n\n" + model.Message;

                try
                {
                    /*var sendMail = new Thread(() =>
                    SendEmail(email));
                sendMail.Start();*/
                    SendEmail(email);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    
                }

                TempData["IsSuccessful"] = true;


                return RedirectToCurrentUmbracoPage();
            }
            
            TempData["Error"] = true;
            return CurrentUmbracoPage();
        }
        private void SendEmail(MailMessage email)
        {
            SmtpClient smtp = new SmtpClient();

            Thread t = new Thread(delegate ()
            {
                smtp.Send(email);
            });

            t.Start();
        }
    }
}