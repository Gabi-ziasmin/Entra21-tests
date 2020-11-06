using Domain.Users;

namespace WebAPI.Controllers
{

    public class CreateUserRequest  
    {

        public string Name {get; set; }
        
        public Profile Profile {get; set; }

        public string Password { get; set; }
    }
}