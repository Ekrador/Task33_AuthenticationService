using System;
using System.Collections.Generic;
using System.Linq;

namespace Task33_AuthenticationService
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new();

        public UserRepository()
        {
            
            _users.Add(new User()
            {
                Email = "vasya@mail.ru",
                FirstName = "vasya",
                Id = Guid.NewGuid(),
                LastName = "vasiliev",
                Login = "vasyok",
                Password = "qwerty"
            });
            _users.Add(new User()
            {
                Email = "vova@mail.ru",
                FirstName = "vova",
                Id = Guid.NewGuid(),
                LastName = "volkov",
                Login = "vovka",
                Password = "qwerty"
            });
            _users.Add(new User()
            {
                Email = "ivan@mail.ru",
                FirstName = "ivan",
                Id = Guid.NewGuid(),
                LastName = "ivanov",
                Login = "vanya",
                Password = "qwerty"
            });
        }
        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetByLogin(string login)
        {
            return _users.FirstOrDefault(x => x.Login == login);
        }
    }
}
