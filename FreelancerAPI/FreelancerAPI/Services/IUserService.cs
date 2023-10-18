using FreelancerAPI.Models;

namespace FreelancerAPI.Services
{
	public interface IUserService
	{	
        public Task<List<User>> GetUsers(); 
        public Task CreateUser(User user);
        public Task<User> GetUserByUId(int uId);
        public Task DeleteUser(User user);
        public Task Updateuser(User user);
    }
}
