using BilgeAdam.Data.EF.Data;
using BilgeAdam.Data.EF.Entities;
using BilgeAdam.Data.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Data.EF
{
    public partial class frmEF2 : Form
    {
        public frmEF2()
        {
            InitializeComponent();
        }
        public int PageIndex { get; set; }
        private void frmEF2_Load(object sender, EventArgs e)
        {
            using (var ctx = new NorthwindContext())
            {
                LoadComboBox<Category>(cmbCategories, ctx, c => new ComboBoxItem<int>
                {
                    Text = c.CategoryName,
                    Value = c.CategoryID
                });

                LoadComboBox<Supplier>(cmbSuppliers, ctx, s => new ComboBoxItem<int>
                {
                    Text = s.CompanyName,
                    Value = s.SupplierID
                });

                LoadProducts(ctx);
            }
        }

        private void LoadProducts(NorthwindContext ctx)
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = ctx.Products
                .Select(p => new DetailedProductDto
                {
                    Id = p.ProductID,
                    Name = p.ProductName,
                    Category = p.Category.CategoryName,
                    Company = p.Supplier.CompanyName,
                    Price = p.UnitPrice,
                    Stock = p.UnitsInStock
                })
                .OrderBy(o => o.Id)
                .Skip(15 * PageIndex)
                .Take(15)
                .ToList();
        }

        private void LoadComboBox<T>(ComboBox comboBox, NorthwindContext context, Expression<Func<T, ComboBoxItem<int>>> select) where T : class
        {
            comboBox.DataSource = context.Set<T>().Select(select).ToList();
            comboBox.DisplayMember = nameof(ComboBoxItem<int>.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var np = new Product
            {
                ProductName = txtName.Text,
                UnitPrice = nudPrice.Value,
                UnitsInStock = (short)nudStock.Value,
                CategoryID = cmbCategories.GetBoundValue<int>(),
                SupplierID = cmbSuppliers.GetBoundValue<int>()
            };
            using (var ctx = new NorthwindContext())
            {
                ctx.Products.Add(np);
                ctx.SaveChanges();
                LoadProducts(ctx);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PageIndex--;
            using (var ctx = new NorthwindContext())
            {
                LoadProducts(ctx);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PageIndex++;
            using (var ctx = new NorthwindContext())
            {
                LoadProducts(ctx);
            }
        }
    }
}
