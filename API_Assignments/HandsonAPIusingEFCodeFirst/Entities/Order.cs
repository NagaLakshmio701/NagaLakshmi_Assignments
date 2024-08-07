
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HandsonAPIusingEFCodeFirst.Entities
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }

        [JsonIgnore] // Ignore for serialization and deserialization
        public Product? Product { get; set; }

        [JsonIgnore] // Ignore for serialization and deserialization
        public User? User { get; set; }
    }
}
