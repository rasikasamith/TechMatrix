using System.ComponentModel.DataAnnotations;

namespace FreelancerUI.Models
{
	public class UserViewModel
	{
		public int UId { get; set; }

		[Required(ErrorMessage = "User Name is required")]
		public string UserName { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

		public string PhoneNumber { get; set; }
		        
        [Required(ErrorMessage = "Skill set is required")]
        public string SkilSets { get; set; }

		public string Hobby { get; set; }
	}
}
