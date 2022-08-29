using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryEmart.Entities
{
    public class ProductOrder
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
