using System.ComponentModel.DataAnnotations;

namespace CaglaFitHealth.Models.Entity
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }   

        public string? Surname { get; set; }

        public string FullName => $"{Name} {Surname}";

        public string? Birthday { get; set; }

        public string? Branch { get; set;}
    }
}
