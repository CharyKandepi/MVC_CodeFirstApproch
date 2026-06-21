using System.ComponentModel.DataAnnotations;

namespace MVC_CodeFirstApproch.Models
{
    public class StudentInformation
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }


        [Required]
        public DateOnly DOB { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Gender { get; set; }

    }
}
