using MinimalJwt.Models;

namespace MinimalJwt.Services
{
    interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
