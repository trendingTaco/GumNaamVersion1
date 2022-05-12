namespace Wakanda_Mini_API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }

        public string Password { get; set; }
        public string PrefName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Role { get; set; }

    }
}