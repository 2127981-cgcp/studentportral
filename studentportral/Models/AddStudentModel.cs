using System.ComponentModel.DataAnnotations;

namespace studentportral.Models
{
    public class AddStudentModel
    {
        [Required]
        public string? Name { get; set; }   
        [Required]
        public string? Email { get; set; }
        [Required]
        public int    Phone { get; set; }
        [Required]
        public bool   Suscribed { get; set; }  
    }
}
