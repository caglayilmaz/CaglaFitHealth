using System.ComponentModel.DataAnnotations;

namespace CaglaFitHealth.Models.Entity
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string FullName => $"{Name} {Surname}";
        public int? Age { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
    }
}
