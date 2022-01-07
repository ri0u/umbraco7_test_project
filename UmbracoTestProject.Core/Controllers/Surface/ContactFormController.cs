using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoTestProject.Core.ViewModels;

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
            return RedirectToCurrentUmbracoPage();
        }
    }
}
