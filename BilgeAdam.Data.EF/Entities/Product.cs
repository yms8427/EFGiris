using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Data.EF.Entities
{
    [Table("Products")]
    public class Product
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        #region Columns
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ProductID { get; set; }

        [MaxLength(40)]
        [Required]
        public string ProductName { get; set; }

        public int? SupplierID { get; set; }

        public int? CategoryID { get; set; }

        [MaxLength(20)]
        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public short? UnitsInStock { get; set; }

        public short? UnitsOnOrder { get; set; }

        public short? ReorderLevel { get; set; }

        [Required]
        public bool Discontinued { get; set; }
        #endregion

        #region Navigation Properties
        [ForeignKey(nameof(SupplierID))]
        public virtual Supplier Supplier { get; set; }

        [ForeignKey(nameof(CategoryID))]
        public virtual Category Category { get; set; }
        #endregion

        #region Reverse Navigation Properties
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } 
        #endregion
    }
}
