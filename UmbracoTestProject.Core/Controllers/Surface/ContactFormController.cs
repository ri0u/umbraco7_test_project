using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoTestProject.Core.ViewModels;
using System.Net.Mail;

namespace UmbracoTestProject.Core.Controllers.Surface
{
    public class ContactFormController : SurfaceController
    {
        public ActionResult Render()
        {
            return PartialView("Forms/ContactForm");
        }

        [HttpPost]
        public ActionResult Submit(ContactFormViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                SendEmail(viewModel);
                return RedirectToCurrentUmbracoPage();
            }
            return RedirectToCurrentUmbracoPage();
        }

        private void SendEmail(ContactFormViewModel viewModel)
        {
            MailMessage message = new MailMessage(viewModel.Email, "info@happyporch.com");
            message.Subject = viewModel.Subject;
            message.Body = viewModel.Message;
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);
        }
    }
}
