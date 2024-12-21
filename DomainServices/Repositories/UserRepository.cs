using DomainModel.Entities;
using DomainModel.Interfaces;

namespace DomainServices.Repositories
    {
    public class UserRepository : IUserRepository
        {
        private readonly List<User> _users = new(); // Simulating a data source (in-memory for this example)

        public User GetById(int id) => _users.FirstOrDefault(user => user.Id == id);

        public IEnumerable<User> GetAll() => _users;

        public void Add(User user)
            {
            user.Id = _users.Count + 1; // Simple ID generation
            _users.Add(user);
            }

        public void Update(User user)
            {
            var existingUser = GetById(user.Id);
            if (existingUser == null) return;

            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            }

        public void Delete(int id)
            {
            var user = GetById(id);
            if (user != null)
                {
                _users.Remove(user);
                }
            }
        }
    }
