using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } //keyName Id and CategoryId makes the EF understands it is the primary key
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
