using System.ComponentModel.DataAnnotations;

namespace BulkyBooksWeb.Models
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }
        [Required]
        public string Name { get; set; }
        
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
