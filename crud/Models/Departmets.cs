using System.ComponentModel.DataAnnotations;

namespace crud.Models
{
    public class Departmets
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Requred*")]
        public string Department { get; set; }
    }
}
