
namespace SalesMS.WinForms
{
    public partial class DepositeForm : Form
    {
        private CustomerService _customerService;

        public DepositeForm(CustomerService customerService)
        {
            _customerService = customerService;

            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbAmount.Text)
                || String.IsNullOrEmpty(tbCVV.Text)
                || String.IsNullOrEmpty(tbCardNumber.Text)
                || String.IsNullOrEmpty(tbExpiryDate.Text))
                {
                MessageBox.Show("One or more field are required");
                return; 
            }
            if (tbCardNumber.Text.Length != 16)
            {
                MessageBox.Show("The Entered card number should be 16 digit !");
                return;
            }
            if (tbCVV.Text.Length != 3)
            {
                MessageBox.Show("CVV code shold be 3 digits !");
                return;
            }
            if (Convert.ToInt32(tbExpiryDate.Text) < 2026)
            {
                MessageBox.Show("Your Card was expired !");
                return;
            }
            if (Convert.ToDecimal(tbAmount.Text) <= 0)
            {
                MessageBox.Show("The amount should be greater than zero");
                return;
            }

            bool Result = _customerService.Deposit(Session.currentCustomer.Id, Convert.ToDecimal(tbAmount.Text));
            if (Result) {
                MessageBox.Show("Done!");
                Close(); }
            else { MessageBox.Show("Something went wrong, please try again later"); }

        }
    }
}