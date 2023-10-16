using FreelancerAPI.Models;
using FreelancerAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FreelancerAPI.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		IUserService _iUserService;
		public UserController(IUserService iUserService) 
		{
			_iUserService=iUserService;
		}
		[HttpGet]
		[Route("GetUsers")]		
		public JsonResult GetUsers()
		{
			ICollection<UserViewModel> resultUsers = new List<UserViewModel>();
			var allusers = _iUserService.GetUsers();
            foreach (var item in allusers)
            {
				resultUsers.Add(new UserViewModel()
				{
					UId= item.UId,
					UserName = item.UserName,
					Email = item.Email,
					PhoneNumber = item.PhoneNumber,
					SkilSets = item.SkilSets,
					Hobby = item.Hobby
				});

			}			
			return new JsonResult(resultUsers);
		}

		[HttpPost]
		[Route("CreateUser")]
		public JsonResult CreateUser(UserViewModel user)
		{
			User newUser = new User();			
			newUser.UserName = user.UserName;
			newUser.Email = user.Email;
			newUser.PhoneNumber = user.PhoneNumber;
			newUser.SkilSets = user.SkilSets;
			newUser.Hobby= user.Hobby;

			_iUserService.CreateUser(newUser);
			return new JsonResult("Added Successfully");
			
		}

		[HttpDelete]
		[Route("DeleteUser")]
		public JsonResult DeleteUser(int UId)
		{
			User deleteUser = _iUserService.GetUserByUId(UId);
			_iUserService.DeleteUser(deleteUser);
			return new JsonResult("Deleted Successfully");			
		}

		[HttpPut]
        [Route("UpdateUser")]
        public JsonResult UpdateUser(UserViewModel user)
		{
			User updatedUser = _iUserService.GetUserByUId(user.UId);
		
			updatedUser.UserName = user.UserName;
			updatedUser.Email = user.Email;
			updatedUser.PhoneNumber = user.PhoneNumber;
			updatedUser.SkilSets = user.SkilSets;
			updatedUser.Hobby = user.Hobby;
			_iUserService.Updateuser(updatedUser);
            return new JsonResult("Updated Successfully");
        }

		[HttpGet]
		[Route("GetUserByUId")]
		public JsonResult GetUserByUId(int  uId) {
         var user=_iUserService.GetUserByUId(uId);
			return new JsonResult(user);
        }
	}
}
