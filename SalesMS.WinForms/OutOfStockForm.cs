
namespace SalesMS.WinForms
{
    public partial class OutOfStockForm : Form
    {
        private ProductService _productService;
        public OutOfStockForm(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            this.dataGridView1.DataSource = _productService.GetOutOfStuckProducts();

            // ===== UI Styling Only =====
            // Form Background
            this.BackColor = Color.FromArgb(15, 23, 42); // Dark navy

            // DataGridView Style
            this.dataGridView1.BackgroundColor = Color.FromArgb(15, 23, 42);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.GridColor = Color.FromArgb(51, 65, 85);

            dataGridView1.EnableHeadersVisualStyles = false;

            // Header
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Rows
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Alternate rows (تعطي شكل أجمل)
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Left += 10;
        }
    }
}
