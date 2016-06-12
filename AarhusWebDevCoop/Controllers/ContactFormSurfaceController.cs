using System.Net.Mail;
using System.Web.Mvc;
using AarhusWebDevCoop.ViewModel;
using Umbraco.Web.Mvc;

namespace AarhusWebDevCoop.Controllers
{
    public class ContactFormSurfaceController : SurfaceController
    {
        public ActionResult Index()
        {
            return PartialView("ContactFormPartial", new ContactForm());
        }

        [HttpPost]
        public ActionResult HandleFormSubmit(ContactForm model)
        {
            if (!ModelState.IsValid) { return CurrentUmbracoPage(); }
            using (var smtp = new SmtpClient()) 
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("soren.brock@gmail.com", "passwordNotUploaded");
                smtp.EnableSsl = true;
                var message = new MailMessage();
                message.To.Add("soren.brock@gmail.com");
                message.Subject = model.Subject;
                message.From = new MailAddress(model.Email, model.Name);
                message.Body = model.Message;
                //smtp.Send(message);
            }

            var comment = Services.ContentService.CreateContent(model.Subject, CurrentPage.Id, "Comment"); // CONTENT API
            comment.SetValue("commentName", model.Name);
            comment.SetValue("email", model.Email);
            comment.SetValue("subject", model.Subject);
            comment.SetValue("message", model.Message);
                
            Services.ContentService.Save(comment);
  
            TempData["success"] = true;
            return RedirectToCurrentUmbracoPage();
        }
    }   
}