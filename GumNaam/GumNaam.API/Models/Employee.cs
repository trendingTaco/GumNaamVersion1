using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace GumNaam.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public string PrefName { get; set; }
        public bool IsAudioAvailable { get; set; }

        [Required]
        public int UserRole { get; set; }
        [JsonIgnore]
        public virtual EmpLogin? EmpLogin { get; set; }
    }
}
