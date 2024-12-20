using System.ComponentModel.DataAnnotations;

namespace Hw_AtributValidation.Models
{
	public class Person
	{

		public bool TermsOfService { get; set; }
		[CreditCard]
		public string CreditNumber { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		[Compare("Password")]
		public string ConfirmPassword { get; set; }
		[EmailAddress]
		[Required]
		public string Email { get; set; }
	}
}
