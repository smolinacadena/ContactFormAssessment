using System.ComponentModel.DataAnnotations;

namespace ContactForm.Models
{
    public class ContactModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public string ContactMessage { get; set; }
    }
}
