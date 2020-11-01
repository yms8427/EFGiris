namespace BilgeAdam.Data.EF
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnConsumed = new System.Windows.Forms.Button();
            this.btnBeverages = new System.Windows.Forms.Button();
            this.btnExpensives = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 60);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(776, 378);
            this.dgvProducts.TabIndex = 0;
            // 
            // btnConsumed
            // 
            this.btnConsumed.Location = new System.Drawing.Point(347, 12);
            this.btnConsumed.Name = "btnConsumed";
            this.btnConsumed.Size = new System.Drawing.Size(143, 23);
            this.btnConsumed.TabIndex = 1;
            this.btnConsumed.Text = "Tükenenler";
            this.btnConsumed.UseVisualStyleBackColor = true;
            this.btnConsumed.Click += new System.EventHandler(this.btnConsumed_Click);
            // 
            // btnBeverages
            // 
            this.btnBeverages.Location = new System.Drawing.Point(496, 12);
            this.btnBeverages.Name = "btnBeverages";
            this.btnBeverages.Size = new System.Drawing.Size(143, 23);
            this.btnBeverages.TabIndex = 1;
            this.btnBeverages.Text = "İçecekler";
            this.btnBeverages.UseVisualStyleBackColor = true;
            this.btnBeverages.Click += new System.EventHandler(this.btnBeverages_Click);
            // 
            // btnExpensives
            // 
            this.btnExpensives.Location = new System.Drawing.Point(645, 12);
            this.btnExpensives.Name = "btnExpensives";
            this.btnExpensives.Size = new System.Drawing.Size(143, 23);
            this.btnExpensives.TabIndex = 1;
            this.btnExpensives.Text = "Fiyatı Yüksek Olanlar (50)";
            this.btnExpensives.UseVisualStyleBackColor = true;
            this.btnExpensives.Click += new System.EventHandler(this.btnExpensives_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExpensives);
            this.Controls.Add(this.btnBeverages);
            this.Controls.Add(this.btnConsumed);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnConsumed;
        private System.Windows.Forms.Button btnBeverages;
        private System.Windows.Forms.Button btnExpensives;
    }
}

