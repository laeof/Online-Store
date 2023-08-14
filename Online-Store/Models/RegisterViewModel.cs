using System.ComponentModel.DataAnnotations;

namespace Online_Store.Models
{
	public class RegisterViewModel
	{
        [Required(ErrorMessage = "Обов'язкове поле")]
		public string FirstName { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Невірний формат електронної пошти")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string PhoneNumber { get; set; }
    }
}
