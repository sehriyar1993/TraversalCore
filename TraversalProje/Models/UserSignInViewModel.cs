using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;


namespace TraversalProje.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "İfadəçi adı qeyd edin")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "şifrənizi  qeyd edin")]
        public string? Password { get; set; }
    }
}
