namespace SalesMS.WinForms
{
    partial class AdminForm
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
            components = new System.ComponentModel.Container();
            btnAddProduct = new Button();
            ProductsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderItemsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            btnEditProduct = new Button();
            btnIncreaseByOne = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            staticsToolStripMenuItem = new ToolStripMenuItem();
            valuedCustomersToolStripMenuItem = new ToolStripMenuItem();
            BestSellingToolStripMenuItem = new ToolStripMenuItem();
            outOfStuckToolStripMenuItem = new ToolStripMenuItem();
            penifitsStaticsToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(434, 393);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(199, 45);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Add product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AllowUserToDeleteRows = false;
            ProductsDataGridView.AutoGenerateColumns = false;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, costPriceDataGridViewTextBoxColumn, salePriceDataGridViewTextBoxColumn, stockQuantityDataGridViewTextBoxColumn, orderItemsDataGridViewTextBoxColumn });
            ProductsDataGridView.DataSource = productBindingSource;
            ProductsDataGridView.Location = new Point(-9, 36);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowHeadersWidth = 62;
            ProductsDataGridView.Size = new Size(815, 351);
            ProductsDataGridView.TabIndex = 1;
            ProductsDataGridView.CellContentClick += dataGridView1_CellContentClick;
            ProductsDataGridView.SelectionChanged += ProductsDataGridView_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // costPriceDataGridViewTextBoxColumn
            // 
            costPriceDataGridViewTextBoxColumn.DataPropertyName = "costPrice";
            costPriceDataGridViewTextBoxColumn.HeaderText = "costPrice";
            costPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            costPriceDataGridViewTextBoxColumn.Name = "costPriceDataGridViewTextBoxColumn";
            costPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            salePriceDataGridViewTextBoxColumn.DataPropertyName = "salePrice";
            salePriceDataGridViewTextBoxColumn.HeaderText = "salePrice";
            salePriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            salePriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            stockQuantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            stockQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderItemsDataGridViewTextBoxColumn
            // 
            orderItemsDataGridViewTextBoxColumn.DataPropertyName = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.HeaderText = "OrderItems";
            orderItemsDataGridViewTextBoxColumn.MinimumWidth = 8;
            orderItemsDataGridViewTextBoxColumn.Name = "orderItemsDataGridViewTextBoxColumn";
            orderItemsDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(95, 393);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(124, 51);
            btnEditProduct.TabIndex = 2;
            btnEditProduct.Text = "Edit product";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnIncreaseByOne
            // 
            btnIncreaseByOne.Location = new Point(639, 404);
            btnIncreaseByOne.Name = "btnIncreaseByOne";
            btnIncreaseByOne.Size = new Size(149, 34);
            btnIncreaseByOne.TabIndex = 3;
            btnIncreaseByOne.Text = "Increase by one";
            btnIncreaseByOne.UseVisualStyleBackColor = true;
            btnIncreaseByOne.Click += btnIncreaseByOne_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 404);
            button1.Name = "button1";
            button1.Size = new Size(86, 45);
            button1.TabIndex = 4;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { staticsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // staticsToolStripMenuItem
            // 
            staticsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { valuedCustomersToolStripMenuItem, BestSellingToolStripMenuItem, outOfStuckToolStripMenuItem, penifitsStaticsToolStripMenuItem1 });
            staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            staticsToolStripMenuItem.Size = new Size(96, 29);
            staticsToolStripMenuItem.Text = "Statistics";
            // 
            // valuedCustomersToolStripMenuItem
            // 
            valuedCustomersToolStripMenuItem.Name = "valuedCustomersToolStripMenuItem";
            valuedCustomersToolStripMenuItem.Size = new Size(254, 34);
            valuedCustomersToolStripMenuItem.Text = "Valued customers";
            valuedCustomersToolStripMenuItem.Click += valuedCustomersToolStripMenuItem_Click;
            // 
            // BestSellingToolStripMenuItem
            // 
            BestSellingToolStripMenuItem.Name = "BestSellingToolStripMenuItem";
            BestSellingToolStripMenuItem.Size = new Size(254, 34);
            BestSellingToolStripMenuItem.Text = "Valued goods";
            BestSellingToolStripMenuItem.Click += BestSellingToolStripMenuItem_Click;
            // 
            // outOfStuckToolStripMenuItem
            // 
            outOfStuckToolStripMenuItem.Name = "outOfStuckToolStripMenuItem";
            outOfStuckToolStripMenuItem.Size = new Size(254, 34);
            outOfStuckToolStripMenuItem.Text = "Out of stuck";
            outOfStuckToolStripMenuItem.Click += outOfStuckToolStripMenuItem_Click;
            // 
            // penifitsStaticsToolStripMenuItem1
            // 
            penifitsStaticsToolStripMenuItem1.Name = "penifitsStaticsToolStripMenuItem1";
            penifitsStaticsToolStripMenuItem1.Size = new Size(254, 34);
            penifitsStaticsToolStripMenuItem1.Text = "Penifits statistics";
            penifitsStaticsToolStripMenuItem1.Click += penifitsStaticsToolStripMenuItem1_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnIncreaseByOne);
            Controls.Add(btnEditProduct);
            Controls.Add(ProductsDataGridView);
            Controls.Add(btnAddProduct);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddProduct;
        private DataGridView ProductsDataGridView;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderItemsDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private Button btnEditProduct;
        private Button btnIncreaseByOne;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem staticsToolStripMenuItem;
        private ToolStripMenuItem valuedCustomersToolStripMenuItem;
        private ToolStripMenuItem BestSellingToolStripMenuItem;
        private ToolStripMenuItem outOfStuckToolStripMenuItem;
        private ToolStripMenuItem penifitsStaticsToolStripMenuItem1;
    }
}