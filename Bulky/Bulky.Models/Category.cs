using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        
        public int Id { get; set; }


        [DisplayName("Category Name")]
        [MaxLength(30)]
        public string? Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
