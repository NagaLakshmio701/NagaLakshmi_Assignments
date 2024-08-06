using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandsonAPIusingEFCodeFirst.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName ="varchar")]

        [StringLength(50)]
        public string? Name { get; set; }

        public int  Price { get; set; }

        public int? Stock {  get; set; }
    }
}
