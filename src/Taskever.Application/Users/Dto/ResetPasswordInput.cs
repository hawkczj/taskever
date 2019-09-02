using System.ComponentModel.DataAnnotations;

namespace Abp.Users.Dto
{
    public class ResetPasswordInput 
    {
        [Range(1, long.MaxValue)]
        public long UserId { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Password { get; set; }

        [StringLength(30, MinimumLength = 3)]
        [Compare("Password", ErrorMessage = "Passwords do no match!")]
        public string PasswordRepeat { get; set; }

        public string PasswordResetCode { get; set; }
    }
}