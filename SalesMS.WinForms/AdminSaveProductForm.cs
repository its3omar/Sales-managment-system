
using System.Xml.Linq;

namespace SalesMS.WinForms
{
    public partial class AdminSaveProductForm : Form
    {
        enum Mode { Add, Update };
        Mode mode = Mode.Add;
        private ProductService _productService;
        private Product? _product;
        private DataGridView _productsDataGridView;
        public AdminSaveProductForm(ProductService productService, DataGridView productsDataGridView, Product? product = null)
        {
            InitializeComponent();
            _productService = productService;
            _productsDataGridView = productsDataGridView;

            if (product != null)
            {
                _product = product;
                mode = Mode.Update;
                tbProductName.Text = _product.Name;
                tbSalePrice.Text = Convert.ToString(_product.salePrice);
                tbCostPrice.Text = Convert.ToString(_product.costPrice);
                tbImagePath.Text= _product.ImagePath;
            }
            // ===== UI Styling Only =====

            this.BackColor = Color.FromArgb(30, 41, 59);

            this.tbCostPrice.BackColor = Color.FromArgb(241, 245, 249);
            tbCostPrice.BorderStyle = BorderStyle.FixedSingle;

            tbProductName.BackColor = Color.FromArgb(241, 245, 249);
            tbProductName.BorderStyle = BorderStyle.FixedSingle;

            tbSalePrice.BackColor = Color.FromArgb(241, 245, 249);
            tbSalePrice.BorderStyle = BorderStyle.FixedSingle;

            tbImagePath.BackColor = Color.FromArgb(241, 245, 249);
            tbImagePath.BorderStyle = BorderStyle.FixedSingle;

            btnSaveProduct.BackColor = Color.FromArgb(59, 130, 246);
            btnSaveProduct.ForeColor = Color.White;
            btnSaveProduct.FlatStyle = FlatStyle.Flat;
            btnSaveProduct.FlatAppearance.BorderSize = 0;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label1.ForeColor = Color.White;




            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        void LoadProductsData()
        {
            _productsDataGridView.DataSource = _productService.GetAllProducts();
            this.Close();
        }

        private void btnSaveProduct_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCostPrice.Text) ||
               string.IsNullOrWhiteSpace(tbProductName.Text) ||
               string.IsNullOrWhiteSpace(tbSalePrice.Text))
            {
                MessageBox.Show("One field or more are required!");
                return;
            }

            switch (mode)
            {
                case Mode.Update:
                    {
                        _product.Name = tbProductName.Text;
                        _product.costPrice = Convert.ToDecimal(tbCostPrice.Text);
                        _product.salePrice = Convert.ToDecimal(tbSalePrice.Text);
                        _product.ImagePath = tbImagePath.Text;
                        if (_productService.UpdateProduct(_product))
                        {
                            MessageBox.Show("Product Updated successfully");
                            LoadProductsData();
                        }
                        else
                            MessageBox.Show("Something went wrong, please try again later");
                        break;
                    }
                case Mode.Add:
                    {
                        Product p = new Product { salePrice = Convert.ToDecimal(tbSalePrice.Text), costPrice = Convert.ToDecimal(tbCostPrice.Text), Name = tbProductName.Text, ImagePath = tbImagePath.Text };
                        if (_productService.CreateNewProduct(p))
                        {
                            MessageBox.Show("Product Created successfully");
                            LoadProductsData();

                        }
                        else
                            MessageBox.Show("Something went wrong, please try again later");
                        break;
                    }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "صور (*.jpg; *.png; *.jpeg)|*.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = ofd.FileName;
                tbImagePath.Text = selectedImagePath;
            }
        }
    }
}