using System.Collections.Generic;
using Domain.Users;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(CreateUserRequest request)
        {
            var user = new User(request.Name, request.Profile);
            
            return Ok(user.Id);
        }
    }
}
