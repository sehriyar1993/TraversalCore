using Microsoft.AspNetCore.Identity;

namespace TraversalProje.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError() { Code = "PasswordTooShort", Description = $"Şifrə minimum {length} simvol olmalıdır" };
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Şifrədə minimum 1 böyük hərf olmalıdır"
			};
		}
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Şifrədə minimum 1 kiçik hərf olmalıdır"
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Şifrədə minimum 1 simvol  olmalıdır"
			};
		}
	}
	
}
