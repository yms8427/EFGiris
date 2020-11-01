using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Data.EF.Entities
{
    [Table("Order Details")]
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [Required]
        public int ProductID { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public short Quantity { get; set; }

        [Required]
        public Single Discount { get; set; }

        [ForeignKey(nameof(OrderID))]
        public virtual Order Order { get; set; }

        [ForeignKey(nameof(ProductID))]
        public virtual Product Product { get; set; }
    }
}
