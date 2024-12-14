using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "O Nome é Obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O E-mail é Obrigatório")]
        [EmailAddress(ErrorMessage = " O E-mail é Invalido")]
        public string Email { get; set; }
    }
}
