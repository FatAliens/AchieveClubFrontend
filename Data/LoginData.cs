using System.ComponentModel.DataAnnotations;

namespace AchieveClubFrontend.Data
{
    public class LoginData
    {
        [Required(ErrorMessage = "Email обязателен.")]
        [EmailAddress(ErrorMessage = "Введен неверный Email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пароль обязателен.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$", ErrorMessage = "Пароль должен состоять не менее чем из 6 символов, содержать только английские буквы и цифры, а также хотя бы одну букву и одну цифру.")]
        public string Password { get; set; }
    }

}
