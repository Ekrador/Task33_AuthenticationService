using System.Collections.Generic;

namespace Task33_AuthenticationService
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetByLogin(string login);
    }
}
