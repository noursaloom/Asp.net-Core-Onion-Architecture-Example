using DomainModel.Entities;
using DomainModel.Interfaces;

namespace DomainServices.Services
    {
    public class UserService
        {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
            {
            _userRepository = userRepository;
            }

        public User GetUserById(int id) => _userRepository.GetById(id);

        public IEnumerable<User> GetAllUsers() => _userRepository.GetAll();

        public void CreateUser(User user) => _userRepository.Add(user);

        public void UpdateUser(User user) => _userRepository.Update(user);

        public void DeleteUser(int id) => _userRepository.Delete(id);
        }
    }
