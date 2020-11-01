using BilgeAdam.Data.EF.Models;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace BilgeAdam.Data.EF.Data
{
    internal class DataAccessor
    {
        public List<ProductDto> GetProducts()
        {
            var query = "SELECT ProductId AS Id, ProductName AS Name, CategoryId, SupplierId, UnitPrice AS Price, UnitsInStock AS Stock FROM Products";
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CnnStr"].ConnectionString))
            {
                return conn.Query<ProductDto>(query).ToList();
            }
        }
    }
}