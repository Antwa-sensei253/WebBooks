using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Books.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(30)]

        [DisplayName("Display Name")]
        public required string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }

    }
}
