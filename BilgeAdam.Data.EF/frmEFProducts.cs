using BilgeAdam.Data.EF.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BilgeAdam.Data.EF
{
    public partial class frmEFProducts : Form
    {
        public frmEFProducts()
        {
            InitializeComponent();
        }

        private void frmEFProducts_Load(object sender, EventArgs e)
        {
            using (var ctx = new NorthwindContext())
            {
                dgvProducts.DataSource = ctx.Products.ToList();
            }
        }

        private void btnConsumed_Click(object sender, EventArgs e)
        {
            using (var ctx = new NorthwindContext())
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = ctx.Products.Where(p => p.UnitsInStock == 0).ToList();
            }
        }

        private void btnBeverages_Click(object sender, EventArgs e)
        {
            using (var ctx = new NorthwindContext())
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = ctx.Products.Where(i => i.CategoryID == 1).ToList();
            }
        }

        private void btnExpensives_Click(object sender, EventArgs e)
        {
            using (var ctx = new NorthwindContext())
            {
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = ctx.Products.Where(d => d.UnitPrice > 50).ToList();
            }
        }
    }
}