using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyDemoApp.Models
{
    public class User
    {
        [DisplayName("User Name")]
        [Required(ErrorMessage = "User Name is required.")]
        public string UserName { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [DisplayName("Enter Password")]
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [DisplayName("Re-enter Password")]
        [Required(ErrorMessage = "RePassword is required.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        public string RePassword { get; set; } = string.Empty;

        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Full Name is required.")]
        public string FullName { get; set; } = string.Empty;

        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Phone Number is required.")]
        [Phone(ErrorMessage = "Invalid Phone Number.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [DisplayName("Age")]
        [Required(ErrorMessage = "Age is required.")]
        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }
    }
}
