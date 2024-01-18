using System.ComponentModel.DataAnnotations;

namespace CaglaFitHealth.Models.Entity
{
    public class Admin
    {
        public int Id { get; set; }
        public required string Username { get; set; }

        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
