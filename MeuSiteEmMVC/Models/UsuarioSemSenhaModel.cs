using MeuSiteEmMVC.Enums;
using System.ComponentModel.DataAnnotations;

namespace MeuSiteEmMVC.Models
{
    public class UsuarioSemSenhaModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o login do usuário.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário.")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o perfil do usuário.")]
        public PerfilEnum? Perfil { get; set; }


    }
}
