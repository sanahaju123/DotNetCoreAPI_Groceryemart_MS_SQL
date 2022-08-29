using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GroceryEmart.BusinessLayer.Interfaces;
using GroceryEmart.BusinessLayer.ViewModels;
using GroceryEmart.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryEmart.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Creating referance variable of IUserGroceryServices and IAdminGroceryServices
        /// </summary>
        private readonly IUserGroceryServices _userGS;
        private readonly IAdminGroceryServices _adminGS;
        /// <summary>
        /// Injecting referance variable into UserController constructor
        /// </summary>
        public UserController(IUserGroceryServices userGroceryServices, IAdminGroceryServices adminGroceryServices)
        {
            _userGS = userGroceryServices;
            _adminGS = adminGroceryServices;
        }
        /// <summary>
        /// Get All registred user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("all-user")]
        public async Task<IEnumerable<ApplicationUser>> AllUser()
        {
            //do code here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Register new user and provide all information by applicationuser class object
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> AddNewUser([FromBody] UserViewModel model)
        {
            //do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing User, get user first then update user info.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("update-user/{UserId}")]
        public async Task<IActionResult> UpdateUser(int UserId, [FromBody] ApplicationUser user)
        {
            //do code here
            throw new NotImplementedException();
        }
    }
}
