
namespace SalesMS.WinForms
{
    public partial class AdminStatisticsForm : Form
    {
        CustomerService _customerService;
        ProductService _productService;
        OrderService _orderService;
        OrderItemService _orderItemService;
        public AdminStatisticsForm(CustomerService customerService, ProductService productService, OrderService orderService, OrderItemService orderItemService)
        {
            InitializeComponent();
            this._customerService = customerService;
            this._productService = productService;
            this._orderService = orderService;
            this._orderItemService = orderItemService;
            InitializeLabels();

            // ===== UI Styling =====

            // Form
            this.BackColor = Color.FromArgb(15, 23, 42);
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            // Labels numbers
            lblTotalCustomersCount.ForeColor = Color.FromArgb(59, 130, 246);
            lblTotalStorePenifits.ForeColor = Color.FromArgb(59, 130, 246);
            lblTotalStoreSales.ForeColor = Color.FromArgb(59, 130, 246);
            lbCapitalOfStore.ForeColor = Color.FromArgb(59, 130, 246);
            lblStoreProductsCount.ForeColor = Color.FromArgb(59, 130, 246);

            // Font bigger for numbers
            lblTotalCustomersCount.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTotalStorePenifits.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTotalStoreSales.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lbCapitalOfStore.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblStoreProductsCount.Font = new Font("Segoe UI", 16, FontStyle.Bold);


            this.label1.ForeColor = Color.White;
            this.label2.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label7.ForeColor = Color.FromArgb(59, 130, 246);
            this.label8.ForeColor = Color.FromArgb(59, 130, 246);
            this.label9.ForeColor = Color.FromArgb(59, 130, 246);
            label7.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            label8.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            label9.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            this.label10.ForeColor = Color.White;
            this.label12.ForeColor = Color.White;
            

        }
        private void InitializeLabels()
        {
            this.lblTotalCustomersCount.Text = _customerService.CountTotalCustomers().ToString();
            this.lblTotalStorePenifits.Text = _orderItemService.GetTotalProjectPenifit().ToString();
            this.lblTotalStoreSales.Text = _orderService.calculateTotalSales().ToString();
            this.lbCapitalOfStore.Text = _productService.CalculateTotalCapitalOfStore().ToString();
            this.lblStoreProductsCount.Text = _productService.CalculateTotalProductsCount().ToString();
        }
    }
}