using FreelancerAPI.Data;
using FreelancerAPI.Models;

namespace FreelancerAPI.Services
{
	public class UserService : IUserService
	{
		private AppDbContext _addDbContext;
		public UserService(AppDbContext addDbContext) 
		{
			_addDbContext = addDbContext;
		}
		public List<User> GetUsers()
		{
			return _addDbContext.User.ToList();
		}
		public void CreateUser(User user)
		{
			_addDbContext.User.Add(user);
			_addDbContext.SaveChanges();
		}
		public User GetUserByUId(int uId)
		{
			User selectedUser = _addDbContext.User.FirstOrDefault(x => x.UId == uId) ?? new User();
			return selectedUser;
		}
		public void DeleteUser(User user)
		{
			_addDbContext.User.Remove(user);
			_addDbContext.SaveChanges();
		}

		public void Updateuser(User user)
		{
			_addDbContext.User.Update(user);
			_addDbContext.SaveChanges();
		}
	}
}
