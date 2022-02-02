using System.ComponentModel.DataAnnotations;

namespace UmbracoTestProject.Core.ViewModels
{
    public class ContactFormViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
