using System.ComponentModel.DataAnnotations;

namespace Bulky_Web.Models
{
    public class Category
    {
        [Key]
        public int Categoryid { get; set; }

        [Required]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}