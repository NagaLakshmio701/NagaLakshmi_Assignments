using HandsonAPIusingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsonAPIusingEFCodeFirst.Entities;

namespace HandsonAPIusingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase

    {
        private readonly IUserRepository _userRepository;

        public UserController()
        {
            _userRepository = new UserRepository();
        }

        [HttpPost]
        [Route ("Register")]

        public IActionResult Register(User user)
        {
            _userRepository.Register(user);
            return StatusCode(200, user);
        }

        [HttpGet]
        [Route ("ValidUser/{Email}/{Password}")]
        public IActionResult ValidUser(string Email,String Password)

        {

            var User =_userRepository.ValidUser(Email, Password);
            if (User != null)
            {
                return StatusCode(200, User);
            }
            return StatusCode(404, "NOT Found");

        }
    }
}
