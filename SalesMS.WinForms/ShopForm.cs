using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SalesMS.WinForms
{
    public partial class ShopForm : Form
    {
        private readonly ProductService _productService;
        private readonly OrderService _orderService;
        private readonly CustomerService _customerService;
        private readonly OrderItemService _orderItemService;
        public static Dictionary<Product, int> _cart = new();
        private decimal _totalPrice = 0;
        private readonly System.Windows.Forms.Timer _searchTimer;

        public ShopForm(
            OrderItemService orderItemService,
            ProductService productService,
            OrderService orderService,
            CustomerService customerService
            )
        {
            InitializeComponent();

            _orderItemService = orderItemService;
            _productService = productService;
            _orderService = orderService;
            _customerService = customerService;

            // إعداد Timer للبحث
            _searchTimer = new System.Windows.Forms.Timer { Interval = 150 };
            _searchTimer.Tick += SearchTimer_Tick;

            lblBalance.Text = Session.currentCustomer.Balance.ToString();

            LoadProducts();
            UpdateCartUI();
            // ===== ShopForm UI Styling =====

            // Form
            this.BackColor = Color.FromArgb(15, 23, 42);
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            this.lblBalance.BackColor = this.BackColor;
            this.lblReceipt.BackColor = this.BackColor;
            this.label1.ForeColor=Color.White;
            this.label2.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label5.ForeColor = Color.White;
            this.label6.ForeColor = Color.White;
            this.label7.ForeColor = Color.White;
             this.lblCartContains.Location = new Point(600, -400);
            // Balance label
            lblBalance.ForeColor = Color.FromArgb(34, 197, 94); // أخضر واضح
            lblReceipt.ForeColor= Color.FromArgb(34, 197, 94);


            // Cart label
            lblCartContains.ForeColor = Color.White;
            lblCartContains.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblCartContains.BackColor = Color.FromArgb(30, 41, 59);
            lblCartContains.BorderStyle = BorderStyle.FixedSingle;
            lblCartContains.Padding = new Padding(5);

            // Search TextBox
            tbSearch.BackColor = Color.FromArgb(30, 41, 59);
            tbSearch.ForeColor = Color.White;
            tbSearch.BorderStyle = BorderStyle.FixedSingle;

            // Buttons
            btnBuy.BackColor = Color.FromArgb(59, 130, 246);
            btnBuy.ForeColor = Color.White;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.Height = 40;

            btnBack.BackColor = Color.FromArgb(239, 68, 68);
            btnBack.ForeColor = Color.White;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Height = 40;

            // FlowLayoutPanel (Cards container)
            flowLayoutPanel1.BackColor = Color.FromArgb(15, 23, 42);
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;

        }


        private void Card_AddToCartClicked(object sender, Product product)
        {
            if (_cart.ContainsKey(product))
                _cart[product]++;
            else
                _cart.Add(product, 1);

            UpdateCartUI();
        }

        private void Card_CancelItemClicked(object sender, Product product)
        {
            if (_cart.ContainsKey(product))
                _cart.Remove(product);

            UpdateCartUI();
        }

        private void UpdateCartUI()
        {
            lblCartContains.Text = string.Join("\n", _cart.SelectMany(c => Enumerable.Repeat(c.Key.Name, c.Value)));
            _totalPrice = _cart.Sum(c => c.Key.salePrice * c.Value);
            lblReceipt.Text = Convert.ToString(_totalPrice);
        }



        private void LoadProducts(string searchQuery = null)
        {
            var products = string.IsNullOrWhiteSpace(searchQuery) ?
                _productService.GetAllProducts() :
                _productService.GetAllProducts(searchQuery);

            flowLayoutPanel1.Controls.Clear();

            foreach (var product in products)
            {
                var card = new ProductCard(product);
                card.AddToCartClicked += Card_AddToCartClicked;
                card.CancelFromCartClicked += Card_CancelItemClicked;
                flowLayoutPanel1.Controls.Add(card);
            }
        }



        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            _searchTimer.Start();
        }

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            _searchTimer.Stop();
            LoadProducts(tbSearch.Text);
        }


        private void btnBuy_Click_1(object sender, EventArgs e)
        {
            if (!_cart.Any())
            {
                MessageBox.Show("You didn't select any items!");
                return;
            }
            var cartIds = ShopForm._cart.ToDictionary(c => c.Key.Id, c => c.Value);
            decimal total = _orderService.GetOrderPrice(cartIds);

            if (!_orderService.CompletePurshaseOrder(total, Session.currentCustomer.Id))
            {
                MessageBox.Show("You don't have enough balance, please deposit and try again.");
                return;
            }

            var order = new Order { CustomerId = Session.currentCustomer.Id, TotalAmount = total };

            bool success =
                _orderService.AddOrder(order) &&
                _orderItemService.AddOrderItems(cartIds, order.Id) &&
                _customerService.deductOrderPrice(Session.currentCustomer.Id, total);

            if (success)
            {
                MessageBox.Show("Congratulations! Your purchase was successful.");
                this.Close();
                var frm = Program.ServiceProvider.GetRequiredService<ShopForm>();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Something went wrong during the purchase process.");
            }

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = NavigationStack.Stack.Pop();
            frm.Show();
        }

        private void lblReceipt_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}