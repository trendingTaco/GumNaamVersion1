using Wakanda_Mini_API.Models;

namespace Wakanda_Mini_API.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
