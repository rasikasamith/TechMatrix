using System.ComponentModel.DataAnnotations;

namespace FreelancerAPI.Models
{
	public class User
	{
		[Key]
		public int UId { get; set; }

		[Required]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		public string Email { get; set; }

		public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Skill set is required")]
        public string SkilSets { get; set; }

		public string Hobby { get; set; }
	}
}
