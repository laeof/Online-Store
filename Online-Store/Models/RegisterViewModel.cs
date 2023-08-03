using System.ComponentModel.DataAnnotations;

namespace Online_Store.Models
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage = "Обов'язкове поле")]
		public string Name { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Невірний формат електронної пошти")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Обов'язкове поле")]
        [RegularExpression(@"^\+38 \(\d{3}\)-\d{3}-\d{2}-\d{2}$", ErrorMessage = "Невірний формат номеру телефону")]
        public string PhoneNumber { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
