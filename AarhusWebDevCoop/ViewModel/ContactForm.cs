using System.ComponentModel.DataAnnotations;

namespace AarhusWebDevCoop.ViewModel
{
    public class ContactForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email adressen er ikke gyldig")]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}