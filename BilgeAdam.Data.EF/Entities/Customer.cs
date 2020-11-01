using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeAdam.Data.EF.Entities
{
    [Table("Customers")]
    public class Customer
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }

        [Key]
        [MaxLength(5)]
        [Required]
        public string CustomerID { get; set; }

        [MaxLength(40)]
        [Required]
        public string CompanyName { get; set; }

        [MaxLength(30)]
        public string ContactName { get; set; }

        [MaxLength(30)]
        public string ContactTitle { get; set; }

        [MaxLength(60)]
        public string Address { get; set; }

        [MaxLength(15)]
        public string City { get; set; }

        [MaxLength(15)]
        public string Region { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(15)]
        public string Country { get; set; }

        [MaxLength(24)]
        public string Phone { get; set; }

        [MaxLength(24)]
        public string Fax { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
