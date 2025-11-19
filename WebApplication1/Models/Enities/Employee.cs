using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Enities
{
    [Table("Employee")]   // 👈 EXACT table name in your database
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}
