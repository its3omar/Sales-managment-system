using Microsoft.Extensions.DependencyInjection;
using SalesMS.WinForms;

namespace SalesMS.WinForms
{
    public partial class LoginForm : Form
    {
        private readonly CustomerService _customerService;



        public LoginForm(CustomerService customerService)
        {
            InitializeComponent();

            _customerService = customerService;

            // ===== UI Styling Only =====

            this.BackColor = Color.FromArgb(15, 23, 42);
            this.label3.ForeColor = Color.White;
            this.lblCreateCustomer.Font = new Font(lblCreateCustomer.Font, FontStyle.Underline);

            tbUsername.BackColor = Color.FromArgb(241, 245, 249);
            tbUsername.BorderStyle = BorderStyle.FixedSingle;

            tbEmail.BackColor = Color.FromArgb(241, 245, 249);
            tbEmail.BorderStyle = BorderStyle.FixedSingle;

            btnLogin.BackColor = Color.FromArgb(59, 130, 246); 
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            chbxRememberMe.ForeColor = Color.White;

            lblCreateCustomer.ForeColor = Color.FromArgb(96, 165, 250); 
            lblCreateCustomer.Cursor = Cursors.Hand;

            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }
        public void AccessToNewPage()
        {
            NavigationStack.Stack.Push(this);
            Hide();
            if (!(chbxRememberMe.Checked))
            {
                tbUsername.Text = null;
                tbEmail.Text = null;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbUsername.Text))
            {
                MessageBox.Show("One or more field are required!");
                return;
            }
            if (tbUsername.Text.ToLower() == "admin" && tbEmail.Text.ToLower() == "admin")
            {
                
                AccessToNewPage();
                var frm1 = Program.ServiceProvider.GetRequiredService<AdminForm>();
                frm1.ShowDialog();
                return;
            }

            Customer? customer = _customerService.Login(tbUsername.Text, tbEmail.Text);

            if (customer == null)
            {
                MessageBox.Show("there is no a user with this Email/password");
                return;
            }
            Session.currentCustomer = customer;
           
            var frm2 = Program.ServiceProvider.GetRequiredService<SMainForm>();
            Hide();
            AccessToNewPage();
            frm2.ShowDialog();
        }

        private void lblCreateCustomer_Click(object sender, EventArgs e)
        {
            var frm1 = Program.ServiceProvider.GetRequiredService<SaveCustomerForm>();
            frm1.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
