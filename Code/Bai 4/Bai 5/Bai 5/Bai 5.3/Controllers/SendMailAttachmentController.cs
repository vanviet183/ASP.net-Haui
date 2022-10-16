using Bai_5._3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;


// Nguyen Van Viet 2020600886 Bai 5.3

namespace Bai_5._3.Controllers
{
    public class SendMailAttachmentController : Controller
    {
        // GET: SendMailAttachment
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MailInfo model, HttpPostedFileBase fileUploader)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(model.From);
                mail.To.Add(model.To);
                mail.Subject = model.Subject;
                mail.Body = model.Note;
                mail.IsBodyHtml = false;

                var fileUpload = Request.Files["fileUpload"];

                if (fileUpload != null)
                {
                    string fileName = Path.GetFileName(fileUploader.FileName);
                    mail.Attachments.Add(new Attachment(fileUploader.InputStream, fileName));
                }

                // Can set to false, if you are sending pure text.
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(model.From, "pass");
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                    smtp.EnableSsl = true;
                    ViewBag.Message = "Sent";
                    smtp.Send(mail);
                }
            }

            return RedirectToAction("Index", "Mail");

        }

    }
}