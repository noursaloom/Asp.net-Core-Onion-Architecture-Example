using ApplicationServices.DTOs;
using DomainModel.Entities;
using DomainServices.Services;

namespace ApplicationServices.Services
    {
    public class UserAppService
        {
        private readonly UserService _userService;

        public UserAppService(UserService userService)
            {
            _userService = userService;
            }

        public IEnumerable<UserDto> GetAllUsers()
            {
            var users = _userService.GetAllUsers();
            return users.Select(user => new UserDto
                {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
                });
            }

        public void CreateUser(UserDto userDto)
            {
            var user = new User
                {
                Name = userDto.Name,
                Email = userDto.Email
                };
            _userService.CreateUser(user);
            }
        }
    }
