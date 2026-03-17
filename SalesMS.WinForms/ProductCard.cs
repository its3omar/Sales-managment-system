
namespace SalesMS.WinForms
{
    public partial class ProductCard : UserControl
    {
        int numberOfPiecesOrdered;
        private Product _product;

        // الحدث الآن يرسل الـProduct مباشرة
        public event EventHandler<Product> AddToCartClicked;
        public event EventHandler<Product> CancelFromCartClicked;

        public ProductCard(Product product)
        {
            numberOfPiecesOrdered = 0;
            InitializeComponent();
            btnIncreaseByOne.FlatAppearance.BorderSize = 0;
            _product = product;
            lblName.Text = _product.Name;
          

            // إذا المسار فارغ أو الملف غير موجود، استخدم الصورة الافتراضية
            string imagePath = _product.ImagePath;
            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
            {
                picProductImage.Image = Properties.Resources.NoImageAvailable;
            }
            var img = (Image)Properties.Resources.ResourceManager.GetObject(_product.ImagePath);
            picProductImage.Image = img ?? Properties.Resources.NoImageAvailable;
            lblPrice.Text = "$" + _product.salePrice.ToString();

            if (_product.StockQuantity == 0)
            {
                this.ForeColor = Color.Red;
                this.btnSelectProduct.Enabled = false;
                this.lblPrice.Text = "Out of The Stock";

            }
            // ===== ProductCard UI Styling =====

            // Card
            this.BackColor = Color.FromArgb(30, 41, 59);
            this.ForeColor = Color.White;
            this.Padding = new Padding(10);
            this.Margin = new Padding(5);
            this.BorderStyle = BorderStyle.FixedSingle;

            // Product name
            lblName.ForeColor = Color.White;
            lblName.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Product price
            lblPrice.ForeColor = Color.FromArgb(59, 130, 246); // أزرق حديث
            lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Product image
            picProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            picProductImage.BackColor = Color.FromArgb(15, 23, 42);
            picProductImage.BorderStyle = BorderStyle.FixedSingle;
            // داخل ProductCard constructor أو ProductCard_Load

            
            // Buttons
            btnSelectProduct.BackColor = Color.FromArgb(59, 130, 246);
            btnSelectProduct.ForeColor = Color.White;
            btnSelectProduct.FlatStyle = FlatStyle.Flat;
            btnSelectProduct.FlatAppearance.BorderSize = 0;
            btnSelectProduct.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            btnCancel.BackColor = Color.FromArgb(239, 68, 68); // أحمر إلغاء
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btnCancel.Hide(); // مخفي افتراضياً
            
            btnIncreaseByOne.BackColor = Color.FromArgb(34, 197, 94); 
            btnIncreaseByOne.ForeColor = Color.White;
            btnIncreaseByOne.FlatStyle = FlatStyle.Flat;
            btnIncreaseByOne.FlatAppearance.BorderSize = 0;
            btnIncreaseByOne.Font= new Font("Segoe UI", 12, FontStyle.Regular);
            btnIncreaseByOne.Hide(); // مخفي افتراضياً
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            ++numberOfPiecesOrdered;
            this.btnSelectProduct.Hide();
            this.btnCancel.Show();
            btnIncreaseByOne.Show();
            this.lblPrice.Hide();

            // نرسل المنتج مباشرة عند رفع الحدث
            AddToCartClicked?.Invoke(this, _product);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnSelectProduct.Show();
            this.btnCancel.Hide();
            this.btnIncreaseByOne.Hide();
            numberOfPiecesOrdered = 0;
            this.lblPrice.Show();
            CancelFromCartClicked?.Invoke(this, _product);
        }

        private void btnIncreaseByOne_Click(object sender, EventArgs e)
        {
            ++numberOfPiecesOrdered;
            if (numberOfPiecesOrdered <= _product.StockQuantity)
            {
                btnSelectProduct_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sorry, you have already ordered all the remaining quantity of this item.");
            }
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}