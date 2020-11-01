using BilgeAdam.Data.EF.Data;
using BilgeAdam.Data.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BilgeAdam.Data.EF
{
    public partial class frmProducts : Form
    {
        private List<ProductDto> allProducts;
        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            var acc = new DataAccessor();
            allProducts = acc.GetProducts();
            dgvProducts.DataSource = allProducts;
        }

        private void btnConsumed_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = allProducts.Where(FilterConsumedProduct).ToList();
            //dgvProducts.DataSource = allProducts.Where(r => r.Stock == 0).ToList();
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = allProducts.Where(p => p.CategoryId == 1).ToList();
        }

        private void btnExpensives_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = allProducts.Where(p => p.Price > 50).ToList();
        }

        private bool FilterConsumedProduct(ProductDto product)
        {
            return product.Stock == 0;
        }

        //private bool FilterConsumedProduct(ProductDto product) => product.Stock == 0;
    }
}