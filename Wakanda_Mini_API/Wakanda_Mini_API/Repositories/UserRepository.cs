using Wakanda_Mini_API.Models;

namespace Wakanda_Mini_API.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {

            new()
            {
                UserName = "Luke_walker",
                EmailAddress = "Luke_the_admin@email.com",
                Password = "StarWars_01",
                FirstName = "Luke",
                LastName = "Skywalker",
                PrefName = "Luke",
                Role = "admin"
            },
            new()
            {
                UserName = "Leia_walker",
                EmailAddress = "Leia_non_admin@email.com",
                Password = "StarWars_007",
                FirstName = "Leia",
                LastName = "Skywalker",
                PrefName = "Leia",
                Role = "Standard"
            },
        };
    }
}