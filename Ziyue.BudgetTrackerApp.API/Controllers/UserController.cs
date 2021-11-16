using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ziyue.BudgetTrackerApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            if (users.Any()) {
                return Ok(users);
            }
            return NotFound("No Users Found");
        }
        [HttpGet("Detail/{id:int}")]
        // https://localhost/api/user/detail/{id}/

        public async Task<IActionResult> GetUserDetail(int id)
        {
            var userDetailResponse = await _userService.GetUserDetail(id);
            if (userDetailResponse != null)
            {
                return Ok(userDetailResponse);
            }
            return NotFound("User Not Found");
        }
    }
}
