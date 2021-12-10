using MinimalJwt.Models;
using MinimalJwt.Repositories;

namespace MinimalJwt.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(obj => obj.Username.Equals
            (userLogin.Username, StringComparison.OrdinalIgnoreCase) && obj.Password.Equals
            (userLogin.Password));
            return user;
        }

    }
}
