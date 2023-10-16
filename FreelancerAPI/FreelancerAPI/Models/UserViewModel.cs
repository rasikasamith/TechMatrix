using System.ComponentModel.DataAnnotations;

namespace FreelancerAPI.Models
{
	public class UserViewModel
	{
		public int UId { get; set; }

		public string UserName { get; set; }
			
		public string Email { get; set; }

		public string PhoneNumber { get; set; }

		public string SkilSets { get; set; }

		public string Hobby { get; set; }
	}
}
