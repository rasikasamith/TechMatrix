using FreelancerAPI.Models;

namespace FreelancerAPI.Services
{
	public interface IUserService
	{
		public List<User> GetUsers();
		public void CreateUser(User user);
		public User GetUserByUId(int uId);
		public void DeleteUser(User user);
		public void Updateuser(User user);
	}
}
