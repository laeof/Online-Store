using System.ComponentModel.DataAnnotations;

namespace Online_Store.Models
{
	public class LoginViewModel
	{
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Password { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
