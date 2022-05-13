using Microsoft.EntityFrameworkCore;

namespace GumNaam.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpLogin>().HasData(
                new EmpLogin { Id = 1, UserRole = "admin" },
                new EmpLogin { Id = 2, UserRole = "standard" });


            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, UserRole = 1, Name = "Grunge Skater ", Password = "AWMGSJ", PrefName = "Lulu", IsAudioAvailable = true },
                new Employee { Id = 2, UserRole = 1, Name = "Polo ", Password = "AWMPS", PrefName = "Leia", IsAudioAvailable = false },
                new Employee { Id = 3, UserRole = 1, Name = "RoSai", Password = "AWMSGT", PrefName = "Sai", IsAudioAvailable = false },
                new Employee { Id = 4, UserRole = 1, Name = "Dubois Doctor", Password = "AWMSJ", PrefName = "Dubois", IsAudioAvailable = false },
                new Employee { Id = 5, UserRole = 1, Name = "Skywalker", Password = "AWMTFJ", PrefName = "Luke", IsAudioAvailable = false },
                new Employee { Id = 6, UserRole = 2, Name = "NoOne", Password = "AWMUTV", PrefName = "Jedi", IsAudioAvailable = false },
                new Employee { Id = 7, UserRole = 2, Name = "Victor Paul", Password = "AWMVNP", PrefName = "Yoda", IsAudioAvailable = false },
                new Employee { Id = 8, UserRole = 2, Name = "Victor Toni", Password = "AWMVNS", PrefName = "Toni", IsAudioAvailable = false },
                new Employee { Id = 9, UserRole = 2, Name = "Victor Other Toni", Password = "AWMVNT", PrefName = "Tony", IsAudioAvailable = false });
 
        }
    }
}