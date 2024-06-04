using System.ComponentModel.DataAnnotations;

namespace MOTChecker.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Registration number is required")]
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Registration number can only contain letters and numbers")]
        [StringLength(7, MinimumLength = 1, ErrorMessage = "Registration number must be between 1 and 7 characters")]
        public string Registration { get; set; }
    }
}
