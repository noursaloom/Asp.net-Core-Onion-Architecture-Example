using ApplicationServices.DTOs;
using ApplicationServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace UserInterface.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
        {
        private readonly UserAppService _userAppService;

        public UserController(UserAppService userAppService)
            {
            _userAppService = userAppService;
            }

        [HttpGet]
        public IActionResult GetAllUsers()
            {
            var users = _userAppService.GetAllUsers();
            return Ok(users);
            }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDto userDto)
            {
            _userAppService.CreateUser(userDto);
            return Ok();
            }
        }
    }
