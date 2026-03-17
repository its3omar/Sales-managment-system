using Microsoft.Extensions.DependencyInjection;

namespace SalesMS.WinForms
{
    public partial class SMainForm : Form
    {
        private readonly CustomerService _customerService;
        public SMainForm(CustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;

            // ===== UI Styling Only =====

            this.BackColor = Color.FromArgb(15, 23, 42);
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            lblBalance.ForeColor = Color.FromArgb(34, 197, 94); // أخضر جميل للرصيد
            lblBalance.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            label3.ForeColor= Color.FromArgb(34, 197, 94);
            label3.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.label1.ForeColor = Color.FromArgb(34, 197, 94);
            label1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            // Deposit Button
            btnDeposite.BackColor = Color.FromArgb(16, 185, 129);
            btnDeposite.ForeColor = Color.White;
            btnDeposite.FlatStyle = FlatStyle.Flat;
            btnDeposite.FlatAppearance.BorderSize = 0;

            // Shop Button
            btnMainShop.BackColor = Color.FromArgb(59, 130, 246);
            btnMainShop.ForeColor = Color.White;
            btnMainShop.FlatStyle = FlatStyle.Flat;
            btnMainShop.FlatAppearance.BorderSize = 0;
            btnMainShop.Font= new Font("Segoe UI", 10, FontStyle.Bold);

            // Orders Button
            btnOrders.BackColor = Color.FromArgb(59, 130, 246);
            btnOrders.ForeColor = Color.White;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Edit Account Button
            button1.BackColor = Color.FromArgb(59, 130, 246);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // MenuStrip
            menuStrip1.BackColor = Color.FromArgb(30, 41, 59);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.RenderMode = ToolStripRenderMode.System;

            RefreshBalanceLabel();
        }
        private void RefreshBalanceLabel()
        {
            lblBalance.Text = Session.currentCustomer.Balance.ToString();
        }


        private void miLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Session.currentCustomer = null;
            var frm = NavigationStack.Stack.Pop();
            frm.Show();
        }



        private void miDeleteMyAccount_Click_1(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Are you sure you want to delete your account !", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == DialogResult.Yes)
            {
                bool wasDeleted = _customerService.DeleteCustomer(Session.currentCustomer.Id);
                if (wasDeleted)
                {
                    MessageBox.Show("Account deleted successfully");
                    miLogOut_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("An unknown error occured while deleting your account,please try again later");
                }
            }
        }

        private void editAccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetRequiredService<SaveCustomerForm>();
            frm.ShowDialog();
        }



        private void btnMainShop_Click(object sender, EventArgs e)
        {
            NavigationStack.Stack.Push(this);
            var frm = Program.ServiceProvider.GetRequiredService<ShopForm>();
            frm.Show();
            Hide();
            RefreshBalanceLabel();
        }

        private void btnDeposite_Click_1(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetRequiredService<DepositeForm>();
            frm.ShowDialog();
            RefreshBalanceLabel();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetRequiredService<CustomerOrdersForm>();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetRequiredService<SaveCustomerForm>();
            frm.ShowDialog();
        }
    }
}
