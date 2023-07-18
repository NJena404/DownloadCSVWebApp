using System.ComponentModel.DataAnnotations;

namespace CSVWebApp.Models
{
    public class EmployeeDetails
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Dept { get; set; }
        public string? Country { get; set; }
    }
}
