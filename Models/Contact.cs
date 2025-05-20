
using System.ComponentModel.DataAnnotations;

namespace ContactApp.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string MobilePhone { get; set; }

        [Phone]
        public string AlternativePhone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Description { get; set; }
    }
}
