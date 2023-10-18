using FreelancerAPI.Data;
using FreelancerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FreelancerAPI.Services
{
	public class UserService : IUserService
	{
		private AppDbContext _addDbContext;
		public UserService(AppDbContext addDbContext) 
		{
			_addDbContext = addDbContext;
		}
       
        public async Task<List<User>> GetUsers()
        {
            return await _addDbContext.User.ToListAsync();
        }       

        public async Task CreateUser(User user)
        {
            await _addDbContext.User.AddAsync(user);
            _addDbContext.SaveChanges();
        }
      
        public async Task<User> GetUserByUId(int uId)
        {
            User selectedUser = await _addDbContext.User.FirstOrDefaultAsync(x => x.UId == uId) ?? new User();
            return selectedUser;
        }       

        public async Task DeleteUser(User user)
        {
            _addDbContext.User.Remove(user);
            await _addDbContext.SaveChangesAsync();
        }
       
        public async Task Updateuser(User user)
        {
           _addDbContext.User.Update(user);
           await _addDbContext.SaveChangesAsync();
        }
    }
}
