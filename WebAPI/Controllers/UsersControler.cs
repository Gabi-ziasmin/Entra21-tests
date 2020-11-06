using System.Collections.Generic;
using Domain.Users;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsersController : ControllerBase
    {
        public readonly UsersService _userService;

        public UsersController()
        {
            _userService = new UsersService();            
        }
        [HttpPost]
        public IActionResult Create(CreateUserRequest request)
        {
            if (request.Profile == Profile.CBF && request.Password != "admin123")
            {
                return Unauthorized();
            }

            var userId = _userService.Create(request.Name, request.Profile);

            return Ok(userId);

            //BadRequest = quando passa informações inválidas
        }
    }
}
