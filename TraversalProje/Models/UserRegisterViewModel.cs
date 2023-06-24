using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace TraversalProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Zəhmət olmasa adınızı qeyd edin")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Zəhmət olmasa soy adınızı qeyd edin")]
		public string? Surname { get; set; }

		[Required(ErrorMessage = "Zəhmət olmasa istifadəçi adınızı qeyd edin")]
		public string? UserName { get; set; }

		[Required(ErrorMessage = "Zəhmət olmasa mail ünvanınızı qeyd edin")]
		public string? Mail { get; set; }

		[Required(ErrorMessage = "Zəhmət olmasa şifrənizi qeyd edin")]
		public string? Password { get; set; }

		[Required(ErrorMessage = "Zəhmət olmasa şifrənizi təkrarlayın")]

		[Compare("Password", ErrorMessage = "Şifrələr uyğun deyil")]
		public string? ConfirmPassword { get; set; }

	}
}
