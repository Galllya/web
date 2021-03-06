using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Hospital
    {
        [Key]
        public int _id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string   Address { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
