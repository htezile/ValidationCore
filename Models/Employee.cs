using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ValidationCore.Models
{
    public class Employee
    {
    
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$", ErrorMessage="Invalid email format")]
        public string Email { get; set; }
        [Range(1000, 2500)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }
    }
}
