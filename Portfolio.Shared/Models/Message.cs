using System.ComponentModel.DataAnnotations;

namespace Portfolio.Shared.Models
{
    public class Message
    {
        [Required, MaxLength(30, ErrorMessage = "{0} should not exceed {1}")]
        public string Subject { get; set; }


        [Required, MaxLength(500, ErrorMessage = "{0} should not exceed {1}")]
        public string Content { get; set; }
    }
}
