
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace SalesMS.WinForms
{
    public partial class AdminForm : Form
    {
        private ProductService _productService;


        public AdminForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;

            ProductsDataGridView.DataSource = _productService.GetAllProducts();

            // ===== UI Styling Only =====

            // Form Background
            this.BackColor = Color.FromArgb(15, 23, 42); // Dark navy

            // DataGridView Style
            ProductsDataGridView.BackgroundColor = Color.FromArgb(15, 23, 42);
            ProductsDataGridView.BorderStyle = BorderStyle.None;
            ProductsDataGridView.GridColor = Color.FromArgb(51, 65, 85);

            ProductsDataGridView.EnableHeadersVisualStyles = false;

            // Header
            ProductsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            ProductsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ProductsDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Rows
            ProductsDataGridView.DefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            ProductsDataGridView.DefaultCellStyle.ForeColor = Color.White;
            ProductsDataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            ProductsDataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternate rows (تعطي شكل أجمل)
            ProductsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);

            ProductsDataGridView.RowHeadersVisible = false;
            ProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridView.Left += 10;
            // MenuStrip Style
            menuStrip1.BackColor = Color.FromArgb(30, 41, 59);
            menuStrip1.ForeColor = Color.White;

            menuStrip1.RenderMode = ToolStripRenderMode.System;

            // Buttons Style
            Color buttonColor = Color.FromArgb(59, 130, 246);

            btnAddProduct.BackColor = buttonColor;
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.FlatAppearance.BorderSize = 0;

            btnEditProduct.BackColor = buttonColor;
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.FlatAppearance.BorderSize = 0;

            btnIncreaseByOne.BackColor = buttonColor;
            btnIncreaseByOne.ForeColor = Color.White;
            btnIncreaseByOne.UseVisualStyleBackColor = false;
            btnIncreaseByOne.FlatStyle = FlatStyle.Flat;
            btnIncreaseByOne.FlatAppearance.BorderSize = 0;

            button1.BackColor = Color.FromArgb(239, 68, 68);
            button1.ForeColor = Color.White;
            button1.UseVisualStyleBackColor = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            // Font
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AdminSaveProductForm frm = new AdminSaveProductForm(_productService, ProductsDataGridView);
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnEditProduct.Enabled = ProductsDataGridView.SelectedRows.Count == 1;
            btnIncreaseByOne.Enabled = ProductsDataGridView.SelectedRows.Count == 1;

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count != 1)
            {
                return;
            }
            Product selectedProduct = (Product)ProductsDataGridView.CurrentRow.DataBoundItem;
            AdminSaveProductForm frm = new AdminSaveProductForm(_productService, ProductsDataGridView, selectedProduct);
            frm.ShowDialog();
        }

        private void btnIncreaseByOne_Click(object sender, EventArgs e)
        {
            if (ProductsDataGridView.SelectedRows.Count  !=1)
            {
                return;
            }
            Product selectedProduct = (Product)ProductsDataGridView.CurrentRow.DataBoundItem;
            if (_productService.IncreaseProductByOne(selectedProduct.Id))
                ProductsDataGridView.DataSource = _productService.GetAllProducts();
            else
            {
                MessageBox.Show("some thing went wrong please try again later");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = NavigationStack.Stack.Pop();
            frm.Show();
            Close();

        }

        private void valuedCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm1 = Program.ServiceProvider.GetRequiredService<ValuedCustomerForm>();
            frm1.Show();

        }

        private void BestSellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetRequiredService<BestSellingForm>();
            frm.Show();
        }

        private void outOfStuckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetRequiredService<OutOfStockForm>();
            frm.Show();
        }

        private void penifitsStaticsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetRequiredService<AdminStatisticsForm>();
            frm.Show();
        }
    }
}