using System.ComponentModel.DataAnnotations;

namespace webapploginpage.Models
{
    public class login
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
