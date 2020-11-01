﻿namespace BilgeAdam.Data.EF.Models
{
    class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
