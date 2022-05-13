namespace GumNaam.API.Models
{
    public class EmpLogin
    {
        public int Id { get; set; }
        public string UserRole { get; set; } = string.Empty;
        public virtual List<Employee> Employees { get; set; }
    }
}
