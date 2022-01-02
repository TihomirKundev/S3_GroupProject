
namespace Week13Assignment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addProduct = new System.Windows.Forms.Button();
            this.productPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showAllProducts = new System.Windows.Forms.Button();
            this.productPriceFilter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cartList = new System.Windows.Forms.ListBox();
            this.updateList = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addProduct);
            this.panel1.Controls.Add(this.productPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.productName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 191);
            this.panel1.TabIndex = 0;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(23, 121);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(305, 59);
            this.addProduct.TabIndex = 2;
            this.addProduct.Text = "Add expense to tranaction log";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // productPrice
            // 
            this.productPrice.DecimalPlaces = 2;
            this.productPrice.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.productPrice.Location = new System.Drawing.Point(125, 70);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(87, 26);
            this.productPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount:";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(125, 25);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(161, 26);
            this.productName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expense form";
            // 
            // showAllProducts
            // 
            this.showAllProducts.Location = new System.Drawing.Point(67, 218);
            this.showAllProducts.Name = "showAllProducts";
            this.showAllProducts.Size = new System.Drawing.Size(196, 40);
            this.showAllProducts.TabIndex = 2;
            this.showAllProducts.Text = "Show all expenses";
            this.showAllProducts.UseVisualStyleBackColor = true;
            this.showAllProducts.Click += new System.EventHandler(this.showAllProducts_Click);
            // 
            // productPriceFilter
            // 
            this.productPriceFilter.DecimalPlaces = 2;
            this.productPriceFilter.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.productPriceFilter.Location = new System.Drawing.Point(137, 264);
            this.productPriceFilter.Name = "productPriceFilter";
            this.productPriceFilter.Size = new System.Drawing.Size(182, 26);
            this.productPriceFilter.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // cartList
            // 
            this.cartList.FormattingEnabled = true;
            this.cartList.ItemHeight = 20;
            this.cartList.Location = new System.Drawing.Point(390, 14);
            this.cartList.Name = "cartList";
            this.cartList.Size = new System.Drawing.Size(380, 244);
            this.cartList.TabIndex = 7;
            // 
            // updateList
            // 
            this.updateList.Enabled = true;
            this.updateList.Tick += new System.EventHandler(this.productListUpdate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 305);
            this.Controls.Add(this.cartList);
            this.Controls.Add(this.productPriceFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showAllProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.NumericUpDown productPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAllProducts;
        private System.Windows.Forms.NumericUpDown productPriceFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox cartList;
        private System.Windows.Forms.Timer updateList;
    }
}

