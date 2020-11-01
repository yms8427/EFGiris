using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Data.EF.Models
{
    public class DetailedProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public decimal? Price { get; set; }
        public short? Stock { get; set; }
    }
}
