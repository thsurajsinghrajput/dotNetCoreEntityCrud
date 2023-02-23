using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="requred*")]
        public string Name { get; set; }
        [Required(ErrorMessage ="requred*")]
        public string Fname { get; set; }
        [Required(ErrorMessage ="reqired*")]
        public string Email { get; set; }
        [Required(ErrorMessage ="requred*")]
        public int Mobile { get; set; }
        [Required(ErrorMessage ="requred*")]
        public string Desription { get; set; }
        [Required(ErrorMessage ="requred*")]
        public int DepID { get; set; }
    }
}
